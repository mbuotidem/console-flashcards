using System;
using System.Collections.Generic;

namespace FlashCards
{
    public class Quiz: IQuestion
    {
        List<string> questions = new List<string>();

        public int NumberOfQuestions()
        {
            return questions.Count;
        }

        public override string ToString()
        {
            return "I am a quiz class!";
        }
    }

}