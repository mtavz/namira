namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class reviews
    {
        public long ID { get; set; }

        public long? UserID { get; set; }

        public long? ProductID { get; set; }

        [Column(TypeName = "ntext")]
        public string Content { get; set; }

        public int? RateValue { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreateDate { get; set; }
    }
}
