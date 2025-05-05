namespace shooter
{
    internal class DualMotorTankChassis : TankChassis
    {
        IMotor LeftMotor;
        IMotor RightMotor;

        public DualMotorTankChassis(IMotor leftMotor, IMotor rightMotor)
        {
            LeftMotor = leftMotor;
            RightMotor = rightMotor;
        }
        public void SetSpeed(double ForwardReverse, double LeftRight)
        {
            LeftMotor.SetSpeed(GetLeftSpeed(ForwardReverse, LeftRight));
            RightMotor.SetSpeed(GetRightSpeed(ForwardReverse, LeftRight));
        }
        public void Rotate(double DirectionSpeed)
        {
            if (DirectionSpeed > 0)
            {
                RightMotor.SetSpeed(DirectionSpeed);
                LeftMotor.SetSpeed(DirectionSpeed * -1);
            }
            else
            {
                RightMotor.SetSpeed(DirectionSpeed );
                LeftMotor.SetSpeed(DirectionSpeed*-1);
            }
        }
    }
}