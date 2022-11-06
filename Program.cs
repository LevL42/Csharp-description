using System;

namespace csharp
{

    class Program
    {
        static void Main()
        {

            // - Используется для коментариев.
            /* - Используется для больших
             коментариев на 
             много строк */
            // Console.WriteLine("Hello"); Данный метод выводит информацию каждый раз в новой строке.
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");
            // Console.Write("Hello");  Данный метод выводит информацию в одну строчку. 
            Console.Write("Hello");
            Console.Write("Hello");
            //Console.Write("Hello \n"); Вданном случае \n образует пропуск строки.
            Console.Write("Hello \n");
            Console.Write("Hello \n");
            Console.Write("Hello");
            // Console.ReadLine(); Данный метод позволяет в водить множество символов и завершается нажатием клавиши ENTER.
            Console.ReadLine();
            // Console.ReadKey(); Данный метод ожидает от пользователя нажатия на любую клавишу и завершает работу
            Console.ReadKey();

        }
    }
}