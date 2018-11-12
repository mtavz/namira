namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderForm")]
    public partial class OrderForm
    {
        public long ID { get; set; }

        public long? UserID { get; set; }

        public int? OrderState { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateCreate { get; set; }
    }
}
