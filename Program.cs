using System;
using System.Collections.Generic;

namespace FlashCards
{
    class Program
    {
        static void Main(string[] args)
        {
            //FlashCard baseClass = new FlashCard("question a", "answer b");
            //Quiz quiz = new Quiz();
            //CISFlashCard cisClass = new CISFlashCard(1,"question a", "answer b", "answer c","answer d", "answer a");

            FileGateway gateway = new FileGateway();

            //Contain the flashcard objects in the data structures below
            List<CISFlashCard> flashCardsList = new List<CISFlashCard>();
            Queue<CISFlashCard> flashCardsQueue = new Queue<CISFlashCard>();
            Stack<CISFlashCard> flashCardsStack = new Stack<CISFlashCard>();

            //Get the lines of the csv
            string[] allLines = gateway.openFile("C:\\Users\\Michael\\FlashCards\\Flashcards.csv");

            for (int i = 1; i < allLines.Length; i++)
            {
                string[] columns = allLines[i].Split(',');
                CISFlashCard flashCard = new CISFlashCard(Convert.ToInt32(columns[0]), columns[1], columns[2], columns[3], columns[4], columns[5]);
                flashCardsList.Add(flashCard);
                flashCardsQueue.Enqueue(flashCard);
            }

            int index = 1;

            while(index < allLines.Length)
            {
                string[] columns = allLines[index].Split(',');
                CISFlashCard flashCard = new CISFlashCard(Convert.ToInt32(columns[0]), columns[1], columns[2], columns[3], columns[4], columns[5]);
                flashCardsStack.Push(flashCard);
                index += 1;
            }

            Console.WriteLine("this is list");
            foreach (var item in flashCardsList)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("this is Queue");
            foreach (var item in flashCardsQueue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("this is Stack");
            foreach (var item in flashCardsStack)
            {
                Console.WriteLine(item);
            }






            

            //Console.WriteLine(baseClass);

        
            //Console.WriteLine(cisClass);

            // Console.WriteLine(cisClass.GetNumberOfAnswers());

            // Console.WriteLine(cisClass.GetLastAnswer());

            // Console.WriteLine(cisClass.NumberOfQuestions());

            // Console.WriteLine("\nThis is quiz");

            // Console.WriteLine(quiz.NumberOfQuestions());

            // //List of IQuestions
            // List<IQuestion> thingsThatRespectTheIQuestionContract = new List<IQuestion>();

            // thingsThatRespectTheIQuestionContract.Add(cisClass);
            // thingsThatRespectTheIQuestionContract.Add(quiz);

            // foreach (var item in thingsThatRespectTheIQuestionContract)
            // {
            //     Console.WriteLine(item.ToString());
                
            // }



            Console.ReadLine();
        }
    }
}
