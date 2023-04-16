using System.ComponentModel.DataAnnotations;

namespace CustomersApi.Dtos
{
    public class CreateCustomerDto
    {
        [Required (ErrorMessage = "Please enter a valid First Name")]
        public string FirstName { get; set; }
        [Required (ErrorMessage = "Please enter a valid Last Name")]
        public string LastName { get; set; }
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Please enter a valid Email")]
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

    }
}
