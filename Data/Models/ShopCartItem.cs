using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data.Models
{
    public class ShopCartItem
    {
        public int id { get; set; }
        public Book book { get; set; }
        public int price { get; set; }

        public string ShopCatrId { get; set; }


    }
}
