using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvC__Lab7
{
    public class Registration
    {
        private int customerId;
        private string productCode;
        private DateTime registrationDate;


        public Registration() { }

        public int CustomerId
        {
            get
            {
                return customerId;
            }
            set
            {
                customerId = value;
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
