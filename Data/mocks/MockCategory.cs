using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.interfaces;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.mocks
{
	public class MockCategory : IBooksCategory
	{
		public IEnumerable<Category> AllCategories
		{
			get
			{
				return new List<Category>
				{
					new Category { categoreName = "Dark Horse", desc = "First publishing house"},
					new Category { categoreName = "Ridna mova", desc = "Second publishing house"}
				};
			}
		}
	}
}
