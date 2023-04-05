using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tugas_PlaneTicket;

namespace tugas_planetiket
{
    class Program
    {
        static void Main(string[] args)
        {
            PlaneTicket ticket1 = new PlaneTicket();
            PlaneTicket ticket2 = new PlaneTicket();

            ticket1.Origin = "Jogja";
            ticket1.Destination = "YIA";
            ticket1.Cost = 650000;
            ticket1.Currency = "IDR";

            ticket2.Origin = "Solo";
            ticket2.Destination = "PKU";
            ticket2.Cost = 250;
            ticket2.Currency = "USD";

            ticket1.PrintSummary();
            Console.WriteLine();
            ticket2.PrintSummary();
            Console.ReadKey();
        }
    }
}