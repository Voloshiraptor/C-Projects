using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    public class Outsourced: Part
    {
        private string companyName;

        public Outsourced(String name, decimal price, int stock, int min, int max, String companyName) :base(name, price, stock, min, max)
        {
            this.companyName = companyName;
        }

        public string CompanyName { get => companyName; set => companyName = value; }
    }
}
