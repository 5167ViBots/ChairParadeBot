using Microsoft.SPOT;
using System;

namespace shooter
{
    class TankChassis
    {
        PWMMotor LeftForward;
        PWMMotor LeftReverse; 
        PWMMotor RightForward;
        PWMMotor RightReverse;
        public TankChassis(PWMMotor leftForward, PWMMotor leftReverse, PWMMotor rightForward, PWMMotor rightReverse)
        {
            LeftForward = leftForward;
            LeftReverse = leftReverse;
            RightForward = rightForward;
            RightReverse = rightReverse;
        }

        public void SetSpeed(double ForwardReverse, double LeftRight)
        {
            double LeftSpeed = ForwardReverse;
            double RighttSpeed = ForwardReverse;

            if (LeftRight > 0) //going right, need to slow down right motors
            {
                double SpeedDifference = (LeftRight / 2);
                if (RighttSpeed > 0)
                    RighttSpeed -= SpeedDifference;
                else if (RighttSpeed < 0)
                    RighttSpeed += SpeedDifference;

            }
            if (LeftRight < 0) //going left, need to slow down left motors
            {
                double SpeedDifference = (System.Math.Abs(LeftRight) / 2);
                if (LeftSpeed > 0)
                    LeftSpeed -= SpeedDifference;
                else if (LeftSpeed < 0)
                    LeftSpeed += SpeedDifference;
            }

            if (LeftSpeed > 1)
                LeftSpeed = 1;
            if (RighttSpeed > 1)
                RighttSpeed = 1;
            if (LeftSpeed < -1)
                LeftSpeed = -1;
            if (RighttSpeed < -1)
                RighttSpeed = -1;
            LeftForward.SetSpeed(LeftSpeed);
            LeftReverse.SetSpeed(LeftSpeed);
            RightForward.SetSpeed(RighttSpeed);
            RightReverse.SetSpeed(RighttSpeed);
        }
    }
}
