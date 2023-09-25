namespace NN.Cart.data.entities
{
    public class BasketItems
    {
        public long Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? Image { get; set; }


        public int Status { get; set; }

        public virtual Basket? Basket { get; set; }

    }
}
