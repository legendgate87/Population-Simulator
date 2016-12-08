using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PopulationSimString
{
   public class SimOneString
    {
       

    //   public static async void birthDo()
    //   {
    //       
    //       float randFour = await RandomNumb.DiceFour();
    //   }

        static public string SimulationString()
        {


            int timeInt=1;



            //  double maturityAgeMale = 4;
            // double maturityAgefemale = 4;

            //----------------------


           


            // double birthRateOne;
            // double birthRateTwo;



           
            int monthsPerYear = 12;
            float year = 0;

            //  var surviChaToMaxAge = (5 * kangarooTotal) / 100;

            //Kangaroos---------------------
            float kangarooMaleMature = 1;
            float kangarooFemaleMature = 1;

            float kangarooMaleInPouch = 0;
            float kangarooFemaleInPouch = 0;

            float youngRoosMale = 0;
            float youngRoosFemale = 0;

            float oldRooMale = 0;
            float oldRooFemale = 0;
            //--------------------

            float grassTotal = 50;



            //Young Totals-----------------


            float youngRoosTotal = youngRoosMale + youngRoosFemale;
            //--------------------------

            //Mature Totals-----------------


            float matureRoosTotal = kangarooMaleMature + kangarooFemaleMature;
            //--------------------------

            //Old Totals-----------------


            float oldRoosTotal = oldRooMale + oldRooFemale;
            //--------------------------


            float kangaroosInPouch = kangarooMaleInPouch + kangarooFemaleInPouch;


            float birthTotal = kangarooMaleMature + kangarooFemaleMature;


            // Random mortality of the young


            //   double mortalityYoung = RandomNumb.DiceOne();
            //   youngRoosTotal = youngRoosTotal - mortalityYoung;
            //--------------------------------

            float kangarooTotal = youngRoosTotal + matureRoosTotal + oldRoosTotal; // Total count

            int monthNumber;

            for (monthNumber=1; monthNumber <= monthsPerYear; monthNumber++) // loop
            {
                

              

                float randThree = RandomNumb.DiceThree();
                float secondRemoveOne = RandomNumb.DiceOne();
                float secondRemoveTwo = RandomNumb.DiceOnePointTwo();



              


                if (monthNumber % 4 == 0 && year >= 2)// poor nutrition remove
                {
                 
               
                   

                    if (kangarooMaleInPouch == 0)
                    {
                        
                    }
                    else
                    {
                        kangarooMaleInPouch = kangarooMaleInPouch - secondRemoveOne;
                        kangarooFemaleInPouch = kangarooFemaleInPouch - secondRemoveTwo;
                    }


                    Console.WriteLine(kangarooMaleInPouch + kangarooFemaleInPouch +  " kangaroos died due to poor nutrition");
               
                    }

                if(kangarooTotal >= grassTotal)
                {

                    if (kangaroosInPouch <= 0)
                    {
                        
                    }
                    else { kangarooMaleInPouch--; kangarooFemaleInPouch--; }
                    

                    if (youngRoosTotal <= 0)
                    {

                    }
                    else { youngRoosMale--; youngRoosFemale--; }
                        
                    

                    if (matureRoosTotal <= 0)
                    {

                    }
                    else
                    { kangarooMaleMature--; kangarooFemaleMature--; }



                        if (oldRoosTotal <= 0)
                    {

                    }
                    else {oldRooFemale--;oldRooMale--;}

                }







                //  if (year == maturityAgeMale) // Male maturity age
                //  {
                //      kangarooMaleMature++;
                //      kangarooFemaleMature++;
                //      youngRoosMale--;
                //      youngRoosFemale--;
                //
                //  }

                    if (kangarooTotal > 200) // If above 10000 populationTotal, remove / half
                {

                    var removeOne = kangarooTotal -10;

                    kangarooTotal = kangarooTotal - removeOne;

                    Console.WriteLine("Removing " + removeOne + " kangaroo from the population due to overpopulation");

                }

         


                if (monthNumber == 6)
                {
                    //Birth +  --------------------------------------------
                   
                    kangarooMaleInPouch++;
                    kangarooFemaleInPouch++;
                    //-------------------------------------------------
                }

                if (monthNumber == 12) // if 12th month we have a year
                {
                    year++;
                    monthNumber = 1;

                    //Birth +  --------------------------------------------

                    kangarooMaleInPouch++;
                    kangarooFemaleInPouch++;
                    //-------------------------------------------------
                }

                //Age if -----------------------------------------// don't count the actuall year, count kangaroo year from birth
                if (kangarooMaleInPouch >= RandomNumb.pouchvalueDiceMale()) // Max pouchvalue! // birthTotalMale Greater then
                {
                    kangarooMaleInPouch--;
                    youngRoosMale++;


                }
                if (kangarooFemaleInPouch >= RandomNumb.pouchvalueDiceFemale()) // Max pouchvalue!
                {
                    kangarooFemaleInPouch--;
                    youngRoosFemale++;

                }

                if (youngRoosMale > RandomNumb.YoungvalueDiceMale()) // Max Youngvalue!
                {
                    youngRoosMale--;
                    kangarooMaleMature++;
                }
                if (youngRoosFemale > RandomNumb.YoungvalueDiceFemale()) // Max Youngvalue!
                {
                    youngRoosFemale--;
                    kangarooFemaleMature++;
                }

                if (kangarooMaleMature > RandomNumb.MaturevalueDiceMale()) // Max Maturevalue!
                {
                    kangarooMaleMature--;
                    oldRooMale++;

                }
                if (kangarooFemaleMature > RandomNumb.MaturevalueDiceFemale()) // Max Maturevalue!
                {
                    kangarooFemaleMature--;
                    oldRooFemale++;
                }

                if (oldRooMale > RandomNumb.OldvalueDiceMale()) // Max Oldvalue!
                {
                    oldRooMale--;
                }
                if (oldRooFemale > RandomNumb.OldvalueDiceFemale()) // Max Oldvalue!
                {
                    oldRooFemale--;
                }
                //---------------------------------------------









                
                Thread.Sleep(1000 * timeInt * 1);


                


            }

            string SimOutPut = ("$\r\n" +
                                    "kangarooMaleInPouch= " + kangarooMaleInPouch +

                                    "kangarooFemaleInPouch= " + kangarooFemaleInPouch +

                                    "youngRoosMale= " + youngRoosMale +
                                    "youngRoosFemale= " + youngRoosFemale +

                                    "kangarooFemaleMature= " + kangarooFemaleMature +
                                    "kangarooMaleMature= " + kangarooMaleMature +

                                    "oldRooFemale= " + oldRooFemale +
                                    "oldRooMale= " + oldRooMale +



                                    "There is " + kangarooTotal + " kangaroos, " + "  Month: " + monthNumber + " Year: " + year +



                                    birthTotal +

                                    "Month length is {timeInt} seconds...");

            return SimOutPut;



        }
        

         
    

    }
        
        }