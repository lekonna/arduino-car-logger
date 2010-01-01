/*
    Logger - logger
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
#include <avr/interrupt.h>
#include <avr/io.h>
#include <EEPROM.h>
#include "logger_defines.h"
#include "maf_tables.h" 

perm_data st;
channel channels[8]; // reserve space for the channels

/* some test reference tables for the interpolation routine 
AFR table 
     
          |            *22.3
          |     *14.7
          |*7.3
          |
          +---------------
          0V    2.5V   5V
          
RPM table

     
          |            *10000
          |     
          |    *800
          |
          +-----------------
          0   13hz     167hz 
          
          
*/
int AFR_values[3]   = {73,147,223};
int AFR_voltages[3] = {VOLTAGE_TO_BIT(0),
                       VOLTAGE_TO_BIT(2.5),
                       VOLTAGE_TO_BIT(5) };

int RPM_values[2]   = { 800,10000 };
int RPM_freq[2]     = {13,167}; // 800-10000 rpm = 13-167hz
int Linear_val[2]   = {0,1023};


void setup() {

  read_data( &st );

  Serial.begin( 9600 );
  /*
  TCCR2A = 0;
  TCCR2B = 1 << CS22 | 1 << CS21 | 1 << CS20 ; // divider 1024
  TIMSK2 = 1<<TOIE2; // enable overflow
  TCNT2 = 0; // reset interrupt
  */
  /* seting up the channels
  setup_channel("name",ch,pin,type,    pri,ref_table_y,ref_table_x ,filter*/
  setup_channel("AFR", 0, 0  ,VOLT    ,0  ,AFR_values ,AFR_voltages,TRUE,sizeof(AFR_values)/sizeof(int));
  setup_channel("RPM", 1,18  ,LO_FREQ ,0  ,RPM_values ,RPM_freq    ,FALSE,sizeof(RPM_values)/sizeof(int));
//  setup_channel("RPM", 1,18  ,LO_FREQ ,0  ,0 ,0    ,FALSE);
//  setup_channel("Maf", 2,2   ,HI_FREQ ,0  ,0          ,0           ,FALSE);
  setup_channel("Maf", 2, 2  ,HI_FREQ ,0 , maf_air  , maf_freq     ,FALSE,sizeof(maf_air)/sizeof(int));
  int free = memoryTest();
  print_header();
  delay(1000);
  
}

void loop() {
  read_channels();
  print_channels();
  delay(100);
}
