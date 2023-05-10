using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.interfaces;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.Repository
{
	public class CategoryRepository : IBooksCategory
	{
		private readonly AppDBContent appDBContent;

		public CategoryRepository(AppDBContent appDBContent)
		{
			this.appDBContent = appDBContent;
		}


		public IEnumerable<Category> AllCategories => appDBContent.Category; 
	}
}
