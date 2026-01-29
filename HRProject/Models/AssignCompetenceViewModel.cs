using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HRProject.Models
{
    public class AssignCompetenceViewModel
    {

        // ✅ NEW: dropdown selection
        [Required(ErrorMessage = "Please select an employee.")]
        [Display(Name = "Employee")]
        public string SelectedUserId { get; set; } = string.Empty;

        // ✅ NEW: dropdown list
        public List<SelectListItem> Employees { get; set; } = new();

        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        [Display(Name = "User Email")]
        public string UserEmail { get; set; }

        [Display(Name = "Competence")]
        public int CompetenceId { get; set; }

        [Display(Name = "Level (1=Basic, 2=Intermediate, 3=Advanced)")]
        public int Level { get; set; }

        [Display(Name = "Years of Experience")]
        [Range(0, 50, ErrorMessage = "Years of experience must be between 0 and 50.")]
        public int? YearsOfExperience { get; set; }

        public List<SelectListItem> Competences { get; set; }
        public List<SelectListItem> Levels { get; set; }

        // 👇 New: list to show in the table
        public List<UserCompetence> ExistingUserCompetences { get; set; } = new();
    }
}
