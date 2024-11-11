namespace DomainLayer.Models
{
	public class ApplicationUser
	{
		public Guid UserId { get; set; }
		public string TelegramUserId { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
		public DateTime CreatedDate { get; set; }
		public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
		// 111
	}
}

