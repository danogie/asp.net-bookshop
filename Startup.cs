using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApplication1.Data;
using WebApplication1.Data.interfaces;
using WebApplication1.Data.mocks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data.Repository;
using WebApplication1.Data.Models;

namespace WebApplication1
{
	public class Startup
	{
		private IConfigurationRoot _confSting;

		public Startup(IHostingEnvironment hostEnv)
		{
			_confSting = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
		}



		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confSting.GetConnectionString("DefaultConnection")));
			services.AddTransient<IAllBooks, BookRepository>();
			services.AddTransient<IBooksCategory, CategoryRepository>();
			services.AddTransient<IAllOrders, OrdersRepository>();

			services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
			services.AddScoped(sp => ShopCart.GetCart(sp));

			services.AddMvc();

			services.AddMemoryCache();
			services.AddSession();

		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			app.UseRouting();
			app.UseDeveloperExceptionPage();
			app.UseStatusCodePages();
			app.UseStaticFiles();
			app.UseSession();
			//app.UseMvcWithDefaultRoute();
			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
				endpoints.MapControllerRoute("categoryFilter", "{controller=Book}/{action}/{category?}", defaults: new { Controller="Book", action="List"});
			});


			using (var scope = app.ApplicationServices.CreateScope())
			{
				AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
				DBObjects.Initial(content);
			}

		}
	}
}
