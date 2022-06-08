using System;

namespace Interface_Inheritance
{
    class Nightstand : Furniture, ITable
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Color { get; set; }
        public bool HasDrawer { get; set; }

        public void ReplaceLegs()
        {
            Console.WriteLine("Inside Night Stand Reupholster");
        }
    }
}