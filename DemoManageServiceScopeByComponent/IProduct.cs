namespace DemoManageServiceScopeByComponent
{
    public interface IProduct :IDisposable
    {
        void AddProduct(Product product);
        List<Product> GetProducts();
    }

    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }


    public class ProductService : IProduct
    {
        public List<Product> Products { get; set; } = [];
        public void AddProduct(Product product) => Products.Add(product);

        public bool IsDispose = false;
        public void Dispose()
        {
            IsDispose = true;
        }

        public List<Product> GetProducts() => Products;
    }
}
