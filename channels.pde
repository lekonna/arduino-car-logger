/*
    Logger - channels
    The car data logging software for Arduino Mega board
    Copyright: Janne Kotka 2010

    This file is part of Logger.

    Logger is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    Logger is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with Logger.  If not, see <http://www.gnu.org/licenses/>.
     
*/

/* function for seting up the channels
   arguments:
   number   - channel number
   type     - channel type: VOLT, HI_FREQ, LO_FREQ
   priotity - channel priority 0-4
   val,ref  - look up table x and y values
   filter   - is filter on/off TRUE/FALSE
*/
int lo_freq_channels[3];
int lo_freq_counter = 0;
int hi_freq_channels[3];
int hi_freq_counter = 0;

/*                        mega irqs pins, 2,3,18,19,20,21 */ 
int irq_pin_translate[] = {0,0,0,1,0, /* 0-4*/
                           0,0,0,0,0, /* 5-9*/
                           0,0,0,0,0, /* 10-14*/
                           0,0,0,5,4, /* 15-19*/
                           3,2,0,0,0};/* 20-24*/
                           
int setup_channel(char *name,int number,char input,char type, char priority, int *val, int *ref, char filter,int refsize)
{
  for (int i = 0; i<sizeof(name)+1 ; i++ ) channels[number].name[i] = name[i];

  channels[number].type = type;
  channels[number].refsize = refsize;
 
  channels[number].input    = input;
  channels[number].priority = priority;
  channels[number].val      = val;
  channels[number].ref      = ref;
  channels[number].filter   = filter;
  channels[number].active   = TRUE;
  
   if (type == HI_FREQ) {
     // attach the interupts ect blaa
    hi_freq_channels[hi_freq_counter] = number;
    switch ( hi_freq_counter ) {
      case 0:
//        Serial.println("attaching interrupt to hi_freq1");
        attachInterrupt(irq_pin_translate[input],hi_freq1,RISING);    
        break;
      case 1:
        attachInterrupt(irq_pin_translate[input],hi_freq2,RISING);    
        break;
      default:
        attachInterrupt(irq_pin_translate[input],hi_freq3,RISING);    
    }
    hi_freq_counter++;
  }
  if (type == LO_FREQ)
  {
    lo_freq_channels[lo_freq_counter] = number;
    switch ( lo_freq_counter ) {
      case 0:
//        Serial.println("attaching interrupt to lo_freq1");
        attachInterrupt(irq_pin_translate[input],lo_freq1,RISING);    
        break;
      case 1:
        attachInterrupt(irq_pin_translate[input],lo_freq2,RISING);    
        break;
      default:
        attachInterrupt(irq_pin_translate[input],lo_freq3,RISING);    
    }
    lo_freq_counter++;

  }
  
  return 1;
}
/*
ISR(TIMER2_OVF_vect) {

  timer_counter++;
  if(timer_counter<99) {
     for(int i = 0; i < hi_freq_counter ;i++)
     {
       channels[hi_freq_channels[i]].value = channels[hi_freq_channels[i]].hi_freq_counter<<4;
       channels[hi_freq_channels[i]].hi_freq_counter = 0;
     }
     timer_counter = 0;
  }
    TCNT2 = 0;
}
*/
void read_channels()
{
  for (int i = 0 ; i < 8 ; i++ ) 
  {
    if(channels[i].type != VOLT ) continue;
    
    int value;
    if(channels[i].val) {
      value = linear_interpolate_f(analogRead(channels[i].input),
                                     channels[i].val,
                                     channels[i].ref,channels[i].refsize);
    } else value = analogRead(channels[i].input);
    
    if(channels[i].filter) value = channel_filter(value,&channels[i]);

    channels[i].value = value;           
  }
}

void print_channels()
{
  // print timestamp
  Serial.print(millis());
  for (int i = 0 ; i < 8 ; i++ ) {
      if (channels[i].active) {
        Serial.print(" ");
        Serial.print(channels[i].value);
      }
  }
  Serial.println();
}

void print_header()
{
  // print timestamp
  Serial.print("timestamp");
  for (int i = 0 ; i < 8 ; i++ ) {
      if (channels[i].active) {
        Serial.print(" ");
        Serial.print(channels[i].name);
      }
  }
  Serial.println();
}

void hi_freq1() 
{
  volatile int channel= hi_freq_channels[0];
  channels[channel].hi_freq_counter++;
//  Serial.println("hifreqirQ");
  if( channels[channel].hi_freq_counter > 100 )
  {
  volatile unsigned long t_now = micros();
  volatile float t_delta = t_now-channels[channel].trig_time;
  channels[channel].trig_time = t_now;
  volatile float freq = 100/(t_delta/1000000);
  channels[channel].hi_freq_counter = 0;
  if (channels[channel].val) {

      channels[channel].value = linear_interpolate_f(int(freq),
                                     channels[channel].val,
                                     channels[channel].ref,channels[channel].refsize);
    } else channels[channel].value = int(freq);
}
}

void hi_freq2() 
{
  volatile int channel= hi_freq_channels[1];
  channels[channel].hi_freq_counter++;
  
}

void hi_freq3() 
{
  volatile int channel= hi_freq_channels[2];
  channels[channel].hi_freq_counter++;
}


void lo_freq1()
{
  volatile unsigned long t_now = micros();
  volatile float t_delta = t_now-channels[lo_freq_channels[0]].trig_time;
  volatile int channel= lo_freq_channels[0];
  channels[channel].trig_time = t_now;
  volatile float freq = 1/(t_delta/1000000);

  if (channels[channel].val) {
      channels[channel].value = linear_interpolate_f(int(freq),
                                     channels[channel].val,
                                     channels[channel].ref,channels[channel].refsize);
    } else channels[channel].value = int(freq);
}

void lo_freq2()
{
  volatile unsigned long t_now = millis();
  volatile unsigned long t_delta = channels[lo_freq_channels[1]].trig_time-t_now;
  channels[lo_freq_channels[1]].trig_time = t_now;
  volatile float freq = 1/(float(t_delta)/1000);
  channels[lo_freq_channels[1]].value = int(t_delta);
}
void lo_freq3()
{
  volatile unsigned long t_now = millis();
  volatile unsigned long t_delta = channels[lo_freq_channels[2]].trig_time-t_now;
  channels[lo_freq_channels[2]].trig_time = t_now;
  volatile float freq = 1/(t_delta/1000);
  channels[lo_freq_channels[2]].value = int(t_delta);
}
