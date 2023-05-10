﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.interfaces
{
    public interface IAllBooks
    {
        IEnumerable<Book> Books { get;}
        IEnumerable<Book> getFavBooks { get; }
        Book getObjectBook(int bookId);
    }
}
