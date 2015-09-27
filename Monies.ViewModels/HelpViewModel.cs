/***************************************************************************************************
 * PROJECT : Monies
 * PROJECT DESCRIPTION : A metro style, smart client expense tracking software.
 * AUTHOR : Vivian Lobo
 * DISCLAIMER : This code is licensed under CPOL. You are free to use this in your project.
 * The author takes no liabilities for any damage caused because of this code. Use at your own risk.
****************************************************************************************************/

using System.Diagnostics;
using System.Windows.Input;
using Monies.Infrastructure.CoreClasses;
using Monies.Infrastructure.MessagingService;
using Monies.Shared;

namespace Monies.ViewModels
{
    /// <summary>
    /// This is a view model for catering to the help secondary view.
    /// </summary>
    public class HelpViewModel : ModalDialogViewModelBase
    {
        #region Commands

        /// <summary>
        /// Gets the command to launch a webpage.
        /// </summary>
        public ICommand LaunchWebpageCommand { get; private set; }

        #endregion


        #region Constructor

        /// <summary>
        /// Initializes and instance of <see cref="HelpViewModel"/>.
        /// </summary>
        public HelpViewModel()
        {
            TitleText = UIText.HELP_WINDOW_HEADER;
            LaunchWebpageCommand = new RelayCommand<string>(LaunchWebpage);
        }

        #endregion


        #region Command Helpers

        /// <summary>
        /// Launches a webpage in the default browser..
        /// </summary>
        /// <param name="url">The URL of the webpage.</param>
        private void LaunchWebpage(string url)
        {
            Process.Start(url);
        }

        #endregion


    }
}
