// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics.SymbolStore;
using System.Reflection.Metadata.Ecma335;
using Worker;

public class FactoryWorkers
{
    public static Person[] ArrayElementInitialization(byte numberOfArrayElements, string name, string lastName, byte age, char sex, byte skillLevel, byte absenseFromWorkInDays, Boolean fired, Boolean poluchilPovestku)
    {
        Person[] a = new Person[numberOfArrayElements];                              // array elements initialization method
        for (byte i = 0; i < numberOfArrayElements; i++)
        {
            a[i] = new Person(name, lastName, age, sex, skillLevel, absenseFromWorkInDays, fired, poluchilPovestku);
        }
        return a;
    }

    public static void OuptufOfArayLength(String displayedComment, Person[] a)   // output an array length (number of workers)
    {
        Console.WriteLine(displayedComment + ' ' + a.Length);
    }

    public static void OuptutADelimiter()                         // output of row delimiter
    {
        Console.WriteLine("************************");
        Console.WriteLine();
    }

    public static string OutputWorkerData(Person worker)
    {
        return "Imya sotrudnika: " + worker.GetName() + "\nFamiliya sotrudnika: " + worker.GetLastName() + "\nVosrast sotrudnika: " + worker.GetAge() +
            "\nPol sotrudnika: " + worker.GetSex() + "\nRazriad sotrudnika: " + worker.GetSkillLevel() + "\nKolichestvo dniej progulov sotrudnika: " + worker.GetAbsenseFromWorkInDays() +
            "\nUvolen: " + worker.IsFired() + "\nPoluchil povestku: " + worker.GetPoluchilPovestkuValue();       
    }

}