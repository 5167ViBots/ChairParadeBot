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
            CurrentState = _controller.GetControllerState();

            if (OldState != CurrentState)
            {
                OldState = CurrentState;
                OldStateDateTime = DateTime.Now;
                _controller.WatchdogStatus = false;
                return;
            }
            if ((DateTime.Now - OldStateDateTime).Milliseconds > TimeoutMS)
            {
                _controller.WatchdogStatus = true;
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
            WatchdogCheck();
            System.Threading.Thread.Sleep(10);
        }


    }
}
