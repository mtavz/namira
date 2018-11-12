namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class users
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        public int? RoleID { get; set; }

        [StringLength(250)]
        public string PassWordHash { get; set; }

        [StringLength(250)]
        public string Gmail { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(250)]
        public string FirstName { get; set; }

        [StringLength(250)]
        public string LastName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BirthDay { get; set; }
    }
}
