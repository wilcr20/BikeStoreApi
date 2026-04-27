namespace BikeStoreApi.Entities.Production
{
    public class Products
    {
        public int ProductId { get; }
        public string ProductName { get; }

        public int BrandId { get; }
        public int CategoryId { get; }

        public int ModelYear { get; }
        public float ListPrice { get; }
    }
}
