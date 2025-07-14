using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    public class Car
    {
        public string carmodel;
        public int year;
        public string color;
        public string company;       
    }

    public class Elecricalcar : Car
    {
        public Elecricalcar(string a, int b, string c, string d)
        {
            Console.WriteLine($"It is Electrical car {a} carmodel ,{b} year released, {c} color, {d} company");
        }

        public virtual void batterytime()
        {
            Console.WriteLine("It is 1 hr time");
        }
        public void isfastcharging()
        {
            Console.WriteLine("it is fast charging");
        }
    }

    public class Hybridcar : Car
    {
        public Hybridcar(string a, int b, string c, String d)
        {
            Console.WriteLine($"It is Hybrid car {a} carmodel ,{b} year released, {c} color, {d} company ");
        }

        Elecricalcar ec = new Elecricalcar("lastest model", 2022, "Black", "Ford");

        public void Hybridcarfeature()
        {
            ec.batterytime();
            ec.isfastcharging();
        }

        public virtual void petrolengine()
        {
            Console.WriteLine("It can run in petrol engine");
        }

        public virtual void disalengine()
        {
            Console.WriteLine("it can run in desel engine");
        }
    }


    public class Combustiontype : Car
    {
        public Combustiontype(string a, int b, string c, string d)
        {
            Console.WriteLine($"It is Combustion type {a} carmodel ,{b} year released, {c} color, {d} company");
        }

        Hybridcar hc = new Hybridcar("oldest model", 2004, "Blue", "Suzi");

        public void combustiontypefeature()
        {
            hc.petrolengine();
            hc.disalengine();

        }
    }
}
