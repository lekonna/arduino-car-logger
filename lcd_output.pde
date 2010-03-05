/*
    Logger - channels
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
void lcd_print_titles()
{
  // print timestamp
  lcd.setCursor(0,0);
  int row,col;
  col=0;
  row=0;
  lcd.setCursor(col,row);


  for (int i = 0 ; i < 8 ; i++ ) {
      if (channels[i].active) {
        if(col > 1) {
          row++;
          col = 0;
          lcd.setCursor(0,row);
        }
        
        lcd.setCursor(col*10,row);
        lcd.print(channels[i].name);
        col++;
      }
  }
}

void lcd_print_channels()
{
  if(!lcd_on) return;
  // print timestamp
  int row,col;
  col=0;
  row=0;
  lcd.setCursor(col,row);

  for (int i = 0 ; i < 8 ; i++ ) {
      if (channels[i].active) {
        if(col > 1) {
          row++;
          col = 0;
          lcd.setCursor(0,row);
        }

        lcd.setCursor(col*10+4,row);
        lcd.print("    ");
        lcd.setCursor(col*10+4,row);
        lcd.print(channels[i].value);
        col++;
      }
  }
}

void lcd_print_header()
{
  lcd.clear();
  lcd.setCursor(0, 0);
  lcd.print("Arduino car logger");
  int row,col;
  col=0;
  row=1;
  lcd.setCursor(col,row);

  for (int i = 0 ; i < 8 ; i++ ) {
      if (channels[i].active) {
       if(col > 3) {
          row++;
          col = 0;
          lcd.setCursor(0,row);
        }
        
        lcd.setCursor(col*4,row);
        lcd.print(channels[i].name);
        col++;
      }

  }
}
