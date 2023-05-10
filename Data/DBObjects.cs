using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.Models;

namespace WebApplication1.Data
{
	public class DBObjects
	{
		public static void Initial(AppDBContent content)
		{
			

			if (!content.Category.Any())
				content.Category.AddRange(Categories.Select(c => c.Value));

			if (!content.Book.Any())
			{
				content.AddRange(
					new Book
					{
						name = "Witcher",
						shortDesc = "Paul Tobin",
						longDesc = "A comic book about witcher's adventures",
						img = "/img/witcher.jpg",
						price = 200,
						isFavourite = true,
						available = true,
						Category = Categories["Dark Horse"]
					},
					new Book
					{
						name = "Hellboy",
						shortDesc = "Mike Mignola",
						longDesc = "A comic book about Hellboy's adventures",
						img = "/img/hellboy.jpg",
						price = 690,
						isFavourite = false,
						available = true,
						Category = Categories["Dark Horse"]
					},
					new Book
					{
						name = "Серед овець",
						shortDesc = "Олександр Корешков",
						longDesc = "A comic book about the wolf between sheeps",
						img = "/img/sered.jpg",
						price = 70,
						isFavourite = true,
						available = false,
						Category = Categories["Dark Horse"]
					},
					new Book
					{
						name = "V for Vendetta",
						shortDesc = "Alan Moore",
						longDesc = "A comic anti-utopian book",
						img = "/img/vforv.jpg",
						price = 400,
						isFavourite = true,
						available = true,
						Category = Categories["Ridna mova"]
					},
					new Book
					{
						name = "Harleen",
						shortDesc = "Stjepan Sejic",
						longDesc = "A comic book about Harley Quinn",
						img = "/img/harly.jpg",
						price = 300,
						isFavourite = false,
						available = false,
						Category = Categories["Ridna mova"]
					},
					new Book
					{
						name = "Hush",
						shortDesc = "Jim Lee",
						longDesc = "A comic book about Batman",
						img = "/img/hush.jpg",
						price = 350,
						isFavourite = false,
						available = true,
						Category = Categories["Ridna mova"]
					});
			}


			content.SaveChanges();

		}

		private static Dictionary<string, Category> category;
		public static Dictionary<string, Category> Categories
		{
			get
			{
				if(category == null)
				{
					var list = new Category[]
					{
						new Category { categoreName = "Dark Horse", desc = "First publishing house"},
						new Category { categoreName = "Ridna mova", desc = "Second publishing house"}
					};

					category = new Dictionary<string, Category>();
					foreach (Category el in list)
						category.Add(el.categoreName, el);
				}
				return category;
			}
		}
	}
}
