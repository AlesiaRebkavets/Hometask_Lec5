﻿// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics.SymbolStore;
using System.Reflection.Metadata.Ecma335;
using Worker;

public class FactoryWorkers
{
    public static Person[] ArrayElementInitialization(byte numberOfArrayElements, string name, string lastName, byte age, char sex, byte skillLevel, byte absenseFromWorkInDays, bool fired, bool poluchilPovestku)
    {
        Person[] a = new Person[numberOfArrayElements];                              // array elements initialization method
        for (byte i = 0; i < numberOfArrayElements; i++)
        {
            a[i] = new Person(name, lastName, age, sex, skillLevel, absenseFromWorkInDays, fired, poluchilPovestku);
        }
        return a;
    }

    public static void OuptufOfArayLength(string displayedComment, Person[] a)   // output an array length (number of workers)
    {
        Console.WriteLine(displayedComment + ' ' + a.Length);
    }

    public static void OutputADelimiter()                         // output of row delimiter
    {
        Console.WriteLine("************************");
        Console.WriteLine();
    }

    public static string OutputSingleWorkerData(Person worker)        // returns personal data of the specific worker for further output in console
    {
        return "Imya sotrudnika: " + worker.GetName() + "\nFamiliya sotrudnika: " + worker.GetLastName() + "\nVosrast sotrudnika: " + worker.GetAge() +
            "\nPol sotrudnika: " + worker.GetSex() + "\nRazriad sotrudnika: " + worker.GetSkillLevel() + "\nKolichestvo dniej progulov sotrudnika: " + worker.GetAbsenseFromWorkInDays() +
            "\nUvolen: " + worker.IsFired() + "\nPoluchil povestku: " + worker.GetPoluchilPovestkuValue();       
    }

    public static string OutputWorkersData(Person[] workers, byte numberOfArrayElements)      // returns personal data all the workers for further output in console
    {
        string s = "";
        for (byte i = 0; i < numberOfArrayElements; i++)
        {
            s += OutputSingleWorkerData(workers[i]) + "\n************************" + "\n";
        }
        return s;
    }

    public static string DismissASingleEmploee(Person worker)                           // fire an emploee if AbsenseFromWorkInDays is not null and return the worker's data
    {
        worker.Fire(worker.GetAbsenseFromWorkInDays());
        if (worker.IsFired())
        {
            return "Sotrudnik " + worker.GetLastName() + " " + worker.GetName() + " uvolen za " + worker.GetAbsenseFromWorkInDays() + " dniej progula"; ;
        }
        else return "Sotrudnik " + worker.GetLastName() + " " + worker.GetName() + " nie uvolen, progulov " + worker.GetAbsenseFromWorkInDays() + " dniej";
    }

    public static string DismissEmploees(Person[] workers, byte numberOfArrayElements)    // fire all the emploees if theis AbsenseFromWorkInDays is not null and return the workers' data
    {
        string s = "";
        for (byte i = 0; i < numberOfArrayElements; i++)
        {
            s += DismissASingleEmploee(workers[i]) + "\n";
        }
        return s;
    }

    public static string ToWarASingleEmploee(Person worker)                                                    // выдает повестку одному работнику мужского пола и возвращает его имя
    {
         worker.Voenkom(worker.GetSex());
         if (worker.GetPoluchilPovestkuValue())
         {
         return "Sotrudnik " + worker.GetLastName() + " " + worker.GetName() + " poluchil povestku ";
         } else return "Sotrudnica " + worker.GetLastName() + " " + worker.GetName() + " nie poluchila povestku. Poka chto. ";

    }

    public static string ToWarAllTheEmploees(Person[] workers, byte numberOfArrayElements)                       // выдает повестки всем работникам мужского пола и возвращает их имена
    {
        string s = "";
        for (byte i = 0; i < numberOfArrayElements; i++) 
        { 
            s += ToWarASingleEmploee(workers[i]) + "\n";
        }
        return s;
    }

}