namespace CoureWork.Context
{
	public class Wallet
	{
		public int Id { get; set; }
		public decimal Balance { get; set; }

		public int AccountId { get; set; }
		public virtual Account Account { get; set; }
	}
}