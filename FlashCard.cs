using System;
using System.Collections.Generic;

namespace FlashCards
{

    public abstract class FlashCard: IQuestion
    {
        protected int id;
        protected string question;
        protected List<string> answers = new List<string>();

        // public FlashCard(string question)
        // {
        //     this.question = question;

        // }


        //Constructor chaining
        public FlashCard(string question):this(1,question, "")
        {

        }

        public FlashCard(int id, string question, string answer1, string answer2, string answer3, string answer4)
        {
            this.id = id;
            this.question = question;
            this.answers.Add(answer1);
            this.answers.Add(answer2);
            this.answers.Add(answer3);
            this.answers.Add(answer4);

        }

        // public FlashCard()
        // {
            
        // }

        //Constructor Overloading
        public FlashCard(int id, string question, string answer1)
        {
            this.id = id;
            this.question = question;
            this.answers.Add(answer1);

        }


        public string GetAnswer(int answerPosition)
        {

            return answers[answerPosition];

        }


        //Method Overloading

        public List<string> GetAnswer(bool all)
        {
            return answers;

        }

        public override string ToString()
        {
            string message = "I am the base flashcard class";
            return message;
        }

        //abstract method must be contained in an abstract class
        public abstract int GetNumberOfAnswers();
        

        //virtual method
        public virtual string GetLastAnswer()
        {
            return answers[answers.Count - 1];
        } 

        public int NumberOfQuestions()
        {
            return 1;
        }




    }
}