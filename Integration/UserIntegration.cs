using System.Net.Http.Json;
using Integration.Base;
using Integration.ViewModel;


namespace Integration;

public class UserIntegration : IntegrationBase
{
    private static string _url = BaseUrl + "users"; 
    
    protected static string URL => _url;

    public static UserViewModel? Get(HttpClient httpClient)
    {
        Task<UserViewModel?> task = httpClient.GetFromJsonAsync<UserViewModel>(URL);
        UserViewModel? result = task.Result;
        return result;
    } // End of  method Get.
   
} // End of class User.