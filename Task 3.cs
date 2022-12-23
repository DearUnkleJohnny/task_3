// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да




// void Distance(string num)
// {
//     if (num[0] == num[4] && num[1] == num[3])
//     {

//         Console.WriteLine($"{num} -> да");
//     }
//     else
//     {
//         Console.WriteLine($"{num} -> нет");
//     }

// }
// Console.WriteLine("Введите пятизначное число: ");
// string num = Convert.ToString(Console.ReadLine());
// Distance(num);




//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//




// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53




// void Distanse(double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     double result = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 3);
//     Console.WriteLine(result);
// }
// Console.WriteLine("Значение по оси X1");
// double Ax = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Значение по оси Y1");
// double Ay = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Значение по оси Z1");
// double Zy = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Значение по оси X2");
// double Bx = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Значение по оси Y2");
// double By = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Значение по оси Z2");
// double Zx = Convert.ToDouble(Console.ReadLine());

// Distanse(Ax, Ay, Bx, By, Zx, Zy);




//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//





// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125




Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void CubeTable(int[] cube)
{
    int count = 1;
    int length = cube.Length;
    while (count < length)
    {
        cube[count] = Convert.ToInt32(Math.Pow(count, 3));
        count++;
    }
}

void PrintArry(int[] coll)
{
    int index = 1;
    int count1 = coll.Length;
    while (index < count1)
    {
        Console.Write(coll[index] + " ");
        index++;
    }
}

int[] arry = new int[cube + 1];
CubeTable(arry);
PrintArry(arry);