using System.Runtime.CompilerServices;

Console.WriteLine("Введите размер массива:");
bool isContinue = true;

while (isContinue)
{
    bool isParseSuccess = int.TryParse(Console.ReadLine(), out int arrayLength);
    if (isParseSuccess)
    {
        if (arrayLength > 2)
        {
            int[] numbers = new int[arrayLength];
            Console.WriteLine("Элементы массива:");
            for (int i = 0; i < numbers.Length; i++)
            {
                bool isInputInt = int.TryParse(Console.ReadLine(),out int inputNumber);
                if (isInputInt)
                {
                    numbers[i] = inputNumber;
                }
                else
                {
                    Console.WriteLine("Введено некорректное число");
                    i--;
                }
            }
            int itemsSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                itemsSum = itemsSum + numbers[i];
            }
            Console.WriteLine($"Сумма элементов массива: {itemsSum}");
            isContinue = false;
        }
        else
        {
            Console.WriteLine("Размерность массива некорректна");
        }
    }
    else 
    {
        Console.WriteLine("Неверно введено число!");
    }
}