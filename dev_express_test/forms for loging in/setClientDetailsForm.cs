using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using advanced_programing_projrct.models;
using advanced_programing_projrct;
using DevExpress.Skins;
using Microsoft.EntityFrameworkCore;

namespace ap_proj.forms_for_loging_in
{
    public partial class setClientDetailsForm : DevExpress.XtraEditors.XtraForm
    {
        public setClientDetailsForm(string clientName, string clientPassword, bool clientGender)
        {
            _name = clientName;
            _password = clientPassword;
            _gender = clientGender;
            InitializeComponent();
        }

        private string _name;
        private string _password;
        private bool _gender;



        private object[] insuretObjects =
        {
            "تعمین اجتماعی",
            "ایران",
        };

        private async void submitButton_Click(object sender, EventArgs e)
        {
            if (insurentesCombobox.SelectedItem is not null)
            {

                using (var db = new DatabaseContext())
                {
                    var client = new Client(name: _name, gender: _gender,
                        height: int.Parse(heightTextbox.Text), password: _password)
                    {
                        Weight = int.Parse(weightTextbox.Text),

                    };
                    try
                    {
                        if (await db.Database.CanConnectAsync())
                        {
                            db.Add(client);
                            db.Database.ExecuteSql($"SET IDENTITY_INSERT dbo.PatientClients ON");
                            await db.SaveChangesAsync();
                        }
                        else
                        {
                            //await db.Database.OpenConnectionAsync();
                            db.Add(client);
                            db.Database.ExecuteSql($"SET IDENTITY_INSERT dbo.PatientClients ON");
                            await db.SaveChangesAsync();
                        }

                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception);
                        throw;
                    }
                    finally
                    {
                        Application.Exit();
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("please fill the form");
            }
        }
    }
}