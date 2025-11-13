using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookstore.Domain.Customers
{
    [Table("Customer")]
    public class Customer : Entity
    {
        [Column("Sub")]
        public string Sub { get; set; }

        [Column("Username")]
        public string? Username { get; set; }

        [Column("FirstName")]
        public string? FirstName { get; set; }

        [Column("LastName")]
        public string? LastName { get; set; }

        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";

        [Column("Email")]
        public string? Email { get; set; }

        [Column("DateOfBirth")]
        public DateTime? DateOfBirth { get; set; }

        [Column("Phone")]
        public string? Phone { get; set; }
    }
}