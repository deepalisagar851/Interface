using System;

namespace Interface
{
    interface IEmployee
    {
        void show();

    }
    class PartTimeEmployees:IEmployee
    {
        public void show()
        {
            Console.WriteLine("This is method of IEmployee Interface");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PartTimeEmployees pte = new PartTimeEmployees();
            pte.show();
            Console.ReadLine();
        }
    }
}
