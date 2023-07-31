using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Configuration.Database;

namespace Models;

[Table("Product", Schema = "Product")]

public class Product
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID { get; set; }
    
    [StringLength(ProductDataAnnotationsCommonValues.TitleMaxLength)]
    [Required]
    public string Title { get; set; }
    
    [StringLength(ProductDataAnnotationsCommonValues.DescriptionMaxLength)]
    [Required]
    public string Description { get; set; }
        
    [Range(ProductDataAnnotationsCommonValues.FloatingPointMinValue, 
        ProductDataAnnotationsCommonValues.FloatingPointMaxValue)]
    [Required]
    public decimal Price { get; set; }
        
    [Range(ProductDataAnnotationsCommonValues.FloatingPointMinValue, 
        ProductDataAnnotationsCommonValues.FloatingPointMaxValue)]
    [Required]
    public decimal DiscountPercentage { get; set; }
        
    [Range(ProductDataAnnotationsCommonValues.FloatingPointMinValue, 
        ProductDataAnnotationsCommonValues.FloatingPointMaxValue)]
    [Required]
    public decimal Rating { get; set; }
        
    [Range(ProductDataAnnotationsCommonValues.FloatingPointMinValue, 
        ProductDataAnnotationsCommonValues.FloatingPointMaxValue)]
    [Required]
    public decimal Stock { get; set; }
        
    [StringLength(ProductDataAnnotationsCommonValues.BrandMaxLength)]
    public string Brand { get; set; }
    
    [StringLength(ProductDataAnnotationsCommonValues.CategoryMaxLength)]
    public string Category { get; set; }
    
    [StringLength(ProductDataAnnotationsCommonValues.ThumbnailMaxLength)]
    public string Thumbnail { get; set; }
    
    [StringLength(ProductDataAnnotationsCommonValues.ImagesMaxLength)]
    public string Images { get; set; }
} // End of class Product.