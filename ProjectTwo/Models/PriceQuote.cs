using System.ComponentModel.DataAnnotations;

namespace ProjectTwo.Models
{
    public class PriceQuote
    {
        [Required(ErrorMessage = "Please enter subtotal amount.")]
        [Range(1, 500, ErrorMessage = "Please enter number greater than 0")]
        public decimal? Subtotal { get; set; }

        [Required(ErrorMessage = "Please enter a discount percentage.")]
        [Range(0,100, ErrorMessage = "Please enter a number 1-100.")]
        public decimal? DiscountPercent { get; set; }

        public decimal Calculate()
        {
            var subtotal = Subtotal.Value;
            var discountAmount = subtotal * (DiscountPercent.Value / 100);
            var total = subtotal - discountAmount;

            return total;
        }

        public decimal CalculateDiscountAmount()
        {
            var subtotal = Subtotal.Value;
            var discountAmount = subtotal * (DiscountPercent.Value / 100);

            return discountAmount;
        }
    }
}