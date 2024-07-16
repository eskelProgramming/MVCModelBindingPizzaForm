using System.ComponentModel.DataAnnotations;

namespace MVCModelBindingPizzaForm.Models
{
    public class Pizza
    {
        /// <summary>
        /// The topping for the pizza (only one topping)
        /// </summary>
        [Required(ErrorMessage = "Please enter a topping")]
        [Display(Name = "Topping")]
        public string Topping { get; set; }

        /// <summary>
        /// The diameter of the pizza
        /// </summary>
        [Range(9, 24, ErrorMessage ="Size must be between 9\" and 24\"")]
        [Display(Name = "Size (inches)")]
        public int Size { get; set; }

        /// <summary>
        /// The quantity of pizzas
        /// </summary>
        [Range(1, 10, ErrorMessage ="Quantity must be between 1 and 10")]
        public int Quantity { get; set; }
    }
}
