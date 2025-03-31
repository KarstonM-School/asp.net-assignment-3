using System.ComponentModel.DataAnnotations;

namespace asp.net_assignment_3.Models
{
    public class Borrowing
    {
        [Required(ErrorMessage = "{0} is required")]
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        public int? BookId { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        public int? BorrowerId { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        public bool IsReturned { get; set; }
    }
}
