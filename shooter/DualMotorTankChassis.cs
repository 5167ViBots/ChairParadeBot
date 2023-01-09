namespace shooter
{
    internal class DualMotorTankChassis : TankChassis
    {
        PWMMotor LefMotor;
        PWMMotor RightMotor;

        public DualMotorTankChassis(PWMMotor leftMotor, PWMMotor rightMotor)
        {
            LefMotor = leftMotor;
            RightMotor = rightMotor;
        }
        public void SetSpeed(double ForwardReverse, double LeftRight)
        {
            LefMotor.SetSpeed(GetLeftSpeed(ForwardReverse, LeftRight));
            RightMotor.SetSpeed(GetRightSpeed(ForwardReverse, LeftRight));
        }
    }
}