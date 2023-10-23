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
                bool isInputInt = int.TryParse(Console.ReadLine(), out int inputNumber);
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
            int maxItem = 0;
            int minItem = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxItem)
                {
                    maxItem = numbers[i];
                }
                else if (numbers[i] < minItem)
                {
                    minItem = numbers[i];
                }
            }
            Console.WriteLine($"Минимальный элемент массива: {minItem}");
            Console.WriteLine($"Максимальный элемент массива: {maxItem}");
            int differenceBetweenMinMax = maxItem - minItem;
            Console.WriteLine($"Разность между максимальным и минимальным элементами массива: {differenceBetweenMinMax}");
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