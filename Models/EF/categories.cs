namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class categories
    {
        public long ID { get; set; }

        public long? ParentID { get; set; }

        [StringLength(250)]
        public string CategoryName { get; set; }
    }
}
