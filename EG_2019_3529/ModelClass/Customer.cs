using System.ComponentModel.DataAnnotations;

namespace WebApplication3529.ModelClass
{
    public class Customer
    {
        [Key]
        [Required]
        public int ID { get; set; }
        public string IdNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string CAddress { get; set; }

    }
}
