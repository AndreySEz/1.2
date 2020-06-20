using System;

namespace ООП_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Abonent abonent1 = new Abonent();
            abonent1.abonentID = rand.Next(11111111, 99999999);
            Console.WriteLine("Абонент "+ abonent1.abonentID + " создан. Заполните данные:");
            Console.WriteLine("Фамилия:");
            abonent1.abonentSurname = Console.ReadLine();
            Console.WriteLine("Имя:");
            abonent1.abonentName = Console.ReadLine();
            Console.WriteLine("Отчество:");
            abonent1.abonentPatronim = Console.ReadLine();
            Console.WriteLine("Адрес:");
            abonent1.cardGet(Console.ReadLine());
            Console.WriteLine("Номер карты:");
            abonent1.cardGet(Console.ReadLine());
            Console.WriteLine("Время междугородних переговоров:");
            abonent1.abonentMultiCityTime = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Время городских переговоров:");
            abonent1.abonentCityTime = Convert.ToInt32(Console.ReadLine());
        }
        class Abonent
        {
            public void adressGet(string adress)
            {
                abonentAdress = adress;
            }
            public void cardGet(string number)
            {
                abonentCardID = number;
            }
            public int abonentID;
            public string abonentSurname;
            public string abonentName;
            public string abonentPatronim;
            private string abonentAdress;
            private string abonentCardID;
            public int abonentMultiCityTime;
            public int abonentCityTime;
        }
    }
}
