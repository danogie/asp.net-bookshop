using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.Models;

namespace WebApplication1.ViewModels
{
	public class BooksListViewModel
	{
		public IEnumerable<Book> allBooks { get; set; }
		
		public string currCategory { get; set; }

	}
}
