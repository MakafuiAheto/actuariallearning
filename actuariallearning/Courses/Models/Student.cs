using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using actuariallearning.Courses.Interfaces;


namespace actuariallearning.Courses.Models
{
	[Table("Students"), Serializable]
	public class Student: AbstractUser, UserInterface
	{
		[Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		protected Guid studentID { get; set; }

        protected HashSet<Permissions> permissions = new HashSet<Permissions>();

        public Student()
		{
		}

        public Student(String firstName, String lastName, String password,
                            Gender gender, String emailAddress)
        {
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.email = email;
        }

        public Student(String firstName, String lastName, String password,
                        HashSet<Permissions> permissions)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.password = password;
            this.permissions.UnionWith(permissions);
        }

       
        public void makeUser()
        {
            this.isSuperUser = false;
        }

        public void makeSuperUser()
        {

        }
        

    }
}

