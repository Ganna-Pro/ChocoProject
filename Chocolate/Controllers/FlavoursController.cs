using Chocolate.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Chocolate.Controllers
{

    public class FlavoursController : Controller
    {
        private object productDescription;

        private static List<FlavoursDetail> _flavoursList;

        public FlavoursController() : base()
        {
            if(_flavoursList == null)
            {
                _flavoursList = PrepareFlavoursDetailList();
            }
            
        }
              
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FlavoursDetail(int? id)
        {
            var currentFlavour = _flavoursList.Where(m => m.Id == id).FirstOrDefault();
            //var currentFlavour = new FlavoursDetail();
            //currentFlavour.Id = 1;
            //currentFlavour.Title = "Love";
            //currentFlavour.Product = (productDescription)productDescription;
            //currentFlavour.Price = 2;
            return View(currentFlavour);
        }
        public IActionResult List()
        {
            return View(_flavoursList.OrderBy(m=>m.Id));
        }

        public IActionResult Edit(int? id)
        {
            var currentFlavour = _flavoursList.Where(m => m.Id == id).FirstOrDefault();
            return View(currentFlavour);
        }
        [HttpPost]
        public IActionResult Edit(FlavoursDetail flavoursDetail)
        {
            var currentFlavour = _flavoursList.Where(m => m.Id == flavoursDetail.Id).FirstOrDefault();
            _flavoursList.Remove(currentFlavour);
            _flavoursList.Add(flavoursDetail);
            //return View(flavoursDetail);
            //return RedirectToAction("MovieDetail", "" , new { id = movieDetail.Id});
            return RedirectToAction("List");

        }
        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(FlavoursDetail flavoursDetail)
        {
            var id = _flavoursList.Count + 1;
            flavoursDetail.Id = id;
            _flavoursList.Add(flavoursDetail);
            return View();
        }
        
        private FlavoursDetail PrepareFlavoursInstance(int id, string title, productDescription product, decimal Price)
        {
            var currentFlavour = new FlavoursDetail();
            currentFlavour.Id = id;
            currentFlavour.Title = title;
            currentFlavour.Product = product;
            currentFlavour.Price = Price;

            return currentFlavour;
        }
        private List<FlavoursDetail>PrepareFlavoursDetailList()
        {

            var flavoursList = new List<FlavoursDetail>();
            flavoursList.Add(PrepareFlavoursInstance(
                1,
                "Gold",
                (productDescription)productDescription,
                3));

            flavoursList.Add(PrepareFlavoursInstance(
                2,
                "Ying Yang",
                (productDescription)productDescription,
                3));

            flavoursList.Add(PrepareFlavoursInstance(
                3,
                "Universe",
                (productDescription)productDescription,
                2));

            return flavoursList;
        }
        
    }
}
