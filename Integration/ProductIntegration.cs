using System.Net.Http.Json;
using Integration.Base;
using Integration.ViewModel;

namespace Integration;

public class ProductIntegration : IntegrationBase
{
    private static string _url = BaseUrl + "products";
    
    protected static string URL => _url;

    public static ProductViewModel? Get(HttpClient httpClient)
    {
        Task<ProductViewModel?> task = httpClient.GetFromJsonAsync<ProductViewModel>(URL);
        ProductViewModel? result = task.Result;
        return result;
    } // End of  method Get.
    
} // End of class ProductIntegration.