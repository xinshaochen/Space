
#include "spi.h"
#include "ALL_Includes.h"

 
/*********************************************
�������ܣ�SPI��ʼ��
�����������
�����������
��    ע����
*********************************************/
void SPI_Init(void)
{   
    SPI_IOConfig(); 
  
    SPI->CR1 |= BIT(2)|BIT(1)|BIT(0);//���豸����λ�ȷ���2��Ƶ
    
    SPI->CR2 |= BIT(1)|BIT(0);//nss��������  
    SPI->CR2 &=~(BIT(2)|BIT(7));//˫�ߵ���ģʽ��ȫ˫��
    
    SPI->CR1 |= BIT(6); //ʹ��SPI BIT(6)
   
}


/*********************************************
�������ܣ�SPI��д����
���������Data����Ҫд�������
�����������
��    ע����
*********************************************/
u8 SPI_RW(u8 Data)
{

   while(!(SPI->SR&0X02));//�ȴ����ͻ�����Ϊ��
   SPI->DR =Data;
   
   while(!(SPI->SR&0X01));//�ȴ����ջ�����Ϊ�ǿ�
   return (SPI->DR);      
}


/*********************************************
�������ܣ�SPI IO��ʼ��
�����������
�����������
��    ע����
*********************************************/
void SPI_IOConfig(void)
{
     //����SPI_SCKΪ���
    SPI_SCK_GPIO->DDR  |=  SPI_SCK ;//���ģʽ
    SPI_SCK_GPIO->CR1  |=  SPI_SCK ;//�������
    
     //����PC6SPI_MOSIΪ���
    SPI_MOSI_GPIO->DDR |=  SPI_MOSI;//���ģʽ
    SPI_MOSI_GPIO->CR1 |=  SPI_MOSI;//�������
  
      //����SPI_CSΪ���
    SPI_CS_GPIO->DDR   |=  SPI_CS;//���ģʽ
    SPI_CS_GPIO->CR1   |=  SPI_CS;//�������
    
       //����SPI_MISOΪ����
    SPI_MISO_GPIO->DDR &= ~SPI_MISO;//����ģʽ
    SPI_MISO_GPIO->CR1 |=  SPI_MISO;//��������

}