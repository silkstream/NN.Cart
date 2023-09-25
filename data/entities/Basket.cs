namespace NN.Cart.data.entities
{
    public class Basket
    {
        public long Id { get; set; }
        public long ProductId { get; set; }

        public int Quantity { get; set; }

        public int Status { get; set; }

        public virtual List<BasketItems>? BasketItems { get; set; }
    }
}
