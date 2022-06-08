using System;

namespace Interface_Inheritance
{
    class DiningTable : Furniture, ITable
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Shape { get; set; }
        public void ReplaceLegs()
        {
            Console.WriteLine("Inside Dining Table Reupholster");
        }
    }
}