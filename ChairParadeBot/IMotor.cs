using Microsoft.SPOT;
using System;

namespace shooter
{
    interface IMotor
    {
        void SetSpeed(double Speed);
        void SetInvert(bool IsInverted);
    }
}
