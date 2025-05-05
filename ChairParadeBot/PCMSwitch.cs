using CTRE.Phoenix;
using Microsoft.SPOT;
using System;

namespace shooter
{
    public class PCMSwitch
    {
        public int Channel { get; set; }
        public bool CurrentState { get; set; }
        PneumaticControlModule PCM;
        public PCMSwitch(PneumaticControlModule pcm, int channel)
        {
            Channel = channel;
            PCM = pcm;
            TurnOff();
        }

        public void TurnOn()
        {
            if (!CurrentState == true)
            {
                PCM.SetSolenoidOutput(Channel, true);
                CurrentState = true;
            }
        }
        public void TurnOff()
        {
            if (!CurrentState == false)
            {
                PCM.SetSolenoidOutput(Channel, false);
                CurrentState = false;
            }


        }
    }
}
