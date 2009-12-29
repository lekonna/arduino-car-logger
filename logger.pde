#include <avr/interrupt.h>
#include <avr/io.h>
#include <EEPROM.h>
#include "logger_defines.h"
 

perm_data st;
channel channels[8]; // reserve space for the channels

/* some test reference tables for the interpolation routine 
0V   = AFR 7.3
2.5V = AFR 14.7
5V   = AFR 22.3
*/
int AFR_values[3]   = {73,147,223};
int AFR_voltages[3] = {VOLTAGE_TO_BIT(0),
                       VOLTAGE_TO_BIT(2.5),
                       VOLTAGE_TO_BIT(5) };


void setup() {
  read_data( &st );
  Serial.begin( 9600 );
  
  /* seting up the channels */
  setup_channel(0,VOLT,0,AFR_values,AFR_voltages,TRUE);
  
}

void read_channels()
{
  for (int i = 0 ; i < 8 ; i++ ) 
  {
    if(channels[i].type != VOLT ) continue;
    int value = linear_interpolate(analogRead(channels[i].input),
                                   channels[i].val,
                                   channels[i].ref);

    if(channels[i].filter) value = channel_filter(value,&channels[i]);

    channels[i].value = value;           
  }
}

void loop() {
  read_channels();
  Serial.print(millis());
  Serial.print(" ");
  Serial.println(channels[0].value);  
  delay(100);
}
