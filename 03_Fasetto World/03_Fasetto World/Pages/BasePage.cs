
using System.Windows.Controls;
using System.Windows;
using System;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace _03_Fasetto_World
{
    /// <summary>
    /// A base page for all pages to gain base functionaity
    /// </summary>
    public class BasePage:Page
    {
        #region Public Properties

        /// <summary>
        /// The animation the play when the page is first loaded
        /// </summary>
        public PageAnimation PageLoadAnimation { get; set; } = PageAnimation.SlideAndFadeInFromRight;

        /// <summary>
        /// The animation the play when the page is unloaded
        /// </summary>
        public PageAnimation PageUnloadAnimation { get; set; } = PageAnimation.SlideAndFadeOutToLeft;

        /// <summary>
        /// The time any slide animation takes to complete
        /// </summary>
        public float SlideSeconds { get; set; } = 0.8f;
        #endregion

        #region Constructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        public BasePage()
        {
            // If we are animating in, hide to begin with
            if(this.PageLoadAnimation != PageAnimation.None)
            {
                this.Visibility = Visibility.Collapsed;
            }
            // Listen out for the page loading
            this.Loaded += BasePage_Loaded;
        }
        #endregion

        #region Page loading
        /// <summary>
        /// Once the page is loaded, perform any required animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BasePage_Loaded(object sender, RoutedEventArgs e)
        {
            // Animate the page in
            await AnimateIn();
        }

        #endregion

        #region Animation in
        public async Task AnimateIn()
        {
            // Make sure we have something to animate
            if (this.PageLoadAnimation == PageAnimation.None)
                return;

            switch (this.PageLoadAnimation)
            {
                case PageAnimation.SlideAndFadeInFromRight:

                    // Start the animation
                    await this.SlideAndFadeInFromRight(this.SlideSeconds*3);
                    break;
           
            }
        }
        #endregion

        #region Animation out
        public async Task AnimateOut()
        {
            // Make sure we have something to animate
            if (this.PageUnloadAnimation == PageAnimation.None)
                return;

            switch (this.PageUnloadAnimation)
            {
                case PageAnimation.SlideAndFadeOutToLeft:

                    // Start the animation
                    await this.SlideAndFadeOutToLeft(this.SlideSeconds*5);
                    break;

            }
        }
        #endregion
    }
}
