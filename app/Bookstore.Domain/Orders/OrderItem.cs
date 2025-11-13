using Bookstore.Domain.Books;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookstore.Domain.Orders
{
    [Table("OrderItem")]
    public class OrderItem : Entity
    {
        // This private constructor is required by EF Core
        private OrderItem() { }

        public OrderItem(Order order, Book book, int quantity)
        {
            OrderId = order.Id;
            Order = order;
            BookId = book.Id;
            Book = book;
            Quantity = quantity;
        }

        [Column("OrderId")]
        public int OrderId { get; set; }
        public Order Order { get; set; }

        [Column("BookId")]
        public int BookId { get; set; }
        public Book Book { get; set; }

        [Column("Quantity")]
        public int Quantity { get; set; }
    }
}