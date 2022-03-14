using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ICTPRG520.Models
{

    public enum BrandsComputers
    {
        DELL = 1,
        HP = 2,
        Toshiba = 3
    }

    public class ComputerModel
    {
        private string _Brand;
        private string _OSComputer;
        private string _RamComputer;
        private string _HardDiskComputer;
        private string _ScreenSize;
        private string _ProcessorComputer;
        private bool _StockAvailible;

        [Display(Name ="Brand")]
        public string Brand { get => _Brand; set => _Brand = value; }

        [Display(Name = "OS")]
        public string OSComputer { get => _OSComputer; set => _OSComputer = value; }

        [Display(Name = "RAM")]
        public string RamComputer { get => _RamComputer; set => _RamComputer = value; }

        [Display(Name = "Hard Disk")]
        public string HardDiskComputer { get => _HardDiskComputer; set => _HardDiskComputer = value; }

        [Display(Name = "Screen Size")]
        public string ScreenSize { get => _ScreenSize; set => _ScreenSize = value; }

        [Display(Name = "Processor")]
        public string ProcessorComputer { get => _ProcessorComputer; set => _ProcessorComputer = value; }

        [Display(Name = "Stock Availible")]
        public bool StockAvailible { get => _StockAvailible; set => _StockAvailible = value; }

        [Display(Name ="Web page")]
        public string WebPage { get; set; }

        protected string GetPage(BrandsComputers brand)
        {
            switch (brand)
            {
                case BrandsComputers.DELL:
                    return "https://deals.dell.com/";
                case BrandsComputers.HP:
                    return "https://store.hp.com/";

                case BrandsComputers.Toshiba:
                    return "https://www.toshiba.com.au/";
                default:
                    return string.Empty;
            }
        }

    }
}