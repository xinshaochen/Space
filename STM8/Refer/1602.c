#include "1602.h"
#include "delay.h"
//#include "tool.h"



const char Num[10]={'0','1','2','3','4','5','6','7','8','9'};


void port_in(void)
{
  D0->DDR&=~D0P;
  D0->CR1|=D0P;
  D1->DDR&=~D1P;
  D1->CR1|=D1P;
  D2->DDR&=~D2P;
  D2->CR1|=D2P;
  D3->DDR&=~D3P;
  D3->CR1|=D3P;
  D4->DDR&=~D4P;
  D4->CR1|=D4P;
  D5->DDR&=~D5P;
  D5->CR1|=D5P;
  D6->DDR&=~D6P;
  D6->CR1|=D6P;
  D7->DDR&=~D7P;
  D7->CR1|=D7P;
}
void port_out(void)
{
  D0->DDR|=D0P;
  D0->CR1|=D0P;
  D1->DDR|=D1P;
  D1->CR1|=D1P;
  D2->DDR|=D2P;
  D2->CR1|=D2P;
  D3->DDR|=D3P;
  D3->CR1|=D3P;
  D4->DDR|=D4P;
  D4->CR1|=D4P;
  D5->DDR|=D5P;
  D5->CR1|=D5P;
  D6->DDR|=D6P;
  D6->CR1|=D6P;
  D7->DDR|=D7P;
  D7->CR1|=D7P;
}
u8 port_read(void)
{
  u8 data=0;
  data = (D0_S<<7)|(D1_S<<6)|(D2_S<<5)|(D3_S<<4)|(D4_S<<3)|(D5_S<<2)|(D6_S<<1)|(D7_S);
  
  return data;
}

void port_write(u8 dat)
{
  if(dat&0x01){D0_H;}else{D0_L;}
  if(dat&0x02){D1_H;}else{D1_L;}
  if(dat&0x04){D2_H;}else{D2_L;}
  if(dat&0x08){D3_H;}else{D3_L;}
  if(dat&0x10){D4_H;}else{D4_L;}
  if(dat&0x20){D5_H;}else{D5_L;}
  if(dat&0x40){D6_H;}else{D6_L;}
  if(dat&0x80){D7_H;}else{D7_L;}
}

//读状态
u8 lcd1602_busy(void)
{
	u8 result;
        port_write(0xff);
	RS_CLR;
	RW_SET;
        EN_CLR;
        EN_CLR;
	EN_SET;
        asm("nop");
     //   asm("nop");
	//delay_ms(5);
	port_in();

	while(port_read() & 0x80);
	//EN_CLR;
	return port_read();
}
//读数据
u8 lcd1602_read_data(void)
{
  RS_SET;
  RW_SET;
  EN_CLR;
  EN_CLR;
  EN_SET;
  port_in();
  return port_read();
}
//写指令
void lcd1602_write_com(u8 com)
{
	//lcd1602_busy();
        port_out();
        port_write(com);
        RS_CLR;
        RW_CLR;
        EN_CLR;
        EN_CLR;
        EN_SET;
}
//写指令。不判忙
void lcd1602_write_com_nobusy(u8 com)
{
//	//while(lcd1602_busy());
//        port_out();
//        port_write(com);
//        RS_CLR;
//        RW_CLR;
//        EN_CLR;
//        EN_CLR;
//        EN_SET;
      RS_CLR;
    RW_CLR;
    EN_CLR;
    asm("nop");
 //   asm("nop");
    port_out();
        port_write(com);
        asm("nop");
//        asm("nop");
    EN_SET;
    asm("nop");
 //   asm("nop");
   EN_CLR;
}
//写数据
void lcd1602_write_data(u8 dat)
{
//	//lcd1602_busy();
//        port_out();
//        port_write(dat);
//        RS_SET;
//        RW_CLR;
//        EN_CLR;
//        EN_CLR;
//        EN_SET;
     // LCD1602_Wait_Ready();
    RS_SET;
    RW_CLR;
    EN_CLR;
    
    port_out();
    asm("nop");
        port_write(dat);
        asm("nop");
 //       asm("nop");
   EN_SET;
   asm("nop");
//   asm("nop");
   EN_CLR;
}
void lcd1602_one_char(u8 X,u8 Y,u8 data)
{
//  if(Y)
//    Y=0x40;
//  else
//    Y=0x00;
//  X&=0x0f;
//  Y+=X;
  lcd_1602_gotoxy(X,Y);

  lcd1602_write_com_nobusy(Y);
  delay_ms(1);
  lcd1602_write_data(data);
  delay_ms(1);
}
void lcd_1602_gotoxy(u8 x,u8 y)
{
  u8 addr;
  if (y == 0)
        addr = 0x00 + x;
    else
        addr = 0x40 + x;
    lcd1602_write_com(addr | 0x80);
//  if(Y)
//    Y=0x40;
//  else
//    Y=0x00;
//  X&=0x0f;
//  Y+=X;
}
void lcd1602_num(u8 X,u8 Y,u32 num,u16 len)
{
  u8 s,i;
  u8 temp;
  u8 test;
  
  s=len;
  
  for(i=0;i<s;i++)
  {
    test=mypow(10,s-i-1);
    temp = (num/test)%10;
    lcd1602_one_char(X+i,Y,Num[temp]);
  }
  
  
  
  
}
//LCD_init
void Lcd_init()
{
    RS->DDR |= RSP;//输出模式
    RS->CR1 |= RSP;//推挽输出
    RW->DDR |= RWP;//输出模式
    RW->CR1 |= RWP;//推挽输出
    EN->DDR |= ENP;//输出模式
    EN->CR1 |= ENP;//推挽输出
    
    delay_ms(100);
    port_out();
    port_write(0x00);
    
    lcd1602_write_com_nobusy(0x38);
    delay_ms(5);
    lcd1602_write_com_nobusy(0x38);
    delay_ms(5);
    lcd1602_write_com_nobusy(0x38);
    delay_ms(5);
    
    lcd1602_write_com_nobusy(0x38);
    delay_ms(5);
    //lcd1602_write_com_nobusy(0x08);
    //delay_ms(5);
    lcd1602_write_com_nobusy(0x01);   
    delay_ms(5);
    lcd1602_write_com_nobusy(0x0c);
    delay_ms(5);
    lcd1602_write_com_nobusy(0x06);
    delay_ms(5);


    
}



void lcd1602_clear(void)
{
  lcd1602_write_com(0x01);
//    LCD1602_Write_Cmd(0x01);
}




