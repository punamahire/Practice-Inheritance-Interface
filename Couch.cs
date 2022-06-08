using System;

namespace Interface_Inheritance
{
    class Couch : Furniture, ISeating
    {
        public int Capacity { get; set; }
        public string Color { get; set; }
        public string CushionFilling { get; set; }

        public void Reupholster()
        {
            Console.WriteLine("Inside Couch Reupholster");
        }
    }
}