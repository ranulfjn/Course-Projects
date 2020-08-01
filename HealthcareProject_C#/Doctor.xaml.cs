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

namespace HealthcareProject
{
    /// <summary>
    /// Interaction logic for Doctor.xaml
    /// </summary>
    public partial class Doctor : Page
    {
        int comboIndex = 0;
        object previousContentNew;
        string docName;
        PatientFile patientName;
        
        public Doctor(object previousContent ,PatientFile Patient , string _docName )
        {
            docName = _docName;
            patientName = Patient;
            InitializeComponent();
            BindDataMedication();
            previousContentNew = previousContent;
            
            
            

        }

        private void completeAppointment_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).Content = previousContentNew;
            ((MainWindow)Application.Current.MainWindow).RefreshDataCombo();
            ((MainWindow)Application.Current.MainWindow).RefreshDataGrid();

        }

        public void BindDataMedication()
        {
            
            
            if (HealthcareDatabase.AllMedications.Count > 0)
            {
                foreach(Medication prescriptionMedicine in HealthcareDatabase.AllMedications)
                {
                    if(prescriptionMedicine.test()==true)
                    {
                        comboIndex = -1;
                        meds.SelectedIndex = comboIndex;
                        meds.Items.Add(prescriptionMedicine);
                    }
                }
               
            }

        }

        public void RefreshDataCombo()
        {
            comboIndex = meds.SelectedIndex;

            //meds.ItemsSource = null;
            //meds.ItemsSource = HealthcareDatabase.AllMedications;

            if (HealthcareDatabase.AllMedications.Count > comboIndex)
            {
                foreach (Medication prescriptionMedicine in HealthcareDatabase.AllMedications)
                {
                    if (prescriptionMedicine.test() == true)
                    {
                        comboIndex = -1;
                        meds.SelectedIndex = comboIndex;
                        meds.Items.Add(prescriptionMedicine);
                    }
                }
            }
            meds.ItemsSource = null;
            //meds.ItemsSource = HealthcareDatabase.AllMedications;
        }

        private void textBlock_Initialized(object sender, EventArgs e)
        {
            
                textBlock.Text = patientName.fullName + " Visits " + docName; 
           
            
        }

        private void info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The Refill count indicates that how many times this prescription can be filled at a pharmacy before it needs to be renewed by the doctor");
        }

        private void requestPresciption_Click(object sender, RoutedEventArgs e)
        {

            Object selectedMed = meds.SelectedItem;
            Medication medicine = (Medication)selectedMed;
            if (selectedMed == null)
            {
                MessageBox.Show("You have not selected Medication !!", "ERROR!!!");
            }
            else
            {
                if (refill.Text != "")
                {
                    int refil = int.Parse(refill.Text);
                    if (refil > 0)
                    {
                        PatientFile.list.Add(new Prescription(medicine, patientName, docName, refil));
                        MessageBox.Show(docName + " has Prescribed " + meds.SelectedItem.ToString() + " to " + patientName.fullName + " With " + refill.Text + " refills");
                        RefreshDataCombo();
                        refill.Text = "";
                    }
                    else
                    { 
                        MessageBox.Show("Enter number of  Refill Greater than 0!!!!", "ERROR!!!");
                        refill.Text = "";

                    }

                }
                else MessageBox.Show("Enter number of  Refill Greater than 0!!!!", "Input Refils");

            }
        }

       
    }
}
