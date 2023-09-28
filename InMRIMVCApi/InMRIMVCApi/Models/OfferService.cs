using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InMRIMVCApi.Models
{
    public class OfferService
    {
        private List<Product> Inventory { get; set; }

        private void AddInventory()
        {
            var products = new Product("P1", 1000, "P1 desc");
                           new Product("P2", 200, "P2 desc");
                           new Product("P3", 400, "P3 desc");
                            new Product("P4", 700, "P4 desc");
                            new Product("P5", 600, "P5 desc");
                            new Product("P6", 800, "P6 desc");


            Inventory.Add(products);
        }
    }
}