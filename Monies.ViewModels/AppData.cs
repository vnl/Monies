﻿/***************************************************************************************************
 * PROJECT : Monies
 * 
 * 
 * DISCLAIMER : This code is licensed under CPOL. You are free to use this in your project.
 * The author takes no liabilities for any damage caused because of this code. Use at your own risk.
****************************************************************************************************/

using Monies.Models.DataModels;

namespace Monies.ViewModels
{
    /// <summary>
    /// A data holder class for the aplication.
    /// </summary>
    public static class AppData
    {
        /// <summary>
        /// Gets or sets the <see cref="User"/> instance who is logged in into the application.
        /// </summary>
        public static User LoggedInUser { get; set; }
    }
}
