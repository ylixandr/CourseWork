using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoureWork.Context
{
	public class CartDetail
	{
		public int CartId { get; set; }
		public string CategoryName { get; set; }
		public string ProductName { get; set; }
		public DateTime PurchaseDate { get; set; }
		public decimal ProductPrice { get; set; }
	}
}
