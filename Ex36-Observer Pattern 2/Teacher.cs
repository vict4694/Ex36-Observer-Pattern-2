using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex36_Observer_Pattern_2
{
    public class Teacher : Person
    {
        public string JobTitle { get; set; }
        public Teacher (string jobTitle, string name) : base(name)
        //ved ikke om den her  konstrukter er nødvendig, men nu brokker det sig mindre
        {
            this.JobTitle = jobTitle;
        }
    }
}
