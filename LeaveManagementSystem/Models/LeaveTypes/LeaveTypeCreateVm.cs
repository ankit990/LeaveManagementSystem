using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.Models.LeaveTypes
{
    public class LeaveTypeCreateVm
    {
        [Required]
        [Length(4,150,ErrorMessage ="Leave type name must be between 4 and 150 characters")]
        public string Name { get; set; }
        [Required]
        [Range(1,90, ErrorMessage = "Number of days must be between 1 and 90")]
        [Display(Name = "Maximum Allocation of Days")]
        public int NumberOfDays { get; set; }
    }
}
