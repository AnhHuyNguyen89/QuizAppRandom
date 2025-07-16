
using System;

namespace QuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Are you ready to play (y/n)?");
            string readyPrompt = Console.ReadLine();
            if (!readyPrompt.Equals("y", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Maybe next time!");
                return;
            }

            string question1 = "What is capital city of VietNam";
            string answer1 = "Hanoi";

            string question2 = "What is 2 +2?";
            string answer2 = "4";

            string question3 = "What is computer sciene?";
            string answer3 = "This is for computer";

            string question4 = "Which club is the best in the world?";
            string answer4 = "It's Chelsea";



            int score = 0;
            int[] questionOrder = { 1, 2, 3, 4 };

            Random rnd = new Random();
            int questionNumber = rnd.Next(1, 5); // 1 to 4 (upper bound exclusive)

            for (int i = 0; i < questionOrder.Length; i++)
            {
                int j = rnd.Next(i, questionOrder.Length);
                int temp = questionOrder[i];
                questionOrder[i] = questionOrder[j];
                questionOrder[j] = temp;
            }
            string userAnswer = "";


            for (int i = 0; i < questionOrder.Length; i++)
            {
                int q = questionOrder[i];

                if (q == 1)
                {
                    Console.WriteLine(question1);
                    userAnswer = Console.ReadLine();
                    if (userAnswer == answer1) score++;
                }
                else if (q == 2)
                {
                    Console.WriteLine(question2);
                    userAnswer = Console.ReadLine();
                    if (userAnswer == answer2) score++;
                }
                else if (q == 3)
                {
                    Console.WriteLine(question3);
                    userAnswer = Console.ReadLine();
                    if (userAnswer == answer3) score++;
                }
                else if (q == 4)
                {
                    Console.WriteLine(question4);
                    userAnswer = Console.ReadLine();
                    if (userAnswer == answer4) score++;
                }
            }

            Console.WriteLine($"Your final score is {score}/4");

        }
    }
}
