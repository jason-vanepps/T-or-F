using System;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            Tools.SetUpInputStream(entry);

            // Type your code below
            string[] questions = { "The sky is up?", "Food is good?", "Washington was our first president", "Dads favorite color is yellow" };

            bool[] answers = { true, true, true, false };
            bool[] responses = new bool[questions.Length];

            if (questions.Length != answers.Length)
            {
                Console.WriteLine("Warning!!! question doesnt equal answer");
            }
            int askingIndex = 0;

            foreach (string question in questions)
            {
                Console.WriteLine(question);
                string reply = Console.ReadLine();
                bool isBool = Boolean.TryParse(reply, out bool inputBool);

                while (isBool == false)
                {
                    Console.WriteLine("Please respond with 'true or 'false'.");
                    string input = Console.ReadLine();
                    Boolean.TryParse(input, out isBool);
                }
                responses[askingIndex] = isBool;
                askingIndex++;
            }

            int scoreIndex = 0;
            int score = 0;
            foreach (bool answer in answers)
            {
                bool inputresponses = responses[scoreIndex];
                Console.WriteLine("Input: " + inputresponses + "|" + "Answer: " + (answers[scoreIndex]));
                if (inputresponses == (answers[scoreIndex]))
                {
                    score++;
                }
                ++scoreIndex;
            }
            Console.WriteLine($"You got {score} of {questions.Length}");

        }
    }
}
