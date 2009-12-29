


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

