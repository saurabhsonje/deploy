using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagementSystemApplication.Models
{
    public class FeedbackModel
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FeedbackID { set; get; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        [Display(Name = "Technical Knowledge")]
        public string TechKnowledge { set; get; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        [Display(Name = "Team Work")]
        public string Teamwork { set; get; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        [Display(Name = "Flexibility")]
        public string Flexibility { set; get; }
        
        [Display(Name = "Comments")]
        [DataType(DataType.MultilineText)]
        public string Comment { set; get; }

        [Required]
        public bool HasEmployeeSubmitted { set; get; }

        [Required]
        public bool HasTdSubmitted { set; get; }


        public virtual RegistrationModel registrationModel { get; set; }
        public string EmployeeId { get; set; }

        public string SubmittedBy { get; set; }
    }
}
