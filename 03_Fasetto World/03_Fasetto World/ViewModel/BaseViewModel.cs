using System.ComponentModel;


namespace _03_Fasetto_World
{
    /// <summary>
    /// A base view model that fires Property changed events as needed
    /// </summary>
    public class BaseViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// this event is fired when any child property is changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged = (sender, e)=> { };

        /// <summary>
        /// call this to fire a <see cref="PropertyChanged"/> event
        /// </summary>
        /// <param name="name"></param>
        public void OnPropertyChanged(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }


}
