using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using advanced_programing_projrct;
using advanced_programing_projrct.models;
using DevExpress.Xpo;

namespace ap_proj.forms_for_loging_in
{
    public partial class loginForm : DevExpress.XtraEditors.XtraForm
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private async void submitButton_Click(object sender, EventArgs e)
        {
            MainForm mainform;
            using (var db = new DatabaseContext())
            {
                if (UserNameTextBox.Text.Length >= 5 && PasswordTextBox.Text.Length>= 8)
                {
                    try
                    {
                        var user = await db.PatientClients.Where(p =>
                            p.Password.ToLower() == PasswordTextBox.Text.ToLower() &&
                            p.Name.ToLower() == UserNameTextBox.Text.ToLower()).FirstOrDefaultAsync();
                        if (user is null)
                        {
                            var doctor = await db.Doctors.Where(d =>
                                d.Name.ToLower() == UserNameTextBox.Text.ToLower() &&
                                d.Password.ToLower() == PasswordTextBox.Text.ToLower()).FirstOrDefaultAsync();
                            if (doctor is null)
                            {
                                var admin = await db.Admins.Where(a =>
                                    a.Password.ToLower() == PasswordTextBox.Text.ToLower() &&
                                    a.Name.ToLower() == UserNameTextBox.Text.ToLower()).FirstOrDefaultAsync();
                                if (admin is null)
                                {
                                    MessageBox.Show("username or password is incorrect");
                                }
                                else
                                {
                                    mainform = new MainForm(myUser: admin);
                                    mainform.Show();
                                    this.Dispose();
                                }
                            }
                            else
                            {
                                mainform = new MainForm(myUser: doctor);
                                mainform.Show();
                                this.Dispose();
                            }
                        }
                        else
                        {
                            mainform = new MainForm(myUser: user);
                            mainform.Show();
                            this.Dispose();
                        }
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception);
                        throw;
                    }
                }
                else
                {
                    MessageBox.Show("username or password is incorrect");
                    return;
                }
            }
        }
    }
}