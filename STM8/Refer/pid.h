#ifndef _PID_H
#define _PID_H


/*====================================================================================================
PID Function
The PID (���������֡�΢��) function is used in mainly
control applications. PIDCalc performs one iteration of the PID
algorithm.
While the PID function works, main is just a dummy program showing
a typical usage.
=====================================================================================================*/
typedef struct PID {
int SetPoint; /* �趨Ŀ�� Desired Value   */
double Proportion; /* �������� Proportional Const  */
double Integral; /* ���ֳ��� Integral Const      */
double Derivative; /* ΢�ֳ��� Derivative Const   */
int LastError; /* Error[-1]       */
int PrevError; /* Error[-2]       */
double SumError; /* Sums of Errors   */
} PID;


double PIDCalc( PID *pp, int NextPoint );
void PIDInit (PID *pp);
double sensor (void);
void actuator(double rDelta);


#endif