using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICTPRG520.Models
{
    public class HPC : ComputerModel
    {
        public HPC()
        {
            this.Brand = "HP";
            this.HardDiskComputer = "500 GB";
            this.OSComputer = "Windows 7";
            this.ProcessorComputer = "Intel Core";
            this.RamComputer = "2 GB";
            this.ScreenSize = "15"; 
            this.StockAvailible = true; 
        }
        public string GetMyPage()
        {
            return GetPage(BrandsComputers.HP); 
        }
    }
}