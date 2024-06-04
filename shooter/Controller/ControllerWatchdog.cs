using Microsoft.SPOT;
using System;

namespace shooter
{
    class ControllerWatchdog
    {
        Controller _controller;
        public ControllerWatchdog(Controller controller, int TimeoutDuration) { 
            _controller = controller; 
            Thread = new System.Threading.Thread(new System.Threading.ThreadStart(WatchdogLoop));
            TimeoutMS = TimeoutDuration;
            Thread.Start();
        }

        public int TimeoutMS { get; set; }

        ControllerState OldState;
        ControllerState CurrentState;
        DateTime OldStateDateTime;

        private void WatchdogCheck()
        {
            //Debug.Print("Controller Watchdog Checking");
            CurrentState = _controller.GetControllerState();

            if (OldState != CurrentState)
            {
                OldState = CurrentState;
                OldStateDateTime = DateTime.Now;
                _controller.WatchdogStatus = true;
                return;
            }
            if ((DateTime.Now - OldStateDateTime).Ticks > TimeoutMS*TimeSpan.TicksPerMillisecond)
            {
                _controller.WatchdogStatus = false;
            }
        }

        System.Threading.Thread Thread;

        public void StartWatchdog()
        {
            Thread.Resume();
        }

        public void StopWatchdog()
        {
            Thread.Suspend();
        }

        public void WatchdogLoop()
        {
            while (true)
            {
                WatchdogCheck();
                System.Threading.Thread.Sleep(10);
            }

        }


    }
}
