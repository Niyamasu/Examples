using System.Text.Json;
using Integration;
using Integration.ViewModel;

namespace IntegrationConsoleApp;

public class IntegrationData
{
    int CalculateDaysBetweenDates(DateTime startDate, DateTime endDate)
    {
        return (int)(endDate - startDate).TotalDays;
    }
    
    public static void ShowInformation(HttpClient httpClient)
    {
        UserViewModel userIntegrationResult = UserIntegration
                                                  .Get(httpClient) ??
                                              new UserViewModel() { Users = Array.Empty<UserViewModel.User>() };

        Console.WriteLine();

        foreach (UserViewModel.User user in userIntegrationResult.Users)
        {
            Console.WriteLine("User_Integration_Result");
            Console.WriteLine(JsonSerializer.Serialize(user));
            Console.WriteLine();
        }

        Console.WriteLine();

        ProductViewModel productIntegrationResult = ProductIntegration
                                                        .Get(httpClient) ??
                                                    new ProductViewModel()
                                                        { Products = Array.Empty<ProductViewModel.Product>() };

        foreach (ProductViewModel.Product product in productIntegrationResult.Products)
        {
            Console.WriteLine("Product_Integration_Result");
            Console.WriteLine(JsonSerializer.Serialize(product));
            Console.WriteLine();
        }
    } // End of method ShowInformation.
} // End of class IntegrationData.