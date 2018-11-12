namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pictures
    {
        public long ID { get; set; }

        public long? ProductID { get; set; }

        [StringLength(250)]
        public string PicURL { get; set; }

        [StringLength(250)]
        public string ALT { get; set; }
    }
}
