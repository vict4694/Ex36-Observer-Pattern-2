using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex36_Observer_Pattern_2
{
    public class Student : Person, IStudent
    {
        private IAcademy academy;
        
        private string _message;
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
        public Student(IAcademy academy, string name): base (name)
        { // constructor
            this.academy = academy;          
        }
        public void Update()
        {
            ////Message = (Academy(academy))
        }
    }
}
