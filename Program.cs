using System;

namespace AlgoritmaTasarimi.Temeller
{
    public class kisi
    {
        public kisi()
        {
        }

        public kisi(string adi)
        {
            Adi = adi;
        }

        public kisi(string adi, int yas)
        {
            Adi = adi;
            Yas = yas;
        }

        public string Adi { get; set; }
        public int Yas { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            kisi k = new kisi("Ahmet", 18);
            Console.WriteLine(k.Adi + ":" + k.Yas);
        }
    }
}

