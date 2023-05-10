using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data.Models
{
	public class Order
	{

		[BindNever]
		public int id { get; set; }

		[Display(Name = "Enter your name")]
		[StringLength(25)]
		[Required(ErrorMessage = "Lenght of your name is less than 6 sembols")]
		public string name { get; set; }

		[Display(Name = "Enter your surname")]
		[StringLength(25)]
		[Required(ErrorMessage = "Lenght of your surname is less than 6 sembols")]
		public string surname { get; set; }

		[Display(Name = "Enter your adress")]
		[StringLength(25)]
		[Required(ErrorMessage = "Lenght of your adress is less than 15 sembols")]
		public string adress { get; set; }

		[Display(Name = "Enter your phone")]
		[DataType(DataType.PhoneNumber)]
		[StringLength(10)]
		[Required(ErrorMessage = "Lenght of your phone is less than 10 sembols")]
		public string phone { get; set; }

		[Display(Name = "Enter your email")]
		[DataType(DataType.EmailAddress)]
		[StringLength(25)]
		[Required(ErrorMessage = "Lenght of your email is less than 10 sembols")]
		public string email { get; set; }

		[BindNever]
		[ScaffoldColumn(false)]
		public DateTime orderTime { get; set; }

		public List<OrderDetail> orderDetails { get; set; }

	}
}
