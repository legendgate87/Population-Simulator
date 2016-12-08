using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PopulationSimString
{
   public static class RandomNumb
    {
        private static readonly Random Rng = new Random();
        private static int dice;

        static public int DiceOne()
            {
             
         

            return dice = Rng.Next(1, 3);

        }

        static public int DiceOnePointTwo()
        {
           
          

            return dice = Rng.Next(1, 3);

        }

        static public int DiceTwo()
        {
          
        

            return dice = Rng.Next(1, 7);

        }

        static public int DiceThree()
        {
           
         

            return dice = Rng.Next(1, 2);

        }

       static public async Task<int> DiceFour()
        {
            int reT = dice = Rng.Next(1, 3);
            await Task.Delay(TimeSpan.FromSeconds(2.0));
            
            return reT;

             

        }

       



        static public int OldvalueDiceMale()
        {

            
            return dice = Rng.Next(8, 16);

        }

        static public int OldvalueDiceFemale()
        {
        
          

            return dice = Rng.Next(8, 16);

        }

        static public int MaturevalueDiceMale()
        {
            
       

            return dice = Rng.Next(27, 32);

        }

        static public int MaturevalueDiceFemale()
        {
        
         

            return dice = Rng.Next(27, 32);

        }

        static public int YoungvalueDiceMale()
        {
          
          

            return dice = Rng.Next(5, 8);

        }

        static public int YoungvalueDiceFemale()
        {
     
        

            return dice = Rng.Next(5, 8);

        }

        static public int pouchvalueDiceMale()
        {
           
       

            return dice = Rng.Next(1, 3);

        }

        static public int pouchvalueDiceFemale()
        {
          
        

            return dice = Rng.Next(1, 3);

        }

    }
}
