using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HRProject.Models
{
    public class ProjectManager
    {
        public int Id { get; set; }

        [Required, StringLength(200)]
        public string Name { get; set; }

        [StringLength(1000)]
        public string? Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }

        // Navigation – one project has many requirements
        public ICollection<ProjectRequirement> Requirements { get; set; }
            = new List<ProjectRequirement>();
    }
}

namespace HRProject.Models
{
    public class ProjectRequirement
    {
        public int Id { get; set; }

        [Required]
        public int ProjectId { get; set; }
        public ProjectManager Project { get; set; }

        [Required]
        public int CompetenceId { get; set; }
        public Competence Competence { get; set; }

        // Minimum level required (1=Basic, 2=Intermediate, 3=Advanced)
        [Range(1, 3)]
        public int MinLevel { get; set; }

        // Minimum years of experience
        [Range(0, 50)]
        public int MinYearsOfExperience { get; set; }
    }
}