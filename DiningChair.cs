using System;

namespace Interface_Inheritance
{
    class DiningChair : Furniture, ISeating
    {
        public int Capacity { get; set; }
        public string Color { get; set; }

        public void Reupholster()
        {
            Console.WriteLine("Inside Dining Chair Reupholster");
        }
    }
}