namespace ICTPRG520.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ALBUM")]
    public partial class Album
    { 
        public int AlbumID { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(75)]
        public string Artist { get; set; }

        [Display]
        public decimal Price { get; set; }

        [Display]
        public DateTime DateReleased { get; set; }

        [Display]
        public DateTime DatePurchased { get; set; }
    }
}