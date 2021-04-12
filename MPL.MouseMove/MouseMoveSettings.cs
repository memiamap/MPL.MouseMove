using System;

namespace MPL.MouseMove
{
    /// <summary>
    /// A class that defines settings for the application.
    /// </summary>
    internal class MouseMoveSettings
    {
        #region Constructors
        /// <summary>
        /// Creates a new instance of the class with the specified parameters.
        /// </summary>
        /// <param name="delayMS">An int indicating the delay in milliseconds between mouse moves.</param>
        internal MouseMoveSettings(int delayMS)
        {
            DelayMS = delayMS;
        }

        #endregion

        #region Methods
        #region _Internal_
        /// <summary>
        /// Creates an instance of the class from saved settings.
        /// </summary>
        /// <returns>A MouseMoveSettings containing the saved settings.</returns>
        internal static MouseMoveSettings FromSavedSettings()
        {
            return new MouseMoveSettings(Properties.Settings.Default.DelayMS);
        }

        /// <summary>
        /// Saves the current settings.
        /// </summary>
        internal void SaveSettings()
        {
            Properties.Settings.Default.DelayMS = DelayMS;
            Properties.Settings.Default.Save();
        }

        #endregion
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the delay in milliseconds between mouse moves.
        /// </summary>
        internal int DelayMS { get; set; }

        #endregion
    }
}