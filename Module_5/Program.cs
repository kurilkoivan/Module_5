using System;

class MainClass
{
    public static void Main(string[] args)
    {
        (string Name, string[] Diches) User;
        Console.WriteLine("Введите имя");
        User.Name = Console.ReadLine();
        User.Diches = new string[5];
        for (int i = 0; i < User.Diches.Length; i++)
        {
            Console.WriteLine("Введите любимое блюдо {0}", i + 1);
            User.Diches[i] = Console.ReadLine();

        }
        Console.ReadKey();
    }
}

