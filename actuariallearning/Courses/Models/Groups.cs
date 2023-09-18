using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace actuariallearning.Courses.Models
{
    [Table("Groups")]
    public class Groups:Utils
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column("Group Id")]
        protected long groupId;

        [Column("Group Name")]
        protected String groupName;

        [Column("Permissions")]
        protected HashSet<Permissions> permissions = new HashSet<Permissions>();

        public Groups()
        {

        }

        public Groups(String groupName, HashSet<Permissions> permissions)
        {
            this.groupName = groupName;
            this.permissions = permissions;
        }
    }
}
