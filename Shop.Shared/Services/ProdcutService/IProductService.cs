using Shop.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Shared.Services.ProdcutService
{
    public interface IProductService
    {
        Task<ServiceReponse<List<Product>>> GetProductsAsync();
        Task<ServiceReponse<Product>> GetProductAsync(int id);
        Task<ServiceReponse<Product>> CreateProductService(Product product);
        Task<ServiceReponse<Product>> UpdateProductAsync(Product product);
        Task<ServiceReponse<bool>> DeleteProductAsync(int id);

        Task<ServiceReponse<List<Product>>> SearchProcutsAsync(string text, int page, int pageSize);
    }
}
