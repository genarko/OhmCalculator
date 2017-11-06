using System.Collections.Generic;
using System.Web.Mvc;
using OhmCalculator.Models;
using OhmCalculator.Repositories;
using System.Threading.Tasks;

namespace OhmCalculator.Controllers
{
    public class HomeController : Controller
    {
        ValuesRepository valuesRepository;
        OhmViewModel ohmViewModel;
        ///
        public HomeController()
        {
            valuesRepository = new ValuesRepository();
            ohmViewModel = new OhmViewModel
            {
                BandA = new List<SelectListItem>(),
                BandB = new List<SelectListItem>(),
                BandC = new List<SelectListItem>(),
                BandD = new List<SelectListItem>()
            };

            ohmViewModel.BandA = valuesRepository.RetrieveBandValues("A");
            ohmViewModel.BandB = valuesRepository.RetrieveBandValues("B");
            ohmViewModel.BandC = valuesRepository.RetrieveBandValues("C");
            ohmViewModel.BandD = valuesRepository.RetrieveBandValues("D");
        }

        /// <summary>
        /// Controller method of the initial page. 
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View(ohmViewModel);
        }


        /// <summary>
        /// Gets the different band values from the form, calls the calcylator class and returns the resistance to the form.
        /// </summary>
        /// <param name="ohmFormViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Index(OhmViewModel ohmFormViewModel)
        {
          
            if(ModelState.IsValid)
            {
                ohmViewModel.Resistance =  new Classes.OhmCalculator().CalculateOhmValue(ohmFormViewModel.SelectedBandA, ohmFormViewModel.SelectedBandB, ohmFormViewModel.SelectedBandC, ohmFormViewModel.SelectedBandD);
            
            }
            return View(ohmViewModel);
        }

    }
}