using System;
using System.Collections.Generic;

namespace Interface_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ISeating> seats = new List<ISeating>();
            Couch c = new Couch();
            Loveseat l = new Loveseat();
            DiningChair dc = new DiningChair();

            seats.Add(c);
            seats.Add(l);
            seats.Add(dc);

            foreach (var seatObj in seats)
            {
                seatObj.Reupholster();
            }

            List<ITable> tables = new List<ITable>();
            DiningTable dt = new DiningTable();
            Nightstand nst = new Nightstand();

            tables.Add(dt);
            tables.Add(nst);

            foreach (var tableObj in tables)
            {
                tableObj.ReplaceLegs();
            }

            List<Furniture> myFurniture = new List<Furniture>();
            myFurniture.Add(c);
            myFurniture.Add(l);
            myFurniture.Add(dc);
            myFurniture.Add(dt);
            myFurniture.Add(nst);

            //myFurniture.AddRange(tables);

            Console.WriteLine();

            foreach (var fObj in myFurniture)
            {
                if (fObj is ISeating)
                {
                    ISeating s = (ISeating)fObj;
                    s.Reupholster();
                }

                // if (fObj is ISeating)
                // {
                //     ((ISeating)fObj).Reupholster();
                // }
            }

            foreach (var fObj in myFurniture)
            {
                if (fObj is ITable)
                {
                    ((ITable)fObj).ReplaceLegs();
                }
            }
        }
    }
}
