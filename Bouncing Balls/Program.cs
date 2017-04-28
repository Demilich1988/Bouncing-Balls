using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouncing_Balls
{
    class Program
    {
        
        static void Main(string[] args)
        {

            //Create the two balls to be throw and give them a color
            Balls bigBoy = new Balls(10, new Color(205,50,127));
            Balls smallfry = new Balls(2, new Color(192, 192, 192));

            //Throw the big ball
            bigBoy.Thrown();
            bigBoy.Thrown();
            Console.WriteLine(bigBoy.GetTimes());

            //Throw the small ball 4 times then pop it
            smallfry.Thrown();
            smallfry.Thrown();
            smallfry.Thrown();
            smallfry.Thrown();
            //Pop smallfry then see if thrown is still getting counted
            smallfry.Pop();
            smallfry.Thrown();
            smallfry.Thrown();

            Console.WriteLine(smallfry.GetTimes());

        }
    }
}
