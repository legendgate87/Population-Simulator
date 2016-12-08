using System;
using System.Threading;

namespace PopulationSimString
{
    class SimOneString
    {
       

    //   public static async void birthDo()
    //   {
    //       
    //       int randFour = await RandomNumb.DiceFour();
    //   }

        static public void Simulation()
        {
            int timeInt=1;

            //  double maturityAgeMale = 4;
            // double maturityAgefemale = 4;

            //----------------------        

            // double birthRateOne;
            // double birthRateTwo;


          //  string row = "-------------------------------------";
            int monthsPerYear = 12;
            int year = 0;

            //  var surviChaToMaxAge = (5 * kangarooTotal) / 100;

            //Kangaroos---------------------
            int kangarooMaleMature = 1;
            int kangarooFemaleMature = 1;

            int kangarooMaleInPouch = 0;
            int kangarooFemaleInPouch = 0;

            int youngRoosMale = 0;
            int youngRoosFemale = 0;

            int oldRooMale = 0;
            int oldRooFemale = 0;
            //--------------------

            int grassTotal = 50;

            for (int monthNumber = 1; monthNumber <= monthsPerYear; monthNumber++) // loop
            {
                
                int randThree = RandomNumb.DiceThree();
                int secondRemoveOne = RandomNumb.DiceOne();
                int secondRemoveTwo = RandomNumb.DiceOnePointTwo();


                //Young Totals-----------------

                int youngRoosTotal = youngRoosMale + youngRoosFemale;
                //--------------------------

                //Mature Totals-----------------


                int matureRoosTotal = kangarooMaleMature + kangarooFemaleMature;
                //--------------------------

                //Old Totals-----------------


                int oldRoosTotal = oldRooMale + oldRooFemale;
                //--------------------------

                int kangaroosInPouch = kangarooMaleInPouch + kangarooFemaleInPouch;

                int birthTotal = kangarooMaleMature + kangarooFemaleMature;


                // Random mortality of the young


                //   double mortalityYoung = RandomNumb.DiceOne();
                //   youngRoosTotal = youngRoosTotal - mortalityYoung;
                //--------------------------------

                int kangarooTotal = youngRoosTotal + matureRoosTotal + oldRoosTotal; // Total count


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
                //--------------------------------------------



                string SimOutPut = ("\r\n" + // Putting the string together
                                    "kangarooMaleInPouch= " + kangarooMaleInPouch + "\r\n" +
                                    "kangarooFemaleInPouch= " + kangarooFemaleInPouch + "\r\n" +
                                    " " + "\r\n" +

                                    "youngRoosMale= " + youngRoosMale + "\r\n" +
                                    "youngRoosFemale= " + youngRoosFemale + "\r\n" +
                                    " " + "\r\n" +

                                    "kangarooFemaleMature= " + kangarooFemaleMature + "\r\n" +
                                    "kangarooMaleMature= " + kangarooMaleMature + "\r\n" +
                                    " " + "\r\n" +

                                    "oldRooFemale= " + oldRooFemale + "\r\n" +
                                    "oldRooMale= " + oldRooMale + "\r\n" +

                                    " " + "\r\n" +
                                    "There is " + kangarooTotal + " kangaroos, " + "  Month: " + monthNumber + " Year: " + year + "\r\n" +
                                    " " + "\r\n" +

                                    "Total Births: " + birthTotal + "\r\n" +
                                    " " + "\r\n" +

                                    "Month length is " + timeInt + "seconds...");

                Console.WriteLine(SimOutPut); // Printing the full string
                
                Thread.Sleep(1000 * timeInt * 1); // Update timer
                Console.Clear(); // Clearing for new text update
            
            }
        }
    } 
        }