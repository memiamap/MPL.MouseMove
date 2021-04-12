using MPL.Common.Win32;
using System;
using System.Threading;

namespace MPL.MouseMove
{
    /// <summary>
    /// A class that defines the mouse move service.
    /// </summary>
    internal class MouseMoveService
    {
        #region Constructors
        /// <summary>
        /// Creates a new instance of the class with the specified parameters.
        /// </summary>
        /// <param name="delayMS">An int indicating the delay in milliseconds between mouse moves.</param>
        internal MouseMoveService(int delayMS = cDELAYMS_DEFAULT)
        {
            DelayMS = delayMS;
        }

        #endregion

        #region Declarations
        #region _Constants_
        private const int cDELAYMS_MINIMUM = 5;
        private const int cDELAYMS_DEFAULT = 1000;

        #endregion
        #region _Members_
        private int _delayMS;
        private DateTime _nextInterval;
        private Thread _runThread;

        #endregion
        #endregion

        #region Methods
        #region _Internal_
        /// <summary>
        /// Starts the service.
        /// </summary>
        internal void Start()
        {
            if (!IsRunning)
            {
                IsRunning = true;

                _delayMS = DelayMS;
                if (_delayMS < cDELAYMS_MINIMUM)
                {
                    _delayMS = cDELAYMS_MINIMUM;
                    DelayMS = cDELAYMS_MINIMUM;
                }

                _runThread = new Thread(new ThreadStart(RunMouseMove)) { Name = "MouseMove Run Thread" };
                _runThread.Start();
            }
        }

        /// <summary>
        /// Stops the service.
        /// </summary>
        internal void Stop()
        {
            if (IsRunning)
                IsRunning = false;
        }

        #endregion
        #region _Private_
        private void RunMouseMove()
        {
            Random rng;

            rng = new Random();

            while (IsRunning)
            {
                if (_nextInterval < DateTime.Now)
                {
                    if (User32Integration.GetCursorPosition(out int x, out int y))
                    {
                        switch (rng.Next(0, 4))
                        {
                            case 0:
                                x++;
                                break;

                            case 1:
                                x--;
                                break;

                            case 2:
                                y++;
                                break;

                            case 3:
                                y--;
                                break;
                        }

                        User32Integration.SetCursorPosition(x, y);
                    }

                    _nextInterval = DateTime.Now.AddMilliseconds(_delayMS);
                }

                Thread.Sleep(cDELAYMS_MINIMUM);
            }
        }

        #endregion
        #endregion

        #region Properties
        /// <summary>
        /// Gets the delay in milliseconds between cursor position updates.
        /// </summary>
        /// <remarks>Changes to the delay will only be effective the next time the service is started.</remarks>
        internal int DelayMS { get; set; }

        /// <summary>
        /// Gets an indication of whether the service is running.
        /// </summary>
        internal bool IsRunning { get; private set; }

        #endregion
    }
}