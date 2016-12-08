using System;

namespace PopulationSim
{
   public class SimOne
    {
        public static readonly string timeInt;


        //   public static async void birthDo()
        //   {
        //       
        //       int randFour = await RandomNumb.DiceFour();
        //   }
        public static Random randomGen()
            {
             Random newRand = new Random();

            return newRand;
             
            }
       
        static public void Simulation()
        {

            for (int i = 0; i < 12; i++)
            {

            
            //int timeInt=1;
            //  double maturityAgeMale = 4;
            // double maturityAgefemale = 4;

            //----------------------

            // double birthRateOne;
            // double birthRateTwo;
           
     //       int monthsPerYear = 12;
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

            int monthNumber = 0;

                

              

                int randThree = randomGen().Next(4);
                int secondRemoveOne = randomGen().Next(2);
                int secondRemoveTwo = randomGen().Next(2);



              


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
                if (kangarooMaleInPouch >= randomGen().Next(3)) // Max pouchvalue! // birthTotalMale Greater then
                {
                    kangarooMaleInPouch--;
                    youngRoosMale++;


                }
                if (kangarooFemaleInPouch >= randomGen().Next(3)) // Max pouchvalue!
                {
                    kangarooFemaleInPouch--;
                    youngRoosFemale++;

                }

                if (youngRoosMale > randomGen().Next(8)) // Max Youngvalue!
                {
                    youngRoosMale--;
                    kangarooMaleMature++;
                }
                if (youngRoosFemale > randomGen().Next(8)) // Max Youngvalue!
                {
                    youngRoosFemale--;
                    kangarooFemaleMature++;
                }

                if (kangarooMaleMature > randomGen().Next(32)) // Max Maturevalue!
                {
                    kangarooMaleMature--;
                    oldRooMale++;

                }
                if (kangarooFemaleMature > randomGen().Next(32)) // Max Maturevalue!
                {
                    kangarooFemaleMature--;
                    oldRooFemale++;
                }

                if (oldRooMale > randomGen().Next(16)) // Max Oldvalue!
                {
                    oldRooMale--;
                }
                if (oldRooFemale > randomGen().Next(16)) // Max Oldvalue!
                {
                    oldRooFemale--;
                }
                //---------------------------------------------
                

            

            string SimOutPut = ("\r\n" +
                                    "kangarooMaleInPouch= " + kangarooMaleInPouch + "\r\n" +

                                    "kangarooFemaleInPouch= " + kangarooFemaleInPouch + "\r\n" +

                                    "youngRoosMale= " + youngRoosMale + "\r\n" +
                                    "youngRoosFemale= " + youngRoosFemale + "\r\n" +

                                    "kangarooFemaleMature= " + kangarooFemaleMature + "\r\n" +
                                    "kangarooMaleMature= " + kangarooMaleMature + "\r\n" +

                                    "oldRooFemale= " + oldRooFemale + "\r\n" +
                                    "oldRooMale= " + oldRooMale + "\r\n" +



                                    "There is " + kangarooTotal + " kangaroos, " + "  Month: " + monthNumber + " Year: " + year + "\r\n" +



                                    "Total Births: " + birthTotal + "\r\n" +

                                    "Month length is " + timeInt + "seconds...");
            Console.WriteLine(SimOutPut);
            }
            Console.ReadLine();


        }
        

         
    

    }
        
        }