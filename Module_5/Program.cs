using System;
using System.Net.Http.Headers;

class MainClass
{
  
public static void Main(string[] args)
    {
        var someName = "Иван";
        Console.WriteLine(someName);
        GetName(ref someName);
        Console.WriteLine(someName);

        var myage = 25;
        ChangeAge(myage);
        Console.WriteLine(myage);
        Console.ReadKey();
    }

     static void GetName(ref string name)
    {
        Console.WriteLine("Введите имя");
        name = Console.ReadLine();
    }
    static void ChangeAge(int age) 
    {
        Console.WriteLine("Введите возраст");
        age = Convert.ToInt32(Console.ReadLine());
    }
}