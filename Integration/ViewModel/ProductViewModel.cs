namespace Integration.ViewModel;

public class ProductViewModel
{
    public IEnumerable<Product>? Products { get; set; }

    public class Product
    {
        public string? Title { get; set; }
        
        public string? Description { get; set; }
        
        public decimal? Price { get; set; }
        
        public decimal? DiscountPercentage { get; set; }
        
        public decimal? Rating { get; set; }
        
        public decimal? Stock { get; set; }
        
        public string? Brand { get; set; }
        
        public string? Category { get; set; }
        
        public string? Thumbnail { get; set; }
        
        public string[]? Images { get; set; }
        
    } // End of class Product.
    
} // End of class ProductViewModel.