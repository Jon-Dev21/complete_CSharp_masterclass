using System;

namespace ArgsCMD
{
    class Program
    {
        static void Main(string[] args)
        {
            // =============================================
            // ============= Main Args - Pt. 1 =============
            // =============================================

            // The args array cannot be null. So it's safe to access the Length property without checking for null.
            // We check args.Length to avoid IndexOutOfBounds errors. If length is 0, no arguments were provided.
            if (args.Length == 0)
            {
                Console.WriteLine("This is a smart app that uses args. Please provide arguments");
                // Pause the app so it doesn't close after printing error message.
                Console.ReadKey();
                // Quit app entirely since we can't proceed further because args has no arguments
                return;
            }
            
            if (args[0] == "help") 
            {
                // Display Instructions
                Console.WriteLine("****************** Instructions ******************");
                Console.WriteLine("* Use one of the commands followed by 2 numbers. *");
                Console.WriteLine("* 'add'  : adds two numbers passed as args        *");
                Console.WriteLine("* 'sub'  : substracts two numbers passed          *");
                Console.WriteLine("* 'exit' : exits the program                      *");
                Console.WriteLine("**************************************************");

                Console.WriteLine("args = new string[3]");
                args = new string[3];
                // Pause
                Console.WriteLine("Press any key to continue: ");
                Console.ReadKey();
                
                Console.Write("Enter command: ");
               args[0] = Console.ReadLine();

                if(args[0].ToLower().Contains("exit"))
                {
                    Console.WriteLine("Closing program...");
                    return;
                }
                else if (args[0].ToLower() != "add" || args[0].ToLower() != "sub")
                {
                    Console.WriteLine("Invalid command: {0}", args[0]);
                } else
                {
                    Console.Write("Enter num 1: ");
                    args[1] = Console.ReadLine();
                    Console.Write("Enter num 2: ");
                    args[2] = Console.ReadLine();
                }
                

            }

            if (args.Length != 3)
            {
                Console.WriteLine("Too many or too little arguments passed, please use the help command for instructions.");
                // Pause
                Console.ReadKey();
                // Quit app
                return;
            }
            else
            {
                bool isNum1 = float.TryParse(args[1], out float num1);
                bool isNum2 = float.TryParse(args[2], out float num2);

                if (!(isNum1 || isNum2))
                {
                    Console.WriteLine("Invalid arguments passed. Arguments must be numbers. \nPlease use the help command for instructions.");
                    // Pause
                    Console.ReadKey();
                    // Quit app
                    return;
                }
                else
                {
                    switch (args[0].ToLower())
                    {
                        case "add":
                            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                            break;
                        case "sub":
                            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                            break;
                        default:
                            Console.WriteLine("Invalid arguments passed. Arguments must be numbers. \nPlease use the help command for instructions.");
                            break;
                    }
                }
            }


            
            

            // Attempting to run this program in the cmd.
            // TO run program in CMD, go to "ProyectPath\bin\Debug\net5.0" and type the name
            // of the exe file (ArgsCmd.exe). To pass arguments, type them alongside the .exe file like so
            // Example: ArgsCmd.exe Param1 Param2 Param3
            
            // Run successful.


            //Console.WriteLine("Hello {0}", args[0]);
            //Console.WriteLine("Hello {0}", args[1]);

            // =============================================
            // ============= Main Args - Pt. 2 =============
            // =============================================
        }
    }
}
