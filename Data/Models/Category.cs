using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data.Models
{
    public class Category
    {
        public int id { get; set; }

        public string categoreName { get; set; }

        public string desc { get; set; }

        public List<Book> books { get; set; }

    }
}
