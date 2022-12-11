using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store.Entities.DBase
{
    public class request: Product
    {
        public DateTime DateOfCreation { get; set; }
        public DateTime PlanDateOfCompletion { get; set; }
        public DateTime DateOfCompletion { get; set; }

        public static double TotalPrice;

        public static List<request> sas = new List<request>();

        public static int ProductCount = 0;

        public static void CountTotalPrice()
        {
            TotalPrice = 0;
            foreach (var e in sas)
            {
                TotalPrice += e.ProductPrice;
            }
        }

    }
}
