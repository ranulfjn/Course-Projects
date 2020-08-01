using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Packaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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
    /// Interaction logic for Pharmacy.xaml
    /// </summary>
    public partial class Pharmacy : Page
    {
        int comboIndex = 0;
        object previousContentNew;
        PatientFile name;
        public Pharmacy(object previousContent, PatientFile Name)
        {
            name = Name;
            InitializeComponent();
            BindDataPharmacy();
            BindDataMeds();
            previousContentNew = previousContent;

        }

        private void exitPharmacy_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).Content = previousContentNew;
            ((MainWindow)Application.Current.MainWindow).RefreshDataCombo();
            ((MainWindow)Application.Current.MainWindow).RefreshDataGrid();
        }

        private void drugInfo_Click(object sender, RoutedEventArgs e)
        {
            Object selectedObject = PharmacyData.SelectedItem;
            if (selectedObject != null)
            {
                Medication selectedMedicine = (Medication)PharmacyData.SelectedItem;
                Medication selectedMed = selectedMedicine;
                MessageBox.Show(selectedMed.GetInfo(), "Details");
                

            }
            else
            {
                MessageBox.Show("You have not selected option!!", "ERROR!!!");
            }
            RefreshDataGrid();
        }



        public void BindDataPharmacy()
        {

            comboPharma.ItemsSource = HealthcareDatabase.AllPharmacists;
            if (HealthcareDatabase.AllPharmacists.Count > 0)
            {
                comboIndex = -1;
                comboPharma.SelectedIndex = comboIndex;
            }

        }

        public void RefreshDataCombo()
        {
            comboIndex = comboPharma.SelectedIndex;

            comboPharma.ItemsSource = null;
            comboPharma.ItemsSource = HealthcareDatabase.AllPharmacists;

            if (HealthcareDatabase.AllPharmacists.Count > comboIndex)
            {
                comboPharma.SelectedIndex = comboIndex;
            }
            comboPharma.ItemsSource = null;
            comboPharma.ItemsSource = HealthcareDatabase.AllPharmacists;
        }

        void BindDataMeds()
        {
            PharmacyData.ItemsSource = HealthcareDatabase.AllMedications;
        }

        private void purchase_Click(object sender, RoutedEventArgs e)
        {

            Object selectedObject = PharmacyData.SelectedItem;
            Medication selectedMedicine = (Medication)PharmacyData.SelectedItem;
            Object selectedCombo = comboPharma.SelectedItem;
            Medication selectedMed = selectedMedicine;
            
            
           
                if (selectedObject != null )
                {

                   // MessageBox.Show(name.fullName + " has purchased drug : " + selectedMed.name() + ", for unit price : " + selectedMed.price() + "$", "Purchase Details");
                    if (selectedMed.test() == false )
                    {
                        MessageBox.Show(name.fullName +" has purchased drug : " + selectedMed.name() + ", for unit price : " + selectedMed.price()+"$" ,"Purchase Details") ;
                    }

                    else 
                    {
                         MessageBox.Show("This is prescription Medicine so pharmacy assisstance is needed . \n Please select a pharmacy to help fill the prescription. \n","Details");


                    }
                }
                 else
                {
                    MessageBox.Show("You have not selected Medicine !!", "ERROR!!!");
                }
            

            

            /*if (selectedMed.test() == true)
            {
                MessageBox.Show("This is prescription Medicine so pharmacy assisstance is needed . \n Please select a pharmacy to help fill the prescription. \n", "Details");
                
            }*/


                if (selectedCombo != null && PharmacyData.SelectedItem != null)
                {
                    bool t = false;
                    foreach (Prescription p in PatientFile.list)
                    {
                        string med = p.medicine.nameOfMedicine.ToString();
                        string pat = p.patient.fullName.ToString();
                        if (med == selectedMed.name() && pat == name.fullName)
                        {
                            string selectedComboPharma = selectedCombo.ToString();
                            Prescription a = new Prescription(selectedMed, name, "", 0);
                            a.FillPrescription(p, p.refills);
                            MessageBox.Show("Pharmacist "+selectedComboPharma + " has helped "+ name.fullName +" to get prescription for  " + selectedMed.name() +"\n"+ name.fullName+ " has purchased "+ selectedMed.name() +" with Unit price: " + selectedMed.price()+ " ,Remaining refills :" + --p.refills);
                        if (p.refills == 0)
                        { 
                            MessageBox.Show("Pharmacist " + selectedCombo.ToString() + " Says " + name.fullName + " does not have enough refils in prescription , Please contact Doctor get Prescription to buy this drug again in Future"); }
                            t = true;
                                break;
                        }
                        //else
                        

                    }
                            if (t == false)
                                MessageBox.Show("Pharmacist " + selectedCombo.ToString()+" Says " + name.fullName + " does not have  Prescription for " + selectedMed.name() + ",Please get prescription from Doctor");

                //MessageBox.Show(name.fullName + " Does not have  Prescription for " + selectedMed.name() + " Get prescription from Doctor");



                }
                else if (selectedCombo == null && PharmacyData.SelectedItem == null)
                {
                    MessageBox.Show("You have to  select Both PHARMACY and MEDICATION ", "ERROR!!!");
                }
              

            RefreshDataCombo();
            //RefreshDataGrid();


        }


        public void RefreshDataGrid()
        {
            PharmacyData.ItemsSource = null;
            PharmacyData.ItemsSource = HealthcareDatabase.AllMedications;
        }

        private void Tblock_Initialized(object sender, EventArgs e)
        {
            Tblock.Text = name.fullName + " shops at Pharmacy " ;
        }
    }
}
