namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderItem")]
    public partial class OrderItem
    {
        public long ID { get; set; }

        public int? Number { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        public long? OrderForm { get; set; }

        public long? ProductVariantID { get; set; }
    }
}
