using System;

class MainClass
{
    static string ShowColor(string username,int userage)
    {
        Console.WriteLine("{0}, {1} лет \nНапишите свой любимый цвет на английском с маленькой буквы", username, userage);
        var color = Console.ReadLine();

        switch (color)
        {
            case "red":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
                break;

            case "green":
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
                break;
            case "cyan":
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
                break;
            default:
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Your color is yellow!");
                break;
        }
        return color;
    }
    static int[] GetArrayFromConsole()
    {
        var result = new int[5];

        for (int i = 0; i < result.Length; i++) 
        {
            Console.WriteLine("ВВедите элемент массива{0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }
        return result;
    }
    static int[] SortArray(int[] result)
    {
        int temp = 0;
        for (int i = 0; i < result.Length; i++)
        {
            for (int j = i + 1; result.Length > j; j++)
                if (result[i] > result[j])
                {
                    temp = result[i];
                    result[i] = result[j];
                    result[j] = temp;
                }
        }
            return result;
    }
public static void Main(string[] args)
    {
        var (name, age) = ("Евгения", 27);

        Console.WriteLine("Мое имя: {0}", name);
        Console.WriteLine("Мой возраст: {0}", age);

        Console.Write("Введите имя: ");
        name = Console.ReadLine();
        Console.Write("Введите возрас с цифрами:");
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ваше имя: {0}", name);
        Console.WriteLine("Ваш возраст: {0}", age);


        (string name, int age) anketa;
        Console.Write("Введите имя: ");
        anketa.name = Console.ReadLine();
        Console.Write("Введите возраст с цифрами: ");
        anketa.age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ваше имя: {0}", anketa.name);
        Console.WriteLine("Ваш возраст: {0}", anketa.age);

        


        var favcolors = new string[3];
        for (int i = 0; i < favcolors.Length; i++) 
        {
            favcolors[i] = ShowColor(anketa.name,anketa.age);    
        }
        Console.WriteLine("Ваши любимые цвета");
        foreach (var color in favcolors) 
        {
            Console.WriteLine(color);
        }
    }
}