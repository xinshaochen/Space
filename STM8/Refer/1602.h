#ifndef _1602_H_
#define _1602_H_
#include "stm8s.h"



#define RS GPIOB
#define RSP (1<<5)
#define RW GPIOB
#define RWP (1<<4)
#define EN GPIOC
#define ENP (1<<3) 

#define D0 GPIOC 
#define D0P (1<<4)
#define D1 GPIOC
#define D1P (1<<5)
#define D2 GPIOC
#define D2P (1<<6)
#define D3 GPIOC
#define D3P (1<<7)
#define D4 GPIOA
#define D4P (1<<2)
#define D5 GPIOD
#define D5P (1<<2)
#define D6 GPIOD
#define D6P (1<<3)
#define D7 GPIOA
#define D7P (1<<3)


#define RS_SET RS->ODR|=RSP;//LED
#define RS_CLR RS->ODR&=~RSP;
#define RW_SET RW->ODR|=RWP;
#define RW_CLR RW->ODR&=~RWP;
#define EN_SET EN->ODR|=ENP; 
#define EN_CLR EN->ODR&=~ENP;

#define D0_H D0->ODR|=D0P;
#define D0_L D0->ODR&=~D0P;
#define D1_H D1->ODR|=D1P;
#define D1_L D1->ODR&=~D1P;
#define D2_H D2->ODR|=D2P;
#define D2_L D2->ODR&=~D2P;
#define D3_H D3->ODR|=D3P;
#define D3_L D3->ODR&=~D3P;
#define D4_H D4->ODR|=D4P;
#define D4_L D4->ODR&=~D4P;
#define D5_H D5->ODR|=D5P;
#define D5_L D5->ODR&=~D5P;
#define D6_H D6->ODR|=D6P;
#define D6_L D6->ODR&=~D6P;
#define D7_H D7->ODR|=D7P;
#define D7_L D7->ODR&=~D7P;

#define D0_S ((D0->IDR&D0P)>>4)
#define D1_S ((D1->IDR&D1P)>>5)
#define D2_S ((D2->IDR&D2P)>>6)
#define D3_S ((D3->IDR&D3P)>>7)
#define D4_S ((D4->IDR&D4P)>>2)
#define D5_S ((D5->IDR&D5P)>>2)
#define D6_S ((D6->IDR&D6P)>>3)
#define D7_S ((D7->IDR&D7P)>>3)

void lcd1602_one_char(u8 X,u8 Y,u8 data);


void lcd1602_write_data(u8 dat);
void lcd1602_write_com(u8 com);
void lcd1602_write_com_nobusy(u8 com);
void Lcd_init(void);

void lcd_1602_gotoxy(u8 x,u8 y);
void lcd1602_display(void);

void port_write(u8 dat);

void lcd1602_clear(void);

void lcd1602_num(u8 X,u8 Y,u32 num,u16 len);
#endif
