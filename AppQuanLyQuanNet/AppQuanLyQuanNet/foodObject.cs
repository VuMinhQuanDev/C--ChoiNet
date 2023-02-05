using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyQuanNet
{
    public class foodObject
    {
        public string nameFood;
        public string foodType;
        public double priceFood;
        public string foodUnit;
        public int amountFood;

        public string getFoodType(string nameFood)
        {
            if (nameFood == "")
            {
                this.foodType = "";
            }else
            {
                this.foodType = nameFood.Split()[0].ToString();
            }
            return this.foodType;
        }
    }
}
