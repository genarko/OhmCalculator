using System.Collections.Generic;
using System.ComponentModel;
using System.Web.Mvc;

namespace OhmCalculator.Models
{
    public class OhmViewModel
    {

        public string SelectedBandA { get; set; }
        public string SelectedBandB { get; set; }
        public string SelectedBandC { get; set; }
        public string SelectedBandD { get; set; }

        [DisplayName("Band A")]
        
        public List<SelectListItem> BandA { get; set; }

        [DisplayName("Band B")]
       
        public List<SelectListItem> BandB { get; set; }

        [DisplayName("Band C")]
        
        public List<SelectListItem> BandC { get; set; }

        [DisplayName("Band D")] 
       
        public List<SelectListItem> BandD { get; set; }

        [DisplayName("Max Resistance")]
        public int Resistance { get; set; }      
        
    }
}