using Configuration.Database;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Models.User;

[Table("BloodType", Schema = "User")]

public class BloodType
{
    [Key]
    [MaxLength(UserFeaturesDataAnnotationsCommonValues.NameMaxLength)]
    public string Name { get; set; }
}