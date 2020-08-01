using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace HealthcareProject
{
    public class Transition
    {

        public string name { get; private set; }
        public string docName { get; private set; }
        public Transition(string name, string docName)
        {
            this.name = name;
            this.docName = docName;
        }


        public string GetName()
        {
            return name;
        }


        public string getDoctor()
        {
            return docName;
        }
            
    }
}
