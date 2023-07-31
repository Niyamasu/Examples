using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Configuration.Database;
using Microsoft.EntityFrameworkCore;

namespace Models.User;

[Table("Gender", Schema = "User")]
public class Gender
{
    [Key]
    [MaxLength(UserFeaturesDataAnnotationsCommonValues.NameMaxLength)]
    public string Name { get; set; }
}