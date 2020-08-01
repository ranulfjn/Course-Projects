using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HealthcareProject
{


    public class PatientFile
    {

        public string fName { get; private set; }
        public string lName { get; private set; }
        public int healthCareNumber { get; private set; }
        public string fullName { get; private set; }

        public static int  Count=107;


        public PatientFile(string fName, string lName,int healthCareNumber)
        {
            this.fName = fName;
            this.lName = lName;
            this.healthCareNumber = healthCareNumber;
            fullName = fName +" "+lName;
        }

        public static List<Prescription> list = new List<Prescription> {

          new Prescription(new PrescriptionMedication("Insulin",12.5,true),new PatientFile("Jadon","Sancho",100),"Dr. Ole S",3),
          new Prescription(new PrescriptionMedication("Paracetamol",2.6,true),new PatientFile("Paul","Pogba",103),"Dr. Ole S",2),
          new Prescription(new PrescriptionMedication("Mumps",16.8,true),new PatientFile("Paul","Pogba",103),"Dr. Tim Sherwood",4),
          new Prescription(new PrescriptionMedication("Mumps",16.8,true),new PatientFile("James","Garner",106),"Dr. Tim Sherwood",2),
          new Prescription(new PrescriptionMedication("Polio",5.6,true),new PatientFile("Brandon","Williams",105),"Dr. Ian Bell",4)
        };

        public void SetFirstName(string fName)
        {
            this.fName = fName;
        }

        public void SetLastName(string lName)
        {
            this.lName = lName;
        }

        public void SetHealthCareNumber(int healthCareNumber)
        {
            this.healthCareNumber = healthCareNumber;
        }


        public string getFullname()
        {
            return fullName;
        }

        public int increaseCount()
        {
            return ++Count;
        }

        public int reduceCount()
        {
            return --Count;
        }



    }
}
