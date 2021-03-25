// using System;
// using System.Collections.Generic;

namespace FlashCards
{

    public class CISFlashCard : FlashCard
    {    
        
        public CISFlashCard(int id, string question, string answer):base(id, question, answer)
        {

        }

        public CISFlashCard(int id, string question, string answer1, string answer2, string answer3, string answer4):base(id, question, answer1, answer2, answer3, answer4)
        {
            
        }



        public override string ToString()
        {
            string message = "This is a CIS flashcard\n";
            message += $"Id: {this.id}\n";
            message += $"Question: {this.id}\n";
            message += $"Answer1 {this.answers[0]}\n";
            message += $"Answer2 {this.answers[1]}\n";
            message += $"Answer3 {this.answers[2]}\n";
            message += $"Answer4 {this.answers[3]}\n";

            return message;
        }

        public override int GetNumberOfAnswers()
        {
            return answers.Count;
        }

        public override string GetLastAnswer()
        {
            if(answers.Count > 0){
                return answers[answers.Count - 1];

            }
            else{
                return "No answers yet!";
            }
            
        } 


    }

}