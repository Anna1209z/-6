using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3


{
    class Program
    {
        static void Main(string[] args)
        {
            Realisation realisation = new Realisation();
            realisation.Name = "Тритатушечки";
            realisation.All();
            Console.ReadKey();
        }
    }
    abstract class Document
    {
        public abstract void Headline(); 
        public abstract void DocumentContent();

        public abstract void Footer();

    }
    class Realisation : Document
    {
        public string Name { get; set; }
        public override void Headline()
        {
            Console.WriteLine($"Це назва книги:{Name}");
        }
        public override void DocumentContent()
        {
            Console.WriteLine("Змiст");
        }
        public override void Footer()
        {
            Console.WriteLine("Iнформацiя про автора");
        }
        public void All()
        {
            Headline();
            DocumentContent();
            Footer();
        }
    }
}
