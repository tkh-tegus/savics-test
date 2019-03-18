using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savics_Test_Kamdjo
{
    public class Patient
    {
        public string FisrtName { get; set; }
        public string LastName { get; set; }
        public string Sexe { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int LivingWithDiabetes { get; set; }

        public override string ToString()
        {
            string str = LastName + " " + FisrtName + " (" + Sexe + "), " + Age.ToString() + " - " + City + " (" + Country + ") ";
            return str;
        }
    }
}
