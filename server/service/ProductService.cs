namespace service;

public class ProductService
{

    public List<Product> MyProducts = new List<Product>();
    
    public List<Product> GetProducts()
    {
        return MyProducts;
    }

    public Product CreateProduct(Product product)
    {
        
        MyProducts.Add(product);
        return product;
    }
}