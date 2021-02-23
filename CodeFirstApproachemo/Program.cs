using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApproachemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ItDbContext db = new ItDbContext();
            var itemList = db.Items.ToList();
            foreach (Item temp in itemList)
            {
                Console.WriteLine(temp.Id + " " + temp.ItemName);
            }

            // Insert Records

            //char ch = 'y';
            //while (ch == 'y')
            //{

            //    try
            //    {
            //        Console.WriteLine("Enter Name");
            //        string itemName = Console.ReadLine();
            //        Console.WriteLine("Snter Qty");
            //        int qty = Convert.ToByte(Console.ReadLine());
            //        Console.WriteLine("Enter Decsription");
            //        string des = Console.ReadLine();
            //        Item item = new Item(itemName, qty, des);
            //        db.Items.Add(item);
            //        db.SaveChanges();
            //        Console.WriteLine("Do you want to insert more record");
            //        ch = (char)Console.Read();
            //    }
            //    catch(Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //    }

            //Console.WriteLine("Enter ID for which to dlete record");
            //int id ;
            //id = Convert.ToByte(Console.ReadLine());
            //Item item = db.Items.Find(id);

            //if (item != null)
            //{
            //    db.Items.Remove(item);
            //    db.SaveChanges();
            //    Console.WriteLine("Record is deleted");
            //}

            Console.WriteLine("Enter ID for which to edit record");

            int id = Convert.ToByte(Console.ReadLine());
            Item item = (from temp in db.Items
                         where temp.Id == id
                         select temp).FirstOrDefault();

            if (item != null)
            {

                db.Items.Where(x => x.Id == id).ToList()
                    .ForEach(i => i.ItemName = "Name is changed");
                db.SaveChanges();
                Console.WriteLine("Record updated");

            }
            else
            {
                Console.WriteLine("Rceord Not found");
            }
        }
    }
}