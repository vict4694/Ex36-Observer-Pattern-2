using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex36_Observer_Pattern_2
{
    public class Academy : Organization, IAcademy
    {
        private List<IStudent> students = new List<IStudent>();
        private string _message;
        public string Message
        {
            get;set;
        }

        public Academy(string name, string address)
        {
            name = Name; //det her er underligt, men lad os se om det virker xd
            Address = address;
        }

        public void Attach(IStudent s)
        {
            students.Add(s);
        }
        public void Detach(IStudent s)
        {
            students.Remove(s);
        }
        public void Notify()
        {
            foreach (IStudent sub in students)
            {
                sub.Update();
            }
        }
    }
}
