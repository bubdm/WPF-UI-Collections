
using System;
using System.Windows;

namespace _03_Fasetto_World
{
    /// <summary>
    /// A base attached property to replace the vanilla WPF attached property
    /// </summary>
    /// <typeparam name="Parent"> The parent class to be the attached property </typeparam>
    /// <typeparam name="Property"> The type of this attached property </typeparam>
    public abstract class BaseAttachedProperty<Parent, Property>
        where Parent: BaseAttachedProperty<Parent, Property>, new()
    {
        #region Public Events

        /// <summary>
        /// Fires when the value changes
        /// </summary>
        public event Action<DependencyObject, DependencyPropertyChangedEventArgs> ValueChanged = (sender, e) => { };

        #endregion

        #region Public properties

        /// <summary>
        /// A singelton instance of our parent class
        /// </summary>
        public static Parent Instance = new Parent();

        #endregion

        #region Attached Property Definitions
        /// <summary>
        /// The attached property for this class
        /// </summary>
        private static readonly DependencyProperty ValueProperty = DependencyProperty.RegisterAttached("Value", typeof(Property), 
            typeof(BaseAttachedProperty<Parent, Property>), new PropertyMetadata(new PropertyChangedCallback(OnValuePropertyChanged)));

        /// <summary>
        /// The callback event when the <see cref="ValueProperty"/> is changed
        /// </summary>
        /// <param name="d">The UI element that had it's property changed</param>
        /// <param name="e">The arguments for the event</param>
        private static void OnValuePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // Call the parent function
            Instance.OnValueChanged(d, e);

            // Call events listners
            Instance.ValueChanged(d, e);
        }

        /// <summary>
        /// Gets the attached property 
        /// </summary>
        /// <param name="d">The element to get the property from</param>
        /// <returns></returns>
        public static Property GetValue(DependencyObject d)=>(Property)d.GetValue(ValueProperty);

        /// <summary>
        /// Sets the attached property 
        /// </summary>
        /// <param name="d">The value to set the property to</param>
        /// <returns></returns>
        public static void SetValue(DependencyObject d, Property value) => d.SetValue(ValueProperty, value);

        #endregion

        #region Event Methods
        /// <summary>
        /// The method that is called when any attached property of this type is changed
        /// </summary>
        /// <param name="sender"> The UI element that this property was changed for </param>
        /// <param name="e"> The arguments for this event </param>
        public virtual void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e) { }

        #endregion
    }
}
