using System.Text.Json;
using System.Text.Json.Serialization;
using Dsw2025Ej14.Api.Domain;

namespace Dsw2025Ej14.Api.Data
{
    public class PersistenciaEnMemoria : IPersistencia
    {
        protected List<Product> _producto = new ();


        public Product GetProduct (string sku)
        {
            _producto = ;

        }


        private void LoadProducts()
        {
            var json = File.ReadAllText("Data\\product.json");
            _producto = JsonSerializer.Deserialize<List<Product>>(json, new JsonSerializerOptions {
                PropertyNameCaseInsensitive = true;
            }) ?? [];
        }
    }
}
