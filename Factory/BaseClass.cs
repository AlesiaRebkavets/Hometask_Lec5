﻿using System;
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

            FactoryWorkers.OuptufOfArayLength("Kolichectvo rabotnikov v otdele =", workers);  // output the array length
            FactoryWorkers.OutputADelimiter();       // output a row delimiter

            Console.WriteLine(FactoryWorkers.OutputSingleWorkerData(workers[1]));     // output personal data of the specific worker 
            FactoryWorkers.OutputADelimiter();       // output a row delimiter

            Console.WriteLine(FactoryWorkers.OutputWorkersData(workers, 5));          // output personal data of all the workers 

            Console.WriteLine(FactoryWorkers.DismissASingleEmploee(workers[1]));      // Dismiss a single employee if he/she has days of absense and display his/her name
            FactoryWorkers.OutputADelimiter();

            Console.WriteLine(FactoryWorkers.DismissEmploees(workers, 5));            // Dismiss all the employees if they have days of absense and display their names
            FactoryWorkers.OutputADelimiter();

            Console.WriteLine(FactoryWorkers.ToWarASingleEmploee(workers[0]));        // россия пришла на завод :(        дать повестку одному работнику
            FactoryWorkers.OutputADelimiter();

            Console.WriteLine(FactoryWorkers.ToWarAllTheEmploees(workers, 5));         //  раздать повестки всем работникам мужского пола
            FactoryWorkers.OutputADelimiter();
                     
        }
    }
}
