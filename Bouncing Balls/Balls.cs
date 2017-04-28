using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouncing_Balls
{
    /*
     * Class for Balls that will take color and show if balls is popped and how many times it is thrown
     */
    class Balls
    {
        //Class instances for color size and times thrown.
        private float size;
        private Color color;
        private int timesThrown;

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="size">Ball size</param>
        /// <param name="color">Ball Color</param>
        public Balls( float size, Color color)
        {
            this.size = size;
            this.color = color;
        }

        /// <summary>
        /// Changes size to 0 if ball is popped
        /// </summary>
        public void Pop()
        {
            size = 0;
        }

        /// <summary>
        /// Adds to timesThrown when ball is thrown
        /// </summary>
        public void Thrown()
        {
            if (size != 0)
            {
                timesThrown++;
            }

        }

        /// <summary>
        /// Get methods for number of times the balls have been thrown. 
        /// </summary>
        /// <returns></returns>
        public int GetTimes()
        {
            return timesThrown;
        }

    }
}
