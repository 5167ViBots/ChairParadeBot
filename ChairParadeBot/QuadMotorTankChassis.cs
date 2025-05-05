using Microsoft.SPOT;
using System;

namespace shooter
{
    class QuadMotorTankChassis : TankChassis
    {
        IMotor LeftForward;
        IMotor LeftReverse;
        IMotor RightForward;
        IMotor RightReverse;
        public QuadMotorTankChassis(IMotor leftForward, IMotor leftReverse, IMotor rightForward, IMotor rightReverse)
        {
            LeftForward = leftForward;
            LeftReverse = leftReverse;
            RightForward = rightForward;
            RightReverse = rightReverse;
        }

        
    }
}
