using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFMS.Models
{
    [Table("Feedback")]
    public class Feedback
    {
        #region Properties	

        [Key]
        [Column(Order = 1)]
        [Display(Name = "Id")]
        public int FeedbackId { get; set; }

        [Required]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        [MaxLength(255)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Submission Date")]
        public DateTime? SubmissionDate { get; set; } = DateTime.Now;

        public List<Response> Responses { get; set; }

        #endregion

    }

}
