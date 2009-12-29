
/* function for seting up the channels
   arguments:
   number   - channel number
   type     - channel type: VOLT, HI_FREQ, LO_FREQ
   priotity - channel priority 0-4
   val,ref  - look up table x and y values
   filter   - is filter on/off TRUE/FALSE
*/
int setup_channel(int number, char type, char priority, int *val, int *ref, char filter)
{
  channels[number].type     = type;
  channels[number].priority = priority;
  channels[number].val      = val;
  channels[number].ref      = ref;
  channels[number].filter   = filter;

  return 1;
}
