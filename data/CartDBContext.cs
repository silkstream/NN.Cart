using Microsoft.EntityFrameworkCore;
using NN.Cart.data.entities;

namespace NN.Cart.data
{
    public class CartDBContext : DbContext
    {
        public CartDBContext(DbContextOptions<CartDBContext> options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketItems> BasketItems { get; set; }

    }
}
