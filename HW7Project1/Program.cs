
/// Homework No. 7 Project No. 1
/// File Name : Program.cs
/// @author : Joshua Um
/// Date : Oct 11 2021
/// 
/// Problem Statement : Define a class called Counter whose objects count things.
/// 
/// Plan:
/// 1. Create counter object.
/// 2. Enter while loop to start program.
/// 3. Print user menu to interact with counter object.
/// 4. If the user selects 1 in the menu, call increaseCounter() to increase counter by 1.
/// 5. If the user inputs 2 in the menu, call decreaseCounter() to decrease counter by 1.
/// 6. If the user inputs 3 in the menu, call resetCounter() to decrease counter by 1.
/// 7. If the user inputs -1, then exit program.

using System;

namespace HW7Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter counterObject = new Counter();

            int choice = 0;
            do
            {
                Console.WriteLine();
                Console.WriteLine(counterObject);
                Console.WriteLine("\nEnter number for action:\n\t1. Increment counter by 1.\n\t2. Decrease counter by 1.\n\t3. Reset Counter to 0.\n\nType \"-1\" to exit program.  ");
                choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        counterObject.increaseCounter();
                        break;
                    case 2:
                        counterObject.decreaseCounter();
                        break;
                    case 3:
                        counterObject.resetCounter();
                        break;
                    case -1:
                        choice = -1;
                        break;
                    default:
                        Console.WriteLine("Invalid choice, try again.");
                        break;
                        
                }

            } while (choice != -1);
            




        }
    }


    class Counter
    {
        private uint count;

        public Counter()
        {
            count = 0;
        }

        public Counter(uint count)
        {
            this.count = count;
        }



        public uint getCount()
        {
            return count;
        }


        public void increaseCounter()
        {
            count++;
        }

        public void decreaseCounter()
        {
            if(count != 0)
            {
                count--;
            }
        }

        public void resetCounter()
        {
            count = 0;
        }

        public override string ToString()
        {
            return "Count : " + count;
        }

        public override bool Equals(Object o)
        {
            if(o != null && this.GetType() == o.GetType())
            {
                Counter that = (Counter)o;
                return count == that.getCount();
            }
            return false;
        }


    }



}
