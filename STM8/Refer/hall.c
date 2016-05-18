#include "hall.h"

void HallInit(void)
{
  H0->DDR&=~H0P;
  H0->CR1|=H0P;
  H0->CR2&=~H0P;
  
  H1->DDR&=~H1P;
  H1->CR1|=H1P;
  H1->CR2&=~H1P;
  
  H2->DDR&=~H2P;
  H2->CR1|=H2P;
  H2->CR2&=~H2P;
  
  H3->DDR&=~H3P;
  H3->CR1|=H3P;
  H3->CR2&=~H3P;
  
  H4->DDR&=~H4P;
  H4->CR1|=H4P;
  H4->CR2&=~H4P;
  
}
u8 HallST(void)
{
  u8 ST=0,lastST=0;
  u8 i;
       if(!H0S) {ST |= 0x01;} 
    else {ST &= ~0x01;}
    if(!H1S) {ST |= 0x02;}
    else {ST &= ~0x02;}
      if(!H2S) {ST |= 0x04;}
      else {ST &= ~0x04;}
      if(!H3S) {ST |= 0x08;}
    else {ST &= ~0x08;}
    if(!H4S) {ST |= 0x10;}
    else {ST &= ~0x10;}  
    
  lastST = ST;
  
  for(i=0;i<10;i++)
  {
     if(!H0S) {ST |= 0x01;} 
    else {ST &= ~0x01;}
    if(!H1S) {ST |= 0x02;}
    else {ST &= ~0x02;}
      if(!H2S) {ST |= 0x04;}
      else {ST &= ~0x04;}
      if(!H3S) {ST |= 0x08;}
    else {ST &= ~0x08;}
    if(!H4S) {ST |= 0x10;}
    else {ST &= ~0x10;}   
    
    lastST &= ST;
  }

  
  return lastST;
    
}

//*****************************
//返回值  ：  0 在正中间，-4~-1 在左边   4~1在右边   
//              99 全黑    10 全白    100 其他
status Detection(u8 st)
{
  if(st==0x01||st==0x05||st==0x0f||st==0x07) return Le4;
   else if(st==0x10||st==0x14||st==0x1e||st==0x1c) return Ri4;
   else if(st==0x03) return Le3;
   else if(st==0x18) return Ri3;
   else if(st==0x02) return Le2;
   else if(st==0x08) return  Ri2;
   else if(st==0x06) return Le1;
   else if(st==0x0c) return Ri1;
   else if(st==0x04||st==0x0e) return Middle;                          
   else if(st==0x1f) return AllBlack;//
   else if(st==0x00) return AllWhite;
   else return Other;
  
}