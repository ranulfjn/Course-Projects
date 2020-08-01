using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace HealthcareProject
{
    public abstract class Medication
    {


        public string nameOfMedicine { get; private set; }
        public  Double priceOfMedicine { get; private set; }
        public bool RequriesPrescription { get; private set; }


        public Medication(string _nameOfMedicine, double _priceOfMedicine,bool _RequriesPrescription)
        {
            nameOfMedicine = _nameOfMedicine;
            priceOfMedicine = _priceOfMedicine;
            RequriesPrescription = _RequriesPrescription;
        }


        public virtual string GetInfo()
        {

            if (RequriesPrescription == true) 
            { 
                return "Drug name: " + nameOfMedicine + " , Unit Price: " + priceOfMedicine + "$ , Requries Prescription " + "\n"; 
            }
            return "Drug name: " + nameOfMedicine + " , Unit Price: " + priceOfMedicine + "$ , Does not Requrie Prescription " + "\n";

        }


        public bool test()
        {
             if (RequriesPrescription == true)
                {
                return true; ;
                }
            return false;
        }


        public double price()
        {
            return priceOfMedicine;

        }


        public string name()
        {
            return nameOfMedicine;
        }




        public override string ToString()
        {
            return nameOfMedicine;
        }


    }
}
