
#include "ALL_Includes.h"
#include "24l01.h"
#include "time.h"
#include "EXIT.h"
#include "remote.h"
#include "led.h"
#include "motor.h"





#define  SYS_CLOCK    16


void CLOCK_Config(u8 SYS_CLK);
void All_Congfig(void);


int main(void)
{     
  u8 R,G,B;
	u8 key;
	u8 s=0;
  u8 rx_buff[33];
      All_Congfig();
      NRF24L01_Init();
      while(NRF24L01_Check());
      NRF24L01_TX_Mode();
//	  Remote_Init();
          TIM4_Init();
          MotorInit();
//          LED_Init();
//          LED_R_SET;
//            LED_G_SET;
//              LED_B_SET;
//while(1)
//{
//	LED_R_SET;
//	LED_G_SET;
//	LED_B_SET;
//	delay_ms(300);
//	LED_R_CLR;
//	LED_B_CLR;
//	LED_G_CLR;
//	delay_ms(300);
//}
//	  while (1)
//	  {
//		  key = Remote_Scan();
//		  if (key)
//		  {
//			  switch (key)
//			  {
//			  case 0://str = "ERROR"; 
//				  break;
//			  case 162://str = "POWER"; 
//				  break;
//			  case 98://str = "UP"; 
//				  break;
//			  case 2://str = "PLAY"; 
//				  break;
//			  case 226://str = "ALIENTEK"; 
//				  break;
//			  case 194://str = "RIGHT"; 
//				  break;
//			  case 34://str = "LEFT"; 
//				  break;
//			  case 224://str = "VOL-"; 
//				  break;
//			  case 168://str = "DOWN"; 
//				  break;
//		  case 144://str = "VOL+"; 
//				  break;
//			  case 104://str = "1"; 
//                            if(RmtCnt==0)
//                            {
//				  s = !s;
//				  if (s) LED_R_SET;
//				  else LED_R_CLR;
//                            }     
//				  break;
//			  case 152://str = "2";
//				  s = !s;
//				  if (s) LED_G_SET;
//				  else LED_G_CLR;
//                                  
//				  break;
//			  case 176://str = "3";
//				  s = !s;
//				  if (s) LED_B_SET;
//				  else LED_B_CLR;
//                                  
//				  break;
//			  case 48://str = "4"; 
//				  break;
//			  case 24://str = "5";
//				  break;
//			  case 122://str = "6";
//				  break;
//			  case 16://str = "7"; 
//				  break;
//			  case 56://str = "8";
//				  break;
//			  case 90://str = "9";
//				  break;
//			  case 66://str = "0";
//				  break;
//			  case 82://str = "DELETE";
//				  break;
//			  }
//		  }else 
//                    delay_ms(10);
//
//			  //delay_ms(300);
//
//	  }
			  //RL = 5;
			  //GL = 19;
			  //BL = 10;
			  //while (1);


      NRF24L01_RX_Mode();
      //马达控制
      while(1)
      {
        if(NRF24L01_RxPacket(rx_buff)==0)
        {
          Left_Run((s8)rx_buff[0]);
          Right_Run((s8)rx_buff[1]);
        }
       delay_ms(1);
      }
      
  while(1)
  {
    if(NRF24L01_RxPacket(rx_buff)==0)
    {
        R = rx_buff[0];
	  G = rx_buff[1];
	  B = rx_buff[2];
          
    }
    if(RL<R) RL++;
          else if(RL>R) RL--;
          if(GL<G) GL++;
          else if(GL>G) GL--;
          if(BL<B) BL++;
          else if(BL>B) BL--;
    delay_ms(1);
    
    
//    if(NRF24L01_RxPacket(rx_buff)==0)
//    {
//      if(rx_buff[0]&0x01) LED_R_CLR;
//      else LED_R_SET;
//      if(rx_buff[0]&0x02) LED_G_CLR;
//      else LED_G_SET;
//      if(rx_buff[0]&0x04) LED_B_CLR;
//      else LED_B_SET;
//      
//    }else delay_ms(100);
      //NRF24L01_TxPacket("XSSR");
	 // NRF24L01_TxPacket("Ccccccccccc");
	//	  delay_ms(1000);
  }              
}
void All_Congfig(void)
{
    CLOCK_Config(SYS_CLOCK);//系统时钟初始化  
	
}

/// <summary>
///函数功能：系统内部时钟配置
///输入参数：SYS_CLK : 2、4、8、16
///输出参数：无
///备    注：系统启动默认内部2ＭＨＺ
/// </summary>
void CLOCK_Config(u8 SYS_CLK)
{
   //时钟配置为内部RC，16M
   CLK->CKDIVR &=~(BIT(4)|BIT(3));
  
   switch(SYS_CLK)
   {
      case 2: CLK->CKDIVR |=((1<<4)|(1<<3)); break;
      case 4: CLK->CKDIVR |=(1<<4); break;
      case 8: CLK->CKDIVR |=(1<<3); break;
   }
}



