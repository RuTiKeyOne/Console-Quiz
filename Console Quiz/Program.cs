using System;

namespace Console_Quiz
{
    class Program
    {
        delegate void AllQuestions();
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Gamer Participant = new Gamer();
            Questions Questions = new Questions();
            //Create array methods
            AllQuestions[] MyQuestions = new AllQuestions[3];
            MyQuestions[0] = Questions.ShowQuestionOne;
            MyQuestions[1] = Questions.ShowQuestionTwo;
            MyQuestions[2] = Questions.ShowQuestionThree;
            Console.WriteLine($"Викторина началась... \nПравила викторины :\n1.В ответ необходимо записывать строку\n2.Игра завершается если количество очков и количество попыток равняется нулю\nКоличество очков : {Participant.Score}\nКоличество попыток : {Participant.Attempts}\nНажмите любую клавишу если готовы начать викторину");
            Console.ReadKey();
            //Cycle
            foreach (AllQuestions MyQuestion in MyQuestions)
            {
                MyQuestion();
            }
            Console.ReadKey();
            Questions.ShowResult();
            Console.ReadKey();
        }
    }
}
