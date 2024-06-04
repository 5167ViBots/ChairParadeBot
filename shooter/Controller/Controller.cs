using CTRE.Phoenix;
using CTRE.Phoenix.Controller;
using Microsoft.SPOT;
using System;

namespace shooter
{
    public class Controller
    {
        //Configuration values: Taken from an xbox 360 wired controller
        public const int ButtonA = 1;
        public const int ButtonB = 2;
        public const int ButtonX = 3;
        public const int ButtonY = 4;
        public const int ButtonLB = 5;
        public const int ButtonRB = 6;
        public const int ButtonBack = 7;
        public const int ButtonStart = 8;
        public const int ButtonL3 = 9;
        public const int ButtonR3 = 10;
        public const int CenterXbox = 11;

        public const int HLeftTStick = 0;
        public const int VLeftTStick = 1;
        public const int HRightTStick = 2;
        public const int VRightTStick = 3;
        public const int LeftTrigger = 4;
        public const int RightTrigger = 5;



        public bool A { get { return gamepad.GetButton(ButtonA); }}
        public bool B { get { return gamepad.GetButton(ButtonB); }}
        public bool X { get { return gamepad.GetButton(ButtonX); }}
        public bool Y { get { return gamepad.GetButton(ButtonY); }}
        public bool LB { get { return gamepad.GetButton(ButtonLB); }}
        public bool RB { get { return gamepad.GetButton(ButtonRB); }}
        public bool Back { get { return gamepad.GetButton(ButtonBack); }}
        public bool Start { get { return gamepad.GetButton(ButtonStart); }}
        public bool L3 { get { return gamepad.GetButton(ButtonL3); }}
        public bool R3 { get { return gamepad.GetButton(ButtonR3); }}
        public bool Center { get { return gamepad.GetButton(CenterXbox); } }



        public bool AHeld { get; private set; }
        public bool BHeld { get; private set; }
        public bool XHeld { get; private set; }
        public bool YHeld { get; private set; }
        public bool LBHeld { get; private set; }
        public bool RBHeld { get; private set; }
        public bool BackHeld { get; private set; }
        public bool StartHeld { get; private set; }
        public bool L3Held { get; private set; }
        public bool R3Held { get; private set; }
        public bool CenterHeld { get; private set; }

        public bool APressed { get
            {
                if (!A)
                    AHeld = false;
                if (A && !AHeld)
                {
                    AHeld = true;
                    return true;
                }
                if (AHeld)
                    return false;
                return false;
                
            }
        }
        public bool BPressed { get
            {
                if (!B)
                    AHeld = false;
                if (B && !BHeld)
                {
                    BHeld = true;
                    return true;
                }
                if (BHeld)
                    return false;
                return false;

            }
        }
        public bool XPressed { get
            {
                if (!X)
                    XHeld = false;
                if (X && !XHeld)
                {
                    XHeld = true;
                    return true;
                }
                if (XHeld)
                    return false;
                return false;

            }
        }
        public bool YPressed { get
            {
                if (!Y)
                    AHeld = false;
                if (Y && !YHeld)
                {
                    YHeld = true;
                    return true;
                }
                if (YHeld)
                    return false;
                return false;

            }
        }
        public bool LBPressed { get
            {
                if (!LB)
                    AHeld = false;
                if (LB && !LBHeld)
                {
                    LBHeld = true;
                    return true;
                }
                if (LBHeld)
                    return false;
                return false;

            }
        }
        public bool RBPressed { get
            {
                if (!RB)
                    RBHeld = false;
                if (RB && !RBHeld)
                {
                    RBHeld = true;
                    return true;
                }
                if (AHeld)
                    return false;
                return false;

            }
        }
        public bool BackPressed { get
            {
                if (!Back)
                    BackHeld = false;
                if (Back && !BackHeld)
                {
                    BackHeld = true;
                    return true;
                }
                if (BackHeld)
                    return false;
                return false;

            }
        }
        public bool StartPressed { get
            {
                if (!Start)
                    StartHeld = false;
                if (Start && !StartHeld)
                {
                    StartHeld = true;
                    return true;
                }
                if (StartHeld)
                    return false;
                return false;

            }
        }
        public bool L3Pressed { get
            {
                if (!L3)
                    L3Held = false;
                if (L3 && !L3Held)
                {
                    L3Held = true;
                    return true;
                }
                if (L3Held)
                    return false;
                return false;

            }
        }
        public bool R3Pressed { get
            {
                if (!R3)
                    R3Held = false;
                if (R3 && !R3Held)
                {
                    R3Held = true;
                    return true;
                }
                if (R3Held)
                    return false;
                return false;

            }
        }
        public bool CenterPressed { get
            {
                if (!Center)
                    CenterHeld = false;
                if (Center && !CenterHeld)
                {
                    CenterHeld = true;
                    return true;
                }
                if (CenterHeld)
                    return false;
                return false;

            }
        }


        public float LeftThumbStickHorizontalAxisValue
        {
            get
            {
                float i = gamepad.GetAxis(HLeftTStick);
                float tmp = (float)System.Math.Abs(i);
                if (tmp > LeftStickDeadzone) return i;
                return 0;
            }
        }
        public float LeftThumbStickVerticalAxisValue { 
            get
            {
                float i = gamepad.GetAxis(VLeftTStick);
                float tmp = (float)System.Math.Abs(i);
                if (tmp > LeftStickDeadzone) return i;
                return 0;
            }
        }
        public float RightThumbStickHorizontalAxisValue { 
            get {
                float i = gamepad.GetAxis(HRightTStick);
                float tmp = (float)System.Math.Abs(i);
                if (tmp > RightStickDeadzone) return i;
                return 0;
            } }
        public float RightThumbStickVerticalAxisValue { 
            get {
                float i = gamepad.GetAxis(VRightTStick);
                float tmp = (float)System.Math.Abs(i);
                if (tmp > RightStickDeadzone) return i;
                return 0;
 } }
        public float LeftTriggerValueRaw { get { return gamepad.GetAxis(LeftTrigger); } }
        public float LeftTriggerValue { get { 
                float i = (LeftTriggerValueRaw + 1) / 2;
                if (i > LeftTriggerDeadzone)
                    return i;
                return 0;
            } }
        public float RightTriggerValueRaw { get { return gamepad.GetAxis(RightTrigger); } }
        public float RightTriggerValue { get { 
                
                float i = (RightTriggerValueRaw + 1) / 2;
                if (i > RightTriggerDeadzone)
                    return i;
                return 0;
            } }

        GameController gamepad;
        public Controller()
        {
            gamepad = new GameController(UsbHostDevice.GetInstance(0));

            //Initialize default deadzones
            LeftStickDeadzone = 0.1F;
            RightStickDeadzone = 0.1F;
            LeftTriggerDeadzone = 0.1F;
            RightTriggerDeadzone = 0.1F;
            WatchdogStatus = true;
        }

        public bool IsConnected { get {
                if (!WatchdogStatus)
                    return false;
                return gamepad.GetConnectionStatus() == UsbDeviceConnection.Connected; } }

        public float LeftStickDeadzone { get; set; }
        public float RightStickDeadzone { get; set; }
        public float LeftTriggerDeadzone { get; set; }
        public float RightTriggerDeadzone { get; set; }



        /*
         * axis 0 = left thumb stick horizontal
         * Axis 1 = left thum stuck vertical
         * axis 2 = right thum stick horizontal
         * Axis 3 = Right THumb Stick Vertical
         * Axis 4 = left trigger | -1 is 0, 1 is 100%
         * Axis 5 = right trigger | -1 is 0, 1 is 100%
         */

        public ControllerState GetControllerState()
        {
            ControllerState state = new ControllerState();

            state.A = gamepad.GetButton(ButtonA);
            state.B = gamepad.GetButton(ButtonB);
            state.X = gamepad.GetButton(ButtonX);
            state.Y = gamepad.GetButton(ButtonY);
            state.LeftBumper = gamepad.GetButton(ButtonLB); ;
            state.RightBumper = gamepad.GetButton(ButtonRB); ;
            state.Select = gamepad.GetButton(ButtonBack); ;
            state.Start = gamepad.GetButton(ButtonStart);
            state.L3 = gamepad.GetButton(ButtonL3);
            state.R3 = gamepad.GetButton(ButtonR3);
            state.Center = gamepad.GetButton(CenterXbox);


            state.LeftStickX= gamepad.GetAxis(HLeftTStick);
            state.LeftStickY= gamepad.GetAxis(VLeftTStick);
            state.RightStickX= gamepad.GetAxis(HRightTStick);
            state.RightStickY= gamepad.GetAxis(VRightTStick);
            state.LeftTrigger= gamepad.GetAxis(LeftTrigger);
            state.RightTrigger= gamepad.GetAxis(RightTrigger);


            return state;
        }

        public bool WatchdogStatus { get; set; }
    }
}
