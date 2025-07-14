using practice;
using System;
using static practice.Car;
using static System.Net.Mime.MediaTypeNames;

namespace practice;

class Program
{
    public static void Main(string[] args)
    {
        //properties
        Test1 properties = new Test1();
        properties.marks = 35;
        properties.marks = 22;
        Console.WriteLine(properties.marks);


        //inheritance
        Dog d = new Dog();
        d.name = "abc dog";
        d.age = 1;
        Console.WriteLine($"The dog name is :{d.name} and age is : {d.age}");
        d.Speak();

        Cat c = new Cat();
        c.name = "abc cat";
        c.age = 2;
        Console.WriteLine($"The cat name is :{c.name} and age is : {c.age}");
        c.Speak();

        Hen h = new Hen();
        h.Fly();
        h.Speak();

        Peackok p = new Peackok();
        p.parts(2, "Male");

        Anotherpeackok ap = new Anotherpeackok();
        ap.parts("Female", 2, 22);
        ap.showliving();

        Company example = new Company();
        Console.WriteLine(example.name);


        //List 
        List<Company> com = new List<Company>
        {
            new Company
            {
                name="A type",
                description="cse",
                age=1,
            },

            new Company
            {
                name="B type",
                description="mech",
                age=2,
            },

            new Company
            {
                name="C type",
                description="eee",
                age=3,
            },
        };

        foreach (var details in com)
        {
            Console.WriteLine(details.name);
            Console.WriteLine(details.description);
        }



        //swap
        int a = 10;
        int b = 20;

        Console.WriteLine("Before Swap:");
        Console.WriteLine($"a = {a}, b = {b}");

        Test4.swap(a, b);



        //patterns -> for
        int rows = 3;
        int stars = 1; 

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= stars; j++)
            {
                Console.Write("* ");
            }

            Console.WriteLine();
            stars += 2; 
        }


        //composition method
        Elecricalcar ec = new Elecricalcar("lastest model", 2022, "Black", "Ford");
        ec.batterytime();
        ec.isfastcharging();
        Console.WriteLine();

        Hybridcar hc = new Hybridcar("oldest model", 2008, "Blue", "Suzi");
        hc.Hybridcarfeature();
        hc.petrolengine();
        hc.disalengine();
        Console.WriteLine();

        Combustiontype ct = new Combustiontype("oldest model", 2004, "white", "audi");
        ct.combustiontypefeature();
        Console.WriteLine();



        //Abstract class

        AbstractCar ac;
        ac = new Ford();
        ac.year = 2020;
        ac.Start();

        ac = new Toyota();
        ac.year = 2021;
        ac.Start();

        ac = new Benz();
        ac.year = 2022;
        ac.Start();
    }
};



   
