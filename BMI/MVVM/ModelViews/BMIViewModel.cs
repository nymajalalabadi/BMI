using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMI.MVVM.Models;

namespace BMI.MVVM.ModelViews
{
    public class BMIViewModel
    {
        public BMIViewModel()
        {
            BMI = new Models.BMI();
            BMI.Height = 180;
            BMI.Weight = 73;
        }

        public  Models.BMI  BMI { get; set; }
    }
}
