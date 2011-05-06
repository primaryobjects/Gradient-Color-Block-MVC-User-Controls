using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;

namespace MVCColorUserControl.Managers
{
    /// <summary>
    /// Helper class for generating gradient color DIV.
    /// </summary>
    public static class ColorManager
    {
        #region Helper Methods

        /// <summary>
        /// Returns a set of DIV tags to display a gradient color to white.
        /// </summary>
        /// <param name="startingRgb">Starting color in the HTML hex format: #FF00FF</param>
        /// <param name="width">Width of block</param>
        /// <param name="height">Height of block</param>
        /// <returns>string</returns>
        public static string GetGradientDiv(string startingRgb, int width, int height)
        {
            string html = "";

            Color color = ColorTranslator.FromHtml(startingRgb);

            foreach (Color gradient in GetGradients(color, Color.White, height))
            {
                html += "<div style=\"background-color: " + ColorTranslator.ToHtml(gradient) + "; width: " + width + "px; height: 1px;\" />";
            }

            return html;
        }

        /// <summary>
        /// Helper method for returning a list of Color objects to create a gradient from start to end.
        /// </summary>
        /// <param name="start">Start color</param>
        /// <param name="end">End color</param>
        /// <param name="steps">Number of gradient steps</param>
        /// <returns>IEnumerable list of Color</returns>
        private static IEnumerable<Color> GetGradients(Color start, Color end, int steps)
        {
            Color stepper = Color.FromArgb((byte)((end.A - start.A) / (steps - 1)),
                                           (byte)((end.R - start.R) / (steps - 1)),
                                           (byte)((end.G - start.G) / (steps - 1)),
                                           (byte)((end.B - start.B) / (steps - 1)));

            for (int i = 0; i < steps; i++)
            {
                yield return Color.FromArgb(start.A + (stepper.A * i),
                                            start.R + (stepper.R * i),
                                            start.G + (stepper.G * i),
                                            start.B + (stepper.B * i));
            }
        }

        #endregion
    }
}