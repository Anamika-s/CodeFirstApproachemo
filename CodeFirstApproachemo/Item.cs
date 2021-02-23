using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApproachemo
{
    class Item
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public int Qty { get; set; }
        public string Description { get; set; }
        public string VendorName { get; set; }
        public Item() { }
        public Item(string itemName , int qty , string des)
        {
            this.ItemName = itemName;
            this.Qty = qty;
            this.Description = des;

        }
    }

    class ItDbContext : DbContext
    {
        //public ItemsDbContext()
        //{

        //}

        public DbSet<Item> Items { get; set; }
    }
}
