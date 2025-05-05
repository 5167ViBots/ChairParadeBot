using Microsoft.SPOT;
using System;

namespace shooter
{
    class MotorGroup : IMotor
    {
        IMotor[] _Motors;
        public MotorGroup(params IMotor[] Motors)
        {
            _Motors = Motors;
        }

        public void SetInvert(bool IsInverted)
        {
            foreach (var motor in _Motors)
            {
                motor.SetInvert(IsInverted);
            }
        }

        public void SetSpeed(double Speed)
        {
            foreach (var motor in _Motors)
            {
                motor.SetSpeed(Speed);
            }
        }
    }
}
