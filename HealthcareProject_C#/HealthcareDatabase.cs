using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareProject
{
    public static class HealthcareDatabase
    {
        public static List<PatientFile> allPatientFiles = new List<PatientFile>()
        {
            new PatientFile("Jadon","Sancho",100),
            new PatientFile("Earling","Halland",101),
            new PatientFile("Marcus","Rashford",102),
            new PatientFile("Paul","Pogba",103),
            new PatientFile("Mason","Greenwood",104),
            new PatientFile("Brandon","Williams",105),
            new PatientFile("James","Garner",106),
            new PatientFile("Bruno","Fernandes",107)
        };



        public static List<string> AllDoctors = new List<string>()
        {
            "Dr. Jose M",
            "Dr. Ole S",
            "Dr. Ian Bell",
            "Dr. Tim Sherwood"
        };



        public static List<string> AllPharmacists = new List<string>()
        {
            "Appolo",
            "Indiana Pharmacists",
            "Quebec Meds",
            "Montreal Pharma"
        };


        public static List<Medication> AllMedications = new List<Medication>()
        {
             new PrescriptionMedication("Insulin",12.5,true),
             new PrescriptionMedication("Paracetamol",2.6,true),
             new PrescriptionMedication("Mumps",16.8,true),
             new PrescriptionMedication("Polio",5.6,true),
             new OverTheCounterMedication("2","Meseals",9.5,false),
            new OverTheCounterMedication("1","SmallPox",20.5,false),
            new OverTheCounterMedication("3","Hepatitis B",56.2,false),
            new OverTheCounterMedication("1","Hepatitis A",42,false)
        };




    }
}
