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

        public override bool Equals(object obj)
        {
            if (!(obj is ControllerState))
                return false;

            if (obj == null)
                return false;

            var item = (ControllerState)obj;

            return
                A == item.A &&
                B == item.B &&
                X == item.X &&
                Y == item.Y &&
                Start == item.Start &&
                Select == item.Select &&
                LeftBumper == item.LeftBumper &&
                RightBumper == item.RightBumper &&
                L3 == item.L3 &&
                R3 == item.R3 &&
                Center == item.Center &&
                LeftStickX == item.LeftStickX &&
                LeftStickY == item.LeftStickY &&
                RightStickX == item.RightStickX &&
                RightStickY == item.RightStickY &&
                LeftTrigger == item.LeftTrigger &&
                RightTrigger == item.RightTrigger;

    }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
