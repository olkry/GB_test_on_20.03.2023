// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых.
// меньше либо равна 3 символа.

//Добовляем необходимые в работе методы

//Печать одномерного массива
void Print1DArr(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1]);
    Console.WriteLine("]");
}

//Метод приёма данных с консоли
string ReadData(string msg)
{
    Console.Write(msg);
    return Console.ReadLine() ?? "0";
}

//Метод приведения строки к массиву
string[] SplitString(string input)
{
      string[] test = input.Split(" ");
      return test;
}

//Метод заведения нового массива с 3мя или менее символами
string[] TestArrey(string[] arrTest)
{
      var res = new string[arrTest.Length];
      for (int i = 0; i<arrTest.Length; i++)
      {
            if(arrTest[i].Length <= 3)
            {
                  res = arrTest[i] + " ";
            }
      }
      return res;

}


string inter = ReadData("Введите через пробел элементы массива: ");
string[] splitstr = SplitString(inter);
Print1DArr(splitstr);
string[] testarrey = TestArrey(splitstr);
Print1DArr(testarrey);