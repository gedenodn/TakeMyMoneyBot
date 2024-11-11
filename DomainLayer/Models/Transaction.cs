using System;
namespace DomainLayer.Models
{
    public class Transaction
    {
        public Guid TransactionId { get; set; }
        public Guid UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public decimal Amount { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public DateTime TransactionDate { get; set; }
        public string? Description { get; set; }
    }
}

