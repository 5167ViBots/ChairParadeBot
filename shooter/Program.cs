using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using System;
using System.Threading;
using CTRE.Phoenix;
using CTRE.Phoenix.Controller;
using CTRE.Phoenix.MotorControl;
using CTRE.Phoenix.MotorControl.CAN;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using System.Text;

namespace shooter
{
    public class Program
    {
        public static void Main()
        {

            //Configuration
            const int PCMCANChannel = 6;
            const int PCMLightChannel = 1;
            const int PCMShooterSolenoidChannel = 0;

            const float ShooterAngleSpeed = .5f;


            //Initialization
            //GameController gamePad = new GameController(UsbHostDevice.GetInstance(0));
            PneumaticControlModule pcm = new PneumaticControlModule(PCMCANChannel);
            PWMMotor Motor1 = new PWMMotor(CTRE.HERO.IO.Port3.PWM_Pin4);
            PWMMotor Motor2 = new PWMMotor(CTRE.HERO.IO.Port3.PWM_Pin6);
            PWMMotor Motor3 = new PWMMotor(CTRE.HERO.IO.Port3.PWM_Pin7);
            PWMMotor Motor4 = new PWMMotor(CTRE.HERO.IO.Port3.PWM_Pin8);
            UsbHostDevice.GetInstance(0).SetSelectableXInputFilter(UsbHostDevice.SelectableXInputFilter.XInputDevices);
            PCMSwitch LightSwitch = new PCMSwitch(pcm, PCMLightChannel);
            PCMSolenoid ShooterSolenoid = new PCMSolenoid(pcm, PCMShooterSolenoidChannel);
            Controller gamepad = new Controller();
            DualMotorTankChassis robotChassis = new DualMotorTankChassis(Motor1, Motor2);


            
            LightSwitch.TurnOn();

            bool Runone = true;

            /* loop forever */
            while (true)
            {
                if (gamepad.IsConnected)
                {
                    CTRE.Phoenix.Watchdog.Feed();
                }
                /*
                if (gamepad.B)
                    ShooterSolenoid.TurnOn();
                else
                    ShooterSolenoid.TurnOff();
                */
                /*
                bool[] buttonarray = new bool[30];
                gamePad.GetButtons(buttonarray);

                bool buttonPressed = false;
                StringBuilder sB = new StringBuilder();
                */
                /*
                for (int i = 0; i < buttonarray.Length; i++)
                {
                    if (buttonarray[i])
                    {
                        Debug.Print("Button " + i.ToString() + " pressed");
                    }
                }
*/
                float[] axises = new float[10];
                if (gamepad.APressed)
                {

                    Debug.Print("Left H: " + gamepad.LeftThumbStickHorizontalAxisValue);
                    Debug.Print("Left V: " + gamepad.LeftThumbStickVerticalAxisValue);
                    Debug.Print("Right H: " + gamepad.RightThumbStickHorizontalAxisValue);
                    Debug.Print("Right V: " + gamepad.RightThumbStickVerticalAxisValue);
                    Debug.Print("Left Trig: " + gamepad.LeftTriggerValue);
                    Debug.Print("Right Trig: " + gamepad.RightTriggerValue);

                }

                if (gamepad.YPressed)
                {
                    if (LightSwitch.CurrentState)
                        LightSwitch.TurnOff();
                    else
                        LightSwitch.TurnOn();
                    
                }

                if (gamepad.BPressed)
                {
                    ShooterSolenoid.TurnOn();
                }

                if (!gamepad.B)
                {
                    ShooterSolenoid.TurnOff();
                }

                if (gamepad.X)
                {
                    ShooterSolenoid.TurnOn();
                }

                if (!gamepad.X)
                {
                    ShooterSolenoid.TurnOff();
                }

                if (gamepad.StartPressed)
                {
                    ShooterSolenoid.TurnOn();
                }
                else
                {
                    ShooterSolenoid.TurnOff();
                }

                if (gamepad.RBPressed)
                {
                    Motor3.SetSpeed(ShooterAngleSpeed);
                }
                else if (gamepad.LBPressed)
                {
                    Motor3.SetSpeed(ShooterAngleSpeed * -1);
                }
                else
                {
                    Motor3.SetSpeed(0);
                }

                robotChassis.SetSpeed(gamepad.LeftThumbStickVerticalAxisValue, gamepad.RightThumbStickHorizontalAxisValue);


                //Motor1.SetSpeed(((gamepad.RightTriggerValue + 1)/2));

                /*
                if (buttonarray[2])
                {
                    buttonPressed = true;
                    shooty.SetSolenoidOutput(0, true);
                }
                else
                {
                    buttonPressed = false;
                    shooty.SetSolenoidOutput(0, false);
                }

                /* let button1 control the explicit PWM pin duration*/
                /*if (gamePad.GetButton(1) == true)
                {
                    pwm_6.Duration = 2000; / 2.0ms /  //Forward is 2000
                    pwm_4.Duration = 2000; /* 2.0ms /
                }
                else
                {
                    pwm_6.Duration = 1500; /* 1.0ms / //Stop is 1500
                    pwm_4.Duration = 1500; /* 1.0ms / //Reverse is 1000
                }

                */























                /*foreach (bool item in buttonarray)
                {


                    if (item)
                    {
                        buttonPressed = true;
                        sB.Append("Button Pressed");
                    }

                }
                */
                //Debug.Print(sB.ToString());
                //Debug.Print(buttonPressed.ToString());

                /*
                if (firstrun)
                {
                    shooty.SetSolenoidOutput(0, true);
                    firstrun = false;
                }
                shooty.SetSolenoidOutput(0, buttonPressed);
                    //shooty.SetSolenoidOutput(0, true);
                    shooty.SetSolenoidOutput(1, buttonPressed);
                    shooty.SetSolenoidOutput(2, buttonPressed);
                   shooty.SetSolenoidOutput(3, buttonPressed);*/
            }
        }
    }
}
