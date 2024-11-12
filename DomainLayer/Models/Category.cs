using System;
namespace DomainLayer.Models
{
	public class Category
	{
		public Guid CategoryId { get; set; }
		public string CategoryName { get; set; }
		public ICollection<ApplicationUser> Users { get; set; }
        public ICollection<Transaction> Transactions { get; set; }

    }
}

