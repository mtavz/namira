namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vproduct")]
    public partial class vproduct
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        public long? Color { get; set; }

        public long? Size { get; set; }

        [Column(TypeName = "money")]
        public decimal? InPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? OutPrice { get; set; }

        public int? Quantiy { get; set; }

        [StringLength(250)]
        public string Thumb { get; set; }

        [Column(TypeName = "ntext")]
        public string Desn { get; set; }

        [StringLength(250)]
        public string Manufac { get; set; }

        [StringLength(250)]
        public string Material { get; set; }

        public long? CategoryID { get; set; }

        [StringLength(250)]
        public string Supplier { get; set; }

        [StringLength(250)]
        public string Country { get; set; }

        public long? ProductID { get; set; }
    }
}
