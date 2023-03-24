using System.ComponentModel.DataAnnotations;

namespace BlazorApp.DAL.Models
{
    public class User
    {
        public Guid? Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        [Required]
        public int? Gender { get; set; }
        public string PhoneNumber { get; set; }
    }
}