// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.


void InputMas(out string a1, 
            out string b1, 
            out string c1, 
            out string d1)
{
    Console.WriteLine("Введите первое слово и нажмите Enter:");
    a1 = Console.ReadLine();
    Console.WriteLine("Введите второе слово и нажмите Enter:");
    b1 = Console.ReadLine();
    Console.WriteLine("Введите третье слово и нажмите Enter:");
    c1 = Console.ReadLine();
    Console.WriteLine("Введите четвертое слово и нажмите Enter:");
    d1 = Console.ReadLine();
}

void Mas(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if(arr1[i].Length <= 3)
            {
            arr2[count] = arr1[i];
            count++;
            }
    }
}
void Print(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != null)
        Console.Write($" '{arr[i]}' ");
    }
    Console.Write("]");
}

Console.Clear();
string a, b, c, d;
InputMas(out a, out b, out c, out d);
string[] arr1 = {a, b, c, d};
string[] arr2 = new string[arr1.Length];
Mas(arr1, arr2);
Console.Clear();
Print(arr1);
Console.Write(" => ");
Print(arr2);