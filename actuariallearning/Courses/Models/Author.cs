using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace actuariallearning.Courses.Models
{
    [Table("Authors"), Serializable]
    public class Author: AbstractUser
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        protected Guid authorID { get; }

        protected HashSet<Permissions> permissions = new HashSet<Permissions>();

        public Author()
        {
        }

        public Author(String firstName, String lastName, String password,
                            Gender gender, String emailAddress)
        {
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.email = email;
        }

        public Author(String firstName, String lastName, String password,
                        HashSet<Permissions> permissions)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.password = password;
            this.permissions.UnionWith(permissions);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString()!;
        }
    }
}
