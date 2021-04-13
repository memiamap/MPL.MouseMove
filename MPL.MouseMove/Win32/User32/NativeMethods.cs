/*
 MPL Common Library (c) 2008-2021 Martin Parkin. All Rights Reserved.
 https://github.com/memiamap/MPL.Common
*/
using System;
using System.Runtime.InteropServices;

namespace MPL.Common.Win32.User32
{
    /// <summary>
    /// A class that defines native extern methods for User32.dll.
    /// </summary>
    internal static class NativeMethods
    {
        #region Declarations
        #region _Externs_
        /// <summary>
        /// Gets the current cursor position.
        /// </summary>
        /// <param name="lpPoint">A POINT that will be set to the screen coordinates of the cursor.</param>
        /// <returns>A bool indicating the result.</returns>
        [DllImport("user32.dll")]
        internal static extern bool GetCursorPos(out POINT lpPoint);

        /// <summary>
        /// Sets the current cursor position.
        /// </summary>
        /// <param name="x">An int indicating the new x-coordinate of the cursor in screen coordinates.</param>
        /// <param name="y">An int indicating the new y-coordinate of the cursor in screen coordinates.</param>
        /// <returns></returns>
        [DllImport("User32.Dll")]
        internal static extern bool SetCursorPos(int x, int y);

        #endregion
        #endregion
    }
}