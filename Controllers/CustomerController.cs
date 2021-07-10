using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusAPP.Enums;
using Microsoft.AspNetCore.Mvc;
using BusAPP.Models;
using BusAPP.Methods;

namespace BusAPP.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Istanbul(IstanbulCard card)
        {
            IstanbulMethods oMethods = new IstanbulMethods();
            if (card.Vehicles == Vehicles.Bus)
            {
                oMethods.GetBalanceBus(card);
                ViewBag.GetBalance = oMethods.GetBalance();
                ViewBag.GetDeductedAmount = oMethods.GetDeductedAmount();
            }
            else if (card.Vehicles == Vehicles.MetroBus)
            {
                oMethods.GetBalanceMetroBus(card);
                ViewBag.GetBalance = oMethods.GetBalance();
                ViewBag.GetDeductedAmount = oMethods.GetDeductedAmount();
            }
            return View();       
        }
        public IActionResult Blue(BlueCard card)
        {
            BlueMethods oMethods = new BlueMethods();
            if (card.Vehicles == Vehicles.Bus)
            {
                oMethods.Bus(card);
                ViewBag.GetPoints = oMethods.GetPoints();
                ViewBag.GetAmountDeducted = oMethods.GetAmountDeducted();
            }
            else if (card.Vehicles == Vehicles.MetroBus)
            {
                oMethods.MetroBus(card);
                ViewBag.GetPoints = oMethods.GetPoints();
                ViewBag.GetAmountDeducted = oMethods.GetAmountDeducted();
            }
            return View();
        }
        public IActionResult Electronic(ElectronicCard card)
        {
            ElectronicMethods oMethods = new ElectronicMethods();
            if (card.Vehicles == Vehicles.Bus)
            {
                oMethods.BusMethod(card);
                ViewBag.GetPoints = oMethods.GetPoints();
                ViewBag.GetAmountDeducted = oMethods.GetAmountDeducted();
            }
            else if (card.Vehicles == Vehicles.MetroBus)
            {
                oMethods.MetroBusMethod(card);
                ViewBag.GetPoints = oMethods.GetPoints();
                ViewBag.GetAmountDeducted = oMethods.GetAmountDeducted();
            }
            return View();
        }
    }
}
