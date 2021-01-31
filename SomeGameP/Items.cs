using SomeGameP.Ops;
using System;
using System.Collections.Generic;
using System.Text;
using SomeGameP.Props;

namespace SomeGameP
{
    class Items:IItemManager
    {
        //      bunch of over thought items below haha
        IItem tenDC = new IItem { Id = 1, ItemName = "50 Dragon Coin", ItemID = 1, ItemPrice = 25 };
        IItem hundDC = new IItem { Id = 2, ItemName = "100 Dragon Coin (Popular)", ItemID = 1, ItemPrice = 45 };
        IItem ecoDC = new IItem { Id = 3, ItemName = "200 Dragon Coin (Economic)", ItemID = 1, ItemPrice = 85 };
        IItem megaDC = new IItem { Id = 4, ItemName = "500 Dragon Coin (MEGA %30 OFF)", ItemID = 1, ItemPrice = 175 };
        IItem wingsuit = new IItem { Id = 5, ItemName = "WingSuit", ItemID = 2, ItemPrice = 100 };
        IItem bookoftips = new IItem { Id = 6, ItemName = "Book of Best Tips", ItemID = 3, ItemPrice = 300 };




        public void ListItems()
        {
            List<IItem> itemss = new List<IItem>() { tenDC, hundDC, ecoDC, megaDC, wingsuit, bookoftips };
            Console.WriteLine("Marketteki ürünlerin listesi:");
            Console.WriteLine();
            foreach (var x in itemss)
            {
                Console.WriteLine();
                Console.WriteLine(x.ItemName);
                Console.WriteLine(x.ItemPrice + " TL");
                Console.WriteLine("_____________________________________");
            }
            Console.WriteLine("*Liste sonu*");
        }




        public void Add(IItem item)
        {
            Console.WriteLine(item.ItemName + " adlı ürün sepetinize eklendi.");
        }
        public void Discard(IItem item)
        {
            Console.WriteLine(item.ItemName + " adlı ürün sepetinizden çıkarıldı.");
        }
    }
}