using System;

namespace FlashCards
{

    public interface IQuestion
    {
        //It is a contract that guarantees that anything that implements it
        //will provide the methods that it claims to have
        public int NumberOfQuestions();
    }

}