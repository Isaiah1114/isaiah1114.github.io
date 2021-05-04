using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CodeAndCars.Models;

namespace CodeAndCars.viewModels
{
    public class InventoryViewModel
    {
        public Inventory inventory { get; set; }
        public List<Customer> customer{ get; set; }
    }
}