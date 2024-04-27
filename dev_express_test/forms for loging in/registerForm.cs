using System;
using System.Windows.Forms;
using advanced_programing_projrct.models;
using ap_proj.forms_for_loging_in;
using DevExpress.XtraEditors;
using Microsoft.EntityFrameworkCore;

namespace dev_express_test
{
    public partial class registerForm : DevExpress.XtraEditors.XtraForm
    {
        public registerForm()
        {
            InitializeComponent();
        }

        private Client _newClient;
        private Doctor _newDoctor;

        private void submitButton_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click_1(object sender, EventArgs e)
        {

        }

        private void genderRadioGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void userTypeRadioGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userTypeRadioGroup.SelectedIndex == 0)
            {
                var heightSpin = new SpinEdit()
                {

                };
            }
            else
            {

            }
        }

        private void allSetButton_Click(object sender, EventArgs e)
        {
            var gender = genderRadioGroup.SelectedIndex == 0;
            if (nameTextbox.Text.Length > 4 && passwordTextbox.Text.Length >= 8
                                            && userTypeRadioGroup.SelectedIndex == 0)
            {
                var clientForm = new setClientDetailsForm(clientGender: gender, 
                    clientName: nameTextbox.Text, clientPassword: passwordTextbox.Text);
                this.Hide();
                clientForm.ShowDialog();

            }
            else if (nameTextbox.Text.Length > 4 && passwordTextbox.Text.Length >= 8
                                                 && userTypeRadioGroup.SelectedIndex == 1)
            {
                var doctorForm = new setDoctorDetailsForm(doctorName: nameTextbox.Text ,
                    doctorPassword: passwordTextbox.Text, doctorGender: gender);
                this.Hide();
                doctorForm.ShowDialog();
            }
            else if (nameTextbox.Text.Length <= 4)
            {
                MessageBox.Show(@"please fill the fullname box");
                nameTextbox.Focus();
            }
            else if (passwordTextbox.Text.Length < 8)
            {
                MessageBox.Show(@"please fill the password box");
                passwordTextbox.Focus();
            }
        }
    }
}
