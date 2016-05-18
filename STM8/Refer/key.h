#ifndef _KEY_H_
#define _KEY_H_

#define KeyU GPIOD
#define KeyUP (1<<1)
#define KeyD GPIOA
#define KeyDP (1<<1)
#define KeyS GPIOD
#define KeySP (1<<6)

#define UP_S ((KeyU->IDR&KeyUP)>>1)
#define DOWN_S ((KeyD->IDR&KeyDP)>>1)
#define SW_S ((KeyS->IDR&KeySP)>>6)

int Key_Scan(int mode);
int sw_scan(void);
#endif
