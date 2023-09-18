using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace actuariallearning.Courses.Models
{
    public abstract class Utils{

       [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        protected DateTime ModifiedOn { get; set; }

       [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        protected DateTime CreatedOn { get;}
    }
}
