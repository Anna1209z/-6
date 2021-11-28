using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лб_6
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Оберiть формат файлу: 1)TXT 2)DOC 3)XML");
                int choose = Convert.ToInt32(Console.ReadLine());
                Realisation realisation = new Realisation();
                if (choose == 1)
                {
                    realisation.FormatName = "TXT";
                    realisation.AllOperations();
                }
                else if (choose == 2)
                {
                    realisation.FormatName = "DOC";
                    realisation.AllOperations();
                }
                else if (choose == 3)
                {
                    realisation.FormatName = "XML";
                    realisation.AllOperations();
                }
                else
                {
                    Console.WriteLine("Неправильно введена iнформацiя");
                }
                Console.ReadKey();
            }
        }

    }
    abstract class AbstractHandler
    {
        public abstract void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();
    }
    class Realisation : AbstractHandler
    {
        public string FormatName { get; set; }
        public override void Create()
        {
            Console.WriteLine($"Створення {FormatName} документу");
        }
        public override void Open()
        {
            Console.WriteLine($"Вiдкриття {FormatName} документу");
        }
        public override void Change()
        {
            Console.WriteLine($"Внесення змiн до {FormatName} документу");
        }
        public override void Save()
        {
            Console.WriteLine($"Зберiгання {FormatName} документу");
        }
        public void AllOperations()
        {
            Create();
            Open();
            Change();
            Save();
        }
    }
}
