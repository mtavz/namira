namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class products
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(250)]
        public string ProductName { get; set; }

        [StringLength(250)]
        public string Thumb { get; set; }

        public long? CategoryID { get; set; }

        [Column(TypeName = "ntext")]
        public string Desn { get; set; }

        [StringLength(250)]
        public string Manufac { get; set; }

        [StringLength(250)]
        public string Supplier { get; set; }

        [StringLength(250)]
        public string Country { get; set; }

        [StringLength(250)]
        public string Material { get; set; }

        public int? ProductStatus { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreateDate { get; set; }
    }
}
