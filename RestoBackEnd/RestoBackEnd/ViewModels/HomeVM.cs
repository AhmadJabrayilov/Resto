using RestoBackEnd.Models;
using System.Collections.Generic;

namespace RestoBackEnd.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> SliderVM { get; set; }
        public PageIntro PageIntro { get; set; }
        public About AboutVM { get; set; }
        public IEnumerable<AboutCard> AboutCardVM { get; set; }
        public Beef Beef { get; set; }
        public Salmon Salmon { get; set; }

    }
}
