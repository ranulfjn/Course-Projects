using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareProject
{
    public class Prescription
    {
        public Medication medicine;
        public PatientFile patient;
        public string doctor;
        public int refills;



        public Prescription(Medication _medicine,PatientFile _patient, string _doctor, int _refills)
        {
            medicine = _medicine;
            patient = _patient;
            doctor = _doctor;
            refills = _refills;
        }

        
        public void FillPrescription(Prescription removePrescription , int refills)
        {
            --refills;
            
            if (refills <= 0)
            {
                PatientFile.list.Remove(removePrescription);
            }
            
        }

    }
}
