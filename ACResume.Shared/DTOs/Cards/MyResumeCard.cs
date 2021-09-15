using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ACResume.Shared.DTOs.Cards
{
    public class MyResumeCard
    {
        public virtual string Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public virtual string Name { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public virtual string Email { get; set; }
        [MaxLength(12)]
        public virtual string Phone { get; set; }
        [MaxLength(255)]
        public virtual string Location { get; set; }
        public virtual List<string> Skills { get; set; }
        public virtual string Experience { get; set; }
    }
}
