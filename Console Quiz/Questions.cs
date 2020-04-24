using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Quiz
{
    class Questions : Game
    {
        internal string Answer { get; set; }
        internal void ShowQuestionOne()
        {
            switch (Attempts != 0)
            {
                case true:
                    Console.WriteLine("\nНазовите отца основателя ООП ?\n\n1.Линус Торвальдс\n2.Тим Бернерс-Ли\n3.Алан Кей\n4.Андерс Хейлсберг\n\nЗапишите ваш ответ :");
                    Answer = Console.ReadLine().ToLower();
                    switch (Answer.Contains("алан кей"))
                    {
                        case true:
                            Score += 10000;
                            Console.WriteLine($"Вы ответили правильно, ваш счет : {Score}, Количество попыток : {Attempts}\nНажмите любую кнопку чтобы продолжить --->");
                            break;
                        case false:
                            switch (Score >= Fine)
                            {
                                case true:
                                    Score -= Fine;
                                    Console.WriteLine($"Вы ответили неправильно, ваш счет : {Score}, Количество попыток : {Attempts}\nНажмите любую кнопку чтобы продолжить --->");
                                    break;
                                case false:
                                    Attempts -= 1;
                                    Console.WriteLine($"Вы ответили неправильно, ваш счет : {Score}, Количество попыток : {Attempts}\nНажмите любую кнопку чтобы продолжить --->");
                                    break;
                            }
                            break;
                    }
                    break;
                case false:
                    break;
            }
        }
        internal void ShowQuestionTwo()
        {
            switch (Attempts != 0)
            {
                case true:
                    Console.WriteLine("\nКакой язык своим выходом убила Java ?\n\n1.Pascall\n2.JavaScript\n3.SmallTalk\n4.Cobol\n\nЗапишите ваш ответ :");
                    Answer = Console.ReadLine().ToLower();
                    switch (Answer.Contains("smalltalk"))
                    {
                        case true:
                            Score += 10000;
                            Console.WriteLine($"Вы ответили правильно, ваш счет : {Score}, Количество попыток : {Attempts}\nНажмите любую кнопку чтобы продолжить --->");
                            break;
                        case false:
                            switch (Score >= Fine)
                            {
                                case true:
                                    Score -= Fine;
                                    Console.WriteLine($"Вы ответили неправильно, ваш счет : {Score}, Количество попыток : {Attempts}\nНажмите любую кнопку чтобы продолжить --->");
                                    break;
                                case false:
                                    Attempts -= 1;
                                    Console.WriteLine($"Вы ответили неправильно, ваш счет : {Score}, Количество попыток : {Attempts}\nНажмите любую кнопку чтобы продолжить --->");
                                    break;
                            }
                            break;
                    }
                    break;
                case false:
                    break;
            }
        }
        internal void ShowQuestionThree()
        {
            switch (Attempts != 0)
            {
                case true:
                    Console.WriteLine("\nКакая книга имеет прозвище Библия C# разработчика в кругу .Net программистов ?\n\n1.Эффективное программирование на C#. 50 способов улучшения кода\n2.Язык программирования C# 5.0 и платформа .NET 4.5, Эндрю Троелсен, 6-е издание\n3.CLR via C#\n4.C# in Depth\n\nЗапишите ваш ответ :");
                    Answer = Console.ReadLine().ToLower();
                    switch (Answer.Contains("clr via c#") || Answer.Contains("clr") || Answer.Contains("via"))
                    {
                        case true:
                            Score += 10000;
                            Console.WriteLine($"Вы ответили правильно, ваш счет : {Score}, Количество попыток : {Attempts}\nНажмите любую кнопку чтобы продолжить --->");
                            break;
                        case false:
                            switch (Score >= Fine)
                            {
                                case true:
                                    Score -= Fine;
                                    Console.WriteLine($"Вы ответили неправильно, ваш счет : {Score}, Количество попыток : {Attempts}\nНажмите любую кнопку чтобы продолжить --->");
                                    break;
                                case false:
                                    Attempts -= 1;
                                    Console.WriteLine($"Вы ответили неправильно, ваш счет : {Score}, Количество попыток : {Attempts}\nНажмите любую кнопку чтобы продолжить --->");
                                    break;
                            }
                            break;
                    }
                    break;
                case false:
                    break;
            }
        }
        internal void ShowResult()
        {
            if (Score > 10000 && Score <= 20000)
            {
                Console.WriteLine($"\nВы набрали {Score} очков и в качестве приза вы получаете 200 долларов, чтобы закончить викторину нажмите на любую клавишу --->");
            }
            else if (Score > 20000 && Score <= 30000)
            {
                Console.WriteLine($"\nВы набрали {Score} очков и в качестве приза вы получаете 300 долларов, чтобы закончить викторину нажмите на любую клавишу --->");
            }
            else
            {
                Console.WriteLine($"\nВы набрали {Score} очков и вы получаете утешительный приз, чтобы закончить викторину нажмите на любую клавишу --->");
            }
        }
    }
}