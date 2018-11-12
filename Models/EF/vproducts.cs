namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vproducts
    {
        public long? ProductID { get; set; }

        [StringLength(250)]
        public string ProductName { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(250)]
        public string Thumb { get; set; }

        public long? CategoryID { get; set; }

        [Column(TypeName = "money")]
        public decimal? InPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? OutPrice { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RATE { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int COUNTS { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreateDate { get; set; }
    }
}
