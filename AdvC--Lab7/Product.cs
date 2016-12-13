using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvC__Lab7
{
    public class Product
    {
        private int name;
        private string productCode;


        public Product() { }

        public int Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string ProductCode
        {
            get
            {
                return productCode;
            }
            set
            {
                productCode = value;
            }
        }




    }
}
