namespace Architecture_and_patterns_in_CSharp
{
    class Program
    {
        static void Main()
        {
            string userString;
            int userNum;

            UI.Print("Здравствуйте, Вас приветствует математическая программа.\r\n Пожалуйста, введите число.\r\n Нажмите q для выхода.");
            userString = UI.Read();

            if (userString == "q" || !int.TryParse(userString, out userNum))
            {
                return;
            }

            UI.Print($"Факториал числа N: {MathOperations.GetFactorial(userNum)}");
            UI.Print($"Сумма от 1 до N: {MathOperations.GetSum(userNum)}");
            UI.Print($"Максимальное четное число меньше N: {MathOperations.GetMaxEvenNum(userNum)}");
        }
    }
}