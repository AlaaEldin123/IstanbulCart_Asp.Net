using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BusAPP.Models;
using BusAPP.AddClasses;

namespace BusAPP.Controllers
{
    public class AdminController : Controller
    {
      
        BusAPPContext context = new BusAPPContext();
        public IActionResult Index()
        {
            return View();
        }
        //begin of istanbul card 
        public IActionResult CreateIstanbulCard()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateIstanbulCard (AddClasses.IstanbulCard istanbul)
        {
            var ist = new AddClasses.IstanbulCard
            {
                CustomerType = istanbul.CustomerType,
                CustomerName = istanbul.CustomerName,
                CustomerId = istanbul.CustomerId,
                CardId = istanbul.CardId,
                Balance = istanbul.Balance
            };

           await context.IstanbulCards.AddAsync(ist);
           await context.SaveChangesAsync();
            return RedirectToAction("IstanbulList");
        }

        public IActionResult IstanbulList()
        {
            var allList = context.IstanbulCards.ToList();
            return View(allList);          
        }
        //end of istanbul Card
        public IActionResult CreateBlueCard()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateBlueCard(AddClasses.BlueCard blue)
        {
            var ist = new AddClasses.BlueCard
            {
               
                CustomerName = blue.CustomerName,
                CustomerId = blue.CustomerId,
                CardId = blue.CardId,
                Points = blue.Points
            };

            await context.BlueCards.AddAsync(ist);
            await context.SaveChangesAsync();
            return RedirectToAction("BlueList");
        }
        public IActionResult BlueList()
        {
            var allList = context.BlueCards.ToList();
            return View(allList);
        }
        //electronic card/////
        public IActionResult CreateElectronicCard()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateElectronicCard(AddClasses.ElectronicCard electronic)
        {
            var ist = new AddClasses.ElectronicCard
            { 
                CardId = electronic.CardId,
                PriceOfCard = electronic.PriceOfCard,
                Points = electronic.Points
            };

            await context.ElectronicCards.AddAsync(ist);
            await context.SaveChangesAsync();
            return RedirectToAction("ElectronicList");
        }
        public IActionResult ElectronicList()
        {
            var allList = context.ElectronicCards.ToList();
            return View(allList);
        }
    }
}
