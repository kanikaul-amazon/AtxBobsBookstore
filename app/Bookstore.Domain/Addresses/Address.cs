using Bookstore.Domain.Customers;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookstore.Domain.Addresses
{
    [Table("Address")]
    public class Address : Entity
    {
        // An empty constructor is required by EF Core
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private Address() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        public Address(Customer customer, string addressLine1, string? addressLine2, string city, string state, string country, string zipCode)
        {
            Customer = customer;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            CustomerId = customer.Id;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipCode;
        }

        [Column("AddressLine1")]
        public string AddressLine1 { get; set; }

        [Column("AddressLine2")]
        public string? AddressLine2 { get; set; }

        [Column("City")]
        public string City { get; set; }

        [Column("State")]
        public string State { get; set; }

        [Column("Country")]
        public string Country { get; set; }

        [Column("ZipCode")]
        public string ZipCode { get; set; }

        [Column("CustomerId")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        [Column("IsActive")]
        public int IsActive { get; set; } = 1;
        
        [NotMapped]
        public bool IsActiveFlag
        { 
            get => IsActive == 1; 
            set => IsActive = value ? 1 : 0; 
        }
    }
}