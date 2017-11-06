using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Block_homework
{
    class Program
    {
        static void Main(string[] args)
        {

            double  holeHeight = Convert.ToDouble(Console.ReadLine()),
                    holeWidth = Convert.ToDouble(Console.ReadLine()),
                    blockX = Convert.ToDouble(Console.ReadLine()),
                    blockY = Convert.ToDouble(Console.ReadLine()),
                    blockZ = Convert.ToDouble(Console.ReadLine());
            if (holeWidth <=0 || holeHeight<=0)
            {
                Console.WriteLine("It is not a hole.Error");
                return;
            }
            if (blockX<=0 || blockY<=0 || blockZ <=0)
            {
                Console.WriteLine("It is not  a block.Error");
                return;
            }
            if ((holeHeight >= blockX && holeWidth >= blockZ)||
                (holeHeight >= blockX && holeWidth >= blockY)||
                (holeHeight >= blockY && holeWidth >= blockZ)||
                (holeHeight >= blockZ && holeWidth >= blockX)||
                (holeHeight >= blockY && holeWidth >= blockX)||
                (holeHeight >= blockZ && holeWidth >= blockY))
            {
                Console.WriteLine("YES"); 
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
