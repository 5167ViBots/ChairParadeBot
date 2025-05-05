using CTRE.Phoenix;
using Microsoft.SPOT;
using System;

namespace shooter
{
    public class PCMSolenoid : PCMSwitch
    {
        public PCMSolenoid(PneumaticControlModule pcm, int channel) : base(pcm, channel)
        {

        }

    }
}
