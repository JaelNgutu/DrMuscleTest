using System;
using System.Collections.Generic;
using System.Text;

namespace DrMuscleTest.ViewModels
{
    public class ViewModelLocator
    {
        public LandingViewModel LandingViewModel
        {
            get
            {
                return new LandingViewModel();
            }
        }
    }
}
