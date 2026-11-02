using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {


            #region  Yazdirma Komutlari
            // Console.WriteLine("Hello, World!");
            // Console.Write("hi ");

            // Console.WriteLine("--------Food Categories--------");
            // Console.WriteLine();
            // Console.WriteLine("1. Foods");
            // Console.WriteLine("2. soups");
            // Console.WriteLine("3. Drinks");
            // Console.WriteLine("4. Tea");
            // Console.WriteLine("5. Water");
            // Console.WriteLine();
            // Console.WriteLine("--------Food Categories--------");
            #endregion


            #region String Degiskenler

            //String degiskenler, metinleri saklamak için kullanılır. String değişkenler çift tırnak (" ") ile tanımlanır.
            //sting name;
            //name = "Ahmet";
            //Console.WriteLine(name);

            // string customerName;
            //  string customerSurname;
            //  string identifyNumber;
            //  string gender;
            //  string telephoneNumber;
            //  string email;
            //  string adress;

            //  customerName = "Ahmet";
            // customerSurname = "Yılmaz";
            // identifyNumber = "12345678901";
            // gender = "Erkek";
            //  telephoneNumber = "05555555555";
            //  email = "ahmet.yilmaz@example.com";
            // adress = "İstanbul, Türkiye";


            // Console.WriteLine("--------Müşteri Bilgileri--------");
            //Console.WriteLine();
            // Console.WriteLine("--------------------------------");
            //  Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //  Console.WriteLine("T.C. Kimlik No: " + identifyNumber);
            // Console.WriteLine("Cinsiyet: " + gender);
            // Console.WriteLine("Telefon: " + telephoneNumber);
            // Console.WriteLine("Email: " + email);
            // Console.WriteLine("Adres: " + adress);
            // Console.WriteLine("-------------------------------");
            // Console.WriteLine();
            // Console.WriteLine();



            //  customerName = "Ayşe";
            // customerSurname = "Kara";
            // identifyNumber = "12345678902";
            // gender = "Kadın";
            // telephoneNumber = "05555555556";
            // email = "ayşe.kara@example.com";
            // adress = "Ankara, Türkiye";


            //  Console.WriteLine("-------------------------------");
            // Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            // Console.WriteLine("T.C. Kimlik No: " + identifyNumber);
            // Console.WriteLine("Cinsiyet: " + gender);
            // Console.WriteLine("Telefon: " + telephoneNumber);
            // Console.WriteLine("Email: " + email);
            //Console.WriteLine("Adres: " + adress);
            // Console.WriteLine("-------------------------------");

            #endregion

            #region İnt Degiskenler

            //int degiskenler, tam sayıları saklamak için kullanılır. int değişkenler, 32 bitlik bir veri tipidir.

            // int number = 12;
            //Console.WriteLine(number);

            int hamburgerPrice = 50;
            int pizzaPrice = 100;
            int saladPrice = 30;
            int lemonadePrice = 20;
            int chickenSoupPrice = 40;
            int waterPrice = 10;



            Console.WriteLine("--------Food Categories--------");
            Console.WriteLine();
            Console.WriteLine("1. Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("2. Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("3. Salad: " + saladPrice + " TL");
            Console.WriteLine("4. Lemonade: " + lemonadePrice + " TL");
            Console.WriteLine("5. Chicken Soup: " + chickenSoupPrice + " TL");
            Console.WriteLine("6. Water: " + waterPrice + " TL");
            Console.WriteLine();


            int hamburgerCount;
            int pizzaCount;
            int saladCount;
            int lemonadeCount;
            int chickenSoupCount;
            int waterCount;



            int totalHamburgerPrice;
            int totalPizzaPrice;
            int totalSaladPrice;
            int totalLemonadePrice;
            int totalChickenSoupPrice;
            int totalWaterPrice;


            hamburgerCount = 2;
            pizzaCount = 1;
            saladCount = 5;
            lemonadeCount = 0;
            chickenSoupCount = 3;
            waterCount = 3;


            totalHamburgerPrice = hamburgerPrice * hamburgerCount;
            totalPizzaPrice = pizzaPrice * pizzaCount;
            totalSaladPrice = saladPrice * saladCount;
            totalLemonadePrice = lemonadePrice * lemonadeCount;
            totalChickenSoupPrice = chickenSoupPrice * chickenSoupCount;
            totalWaterPrice = waterPrice * waterCount;

            Console.WriteLine("--------Restaurant Menu--------");
            Console.WriteLine();
            Console.WriteLine("1. Hamburger: " + totalHamburgerPrice + " TL");
            Console.WriteLine("2. Pizza: " + totalPizzaPrice + " TL");
            Console.WriteLine("3. Salad: " + totalSaladPrice + " TL");
            Console.WriteLine("4. Lemonade: " + totalLemonadePrice + " TL");
            Console.WriteLine("5. Chicken Soup: " + totalChickenSoupPrice + " TL");
            Console.WriteLine("6. Water: " + totalWaterPrice + " TL");


            #endregion

            Console.ReadLine();

        }
    }
}