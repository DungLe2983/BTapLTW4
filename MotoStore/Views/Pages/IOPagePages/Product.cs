using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoStore.Views.Pages.IOPagePages
{
    public class Product
    {
        public string NameProduct { get; set; }
        public double ValueMoney { get; set; }
        public string Image { get; set; }

        public Product(string productName, double valueMoney, string image)
        {
            NameProduct = productName;
            ValueMoney = valueMoney;
            Image = image;
        }
    }
}
