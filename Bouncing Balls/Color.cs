using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouncing_Balls
{
    /*
     * Class to take the color of the calls 
     */
    class Color
    {
        //private instances needed for class
        private int red;
        private int blue;
        private int green;
        private int alpha;


        //Constructor for all values
        public Color(int red, int blue, int green, int alpha)
        {
            this.red = red;
            this.blue = blue;
            this.green = green;
            this.alpha = alpha;
        }

        //Constructor with alpha at defualt of 225
        public Color(int red, int blue, int green)
        {
            this.red = red;
            this.blue = blue;
            this.green = green;
        }

        /// <summary>
        /// Get for color Red
        /// </summary>
        /// <returns></returns>
        public int GetRed()
        {
            return red;
        }

        /// <summary>
        /// Set for color Red
        /// </summary>
        public void SetRed(int red)
        {
            this.red = red;
        }

        /// <summary>
        /// Get for color Blue
        /// </summary>
        /// <returns></returns>
        public int GetBlue()
        {
            return blue;
        }

        /// <summary>
        /// Set for color Blue
        /// </summary>
        public void SetBlue(int blue)
        {
            this.blue = blue;
        }

        /// <summary>
        /// Get for color Green
        /// </summary>
        /// <returns></returns>
        public int GetGreen()
        {
            return green;
        }

        /// <summary>
        /// Set for color Green
        /// </summary>
        public void SetGreen(int green)
        {
            this.green = green;
        }

        /// <summary>
        /// Get for Alpha value
        /// </summary>
        /// <returns></returns>
        public int GetAlpha()
        {
            return alpha;
        }

        /// <summary>
        /// Set for Alpha value
        /// </summary>
        public void SetAlpha(int alpha)
        {
            this.alpha = alpha;
        }

        /// <summary>
        /// Preforms the math for the greyscale and then return greyscale value 
        /// </summary>
        /// <param name="red"></param>
        /// <param name="blue"></param>
        /// <param name="green"></param>
        /// <returns></returns>
        public int GreyScale(int red, int blue, int green)
        {
            int greyValue = (red + blue + green) / 3;

            return greyValue;
        }
    }
}
