/*
 MPL Common Library (c) 2008-2021 Martin Parkin. All Rights Reserved.
 https://github.com/memiamap/MPL.Common
*/
using MPL.Common.Win32.User32;
using System;

namespace MPL.Common.Win32
{
    /// <summary>
    /// A class that defines methods to integrate with the User32 library.
    /// </summary>
    public static class User32Integration
    {
        #region Methods
        #region _Public_
        /// <summary>
        /// Gets the current cursor position on the screen.
        /// </summary>
        /// <param name="x">An int that will be set to the x-coordinate of the cursor.</param>
        /// <param name="y">An int that will be set to the y-coordinate of the cursor.</param>
        /// <returns>A bool indicating success.</returns>
        public static bool GetCursorPosition(out int x, out int y)
        {
            bool returnValue = false;

            if (NativeMethods.GetCursorPos(out POINT point))
            {
                x = point.x;
                y = point.y;
                returnValue = true;
            }
            else
            {
                x = 0;
                y = 0;
            }

            return returnValue;
        }

        /// <summary>
        /// Sets the current cursor position on the screen.
        /// </summary>
        /// <param name="x">An int indicating the x-coordinate of the cursor.</param>
        /// <param name="y">An int indicating the y-coordinate of the cursor.</param>
        /// <returns>A bool indicating success.</returns>
        public static bool SetCursorPosition(int x, int y)
        {
            return NativeMethods.SetCursorPos(x, y);
        }

        #endregion
        #endregion
    }
}