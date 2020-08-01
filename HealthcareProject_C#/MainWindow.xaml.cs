using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HealthcareProject //Referred class exercise code for ADD and REMOVE Fuctionalities
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        int comboIndex = 0;
        public MainWindow()
        {
            InitializeComponent();
            BindDataPatient();
            BindDataDoctors();
        }

        void BindDataPatient()
        {
            patientData.ItemsSource = HealthcareDatabase.allPatientFiles; //ADDING data to the Data Grid
        }

        public void RefreshDataGrid()
        {
            patientData.ItemsSource = null;
            patientData.ItemsSource = HealthcareDatabase.allPatientFiles;
        }
        void EmptyInputFieldsPatient()
        {
            firstName.Text = " ";
            lastName.Text = " ";
           
            
        }

        void EmptyInputFieldsDoctor()
        {
            
            DocFirstName.Text = " ";
            DocLastName.Text = " ";

        }

        private bool AreInputFieldsValidPatient()
        {
            bool isfNameValid, islNameValid;

            isfNameValid = firstName.Text != "";
            islNameValid = lastName.Text != "";

            return isfNameValid && islNameValid;
        }
        private bool AreInputFieldsValidDoctor()
        {
            bool  isDocFnameValid, isDocLnameValid;


            isDocFnameValid = DocFirstName.Text != "";
            isDocLnameValid = DocLastName.Text != "";

            return isDocFnameValid && isDocLnameValid; 
        }

        
        private void patientToDoctor_Click(object sender, RoutedEventArgs e)
        {
            Object selectedPatientObject = patientData.SelectedItem;
            Object selectedDocName = combo.SelectedItem;
            if (selectedPatientObject == null || selectedDocName == null)
            {
                MessageBox.Show("You have to select both PATIENT and DOCTOR  !!", "ERROR!!!");
            }
            else
            {
                PatientFile selectedPatientName = (PatientFile)selectedPatientObject;
                
                string docName = selectedDocName.ToString();
                
                Page docPage = new Doctor(this.Content, selectedPatientName,docName);
                this.Content = docPage;
            }

               

        }

        private void patientToPharmacy_Click(object sender, RoutedEventArgs e)
        {


            Object selectedPatientObject = patientData.SelectedItem;
            if (selectedPatientObject == null )
            {
                MessageBox.Show("You have not Selected a Patient !!", "ERROR!!!");
            }
            else
            {
                PatientFile selectedPatientName = (PatientFile)selectedPatientObject;
                
                Page pharmPage = new Pharmacy(this.Content, selectedPatientName);
                this.Content = pharmPage;

            }
        }

        private void add_Click(object sender, RoutedEventArgs e) //Add new Patient to Data Grid
        {
            if (AreInputFieldsValidPatient())
            {
                string fName = firstName.Text;
                string lName = lastName.Text;
                PatientFile obj= new PatientFile("","",0);
                PatientFile newPatient = new PatientFile(fName, lName,obj.increaseCount() );
                HealthcareDatabase.allPatientFiles.Add(newPatient);
                RefreshDataGrid();
                EmptyInputFieldsPatient();
            }
            else
            {
                MessageBox.Show("Input is not valid!!!", "ERROR!!!");
            }
        }

        private void remove_Click(object sender, RoutedEventArgs e) //Remove Patient from Data Grid  
        {
            Object selectedObject = patientData.SelectedItem;
            if (selectedObject != null)
            {
                PatientFile selectedPatient = (PatientFile)patientData.SelectedItem;
                string removePatient = selectedPatient.fullName;
                MessageBoxResult result = MessageBox.Show("Do you really want to remove " + removePatient, "Remove!!!", MessageBoxButton.YesNo);

                if (result == MessageBoxResult.Yes)
                {
                   
                    HealthcareDatabase.allPatientFiles.Remove(selectedPatient);
                    RefreshDataGrid();
                }
            }
            else
            {
                MessageBox.Show("You have not selected Patient Name to remove it!!", "ERROR!!!");
            }


         }


        public void BindDataDoctors() //Adding Data to the ComboBox
        {
            
            combo.ItemsSource = HealthcareDatabase.AllDoctors; 
            if (HealthcareDatabase.AllDoctors.Count > 0)
            {
                comboIndex = -1;
                combo.SelectedIndex = comboIndex;
            }

        }

        public void RefreshDataCombo()
        {
            comboIndex = combo.SelectedIndex;

            combo.ItemsSource = null;
            combo.ItemsSource = HealthcareDatabase.AllDoctors;

            if (HealthcareDatabase.AllDoctors.Count > comboIndex)
            {
                combo.SelectedIndex = comboIndex;
            }
            combo.ItemsSource = null;
            combo.ItemsSource = HealthcareDatabase.AllDoctors;
        }

        private void addDoc_Click(object sender, RoutedEventArgs e) //Add New Doctor  to ComboBox
        {
            string docFName = DocFirstName.Text;
            string docLName = DocLastName.Text;
            string docFullName = docFName + " " + docLName;
            if (docFName != "" && docLName != "")
            {
                HealthcareDatabase.AllDoctors.Add(docFullName);
                RefreshDataCombo();
                DocFirstName.Text="";
                DocLastName.Text="";
            }
            else
            {
                MessageBox.Show("You have not entered  name...", "ERROR!!!");
            }
        }

        private void removeDoc_Click(object sender, RoutedEventArgs e) //Remove  Doctor  from  ComboBox
        {
            if (combo.SelectedItem != null)
            {
                string selectedDocName = combo.SelectedItem.ToString();
                MessageBoxResult result = MessageBox.Show("Do you really want to remove " + selectedDocName, "Remove!!!", MessageBoxButton.YesNo);

                if (result == MessageBoxResult.Yes) 
                {
                    HealthcareDatabase.AllDoctors.Remove(selectedDocName);
                    RefreshDataCombo();
                }
               
            }
            else
            {
                MessageBox.Show("You have not selected Doctor to Remove it", "ERROR!!!");
            }
        }
    }
}
