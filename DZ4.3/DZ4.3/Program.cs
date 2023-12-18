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
            Array.Sort(numbers);
            bool dupFlag = false;
            int dupCount = 0, currElement = numbers[0];
            foreach (int arrayElement in numbers)
            {
                if (arrayElement == currElement)
                {
                    dupCount++;
                }
                else
                {
                    if (dupCount > 1)
                    {
                        dupFlag = true;
                        Console.WriteLine($"Повторяющийся элемент: {currElement}, количество повторений: {dupCount}");
                    }
                    dupCount = 1;
                    currElement = arrayElement;
                }
            }
            if (dupCount > 1)
            {
                dupFlag = true;
                Console.WriteLine($"Повторяющийся элемент: {currElement}, количество повторений: {dupCount}");
                isContinue = false;
            }
            if (!dupFlag)
            {
                Console.WriteLine($"Массив состоит из уникальных элементов");
                isContinue = false;
            }
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