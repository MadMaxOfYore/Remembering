using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfStudy
{
    class Program
    {
        public static string user;
        private static bool answer1 = false;
        private static bool answer2 = false;
        private static bool answer3 = false;
        private static bool incomplete = true;

        static void Main(string[] args)
        {
            
            GetUsername();
            
            while (incomplete)
            {
                TestSequence();
                if (answer1 && answer2 && answer3) 
                {
                    incomplete = false;
                    Console.WriteLine("All Tests Complete!!! Have a great day " + user + "!!!");
                }
                else 
                {
                    Console.WriteLine("Testing Incomplete");
                    Console.WriteLine();
                }


            }
            Console.ReadLine();
         
        }

        public static void GetUsername()
        {
            Console.WriteLine("What is your name?");
            user = Console.ReadLine();

            Console.WriteLine("Hello " + user);
            Console.WriteLine();
        }
                             

        public static bool TestSequence()
        {
            
            Console.WriteLine("This is a Test of your IF statements");
            Console.WriteLine("1) Test 1");
            Console.WriteLine("2) Test 2");
            Console.WriteLine("3) Test 3");
            Console.WriteLine("4) Check Satus");

            string answer = Console.ReadLine();
                                    
            if (answer == "1")
            {
                Console.WriteLine("Selection 1 Test Complete.");
                answer1 = true;
                return true;
            }
            else if (answer == "2")
            {
                Console.WriteLine("Selection 2 Test Complete.");
                answer2 = true;
                return true;
            }
            else if (answer == "3")
            {
                Console.WriteLine("Selection 3 Test Complete.");
                answer3 = true;
                return true;
            }
            else if (answer == "4")
            {
                CheckStatus();
                return true;
            }
            else
            {
                Console.WriteLine("Invalid Test Key " + user +
                     ". Please select the correct user key.");
                return false;
            }
            
            
        }
        
        public static void CheckStatus()
        {
            Console.WriteLine("Test 1 {0}", answer1);
            Console.WriteLine("Test 1 {0}", answer2);
            Console.WriteLine("Test 1 {0}", answer3);

            /* This does not work IGNORE!  Keeping it so I know I tried it.
            if (answer1)
            {
                Console.WriteLine("Test 1 Complete.");
                Console.WriteLine("Test 2 Incomplete.");
                Console.WriteLine("Test 3 Incomplete.");
                Console.WriteLine();

            }
            else if (answer1 && answer2)
            {
                Console.WriteLine("Test 1 Complete.");
                Console.WriteLine("Test 2 Complete.");
                Console.WriteLine("Test 3 Incomplete.");
                Console.WriteLine();
            }
            else if (answer1 && answer3)
            {
                Console.WriteLine("Test 1 Complete.");
                Console.WriteLine("Test 2 Incomplete.");
                Console.WriteLine("Test 3 Complete.");
                Console.WriteLine();
            }
            else if (answer2)
            {
                Console.WriteLine("Test 1 Incomplete.");
                Console.WriteLine("Test 2 Complete.");
                Console.WriteLine("Test 3 Incomplete.");
                Console.WriteLine();
            }
            else if (answer2 && answer3)
            {
                Console.WriteLine("Test 1 Incomplete.");
                Console.WriteLine("Test 2 Complete.");
                Console.WriteLine("Test 3 Complete.");
                Console.WriteLine();
            }
            else if (answer3)
            {
                Console.WriteLine("Test 1 Incomplete.");
                Console.WriteLine("Test 2 Incomplete.");
                Console.WriteLine("Test 3 Complete.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Test 1 Incomplete.");
                Console.WriteLine("Test 2 Incomplete.");
                Console.WriteLine("Test 3 Incomplete.");
                Console.WriteLine();
            }
            */
        }

    }
}
