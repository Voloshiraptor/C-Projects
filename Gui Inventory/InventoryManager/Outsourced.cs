using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    class Outsourced: Part
    {
        private string companyName;

        public string CompanyName { get => companyName; set => companyName = value; }
    }
}
