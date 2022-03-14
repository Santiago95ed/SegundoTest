using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ICTPRG520.Models
{
    public class AlbumModel
    {
        [Key]
        public int AlbumID { get; set; }

        [StringLength(50), Display(Name = "Title")]
        public string Title { get; set; }

        [StringLength(75), Display(Name = "Artist")]
        public string Artist { get; set; }

        [Display(Name = "Price")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Price { get; set; }

        [Display(Name = "Date released")]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime DateReleased { get; set; }

        [Display(Name = "Date purchased")]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime DatePurchased { get; set; }
    }
}