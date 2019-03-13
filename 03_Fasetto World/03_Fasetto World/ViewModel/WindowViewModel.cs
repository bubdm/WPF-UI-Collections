
using System.Windows;

namespace _03_Fasetto_World
{
    /// <summary>
    /// The view model for the custom flat window
    /// </summary>
    class WindowViewModel :BaseViewModel
    {
        #region
        /// <summary>
        /// the window this view model controls
        /// </summary>
        private readonly Window mWindow;
        #endregion
        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public WindowViewModel(Window window)
        {
            window = mWindow;
        }
        #endregion
    }
}
