using Bogus;
using Shop.Shared.Models;

namespace Shop.DataSeeder
{
    public class ProductsDataSeeder
    {
        public static List<Product> GenerateProductsData()
        {
            var productsFaker = new Faker<Product>("pl") // język polski nie obslugiwany dla wszystkich danych
                .UseSeed(123456) // seed dla powtarzalności
                .RuleFor(p => p.Id, f => f.IndexFaker + 1) // indeksowanie zaczyna się od 0
                .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                .RuleFor(p => p.Price, f => f.Random.Double(1, 1000))
                .RuleFor(p => p.Description, f => f.Commerce.ProductDescription())
                .RuleFor(p => p.Barcode, f => f.Commerce.Ean13())
                .RuleFor(p => p.CreatedDate, f => f.Date.Past());

            var products = productsFaker.Generate(100);
            return products;
        }
    }
}
