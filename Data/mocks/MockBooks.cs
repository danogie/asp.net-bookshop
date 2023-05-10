using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.interfaces;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.mocks
{
	public class MockBooks : IAllBooks
	{
		private readonly IBooksCategory _categoryBooks = new MockCategory();


		public IEnumerable<Book> Books 
		{
			get
			{
				return new List<Book>
				{
					new Book {name = "Witcher",
						shortDesc = "Paul Tobin",
						longDesc = "A comic book about witcher's adventures",
						img = "/img/witcher.jpg",
						price = 200,
						isFavourite = true,
						available = true,
						Category = _categoryBooks.AllCategories.First()
					},
					new Book {name = "Hellboy",
						shortDesc = "Mike Mignola",
						longDesc = "A comic book about Hellboy's adventures",
						img = "/img/hellboy.jpg",
						price = 690,
						isFavourite = false,
						available = true,
						Category = _categoryBooks.AllCategories.First()
					},
					new Book {name = "Серед овець",
						shortDesc = "Олександр Корешков",
						longDesc = "A comic book about the wolf between sheeps",
						img = "/img/sered.jpg",
						price = 70,
						isFavourite = true,
						available = false,
						Category = _categoryBooks.AllCategories.First()
					},
					new Book {name = "V for Vendetta",
						shortDesc = "Alan Moore",
						longDesc = "A comic anti-utopian book",
						img = "/img/vforv.jpg",
						price = 400,
						isFavourite = true,
						available = true,
						Category = _categoryBooks.AllCategories.Last()
					},
					new Book {name = "Harleen",
						shortDesc = "Stjepan Sejic",
						longDesc = "A comic book about Harley Quinn",
						img = "/img/harly.jpg",
						price = 300,
						isFavourite = false,
						available = false,
						Category = _categoryBooks.AllCategories.Last()
					},
					new Book {name = "Hush",
						shortDesc = "Jim Lee",
						longDesc = "A comic book about Batman",
						img = "/img/hush.jpg",
						price = 350,
						isFavourite = false,
						available = true,
						Category = _categoryBooks.AllCategories.Last()
					},
				};
			}
		}
		public IEnumerable<Book> getFavBooks { get; set; }

		public Book getObjectBook(int bookId)
		{
			throw new NotImplementedException();
		}
	}
}
