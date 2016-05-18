#ifndef _HALL_H_
#define _HALL_H_
#include "stm8s.h"

#define H0 GPIOB
#define H0P (1<<5)

#define H1 GPIOB
#define H1P (1<<4)

#define H2 GPIOC
#define H2P (1<<6)

#define H3 GPIOC
#define H3P (1<<7)

#define H4 GPIOD
#define H4P (1<<2)


#define H0S ((H0->IDR&H0P)>>5)
#define H1S ((H1->IDR&H1P)>>4)
#define H2S ((H2->IDR&H2P)>>6)
#define H3S ((H3->IDR&H3P)>>7)
#define H4S ((H4->IDR&H4P)>>2)

typedef enum
{
  Ri4=-4,
  Ri3,
  Ri2,
  Ri1,
  Middle,
  Le1,
  Le2,
  Le3,
  Le4,
  Other,
  AllWhite,
  AllBlack,
}status;


void HallInit(void);
u8 HallST(void);
status Detection(u8 st);


#endif
