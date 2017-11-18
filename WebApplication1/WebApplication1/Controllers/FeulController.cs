using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.BussinesLogic;
using WebApplication1.Models;
using WebApplication1.ViewModel;

namespace WebApplication1.Controllers
{
    public class FeulController : Controller
    {
        private readonly FuelBusinesLogic _busienssLogic;
  

        public FeulController()
        {
            _busienssLogic = new FuelBusinesLogic();
        }
        
       
        // GET: Feul
        public ActionResult Index()
        {
            var model = new FuelViewModel { FuelModel = new FuelModel()};
            return View("View",model);
        }
        [HttpPost]
        public ActionResult FeulCalculate(FuelViewModel model)
        {
            if (model.FuelModel != null && model.FuelModel.Distance != 0)
            {
                model.FuelModel.AvgConsumption = _busienssLogic.CalculateAvgConsumption(model.FuelModel.Fuel, model.FuelModel.Distance);
                model.ShowResult = true;
                return View("View", model);
            }
            model.ShowResult = false;
            ViewBag.ERROR = "Bledne dane";
            return View("View", model);
        }
    }
}