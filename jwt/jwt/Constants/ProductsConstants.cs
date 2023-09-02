using jwt.Models;

namespace jwt.Constants
{
    public class ProductsConstants
    {
        public static List<ProductsModel> Products = new List<ProductsModel> 
        {
            new ProductsModel(){Name="Coca Cola",Description="Bebida con gas"}, 
            new ProductsModel(){Name="Agua Cielo",Description="Agua mineral de 2L"} 
        };
    }
}
