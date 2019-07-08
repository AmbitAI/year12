using System;
using System.Diagnostics;
using System.Linq;


namespace basicfact
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("================================================");
            Console.WriteLine("Welcome to basic facts");
            Console.WriteLine("================================================");

            string[] level = new string[] { "E", "e", "M", "m", "H", "h" };

            Console.WriteLine("Please press a key to chose from Easy(E/e), Medium(M/m) or Hard(H/h)");

            string reply = "";
            while (true)
            {
                reply = Console.ReadLine();
                if (level.Contains(reply))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("please enter E/e, M/m or H/h");
                }
            }


            Console.WriteLine("How many questions do you want to do? (with a minimum number of 20)");

            int que_number;
            while (true)
            {
                try
                {
                    que_number = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Enter a number only");
                }
            }



            Console.WriteLine("Do you want timed responses? Y/y or N/n");
            Stopwatch sw = new Stopwatch();
            string reply2 = "";
            while (true)
            {
                reply2 = Console.ReadLine();
                if (reply2 == "Y" || reply2 == "y" || reply2 == "N" || reply2 == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("please enter Y/y, or N/n");
                }
            }

            if (reply == "e" || reply == "E")
            {
                sw.Start();
                Process(0, que_number, 4);
                sw.Stop();

            }
            else if (reply == "m" || reply == "M")
            {
                sw.Start();
                Process(0, que_number, 6);
                sw.Stop();
            }


            else if (reply == "h" || reply == "H")
            {
                sw.Start();
                Process(0, que_number, 11);
                sw.Stop();
            }

            if (reply2 == "Y" || reply2 == "y")
            {
                float tim = sw.Elapsed.Seconds;
                Console.WriteLine("You spent " + tim + " seconds");
            }

            else if (reply2 == "N" || reply2 == "n")
            {
                Console.WriteLine("timed responsed was not enable");
            }

            Console.WriteLine("================================================");
            Console.WriteLine("Thank you for using the basic facts program");

            Console.ReadLine();
        }

        public static void Process(int n, int que_number, int number)
        {

            int count = 0;

            int functions = 0;
            while (n < que_number)
            {


                if (functions <= 4)
                {
                    functions++;
                    if (functions == 5)
                    {
                        functions = 1;
                    }

                }

                Random num = new Random();
                int number1 = num.Next(1, number);
                int number2 = num.Next(1, number);

                int reply3 = 0;


                string correctly = Calculation.Calculation_function(number1, number2, functions, reply3);
                if (correctly == "Correct")
                {
                    count++;
                }
                n++;

            }
            Console.WriteLine("You've got " + count + " out of " + que_number + " correctly");

        }

    }






    class Calculation
    {
        public static string Calculation_function(int num1, int num2, int functions, int reply3)
        {
            string reply = "";

            if (functions == 1)
            {
                Console.WriteLine(num1 + " + " + num2 + " = ");
                int answer = num1 + num2;

                try
                {
                    reply3 = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    reply = "Incorrect";
                }


                if (reply3 == answer)
                {
                    reply = "Correct";
                    Console.WriteLine("Correct");
                }
                else
                {
                    reply = ("Incorrect");
                    Console.WriteLine("Incorrect");
                }

                return reply;
            }


            else if (functions == 2 && num1 >= num2)
            {


                Console.WriteLine(num1 + " - " + num2 + " = ");
                int answer = num1 - num2;

                try
                {
                    reply3 = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    reply = "Incorrect";
                }


                if (reply3 == answer)
                {
                    reply = "Correct";
                    Console.WriteLine("Correct");
                }
                else
                {
                    reply = ("Incorrect");
                    Console.WriteLine("Incorrect");
                }
            }


            else if (functions == 2 && num2 > num1)
            {

                Console.WriteLine(num2 + " - " + num1 + " = ");
                int answer = num2 - num1;

                try
                {
                    reply3 = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    reply = "Incorrect";
                }


                if (reply3 == answer)
                {
                    reply = "Correct";
                    Console.WriteLine("Correct");
                }
                else
                {
                    reply = ("Incorrect");
                    Console.WriteLine("Incorrect");
                }
            }

            else if (functions == 3)
            {
                Console.WriteLine(num1 + " × " + num2 + " = ");
                int answer = num1 * num2;
                try
                {
                    reply3 = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    reply = "Incorrect";
                }
                if (reply3 == answer)
                {
                    reply = "Correct";
                    Console.WriteLine("Correct");
                }
                else
                {
                    reply = ("Incorrect");
                    Console.WriteLine("Incorrect");
                }
            }

            else if (functions == 4)
            {
                int number3 = num1 * num2;
                Console.WriteLine(number3 + " ÷ " + num2 + " = ");
                try
                {
                    reply3 = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    reply = "Incorrect";
                }
                if (reply3 == num1)
                {
                    reply = "Correct";
                    Console.WriteLine("Correct");
                }
                else
                {
                    reply = ("Incorrect");
                    Console.WriteLine("Incorrect");
                }
            }

            return reply;
        }
    }
}

