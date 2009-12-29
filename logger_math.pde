/* interpolation functions for tables */

int linear_interpolate(int ad, int* values, int* ref_points )
{

  int index; 
  int value;
  int slope;

/* find the closest index */
  
  for(int i = 0; i < sizeof(ref_points)+1; i++ ) {
    if( ref_points[i] > ad)  {
       index = i;
       break;
    }
  }
  
  /* slope = (y1 - y0) / (x1 - x0)
     value = y0 + (x-x0) * slope  
     
     multiplying the values by 128 to stay within integer
     domain with the division      
   */
  slope  = ((values[index]-values[index-1])<<7) / (ref_points[index]-ref_points[index-1]);

  /* dividing by 128 to get the real numbers */
  value =  values[index-1] + ((slope * (ad-ref_points[index-1]))>>7);

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
