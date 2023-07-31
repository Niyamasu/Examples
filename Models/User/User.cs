using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using Models.Enum;
using Configuration.Database;

namespace Models.User;

[Table("User", Schema = "User")]
public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID { get; set; }
    
    [Required]
    [StringLength(UserDataAnnotationsCommonValues.NameMaxLength)]
    public string FirstName { get; set; }

    [Required]
    [StringLength(UserDataAnnotationsCommonValues.NameMaxLength)]
    public string LastName { get; set; }

    [Range(UserDataAnnotationsCommonValues.AgeMinValue
        , UserDataAnnotationsCommonValues.AgeMaxValue)]
    public int Age { get; set; }

    [Required] 
    [ForeignKey(nameof(Gender))]
    public string GenderName { get; set; }
    
    public Gender Gender { get; set; }
    

    [EmailAddress]
    [StringLength(UserDataAnnotationsCommonValues.EmailMaxLength)]
    public string Email { get; set; }

    [Phone]
    [StringLength(UserDataAnnotationsCommonValues.PhoneNumberMaxLength)]
    public string Phone { get; set; }


    public DateTime BirthDate { get; set; }

    [Required] 
    [ForeignKey(nameof(BloodType))]
    public string BloodTypeName { get; set; }
    
    public BloodType BloodType { get; set; }

    [Range(UserDataAnnotationsCommonValues.HeightWeightMinValue
        , UserDataAnnotationsCommonValues.HeightWeightMaxValue)]
    public double Height { get; set; }

    [Range(UserDataAnnotationsCommonValues.HeightWeightMinValue
        , UserDataAnnotationsCommonValues.HeightWeightMaxValue)]
    public double Weight { get; set; }
} // End of class User.