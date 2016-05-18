#include "pid.h"
#include "EXIT.h"
#include <string.h>

/*====================================================================================================
PID计算部分
=====================================================================================================*/
double PIDCalc( PID *pp, int NextPoint )
{
  int iError,ilncpid;
  iError = pp->SetPoint - NextPoint;
  ilncpid =  pp->Proportion * iError
          - pp->Integral * pp->LastError
          + pp->Derivative * pp->PrevError;
          
  pp->PrevError = pp->LastError;
  pp->LastError = iError;
  return ilncpid;
  
//double dError,
//Error;
//Error = pp->SetPoint - NextPoint; /* 偏差 */
//pp->SumError += Error; /* 积分            */
//dError = pp->LastError - pp->PrevError; /* 当前微分*/
//pp->PrevError = pp->LastError;
//pp->LastError = Error;
//return (pp->Proportion * Error /*比例项  */
//+ pp->Integral * pp->SumError /*积分项  */
//+ pp->Derivative * dError /*微分项      */
//);
}
/*====================================================================================================
Initialize PID Structure
=====================================================================================================*/
void PIDInit (PID *pp)
{
  memset ( pp,0,sizeof(PID));
}
/*====================================================================================================
Main Program
=====================================================================================================*/
extern Channel CH0,CH1,CH2,CH3,CH4;

double sensor (void) /* Dummy Sensor Function        */
{
  if(ADC_Channel_Status(CH0)==nonzero) return 4;
  else if(ADC_Channel_Status(CH4)==nonzero) return -4;
  else if(ADC_Channel_Status(CH0)==nonzero&&ADC_Channel_Status(CH1)==nonzero) return 3;
  else if(ADC_Channel_Status(CH3)==nonzero&&ADC_Channel_Status(CH4)==nonzero) return -3;
  else if(ADC_Channel_Status(CH1)==nonzero) return 2;
  else if(ADC_Channel_Status(CH3)==nonzero) return -2;
  else if(ADC_Channel_Status(CH1)==nonzero&&ADC_Channel_Status(CH2)==nonzero) return 1;
  else if(ADC_Channel_Status(CH2)==nonzero&&ADC_Channel_Status(CH3)==nonzero) return -1;
  else if(ADC_Channel_Status(CH2)==nonzero) return 0;
  else return 10;
}
void actuator(double rDelta) /* Dummy Actuator Function */
{}
