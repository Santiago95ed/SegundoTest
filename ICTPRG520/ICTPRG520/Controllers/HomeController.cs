using ICTPRG520.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ICTPRG520.Context;



namespace ICTPRG520.Controllers
{
    public class HomeController : Controller
    {

        private DbContextTest db = new DbContextTest();

        #region Task 1 to 4 

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FinancialCalculator FinancialModel)
        {

            double MortgagePayment = ((FinancialModel.PrincipalAmount / FinancialModel.years) * FinancialModel.AnnualIntrsRate);

            MortgagePayment = (FinancialModel.PrincipalAmount / FinancialModel.years) + MortgagePayment;

            ViewBag.MortgagePayment = MortgagePayment.ToString();

            return View();
        }

        public ActionResult CreateTask2()
        {

            return View();
        }

        [HttpPost]
        public ActionResult CreateTask2(Models.EmployeeModel modelEmployee)
        {

            db.Employee.Add(
                new Employee
                {
                    EmployeeName = modelEmployee.EmployeeName,
                    EmployeeLastName = modelEmployee.EmployeeLastName,
                    Rate = modelEmployee.Rate

                });
            db.SaveChanges();
            return RedirectToAction("Task2");
        }


        public ActionResult Task2()
        {
            List<Models.EmployeeModel> listEmployee = GetEmployees();



            return View(listEmployee);
        }

        [HttpPost]
        public ActionResult Task2(IEnumerable<ICTPRG520.Models.EmployeeModel> modelEmployee)
        {

            List<Models.EmployeeModel> listEmployee = GetEmployees();

            listEmployee.ForEach(x =>
            {
                x.HoursWorked = modelEmployee.First(y => y.EmployeeID == x.EmployeeID).HoursWorked;
                x.TotalWages = x.Rate * (decimal)x.HoursWorked;
            });

            return View("EmployeeWages", listEmployee);
        }


        public ActionResult EmployeeWages(List<Models.EmployeeModel> listEmployee)
        {

            return View(listEmployee);
        }

        private List<Models.EmployeeModel> GetEmployees()
        {
            List<Models.EmployeeModel> listEmployee = new List<EmployeeModel>();
            Models.EmployeeModel employeeObj = null;
            db.Employee.ToList().ForEach(x =>
            {
                employeeObj = new EmployeeModel
                {
                    EmployeeID = x.Id,
                    EmployeeName = x.EmployeeName,
                    EmployeeLastName = x.EmployeeLastName,
                    Rate = (decimal)x.Rate
                };
                listEmployee.Add(employeeObj);
            });

            return listEmployee;
        }

        private Models.EmployeeModel GetEmployee(int idEmployee)
        {
            EmployeeModel modelEmployee = new EmployeeModel();

            Employee dbEmployee = db.Employee.First(x => x.Id == idEmployee);

            modelEmployee.EmployeeID = dbEmployee.Id;
            modelEmployee.EmployeeLastName = dbEmployee.EmployeeLastName;
            modelEmployee.EmployeeName = dbEmployee.EmployeeName;
            modelEmployee.Rate = (decimal)dbEmployee.Rate;

            return modelEmployee;
        }


        public ActionResult EditTask2(int id)
        {
            return View(GetEmployee(id));
        }

        [HttpPost]
        public ActionResult EditTask2(EmployeeModel modelEmployee)
        {
            Employee dbEmployee = db.Employee.First(x => x.Id == modelEmployee.EmployeeID);

            dbEmployee.EmployeeName = modelEmployee.EmployeeName;
            dbEmployee.EmployeeLastName = modelEmployee.EmployeeLastName;
            dbEmployee.Rate = modelEmployee.Rate;
            db.SaveChanges();

            return RedirectToAction("Task2");
        }

        public ActionResult DeleteTask2(int id)
        {
            Employee dbEmployee = db.Employee.First(x => x.Id == id);
            db.Employee.Remove(dbEmployee);
            db.SaveChanges();
            return RedirectToAction("Task2");
        }

        public ActionResult Task3()
        {

            return View();
        }

        public ActionResult Task4()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Task4(Task4 task4Model)
        {
            ViewBag.marker = -1;

            task4Model.ResultPlus = task4Model.Number1 + task4Model.Number2;
            task4Model.ResultMinus = task4Model.Number1 - task4Model.Number2;
            task4Model.ResultMul = task4Model.Number1 * task4Model.Number2;
            if (task4Model.Number2 != 0)
            {
                task4Model.ResultDiv = task4Model.Number1 / task4Model.Number2;
            }
            else
            {
                ViewBag.divBy0 = -1;
            }


            return View(task4Model);
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        #endregion

        #region Task 5 

        public ActionResult Task5()
        {
            HPC hpClass = new HPC();
            ToshibaC toshibaClass = new ToshibaC();
            DellC dellClass = new DellC();

            hpClass.WebPage = hpClass.GetMyPage();
            toshibaClass.WebPage = toshibaClass.GetMyPage();
            dellClass.WebPage = dellClass.GetMyPage();

            ViewBag.ModelHP = hpClass;
            ViewBag.ModelToshiba = toshibaClass;
            ViewBag.ModelDell = dellClass;


            return View();
        }

        #endregion


        #region Task 6

        public ActionResult Task6()
        {
            List<AlbumModel> listAlbumModel = new List<AlbumModel>();
            AlbumModel albumModel = null;

            db.Album.ToList().ForEach(x =>
            {
                albumModel = new AlbumModel
                {
                    AlbumID = x.AlbumID,
                    Artist = x.Artist,
                    DatePurchased = x.DatePurchased,
                    DateReleased = x.DateReleased,
                    Price = x.Price,
                    Title = x.Title
                };
                listAlbumModel.Add(albumModel);
            });

            return View(listAlbumModel);
        }

        public ActionResult CreateTask6()
        {

            return View();
        }

        [HttpPost]
        public ActionResult CreateTask6(AlbumModel albumModel)
        {
            Album album = new Album
            {
                Artist = albumModel.Artist,
                DatePurchased = albumModel.DatePurchased,
                DateReleased = albumModel.DateReleased,
                Price = albumModel.Price,
                Title = albumModel.Title
            };

            db.Album.Add(album);
            db.SaveChanges(); 

            return RedirectToAction("Task6");
        }


        #endregion

    }
}