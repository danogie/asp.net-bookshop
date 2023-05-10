using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.interfaces;
using WebApplication1.Data.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Data.Controllers{
	public class BooksController : Controller{
		private readonly IAllBooks _allBooks;
		private readonly IBooksCategory _allCategories;

		public BooksController(IAllBooks iAllBooks, IBooksCategory iBooksCat)
		{
			_allBooks = iAllBooks;
			_allCategories = iBooksCat;
		}

		[Route("Books/List")]
		[Route("Books/List/{category}")]

		public ViewResult List(string category)
		{
			string _category = category;
			IEnumerable<Book> books = null;
			string currCategory = "";
			if(string.IsNullOrEmpty(category))
			{
				books = _allBooks.Books.OrderBy(i => i.id);
			}
			else
			{
				if(string.Equals("first", category, StringComparison.OrdinalIgnoreCase))
				{
					books = _allBooks.Books.Where(i => i.Category.categoreName.Equals("Dark Horse")).OrderBy(i => i.id);
					currCategory = "Dark Horse publishing house";
				}
				else if (string.Equals("second", category, StringComparison.OrdinalIgnoreCase))
				{
					books = _allBooks.Books.Where(i => i.Category.categoreName.Equals("Ridna mova")).OrderBy(i => i.id);
					currCategory = "Ridna mova publishing house";
				}
			}
			var bookObj = new BooksListViewModel
			{
				allBooks = books,
				currCategory = currCategory
			};


			ViewBag.Title = "cosmic page"; 
			//BooksListViewModel obj = new BooksListViewModel();
			//obj.allBooks = _allBooks.Books;
			//obj.currCategory = "Комікси";

			return View(bookObj);
		}

	}
}
