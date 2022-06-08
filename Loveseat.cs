using System;

namespace Interface_Inheritance
{
    class Loveseat : Furniture, ISeating
    {
        public string Color { get; set; }
        public int Capacity { get; set; }
        public void Reupholster()
        {
            Console.WriteLine("Inside Loveseat Reupholster");
        }
    }
}