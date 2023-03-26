//Получение числа, который вводит пользователь
int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не целое положительное число. Введите корректное число.";
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
            break;
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }
    return result;
}

//Метод заполнения строк массива
void GetStrings(string[] stringArray)
{
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1}-ю строку:");
        stringArray[i] = Console.ReadLine();
    }
}

//Метод вывода массива
void PrintArray(string[] stringArray)
{
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.WriteLine(stringArray[i]);
    }
}

//Метод получения нового массива с исключенными строками
string[] FilterStringsArray(string[] stringArray)
{
    //Обнуляем счетчик количества строк    
    int count = 0;
    //Задаем переменную для возможности быстрого изменения ограничения длины при необходимости
    int fixLength = 3;
    //Перебираем все строки массива и определяем сколько из них будет в новом массиве 
    for (int i = 0; i < stringArray.Length; i++)
    {
        if ((stringArray[i]).Length <= fixLength) count++;
    }
    //Выделяем область памяти под новый массив строк    
    string[] newArrayOfString = new string[count];
    int j = 0;
    //Переносим в новый массив только те строки, длина которых не превышает 3
    for (int i = 0; i < stringArray.Length; i++)
    {
        if ((stringArray[i]).Length <= fixLength)
        {
            newArrayOfString[j] = stringArray[i];
            j++;
        }
    }
    return newArrayOfString;
}

//Получаем размерность массива от пользователя
int m = GetNumber("Введите количество строк в массиве строк m:");
//Резервируем память для массива в соответствии с размером
string[] arrayOfStrings = new string[m];
//Заполняем массив
GetStrings(arrayOfStrings);
//Выводим введенный пользователем массив
Console.WriteLine();
Console.WriteLine("Введенный массив:");
Console.WriteLine();
PrintArray(arrayOfStrings);
//Формируем новый массив только для строк с длиной <=3 символа
string[] newArrayOfStrings = FilterStringsArray(arrayOfStrings);
//Выводим новый массив только из строк, в которых <=3 символов
Console.WriteLine();
Console.WriteLine("Новый массив:");
Console.WriteLine();
PrintArray(newArrayOfStrings);