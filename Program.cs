Class1 p = new Class1();

  Console.WriteLine("Введите число в диапазоне от 0 до 65535");
        
        
if (int.TryParse(Console.ReadLine(),out int x))
{
    p.String(x);

}
else
{
    Console.WriteLine("Это не число");
    Environment.Exit(0);
}

Console.WriteLine("Введите название файла");
string name = Console.ReadLine();
if (File.Exists(name) == true)
{
    p.Fail(x,name);
}
else
{
    Console.WriteLine("Файл не найден.Повторите");
    name = Console.ReadLine();
    if (File.Exists(name) == true)
    {
        p.Fail(x, name);
    }
    else
    {
        Console.WriteLine("Файл не найден");
        Environment.Exit(0);
    }
}

//if (int.TryParse(num, out n) && n > 0 && n <= 65535)
//{

//         bool prime = true;

//         for (int i = 2; i <= n / 2; i++)
//         {
//             if (n % i == 0)
//             {
//                 prime = false;
//                 Console.WriteLine();
//                 Console.WriteLine("Число непростое");
//                 Console.WriteLine();
//                 Console.WriteLine(i + "*" + n / i + "=" + num);
//                 break;
//             }
//             if (prime)
//             {
//                 Console.WriteLine($"Число {num} простое");
//             }

//         }

//         Console.WriteLine();
//         Console.WriteLine("Введите название файла");
//         string txt = Console.ReadLine();
//         bool fileExist = File.Exists(txt);
//           File.AppendAllText("t1.txt", num);
//         if (fileExist)
//         {
//             Console.WriteLine("Файл найден.");
//         }
//         else
//         {
//             Console.WriteLine("Файл не найден.Напишите название существующего");
//         }

//        // string path = num;
//        // string text = num;

//        // using (StreamWriter writer = new StreamWriter(path))
//        // {
//        //     writer.Write(text);
//        //}
//}                    
//    else
//    {
//         Console.WriteLine("Вы вышли из диапозона");
//    }

//     //if (!int.TryParse(num, out n))
//     //{
//     //    Console.WriteLine("Это не число");
//     //}

internal class Class1
{
    internal void Fail(int x,string name)
    {
        if (File.Exists(name) == true)
        {
            Console.WriteLine("Файл найден");
        }
        else
        {
            Console.WriteLine("Файл не найден");
        }
    }

    internal void String(int x)
    {  if 
            ( x > 0 && x <= 65535)
        {          
            Console.WriteLine("Это число входит в диапозон");

            bool prime = true;

            for (int i = 2; i <= x / 2; i++)
            {
                if (x % i == 0)
                {
                    prime = false;
                    Console.WriteLine();
                    Console.WriteLine("Число непростое");
                    Console.WriteLine();
                    Console.WriteLine(i + "*" + x / i + "=" + x);
                    break;
                }
                if (prime)
                {
                    Console.WriteLine($"Число {x} простое");
                }

            }

        }
        else
        {
            Console.WriteLine("Число должно входить в заданный диапозон.Повторите ввод!!");
            x = Convert.ToInt32(Console.ReadLine());
            if(x > 0 && x <= 65535)
            {
                Console.WriteLine("Это число входит в диапозон");
            }
            else
            {
                Console.WriteLine("Число должно входить в заданный диапозон");
                       Environment.Exit(0);
            }
        }
    }
}
