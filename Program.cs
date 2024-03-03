
Console.WriteLine("Введите элементы массива через пробел:");
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
string input = Console.ReadLine();
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
string[] inputArray = input.Split(' ',StringSplitOptions.RemoveEmptyEntries);
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.

string[] resultArray = GetNewArray(inputArray);

Console.WriteLine("Новый массив:");
Console.WriteLine(string.Join(" ", resultArray));


static string [] GetNewArray(string[] inputArray)
{
    int count = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            count++;
        }
    }

    string[] resultArray = new string[count];
    int index = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            resultArray[index] = inputArray[i];
            index++;
        }
    }

    return resultArray;
}
