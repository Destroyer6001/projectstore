using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarker
{
   
        public abstract class Product : IPay
        {
            public string Description { get; set; }
            public int Id { get; set; }
            public decimal Price { get; set; }
            public float Tax { get; set; }

            public abstract decimal ValueToPay();

            public override string ToString()
            {
                return $"{Id} - {Description}" +
                    $"\n\tTax................ :{$"{Tax:P2}",15}" +
                    $"\n\tPrice.............. :{$"{Price:C2}",15}";
            }
        }
    
}
