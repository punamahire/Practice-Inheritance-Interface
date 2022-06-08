using System;

namespace Interface_Inheritance
{
    interface ISeating
    {
        int Capacity { get; set; }

        void Reupholster();
    }
}