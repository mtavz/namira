namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class productVariants
    {
        public long ID { get; set; }

        public long? ProductID { get; set; }

        public long? Color { get; set; }

        public long? Size { get; set; }

        [Column(TypeName = "money")]
        public decimal? InPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? OutPrice { get; set; }

        public int? Quantiy { get; set; }
    }
}
