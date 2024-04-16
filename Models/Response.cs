using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System;

namespace CFMS.Models
{   

    [Table("Response")]
    public class Response
    {
        #region Properties	

        [Key]
        [Column(Order = 1)]
        [Display(Name = "Id")]
        public int ResponseId { get; set; }

        [Required]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }
        
        [Required]
        [MaxLength(255)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Submission Date")]
        public DateTime? SubmissionDate { get; set; } = DateTime.Now;

        public int FeedbackId { get; set; }
        public Feedback Feedback { get; set; }

        #endregion

    }
}
