using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Smartphone
{
    class Game : App
    {
        public new string Name { get; set; }
        public decimal Price { get; set; }

        public bool IsFamilySafe { get; set; }

        public Game(string name, decimal price, bool isFamilySafe, int funFactor, decimal storagePlaceNeeded) : base(funFactor,storagePlaceNeeded,name)
        {
            Name = name;
            Price = price;
            IsFamilySafe = isFamilySafe;
        }

        public override string ToString()
        {
            string output = "Game: " + Name + " Price: " + Price + " FamilySafe: " + IsFamilySafe;
            return output; 
        }
        public override void Start()
        {
            Console.WriteLine(Name + " gestartet.");
            Thread.Sleep(1000);
            Console.WriteLine("Spiel läuft.");
            Thread.Sleep(1000);
            Console.WriteLine("Du hast mega viel Spaß");

        }
    }
}
