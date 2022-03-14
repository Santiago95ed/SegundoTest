using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICTPRG520.Models
{
    public class ToshibaC : ComputerModel
    {
        public ToshibaC()
        {
            this.Brand = "Toshiba";
            this.HardDiskComputer = "750 GB";
            this.OSComputer = "Windows 7";
            this.ProcessorComputer = "AMD";
            this.RamComputer = "1 GB";
            this.ScreenSize = "15.5";
            this.StockAvailible = true;
        }
        public string GetMyPage()
        {
            return GetPage(BrandsComputers.Toshiba);
        }
    }
}