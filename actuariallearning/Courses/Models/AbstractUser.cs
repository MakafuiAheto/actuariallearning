using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace actuariallearning.Courses.Models
{
    [Table("User")]
    public abstract class AbstractUser: Utils
    {
        [Editable(true), Column("First Name")]
        protected String? firstName { get; set; }

        [Editable(true), Column("Last Name")]
        protected String? lastName { get; set; }

        [Editable(true), Column("Username")]
        protected String? userName { get; set; }

       [DataType(DataType.EmailAddress)]
       [EmailAddress, Editable(true)]
        protected String? email { get; set; }

        [Editable(true)]
        protected String? password { get; set; }

        [Editable(true)]
        protected Uri? imageUrl;


        [Editable(true)]
        protected Boolean isActive { get; set; } = true;

        [Editable(true)]
        protected Boolean isStaff { get; set; } = false;

        [Editable(true)]
        protected Boolean isSuperUser { get; set; } = false;


        [Editable(true)]
        protected Gender gender { get; set; }

    }
}
