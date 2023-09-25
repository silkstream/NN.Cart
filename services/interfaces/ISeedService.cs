using NN.Cart.data.entities;

namespace NN.Cart.services.interfaces
{
    public interface ISeedService
    {
        void SeedProducts();
        List<Product> GetProducts();


    }
}
