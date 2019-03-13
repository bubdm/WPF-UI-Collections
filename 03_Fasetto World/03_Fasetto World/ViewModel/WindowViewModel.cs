
using System.Windows;

namespace _03_Fasetto_World
{
    /// <summary>
    /// The view model for the custom flat window
    /// </summary>
    class WindowViewModel :BaseViewModel
    {
        #region private member
        /// <summary>
        /// The window this view model controls
        /// </summary>
        private Window mWindow;
        /// <summary>
        /// The margin around the window to allow for a drop shadow
        /// </summary>
        private int mOuterMarginSize = 10;
        /// <summary>
        /// The radius of the edges of the window.
        /// </summary>
        private int mWindwoRadius = 10;
        #endregion

        #region public properties

        /// <summary>
        /// The size of the resize border around the window
        /// </summary>
        public int ResizeBorder { get; set; } = 6;

        public Thickness ResizeBorderThickness { get {return new Thickness(ResizeBorder); } }
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
