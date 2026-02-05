using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Feedback
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage ="Need Your Name")]
        public string Name { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Need Your Surname")]
        public string SurName { get; set; }
        [Display(Name = "Age")]
        [Range(1, 220, ErrorMessage = "Age must be between 1 and 220")]
        public int Age { get; set; }
        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [Display(Name = "Your Message")]
        [Required(ErrorMessage = "Message cannot be empty")]
        [StringLength(3000, ErrorMessage = "Message cannot exceed 3000 characters")]
        public string Message { get; set; }

    }
}
