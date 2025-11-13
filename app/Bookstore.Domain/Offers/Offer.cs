using Bookstore.Domain.Customers;
using Bookstore.Domain.ReferenceData;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookstore.Domain.Offers
{
    [Table("Offer")]
    public class Offer : Entity
    {
        public Offer(
            int customerId,
            string bookName,
            string author,
            string ISBN,
            int bookTypeId,
            int conditionId,
            int genreId,
            int publisherId,
            decimal bookPrice)
        {
            CustomerId = customerId;
            BookName = bookName;
            Author = author;
            this.ISBN = ISBN;
            BookTypeId = bookTypeId;
            ConditionId = conditionId;
            GenreId = genreId;
            PublisherId = publisherId;
            BookPrice = bookPrice;
        }

        [Column("Author")]
        public string Author { get; set; }

        [Column("ISBN")]
        public string ISBN { get; set; }

        [Column("BookName")]
        public string BookName { get; set; }

        [Column("FrontUrl")]
        public string? FrontUrl { get; set; }

        public ReferenceDataItem Genre { get; set; }
        [Column("GenreId")]
        public int GenreId { get; set; }

        public ReferenceDataItem Condition { get; set; }
        [Column("ConditionId")]
        public int ConditionId { get; set; }

        public ReferenceDataItem Publisher { get; set; }
        [Column("PublisherId")]
        public int PublisherId { get; set; }

        public ReferenceDataItem BookType { get; set; }
        [Column("BookTypeId")]
        public int BookTypeId { get; set; }

        [Column("Summary")]
        public string? Summary { get; set; }

        [Column("OfferStatus")]
        public OfferStatus OfferStatus { get; set; } = OfferStatus.PendingApproval;

        [Column("Comment")]
        public string? Comment { get; set; }

        public Customer Customer { get; set; }
        [Column("CustomerId")]
        public int CustomerId { get; set; }

        [Column("BookPrice")]
        public decimal BookPrice { get; set; }
    }
}