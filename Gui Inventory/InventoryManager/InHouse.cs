using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    public class InHouse: Part
    {
        public int machineID;

        public InHouse(String name, decimal price, int stock, int min, int max, int machineID) : base(name, price, stock, min, max)
        {
            this.machineID = machineID;
        }

        public int MachineID { get => machineID; set => machineID = value; }
    }
}
