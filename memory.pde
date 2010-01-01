int memoryTest() {
  int byteCounter = 0;
  byte *byteArray; 
  
  while ( (byteArray = (byte*) malloc (byteCounter * sizeof(byte))) != NULL ) {
    byteCounter++; 
    free(byteArray);
  }
  
  free(byteArray); 
  return byteCounter; 
}

