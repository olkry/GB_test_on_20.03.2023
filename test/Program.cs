// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых.
// меньше либо равна 3 символа.

//Добовляем необходимые в работе методы

//Печать одномерного массива
void Print1DArr(string[] arr)
{
      Console.Write("["); //Печать начинается с ковычки
      for (int i = 0; i < arr.Length - 1; i++) // -1 нам нужно закончить на предпоследнем значении
      {
            Console.Write(arr[i] + ", "); //Потом каждый идекс заполняется значениями, с добовлением запятой и пробела
      }
      Console.Write(arr[arr.Length - 1]);// добавляем последнее значение
      Console.WriteLine("]");// добовляем закрывающую скобку
}

//Метод приёма данных с консоли
string ReadData(string msg)
{
      Console.Write(msg);
      return Console.ReadLine() ?? "0"; //Сразу проверяем на NULL
}

//Метод приведения строки к массиву
string[] SplitString(string input)
{
      string[] test = input.Split(" "); // Дробим строку по пробелам и заносим в массив.
      return test;
}

//Метод заведения нового массива с 3мя или менее символами
string[] TestArrey(string[] arrTest)
{
      string[] res = new string[arrTest.Length]; // Новый массив длиной с входящий
      int count = 0; // Колличество найденых по условию задания значений
      for (int i = 0; i < arrTest.Length; i++)
      {
            if (arrTest[i].Length <= 3)
            {
                  res[count] = arrTest[i];
                  count++;
            }
      }
      string[] finalArr = new string[count]; //Массив длиной в кол-во найденых по условию значений
      for (int i = 0; i < count; i++)
      {
            finalArr[i] = res[i];
      }
      return finalArr;

}


string inter = ReadData("Введите через пробел элементы массива: ");
string[] splitstr = SplitString(inter);
Console.WriteLine("Из введёных данных получаем массив: ");
Print1DArr(splitstr);
string[] testarrey = TestArrey(splitstr);
Console.WriteLine("По условию задачи необходимо оставить в массиве только значения не превышающие 3х символов:");
Print1DArr(testarrey);