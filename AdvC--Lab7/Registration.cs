using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvC__Lab7
{
    public class Registration
    {
        private string customerName;
        private string productCode;
        private DateTime registrationDate;


        public Registration() { }

        public string CustomerName
        {
            get
            {
                return customerName;
            }
            set
            {
                customerName = value;
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

        public DateTime RegistrationDate
        {
            get
            {
                return registrationDate;
            }
            set
            {
                registrationDate = value;
            }
        }




    }
}
