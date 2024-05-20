using System;

namespace CoureWork.Context
{
	public class Cart
	{
		public int Id { get; set; }
		public int AccountId { get; set; }
		public int ProductId { get; set; }
		public int CategoryId { get; set; }
		public DateTime PurchaseDate { get; set; }
		public decimal ProductPrice { get; set; }
		public int Quantity { get; set; }
		public string ProductType { get; set; }
		public string ProductName { get; set; }
		public virtual Account Account { get; set; }
	}
}