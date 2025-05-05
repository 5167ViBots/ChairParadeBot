using Microsoft.SPOT;
using System;

namespace shooter
{
    class QuadMotorTankChassis : TankChassis
    {
        PWMMotor LeftForward;
        PWMMotor LeftReverse; 
        PWMMotor RightForward;
        PWMMotor RightReverse;
        public QuadMotorTankChassis(PWMMotor leftForward, PWMMotor leftReverse, PWMMotor rightForward, PWMMotor rightReverse)
        {
            LeftForward = leftForward;
            LeftReverse = leftReverse;
            RightForward = rightForward;
            RightReverse = rightReverse;
        }

        
    }
}
