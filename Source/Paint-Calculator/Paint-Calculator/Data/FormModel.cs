using System.ComponentModel.DataAnnotations;

namespace Paint_Calculator.Data
{
    
    // Form Model
    // Description: An object to store the data entered by the user in
    public class FormModel
    {
        // Width (decimal): The width of the room
        [Required]
        [StringLength(10, ErrorMessage = "Width is too large.")]
        public decimal Width { get; set; }

        // Length (decimal): The length of the room
        [Required]
        [StringLength(10, ErrorMessage = "Length is too large.")]
        public decimal Length { get; set; }

        // Height (decimal): The height of the room
        [Required]
        [StringLength(10, ErrorMessage = "Height is too large.")]
        public decimal Height { get; set; }
    }
}
