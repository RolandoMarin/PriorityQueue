using System;
using System.Collections.Generic;

namespace Queue2
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            Queue<ERQueue> myQueue = new Queue<ERQueue>();

            string selectedChoice;

            do
            {
                Console.Clear();

                Console.Write(Menu());

                selectedChoice = Console.ReadLine();

                //Add Patient
                if (selectedChoice.ToUpper() == "A")
                {

                    Console.WriteLine("\nWho are we helping today?");

                    string patient = Console.ReadLine();

                    Console.WriteLine("Priority (1:highest priority – 5:lowest priority)");

                    int mission = int.Parse(Console.ReadLine());

                    myQueue.Enqueue(new ERQueue(patient, mission));

                }

                //shows us the name of patient and what they have
                else if (selectedChoice.ToUpper() == "P")
                {
                   
                    ERQueue next = myQueue.Dequeue();
                  

                    Console.WriteLine("\nYou are next " + next.Name);

                    Console.WriteLine("I see you have a priotiry of " + next.Condition + " let me help you with that!");
                    Console.WriteLine("All Done!");

                    Console.WriteLine("Press enter for new patient");
                    Console.ReadLine();
                }

                else if (selectedChoice.ToUpper() == "L")
                {
                    //string allNode = + myQueue.Dequeue();

                    //while(myQueue.Dequeue() != null) 
                    //{
                    //    myQueue = myQueue.Dequeue();




                }
             else if (selectedChoice.ToUpper() == "Q")
                 {
                    break;
            
                 }
                
            }//quit
           while (selectedChoice != "Q");
            
       


            static string Menu()
            {
                return "(A)dd Patient\n" +
                  "(P)roccess Current Patient \n" +
                  "(L)ist all in Queue\n" +
                  "(Q)uite\n\n" +
                  "Choose Your option(A, P, L, Q): \n";
            }

         
           



        }
    }
}
