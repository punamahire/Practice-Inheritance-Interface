using System;

namespace Interface_Inheritance
{
    interface ITable
    {
        int Length { get; set; }
        int Width { get; set; }
        int Height { get; set; }
        void ReplaceLegs();
    }
}