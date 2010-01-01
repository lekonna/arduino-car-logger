/*
    Logger - logger_math
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

/* interpolation functions for tables */

int linear_interpolate(int ad, int* values, int* ref_points,int refsize )
{

  int index; 
  int value;
  int slope;

/* find the closest index */
  if(refsize>2) {
    for(int i = 0; refsize; i++ ) {
        if( ref_points[i] > ad)  {
         index = i;
         break;
      }
    }
  } else index = 1;
  /* slope = (y1 - y0) / (x1 - x0)
     value = y0 + (x-x0) * slope  
     
     multiplying the values by 128 to stay within integer
     domain with the division      
   */
//  Serial.println((values[index]-values[index-1])<<7);
  slope  = ((values[index]-values[index-1])<<7) / (ref_points[index]-ref_points[index-1]);
//  Serial.println(slope);
  /* dividing by 128 to get the real numbers */
  value =  values[index-1] + ((slope * (ad-ref_points[index-1]))>>7);

  return value;

}
int linear_interpolate_f(int ad, int* values, int* ref_points,int refsize )
{

  int index; 
  int value;
  float slope;

/* find the closest index */
  
  if(refsize>2) {
    for(int i = 0; i < refsize; i++ ) {
      if( ref_points[i] > ad)  {
         index = i;
         break;
      }       
    }
  } else {
    index = 1;
  }
  /* slope = (y1 - y0) / (x1 - x0)
     value = y0 + (x-x0) * slope  
     
     multiplying the values by 128 to stay within integer
     domain with the division      
   */
//  Serial.println((values[index]-values[index-1])<<7);
  slope  = float((values[index]-values[index-1])) / float((ref_points[index]-ref_points[index-1]));
//  Serial.println(slope);
  /* dividing by 128 to get the real numbers */
  value =  values[index-1] + ((slope * (ad-ref_points[index-1])));

  return value;

}

/* 
  filter function for channels 
   this function filters the channels input by averaging FILTER_SIZE last results
*/
int channel_filter( int value, struct channel* ch)
{
      int index = (ch->filt_i++) % FILTER_SIZE;
      ch->filt[index] = value;
      int sum=0;
      for( int ii = 0; ii < FILTER_SIZE; ii++) sum+=ch->filt[ii];
      return sum >> (FILTER_SIZE==16?4:(FILTER_SIZE==8?3:(FILTER_SIZE==4?2:1)));
}
