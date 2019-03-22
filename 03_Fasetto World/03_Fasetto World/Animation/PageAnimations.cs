
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace _03_Fasetto_World
{
    /// <summary>
    /// Helpers to animate pages in specific ways
    /// </summary>
    public static class PageAnimatinos
    {
        #region slide and fade in from right function
        /// <summary>
        /// Slides a page in from right 
        /// </summary>
        /// <param name="page">The page to animate</param>
        /// <param name="seconds">Animation time</param>
        /// <returns></returns>
        public static async Task SlideAndFadeInFromRight(this Page page, float seconds)
        {
            // create the storyboard
            var sb = new Storyboard();

            // add slide from right animation
            sb.AddSlideFromRight(seconds, page.WindowWidth);

            //Add fade in animation
            sb.AddFadeIn(seconds);

            // start animating
            sb.Begin(page);

            // Make page visible
            page.Visibility = Visibility.Visible;

            // Wait for it to finish
            await Task.Delay((int)seconds * 1000);
        }
        #endregion

        #region slide and fade out to left function
        /// <summary>
        /// Slides a page in from right 
        /// </summary>
        /// <param name="page">The page to animate</param>
        /// <param name="seconds">Animation time</param>
        /// <returns></returns>
        public static async Task SlideAndFadeOutToLeft(this Page page, float seconds)
        {
            // create the storyboard
            var sb = new Storyboard();

            // add slide from right animation
            sb.AddSlideToLeft(seconds, page.WindowWidth);

            //Add fade in animation
            sb.AddFadeOut(seconds);

            // start animating
            sb.Begin(page);

            // Make page visible
            page.Visibility = Visibility.Visible;

            // Wait for it to finish
            await Task.Delay((int)seconds * 1000);
        }
        #endregion
    }
}
