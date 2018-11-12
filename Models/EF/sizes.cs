namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sizes
    {
        public long ID { get; set; }

        [StringLength(250)]
        public string SizeName { get; set; }

        [Column(TypeName = "ntext")]
        public string Desn { get; set; }
    }
}
