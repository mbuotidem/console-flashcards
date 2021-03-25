using System;
using System.Collections.Generic;
using System.IO;

namespace FlashCards
{
    public class FileGateway
    {
        
        // Step 1 Open the file
        string[] message;

        public string[] openFile(string path)
        {
            message = File.ReadAllLines(path);

            return message;

        }

        public string[] openFile()
        {
            message = File.ReadAllLines("C:\\Users\\Michael\\FlashCards\\Flashcards.csv");
            return message;

        }

        // Step 2 

        // Step 3


        // Step 4



    }
}