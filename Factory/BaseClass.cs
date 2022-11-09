using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Worker;

namespace Factory
{
    internal class BaseClass
    {
        static void Main()
        {
            Person[] workers = new Person[5];
                       
            workers = FactoryWorkers.ArrayElementInitialization(5, "", "", 0, '-', 0, 0, false, false);     // array element initialization
            // вызывается метод, который инициализирует работников завода, присваивая всем однотипную личную информацию
            // знаю, что практического смысла в этом нет, но тут я хотела показать, что умею создавать и использовать конструктор, юзаю его с массивом обьектов, да еще и в отдельном методе 
            // ниже я работаю с каждым работником отдельно; присваиваю им личную информацию, показавая, что умею работать и с сеттером тоже :)
            // текущий метод можно воспринимать как закупку пустых книжек для личных дел отделом кадров завода :)
           
            workers[0].SetMainData("Vasiliy", "Pupkin", 47, 'm', 6, 3, false, false);   // edit values of array elements 
            workers[1].SetMainData("Anna", "Petrova", 38, 'f', 7, 0, false, false);
            workers[2].SetMainData("Ivan", "Ivanov", 30, 'm', 4, 0, false, false);
            workers[3].SetMainData("Dariya", "Sidorova", 41, 'f', 7, 8, false, false);
            workers[4].SetMainData("Fedor", "Kosyakov", 45, 'm', 7, 10, false, false);

            Console.WriteLine("Kolichectvo rabotnikov v otdele = " + workers.Length);  // output the array length
            Console.WriteLine("************************");

            for (int i = 0; i < 5; i++)                                                     // output of array elements data
            {
                Console.WriteLine("Imya sotrudnika: " + workers[i].GetName());
                Console.WriteLine("Familiya sotrudnika: " + workers[i].GetLastName());
                Console.WriteLine("Vosrast sotrudnika: " + workers[i].GetAge());
                Console.WriteLine("Pol sotrudnika: " + workers[i].GetSex());
                Console.WriteLine("Razriad sotrudnika: " + workers[i].GetSkillLevel());
                Console.WriteLine("Kolichestvo dniej progulov sotrudnika: " + workers[i].GetAbsenseFromWorkInDays());
                Console.WriteLine("Uvolen: " + workers[i].IsFired());
                Console.WriteLine("Poluchil povestku: " + workers[i].GetPoluchilPovestkuValue());
                Console.WriteLine("************************");
            }

            for (byte i = 0; i < 5; i++)                                                     // Dismiss employees and display their names
            {
                workers[i].Fire(workers[i].GetAbsenseFromWorkInDays());
                if (workers[i].IsFired())
                {
                    Console.WriteLine("Sotrudnik " + workers[i].GetLastName() + " " + workers[i].GetName() + " uvolen za " + workers[i].GetAbsenseFromWorkInDays() + " dniej progula");
                }
            }

            Console.WriteLine("************************");

            for (byte i = 0; i < 5; i++)                                                     // россия пришла на завод :(
            {
                workers[i].Voenkom(workers[i].GetSex());
                if (workers[i].GetPoluchilPovestkuValue())
                {
                    Console.WriteLine("Sotrudnik " + workers[i].GetLastName() + " " + workers[i].GetName() + " poluchil povestku ");
                }
            }
         
        }
    }
}
