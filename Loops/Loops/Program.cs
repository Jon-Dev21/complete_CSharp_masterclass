using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // =================================================
            // ============= Introduction to Loops =============
            // =================================================

            /* Advantages of Loops:
             * 
             * Save time
             * Quick and easy code repetition
             * Allows us to work with huge amounts of data
             * Allows you to loop through arrays.
             * 
             * 
             * Loop Type
             * 
             * for loop (great for counters)
             * while loop (check then go. executes code as long as the condition is met.)
             * do while loop (do first then check. Executes once, then keep executing code as long as the condition is met.)
             * foreach loop (run through array or list. Only runs as long as there is content)
             */

            // =================================================
            // ================== For Loops ====================
            // =================================================

            //for(int i = 0; i <= 50; i+=5)
            //{
            //    Console.WriteLine("{0}. Hello", i);
            //}

            // Write a for loop that prints out odd numbers from 0 to 20
            //for (int i = 1; i < 20; i++)
            //{
            //    Console.Write(i%2!=0 ?i : ", ");
            //}
            //Console.WriteLine();
            //// The example was way easier...
            //for (int i = 1; i < 20; i+=2)
            //{
            //    Console.WriteLine(i);
            //}

            // =================================================
            // =============== Do While Loops ==================
            // =================================================

            //int counter = 0;
            //do
            //{
            //    Console.WriteLine(counter);
            //    counter++;
            //} while (counter <5);


            //int textLength = 0;
            //string wholeText = "";
            //do
            //{
            //    Console.Write("Enter a name: ");
            //    string name = Console.ReadLine();
            //    int currentLength = name.Length;
            //    textLength += currentLength;
            //    wholeText += name;
            //} while (textLength < 20);
            //Console.WriteLine("Thank's that was enough, Mr. {0}", wholeText);

            // =================================================
            // ================= While Loops ===================
            // =================================================

            //int counter = 0;
            //while(counter < 10)
            //{
            //    Console.WriteLine(counter);
            //    counter++;
            //}

            // Create a mini people counter. Loop counts when you press enter.

            //int peopleCnt = 0;
            //string input = "";
            //Console.WriteLine("Press enter to count people. Type anything else to stop the counter.");
            //while (input.Equals(""))
            //{
            //    input = Console.ReadLine();
            //    Console.WriteLine("Number of People: {0}", input == "" ? ++peopleCnt : peopleCnt);
            //}

            // =================================================
            // ============= Break and Continue ================
            // =================================================

            //for(int counter = 0; counter <10; counter++)
            //{                
            //    if(counter %2==0)
            //    {
            //        Console.WriteLine("Odd Number");
            //        continue;
            //    }
            //    Console.WriteLine(counter);
            //}

            // Break stops the iteration
            // continue resets the iteration.


            // =================================================
            // ============== Loops Challenge ==================
            // =================================================

            /*
            Imagine you are a developer and get a job in which you need to create a program for a teacher. 
            He needs a program written in c# that calculates the average score of his students. 
            So he wants to be able to enter each score individually and then get the final average score once he enters -1.
            So the tool should check if the entry is a number and should add that to the sum. Finally once he is done 
            entering scores, the program should write onto the console what the average score is.
            The numbers entered should only be between 0 and 20. Make sure the program doesn't crash if the teacher enters 
            an incorrect value. Test your program thoroughly.             
             */
            CalculateAvgScore();

        }

        public static void CalculateAvgScore()
        {
            Console.WriteLine("Please enter scores between 0 and 20. ");
            Console.WriteLine("Enter -1 to exit.");
            Console.WriteLine();
            int score = 0;
            string scoreStr;
            int totalScore = 0;
            int scoreCount = 0;
            int averageScore = 0;
            while (score != -1)
            {                 
                Console.Write("Score {0}: ", scoreCount+1);
                scoreStr = Console.ReadLine();
                if(int.TryParse(scoreStr, out score))
                {
                    if(score >= 0 && score <= 20)
                    {
                        scoreCount++;
                        totalScore += score;
                        averageScore = totalScore / scoreCount;
                    } else if (score != -1)
                    {
                        Console.WriteLine("Score must be between 0 and 20.");
                    }
                    
                    
                } else if(scoreStr == "-1")
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Invalid score {0}", scoreStr);
                }

            }
            Console.WriteLine("Total Score is {0}", totalScore);
            Console.WriteLine("Total Scores entered {0}", scoreCount);
            Console.WriteLine("Average score is {0}", averageScore);
            
        }
    }
}
