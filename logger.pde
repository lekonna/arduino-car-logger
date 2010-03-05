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
#include <LiquidCrystal.h>
#include <avr/interrupt.h>
#include <avr/io.h>
#include <EEPROM.h>
#include "logger_defines.h"
#include "maf_tables.h" 

perm_data st;
channel channels[8]; // reserve space for the channels
int lcd_on = 1;
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
int EGT_values[2]   = { 0,1167 };
int EGT_voltages[2] = { VOLTAGE_TO_BIT(0),VOLTAGE_TO_BIT(5)};
int RPM_values[2]   = { 800,10000 };
int RPM_freq[2]     = {13,167}; // 800-10000 rpm = 13-167hz
int Linear_val[2]   = {0,1023};
int MAP_values[2]   = { 20, 400 };
int MAP_voltages[2] = { VOLTAGE_TO_BIT(0.2),VOLTAGE_TO_BIT(4.8)};
int FPR_values[2]   = { 20, 700 };
int FPR_voltages[2] = { VOLTAGE_TO_BIT(0.2),VOLTAGE_TO_BIT(4.8)};

int poo;
unsigned int fps    = 8;
unsigned int f_time = 0;
// works both with 4 and 8 data line lcds. nice. 
LiquidCrystal lcd(42, 40,38,28,26,24,22); //LiquidCrystal lcd(42, 40,38,36,34,32,30,28,26,24,22);
void setup() {
  lcd.begin(20, 4);
  lcd.clear();
  read_data( &st );

  Serial.begin( 57600 );
 
  /* seting up the channels
  setup_channel("name",ch,pin,type,    pri,ref_table_y,ref_table_x ,filter*/
  setup_channel("AFR", 1, 0  ,VOLT    ,0  ,AFR_values ,AFR_voltages,TRUE,sizeof(AFR_values)/sizeof(int));
  setup_channel("RPM", 0,18  ,LO_FREQ ,0  ,RPM_values ,RPM_freq    ,FALSE,sizeof(RPM_values)/sizeof(int));
  setup_channel("Maf", 2, 2  ,HI_FREQ ,0 , maf_air  , maf_freq     ,FALSE,sizeof(maf_air)/sizeof(int));
  setup_channel("EGT", 4, 1  ,VOLT ,0 , EGT_values  , EGT_voltages    ,FALSE ,sizeof(EGT_voltages)/sizeof(int));
  setup_channel("MAP", 3, 3  ,VOLT ,0 , MAP_values  ,MAP_voltages     ,FALSE,sizeof(MAP_voltages)/sizeof(int));
  setup_channel("FPR", 5, 3  ,VOLT ,0 , FPR_values  ,FPR_voltages     ,FALSE,sizeof(FPR_voltages)/sizeof(int));
 
  print_header();
  lcd_print_header();
  delay(3000);
  lcd.clear();
  lcd_print_titles();
  
}

void loop() {
  read_channels();
  print_channels();
  
  if(millis()-f_time>(1000/fps)) {
    lcd_print_channels();
    f_time=millis();
    }
  
//  delay(100);
  
}
