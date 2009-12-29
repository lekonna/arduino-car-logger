
// size of the averaging filter, must be 2,4,8,16 
#define FILTER_SIZE 8

/* macro to help type in the reference values for the channel look-up tables */

#define VOLTAGE_TO_BIT( data ) (int (((10240 / 5 ) * data)/10))

#define VOLT 1
#define HI_FREQ 2
#define LO_FREQ 3
#define TRUE 1
#define FALSE 0


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
  /* value is where the current measuerement value is stored */
  int value;     // current measured value
  
  /* these are for internal usage no need to fill */
  int filt[FILTER_SIZE];   // filter buffer
  int filt_i;    // filter_index;

};
