
using System.Collections.Generic;
using System;
namespace Develop02 
{
    public  class Entry
    {
            public string prompt;
            List<string> listOfPrompts = new List<string> {"What did you have for dinner", "What was the coolest thing you did?", "Did you feel Gods love if so how?",};
            public string response;
            public string date;
            public string ConvertToString()
            {
                return $"{date}\n{prompt}\n{response}\n";
            }
            public void Hold(string prompt, string response, string date)
            {
                this.prompt = prompt;
                this.response = response;
                this.date = date;
            }
            public string GetPromt()
            {
                Random random = new Random();
                int RandomIndex = random.Next(listOfPrompts.Count);
                return listOfPrompts[RandomIndex];
            }

    }
}