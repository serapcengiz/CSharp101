using System;
namespace csharpconsole
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("İsminizi Girin");
            string name =Console.ReadLine();
            Console.WriteLine("Soyadınızı Girin");
            string surname =Console.ReadLine();
            Console.WriteLine("Merhaba"+name +" "+surname);
        }
    }
}
