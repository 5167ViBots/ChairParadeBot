using Microsoft.SPOT;
using System;

namespace shooter
{
    public struct ControllerState
    {
        public bool A;
        public bool B;
        public bool X;
        public bool Y;
        public bool Start;
        public bool Select;
        public bool LeftBumper;
        public bool RightBumper;
        public bool L3;
        public bool R3;
        public bool Center;
        public float LeftStickX;
        public float LeftStickY;
        public float RightStickX;
        public float RightStickY;
        public float LeftTrigger;
        public float RightTrigger;


        public static bool operator ==(ControllerState c1, ControllerState c2)
        {
            return c1.Equals(c2);
        }

        public static bool operator !=(ControllerState c1, ControllerState c2)
        {
            return !c1.Equals(c2);
        }
    }
}
