using _02_WPFTreeView.Directory.ViewModels;
using System.Collections.ObjectModel;

namespace _02_WPFTreeView
{
    /// <summary>
    /// The view model for the application main Directory view
    /// </summary>
    class DirectoryStructureViewModel:BaseViewModel
    {
        #region Public Property
        /// <summary>
        /// A list of all directories on the machines
        /// </summary>
        public ObservableCollection<DirectoryItemViewModel> Items { get; set; }

        #endregion

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public DirectoryStructureViewModel()
        {

        }
        #endregion
    }
}
