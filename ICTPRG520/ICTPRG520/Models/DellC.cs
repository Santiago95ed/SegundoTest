using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICTPRG520.Models
{
    public class DellC : ComputerModel
    {

        public DellC()
        {
            this.Brand = "Dell";
            this.HardDiskComputer = "650 GB";
            this.OSComputer = "Windows 8";
            this.ProcessorComputer = "Intel Core";
            this.RamComputer = "4 GB";
            this.ScreenSize = "14";
            this.StockAvailible = true;
        }

        public string GetMyPage()
        {
            return GetPage(BrandsComputers.DELL);
        }
    }
}