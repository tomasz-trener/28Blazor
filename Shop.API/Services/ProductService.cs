using Microsoft.EntityFrameworkCore;
using Shop.API.Models;
using Shop.Shared;
using Shop.Shared.Models;
using Shop.Shared.Services.ProdcutService;

namespace Shop.API.Services
{
    public class ProductService : IProductService
    {

        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }

        public Task<ServiceReponse<Product>> CreateProductServiceReponse(Product product)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceReponse<bool>> DeleteProductAsync(int id)
        {
            var result = new ServiceReponse<bool>();

            try
            {
                var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
                if (product == null)
                {
                    result.Success = false;
                    result.Message = "Product not found";
                    result.Data = true;
                }

                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
                result.Success = true;
                result.Message = "Product deleted successfully";
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"Error deleting product: {ex.Message}";
            }

            return result;
        }

        public async Task<ServiceReponse<Product>> GetProductAsync(int id)
        {
            var result = new ServiceReponse<Product>();
            try
            {
                result.Data = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
                result.Success = true;
                if (result.Data == null)
                {
                    result.Success = false;
                    result.Message = "Product not found";
                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"Error retrieving product: {ex.Message}";
            }
            return result;
        }

        public async Task<ServiceReponse<List<Product>>> GetProductsAsync()
        {
            var result = new ServiceReponse<List<Product>>();
            try
            {
                result.Data = await _context.Products.ToListAsync();
                result.Success = true;
                result.Message = "Products retrieved successfully";
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"Error retrieving products: {ex.Message}";
            }

            return result;
        }

        public Task<ServiceReponse<List<Product>>> SearchProcutsAsync(string text, int page, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceReponse<Product>> UpdateProductAsync(Product updatedProduct)
        {
            var result = new ServiceReponse<Product>();

            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == updatedProduct.Id);

            if (product == null)
            {
                result.Success = false;
                result.Message = "Product not found";
                return result;
            }

            _context.Entry(product).CurrentValues.SetValues(updatedProduct);
            //product.Name = updatedProduct.Name;
            //product.Description = updatedProduct.Description;
            //product.Price = updatedProduct.Price;
            //.....

            await _context.SaveChangesAsync();

            result.Data = product;
            result.Success = true;
            result.Message = "Product updated successfully";
            return result;
        }
    }
}
