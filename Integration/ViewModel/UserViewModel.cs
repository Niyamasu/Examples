namespace Integration.ViewModel;

public class UserViewModel
{
    public IEnumerable<User>? Users { get; set; }

    public class User
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public int? Age { get; set; }

        public string? Gender { get; set; }

        public string? Email { get; set; }

        public string? Phone { get; set; }

        public string? BirthDate { get; set; }

        public string? BloodGroup { get; set; }

        public int? Height { get; set; }

        public double? Weight { get; set; }
    } // End of class User.
    
} // End of class UserViewModel.