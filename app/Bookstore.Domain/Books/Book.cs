using Bookstore.Domain.ReferenceData;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookstore.Domain.Books
{
    [Table("Book")]
    public class Book : Entity
    {
        public const int LowBookThreshold = 5;

        public Book(
            string name, 
            string author, 
            string ISBN, 
            int publisherId, 
            int bookTypeId, 
            int genreId,
            int conditionId,
            decimal price,
            int quantity, 
            int? year = null,
            string? summary = null,
            string? coverImageUrl = null)
        {
            Name = name;
            Author = author;
            this.ISBN = ISBN;
            PublisherId = publisherId;
            BookTypeId = bookTypeId;
            GenreId = genreId;
            ConditionId = conditionId;
            Price = price;
            Quantity = quantity;
            Year = year;
            Summary = summary;
            CoverImageUrl = coverImageUrl;
        }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Author")]
        public string Author { get; set; }

        [Column("Year")]
        public int? Year { get; set; }

        [Column("ISBN")]
        public string ISBN { get; set; }

        public ReferenceDataItem Publisher { get; set; }
        [Column("PublisherId")]
        public int PublisherId { get; set; }

        public ReferenceDataItem BookType { get; set; }
        [Column("BookTypeId")]
        public int BookTypeId { get; set; }

        public ReferenceDataItem Genre { get; set; }
        [Column("GenreId")]
        public int GenreId { get; set; }

        public ReferenceDataItem Condition { get; set; }
        [Column("ConditionId")]
        public int ConditionId { get; set; }

        [Column("CoverImageUrl")]
        public string? CoverImageUrl { get; set; }

        [Column("Summary")]
        public string? Summary { get; set; }

        [Column("Price")]
        public decimal Price { get; set; }

        [Column("Quantity")]
        public int Quantity { get; set; }

        [Column("IsInStock")]
        public int IsInStockValue { get; set; }
        
        [NotMapped]
        public bool IsInStock 
        { 
            get => Quantity > 0; 
            set => IsInStockValue = value ? 1 : 0; 
        }

        [Column("IsLowInStock")]
        public int IsLowInStockValue { get; set; }
        
        [NotMapped]
        public bool IsLowInStock 
        { 
            get => Quantity <= LowBookThreshold; 
            set => IsLowInStockValue = value ? 1 : 0; 
        }

        public void ReduceStockLevel(int quantity)
        {
            Quantity = Math.Max(Quantity - quantity, 0);
        }
    }
}