
using System;
using System.Windows;
using System.Windows.Media.Animation;

namespace _03_Fasetto_World
{
     
    /// <summary>
    /// Animation helpers for <see cref="Storyboard"/>
    /// </summary>
    public static class StoryboardHelper
    {
        #region slide in animation function
        /// <summary>
        /// Adds a slide from right animation to the storyboard
        /// </summary>
        /// <param name="storyboard">The storyboard to add animation to</param>
        /// <param name="seconds">The time the animation will take</param>
        /// <param name="offset">The distance to the right to start from</param>
        /// <param name="decelerationRation">The rate of deceleration</param>
        public static void AddSlideFromRight(this Storyboard storyboard, float seconds, double offset, float decelerationRation = 0.9f)
        {
            // create the margin animate from right
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(offset, 0, -offset, 0),
                To = new Thickness(0),
                DecelerationRatio = decelerationRation
            };

            // set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));

            // add it to storyboard
            storyboard.Children.Add(animation);
        }

        #endregion

        #region slide in to left animation function
        /// <summary>
        /// Adds a slide from right animation to the storyboard
        /// </summary>
        /// <param name="storyboard">The storyboard to add animation to</param>
        /// <param name="seconds">The time the animation will take</param>
        /// <param name="offset">The distance to the right to start from</param>
        /// <param name="decelerationRation">The rate of deceleration</param>
        public static void AddSlideToLeft(this Storyboard storyboard, float seconds, double offset, float decelerationRation = 0.9f)
        {
            // create the margin animate from right
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0),
                To = new Thickness(-offset, 0, offset, 0),
                DecelerationRatio = decelerationRation
            };

            // set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));

            // add it to storyboard
            storyboard.Children.Add(animation);
        }

        #endregion

        #region fade in animation function
        /// <summary>
        /// Adds fade in animation to the storyboard
        /// </summary>
        /// <param name="storyboard">The storyboard to add animation to</param>
        /// <param name="seconds">The time the animation will take</param>
        public static void AddFadeIn(this Storyboard storyboard, float seconds)
        {
            // create the margin animate from right
            var animation = new DoubleAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = 0,
                To = 1
            };

            // set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Opacity"));

            // add it to storyboard
            storyboard.Children.Add(animation);
        }
        #endregion

        #region fade out animation function
        /// <summary>
        /// Adds fade in animation to the storyboard
        /// </summary>
        /// <param name="storyboard">The storyboard to add animation to</param>
        /// <param name="seconds">The time the animation will take</param>
        public static void AddFadeOut(this Storyboard storyboard, float seconds)
        {
            // create the margin animate from right
            var animation = new DoubleAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = 1,
                To = 0
            };

            // set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Opacity"));

            // add it to storyboard
            storyboard.Children.Add(animation);
        }
        #endregion
    }
}
