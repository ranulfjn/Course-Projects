using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareProject
{
    public class OverTheCounterMedication : Medication
    {
        public string dosage;
        public OverTheCounterMedication(string _dosage,string _nameOfMedicine, double _priceOfMedicine, bool _RequriesPrescription) : base(_nameOfMedicine, _priceOfMedicine, _RequriesPrescription)
        {
            dosage = _dosage;
        }


        public override string GetInfo()
        {
            return base.GetInfo() + "Prescribed Dosage : " + dosage + " , in every 6-12 hours per day";
        }
    }
}
