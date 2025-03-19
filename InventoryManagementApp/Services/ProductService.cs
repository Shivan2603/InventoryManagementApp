using InventoryManagement.Data;
using InventoryManagement.Models;
using System.Linq;

public class ProductService
{
    private readonly DatabaseHelper _context;
    public ProductService(DatabaseHelper context)
    {
        _context = context;
    }

    public IQueryable<Product> GetFilteredProducts(string searchTerm, decimal? minPrice, decimal? maxPrice)
    {
        var query = _context.Products.AsQueryable();
        if (!string.IsNullOrEmpty(searchTerm))
            query = query.Where(p => p.Name.Contains(searchTerm) || p.Id.ToString().Contains(searchTerm));
        if (minPrice.HasValue)
            query = query.Where(p => p.Price >= minPrice.Value);
        if (maxPrice.HasValue)
            query = query.Where(p => p.Price <= maxPrice.Value);
        return query;
    }

    public void AddProduct(Product product)
    {
        _context.Products.Add(product);
        _context.SaveChanges();
    }

    public void UpdateProduct(Product product)
    {
        _context.Products.Update(product);
        _context.SaveChanges();
    }

    public void DeleteProduct(int id)
    {
        var product = _context.Products.Find(id);
        if (product != null)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }
    }
}