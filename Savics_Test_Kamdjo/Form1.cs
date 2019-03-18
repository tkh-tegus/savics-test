using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Savics_Test_Kamdjo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveClicked(object sender, EventArgs e)
        {
            string FisrtName = this.first_name.Text;
            string LastName = this.last_name.Text;
            int Age = int.Parse(this.ageTextbox.Value.ToString());
            string City = "";
            if(this.cityComboBox.SelectedItem != null)
            {
                City = ((KeyValuePair<string, string>)this.cityComboBox.SelectedItem).Value;
            }

            string Country = "";
            if (this.countryComboBox.SelectedItem != null)
            {
                Country = ((KeyValuePair<string, string>)this.countryComboBox.SelectedItem).Value;
            }

            
            string Sexe = "";
            int LivingWithDiabetes = 3;
            Sexe = (this.maleCheckBox.Checked ? "Male" : "Female");
            
            if (this.yesRadioButton.Checked)
            {
                LivingWithDiabetes = 1;
            }
            else if (this.noRadioButton.Checked)
            {
                LivingWithDiabetes = 2;
            }

            

            if (string.IsNullOrWhiteSpace(FisrtName))
            {
                this.error.Text = "Please enter the first name";
            }else if(Age <= 0)
            {
                this.error.Text = "age is greater than zero";
            }else if (string.IsNullOrWhiteSpace(City))
            {
               this.error.Text = "Please select a city";
            }
            else if (string.IsNullOrWhiteSpace(Country))
            {
                this.error.Text = "Please select a country";
            }
            else
            {
                
                Patient elt = new Patient
                {
                    FisrtName = FisrtName,
                    LastName = LastName,
                    City = City,
                    Country = Country,
                    Sexe = Sexe,
                    Age = Age,
                    LivingWithDiabetes = LivingWithDiabetes
                };
                this.medical_registre.Add(elt);
                if (elt.Age <= 18)
                {
                    medical_registre_filter.Add(elt);
                }
                Show(this.medical_registre);
                
            }
            
        }

        private void onlyMinorsClicked(object sender, EventArgs e)
        {

            if (this.OnlyMinorscheckBox.Checked)
            {
                Show(this.medical_registre_filter);
            }
            else
            {
                Show(this.medical_registre);
            }
        }
    }
}
