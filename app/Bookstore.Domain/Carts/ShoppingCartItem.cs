using Bookstore.Domain.Books;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookstore.Domain.Carts
{
    [Table("ShoppingCartItem")]
    public class ShoppingCartItem : Entity
    {
        // An empty constructor is required by EF Core
        private ShoppingCartItem() { }

        public ShoppingCartItem(ShoppingCart shoppingCart, int bookId, int quantity, bool wantToBuy)
        {
            ShoppingCartId = shoppingCart.Id;
            ShoppingCart = shoppingCart;
            BookId = bookId;
            Quantity = quantity;
            WantToBuy = wantToBuy ? 1 : 0;
        }

        [Column("ShoppingCartId")]
        public int ShoppingCartId { get; set; }
        public ShoppingCart ShoppingCart { get; set; }

        [Column("BookId")]
        public int BookId { get; set; }
        public Book Book { get; set; }

        [Column("Quantity")]
        public int Quantity { get; set; }

        [Column("WantToBuy")]
        public int WantToBuy { get; set; }

        [NotMapped]
        public bool WantToBuyFlag
        {
            get => WantToBuy == 1;
            set => WantToBuy = value ? 1 : 0;
        }
    }
}
