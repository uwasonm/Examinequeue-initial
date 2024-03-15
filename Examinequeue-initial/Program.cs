
using System.Collections;

namespace Examinequeue_initial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
            Queue ica_Queue = new Queue();

            do
            {
                Console.WriteLine("Type \"+\" for queueing , \"-\" for dqueueing" +
                                  " or \"Q\" to exist the program");
                string nav = Console.ReadLine();

                switch (nav)
                {
                    case "+":
                        {
                            Console.WriteLine("Who is joining the queue?");
                            string input = Console.ReadLine();
                            ica_Queue.Enqueue(input);
                            break;
                        }

                    case "-":
                        {
                            if (ica_Queue.Count > 0)
                                ica_Queue.Dequeue();
                            else Console.WriteLine("There is no one on the queue.");
                            break;
                        }

                    case "QUIT":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("You can only choose + , - or  Quit");
                        break;
                }
                Console.WriteLine("People on the queue are:");
               
                foreach (string element in ica_Queue)

                {
                    Console.WriteLine(element);
                }
                Console.WriteLine($"At the moment the queue size is :" + ica_Queue.Count);
                Console.WriteLine();
            } while (true);

        }
    }
}
