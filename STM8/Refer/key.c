#include "key.h"
#include "stm8s.h"

void Key_Init()
{
  KeyU->DDR&=~KeyUP;
  KeyU->CR1|=KeyUP;
  KeyU->CR2&=~KeyUP;
    KeyD->DDR&=~KeyDP;
  KeyD->CR1|=KeyDP;
  KeyD->CR2&=~KeyDP;
    KeyS->DDR&=~KeySP;
  KeyS->CR1|=KeySP;
  KeyS->CR2&=~KeySP;
}
//1ÎªÁ¬°´
int Key_Scan(int mode)
{
  static u8 key_up=1;
  if(mode) key_up=1;
  if(key_up&&(UP_S==0||DOWN_S==0||SW_S==0))
  {
    
    delay_ms(10);
    key_up=0;
    if(UP_S==0)return 1;
    else if(DOWN_S==0)return 2;
    else if(SW_S==0)return 3;
    
  }else if(UP_S==1&&DOWN_S==1&&SW_S==1)key_up=1;
  return 0;
}
int sw_scan(void)
{
  return SW_S;
}

