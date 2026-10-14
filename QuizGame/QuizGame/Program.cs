using System;


namespace QuizGame
{
    internal class Program
    {
       static short NumCorrectAnswers = 0;
       static short NumWrongAnswers = 0;
        static void Main(string[] args)
        {
            string[] Quetions = new string[]
            {

                "What is the closest planet to the Sun in our solar system?",
                "How many months are there in a Gregorian calendar year?",
                "What is the capital city of Egypt?",
                "Which animal is commonly known as the 'ship of the desert'?",
                "How many days are there in a week?"
            };
            string[] Answers =
            {
                    "Mercury",
                    "12",
                    "Cairo",
                    "Camel",
                    "7"
            };
           
            Console.WriteLine("Welcome to Quiz Game ");
            Console.WriteLine("---------------------");
            Console.WriteLine("Please Answer the following quations");
            for (int i = 0; i < Quetions.Length; i++)
            {
                    Console.WriteLine(Quetions[i]);
                try
                {
                    string UserAnswer = Console.ReadLine();
                    if (IsCorrectAnswer(UserAnswer, Answers[i]))
                    {
                        Console.WriteLine(" True Answer ");
                    }
                    else
                    {
                        Console.WriteLine($"Wrong Answer the Correct Answer is {Answers[i]}");
                    }
                }
                catch (Exception e) { 
                Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("The Quiz is done ");
            Console.WriteLine("-----------------");
            Console.WriteLine($"The Number of Qutions is {Quetions.Length} ");
            Console.WriteLine($"The number of The correct Answers {NumCorrectAnswers} , Number of wrong Answer is {NumWrongAnswers}");
            bool TheFinalResult = NumCorrectAnswers >= NumWrongAnswers;
            string result = (TheFinalResult) ? "Pass" : "Fail";
            Console.WriteLine($"The Final Result{result}");
        }

        static bool IsCorrectAnswer(string UserAnswer,string CorrectAnswer)
        {
            if (String.IsNullOrEmpty(UserAnswer))
            {
                throw new Exception("Answer Cannot be null or empty");
            }
            if (CorrectAnswer.Trim().ToUpper() == UserAnswer.Trim().ToUpper()) { 
                NumCorrectAnswers++;
                return true;
                
            }
            else
            {
                NumWrongAnswers++;
                return false;
            }
        }
    }
}
