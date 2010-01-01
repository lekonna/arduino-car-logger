/*
    Logger - logger_defines.h
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
// size of the averaging filter, must be 2,4,8,16 
#define FILTER_SIZE 8

/* macro to help type in the reference values for the channel look-up tables */

#define VOLTAGE_TO_BIT( data ) (int (((10240 / 5 ) * data)/10))

#define VOLT 1
#define HI_FREQ 2
#define LO_FREQ 3
#define TRUE 1
#define FALSE 0

volatile int timer_counter;
/* struct to save the current settings */

struct perm_data {
  char output_type;
  char last_screen;
};


/* struct for handling the channels */ 

struct channel {
  char type;     // HI_FREQ, LO_FREQ, VOLT
  int *val;      // reference table for y (eg. values)
  int *ref;      // reference table for x (eg. voltage)
  char priority; // channel priority 0-4
  char filter;   // Do we filter or not?
  int input;     // the input pin
  char name[64];
  /* value is where the current measuerement value is stored */
  volatile int value;     // current measured value
  
  /* these are for internal usage no need to fill */
  int filt[FILTER_SIZE];   // filter buffer
  int filt_i;    // filter_index;
  int active;
  int refsize;
  volatile unsigned long trig_time;
  volatile unsigned long hi_freq_counter;
};
