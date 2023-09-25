using NN.Cart.data;
using NN.Cart.data.entities;
using NN.Cart.services.interfaces;
using System.Collections.Specialized;
namespace NN.Cart.services
{
    public class SeedService :ISeedService
    {
        protected readonly CartDBContext _cartDBContext;

        public SeedService(CartDBContext cartDBContext) 
        {
             _cartDBContext = cartDBContext;    
        } 
        public void SeedProducts()
        {
            var productItem = new List<Product>();
            productItem.Add(new Product() {Name="Blue Jersey",Price=150,Category="Clothing",Description="A blue woolen Jersey" });
            productItem.Add(new Product() { Name = "Red Jersey", Price = 150, Category = "Clothing", Description = "A red woolen Jersey" });
            productItem.Add(new Product() { Name = "Green Jersey", Price = 150, Category = "Clothing", Description = "A green woolen Jersey" });
            productItem.Add(new Product() { Name = "Yellow Jersey", Price = 150, Category = "Clothing", Description = "A yellow woolen Jersey" });

            _cartDBContext.Products.AddRange(productItem);
            _cartDBContext.SaveChanges();

        }
        public List<Product> GetProducts()
        {
            var products = _cartDBContext.Products.ToList();
            return products;


        }
    }
}
