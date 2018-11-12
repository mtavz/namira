namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class colors
    {
        public long ID { get; set; }

        [StringLength(250)]
        public string Color { get; set; }
    }
}
