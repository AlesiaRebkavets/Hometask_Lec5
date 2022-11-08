// See https://aka.ms/new-console-template for more information
using System;
using Worker;

public class FactoryWorkers
{     
    static void Main()
    {
        Person[] worker = new Person[5];

        for (int i = 0; i < 5; i++)                       // array element initialization
        {
            worker[i] = new Person();
        }

        worker[0].SetMainData("Vasiliy", "Pupkin", 47, 'm', 6, 3, false, false);   // set values to array elements
        worker[1].SetMainData("Anna", "Petrova", 38, 'f', 7, 0, false, false);
        worker[2].SetMainData("Ivan", "Ivanov", 30, 'm', 4, 0, false, false);
        worker[3].SetMainData("Dariya", "Sidorova", 41, 'f', 7, 8, false, false);
        worker[4].SetMainData("Fedor", "Kosyakov", 45, 'm', 7, 10, false, false);
  
        Console.WriteLine("Kolichectvo rabotnikov v otdele = " + worker.Length);  // output the array length
        Console.WriteLine("************************");

        for (int i = 0; i < 5; i++)                                                     // output of array elements data
        {
            Console.WriteLine("Imya sotrudnika: " + worker[i].GetName());
            Console.WriteLine("Familiya sotrudnika: " + worker[i].GetLastName());
            Console.WriteLine("Vosrast sotrudnika: " + worker[i].GetAge());
            Console.WriteLine("Pol sotrudnika: " + worker[i].GetSex());
            Console.WriteLine("Razriad sotrudnika: " + worker[i].GetSkillLevel());
            Console.WriteLine("Kolichestvo dniej progulov sotrudnika: " + worker[i].GetAbsenseFromWorkInDays());
            Console.WriteLine("Uvolen: " + worker[i].IsFired());
            Console.WriteLine("Poluchil povestku: " + worker[i].GetPoluchilPovestkuValue());
            Console.WriteLine("************************");
        }

        for (byte i = 0; i < 5; i++)                                                     // Dismiss employees and display their names
        {
            worker[i].Fire(worker[i].GetAbsenseFromWorkInDays());
            if (worker[i].IsFired())
            {
                Console.WriteLine("Sotrudnik " + worker[i].GetLastName() + " " + worker[i].GetName() + " uvolen za " + worker[i].GetAbsenseFromWorkInDays() + " dniej progula");
            }
        }

        Console.WriteLine("************************");

        for (byte i = 0; i < 5; i++)                                                     // россия пришла на завод :(
        {
            worker[i].Voenkom(worker[i].GetSex());
            if (worker[i].GetPoluchilPovestkuValue())
            {
                Console.WriteLine("Sotrudnik " + worker[i].GetLastName() + " " + worker[i].GetName() + " poluchil povestku ");
            }
        }
















    }
}