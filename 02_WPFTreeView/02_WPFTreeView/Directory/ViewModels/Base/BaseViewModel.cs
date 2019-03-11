using System.ComponentModel;

namespace _02_WPFTreeView.Directory.ViewModels
{
    /// <summary>
    /// A base view model that fires Property changed events as needed
    /// </summary>
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender, e)=> { };
    }
}
