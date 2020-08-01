using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareProject
{
    public class PrescriptionMedication : Medication
    {

        public string nameOfMedicine { get; private set; }
        public Double priceOfMedicine { get; private set; }
        public bool RequriesPrescription { get; private set; }

        public PrescriptionMedication(string _nameOfMedicine, double _priceOfMedicine, bool _RequriesPrescription) :base( _nameOfMedicine,  _priceOfMedicine,  _RequriesPrescription)
        {
            nameOfMedicine = _nameOfMedicine;
            priceOfMedicine = _priceOfMedicine;
            RequriesPrescription = _RequriesPrescription;
        }

        public override string GetInfo()
        {
            
            if (RequriesPrescription == true)
            {
                return base.GetInfo() + "Contact Doctor for dosage details \n" + "For details on reimbursement please enquire your insurance Provider";
            }
            return "";
        }

    }
}
