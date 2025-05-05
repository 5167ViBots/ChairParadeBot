namespace shooter
{
    internal class TankChassis
    {

        IMotor LeftMotor;
        IMotor RightMotor;

        public TankChassis(IMotor leftMotor, IMotor rightMotor)
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
                RightMotor.SetSpeed(DirectionSpeed);
                LeftMotor.SetSpeed(DirectionSpeed * -1);
            }
        }

        protected double GetLeftSpeed(double ForwardReverse, double LeftRight)
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
            return LeftSpeed;
        }
        protected double GetRightSpeed(double ForwardReverse, double LeftRight)
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

            return RighttSpeed;
        }
    }
}