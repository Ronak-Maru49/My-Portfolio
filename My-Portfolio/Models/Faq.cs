using System.ComponentModel.DataAnnotations;

namespace My_Admin_panel.Models
{
    public class Faq
    {
        [Key]
        public int Id { get; set; }  // Primary key

        [Required]
        [StringLength(200)]
        public string Question { get; set; }  // FAQ question

        [Required]
        [StringLength(1000)]
        public string Answer { get; set; }    // FAQ answer
    }
}