/*
    Logger - permanent_data
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


/*

   permanent data 
   this sketch contains the required functions to save the perman3ent
   data needed for the logger. 
   
*/

/* setup_data struct holds the permanent data */ 


/* save_data function saves the struct to EEPROM */
int save_data( struct perm_data *d )
{
  EEPROM.write( 0,d->output_type);
  EEPROM.write( 1,d->last_screen);
}

/* read_data function reads the struct from EEPROM */

int read_data( struct perm_data *d )
{
  d->output_type = EEPROM.read(0);
  d->last_screen = EEPROM.read(1);
}

