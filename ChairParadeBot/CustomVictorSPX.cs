using CTRE.Phoenix.MotorControl.CAN;
using System;
using System.Text;
using System.Windows.Forms;

namespace shooter
{
    public partial class CustomVictorSPX : VictorSPX, IMotor
    {
        public CustomVictorSPX(int DeviceNumber) : base(DeviceNumber) { }

        public void SetInvert(bool IsInverted)
        {
            SetInverted(IsInverted);
        }

        public void SetSpeed(double Speed)
        {
            Set(CTRE.Phoenix.MotorControl.ControlMode.PercentOutput, Speed);
        }
    }
}
