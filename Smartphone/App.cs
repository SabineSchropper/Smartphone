using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Smartphone
{
    class App
    {
        public int FunFactor { get; set; }
        public decimal StoragePlaceNeeded { get; set; }

        public string Name { get; set; }

        public App(int funFactor, decimal storagePlaceNeeded, string name)
        {
            FunFactor = funFactor;
            StoragePlaceNeeded = storagePlaceNeeded;
            Name = name;
        }

        public override string ToString()
        {
            string output = "Name: " + Name + " Spaßfaktor: " + FunFactor + " Speicherplatz: " + StoragePlaceNeeded;
            return output;
        }
        public virtual void Start()
        {
            Console.WriteLine(Name +" gestartet.");
            Thread.Sleep(1000);
            Console.WriteLine("App läuft.");
            Thread.Sleep(1000);
            Console.WriteLine("Du bist zufrieden");
            
        }
    }
}
