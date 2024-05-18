using System;

namespace Module___5
{
    class Personal_Information
    {
        static void Main(string[] args)
        {
            EnterUser();
            ShowData();
        }
        static (string Name, string LastName, int Age, int NumPet, int NumFavColor, bool HavePet, string[] PetName, string[] favColor) UserData;
        static (string Name, string LastName, int Age, int NumPet, int NumFavColor, bool HavePet, string[] PetName, string[] favColor) EnterUser()
        {
            Console.Write("Введите имя: ");
            UserData.Name = Console.ReadLine();

            Console.Write("Введите фамилию: ");
            UserData.LastName = Console.ReadLine();

            string age;
            int intage;
            do
            {
                Console.Write("Введите возраст цифрами: ");
                age = Console.ReadLine();

            } while (Checknum(age, out intage));

            UserData.Age = intage;

            Console.Write("Есть ли у вас питомцы? (Да/Нет): ");
            var PetResult = Console.ReadLine();

            while (PetResult != "Да" && PetResult != "Нет")
            {
                Console.WriteLine("Некорректный ответ, пожалуйста, ответьте Да или Нет");
                PetResult = Console.ReadLine();
            }
            if (PetResult == "Да")
            {
                UserData.HavePet = true;
                string pet;
                int intpet;
                do
                {
                    Console.WriteLine("Введите количество питомцев цифрами: ");
                    pet = Console.ReadLine();

                } while (Checknum(pet, out intpet));

                UserData.NumPet = intpet;

                string[] PetName = new string[intpet];
                Console.WriteLine("Введите имя или имена питомцев: ");
                for (int i = 0; i < intpet; i++)
                {
                    PetName[i] = Console.ReadLine();
                }

                UserData.PetName = PetName;
            }

            else
            {
                UserData.NumPet = 0;
            }

            string colors;
            int intcolors;
            do
            {
                Console.Write("Напишите количество ваших любимых цветов цифрами: ");
                colors = Console.ReadLine();
            } while (Checknum(colors, out intcolors));

            UserData.NumFavColor = intcolors;

            string[] favColor = new string[intcolors];
            Console.WriteLine("Введите Ваши любимые цвета: ");
            for (int i = 0; i < intcolors; i++)
            {
                favColor[i] = Console.ReadLine();
            }

            UserData.favColor = favColor;

            return UserData;
        }

        static bool Checknum(string number, out int corrnumber)
        {
            if (int.TryParse(number, out int intnum))
            {

                if (intnum > 0)
                {
                    corrnumber = intnum;
                    return false;
                }
            }
            {
                Console.WriteLine("Некорректное значение, введите значение цифрами");
                corrnumber = 0;
                return true;
            }
        }
        static (string Name, string LastName, int Age, int NumPet, int NumFavColor, bool HavePet, string[] PetName, string[] favColor) ShowData()
        {
            Console.WriteLine("/////////////////////////////");
            Console.WriteLine($"Имя: {UserData.Name}");
            Console.WriteLine($"Фамилия: {UserData.LastName}");
            Console.WriteLine($"Возраст: {UserData.Age}"); if (UserData.HavePet)
            {
                Console.WriteLine($"Количество питомцев: {UserData.NumPet}");
                Console.WriteLine("Имена питомцев:");
                foreach (string pet in UserData.PetName)
                {
                    Console.WriteLine(pet);
                }
            }
            else
            {
                Console.WriteLine("У вас нет питомцев");
            }
            Console.WriteLine($"Количество любимых цветов: {UserData.NumFavColor}");
            Console.WriteLine("Ваши любимые цвета:");
            foreach (string col in UserData.favColor)
            {
                Console.WriteLine(col);
            }

            return UserData;
        }
    }
}