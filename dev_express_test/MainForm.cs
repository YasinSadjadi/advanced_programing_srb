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
using advanced_programing_projrct.interfaces;
using advanced_programing_projrct.models;
using advanced_programing_projrct.models.Doctor;

namespace ap_proj
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm(IUser myUser)
        {
            InitializeComponent();
            User = myUser;
        }

        private IUser User;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (User.GetType() == typeof(Client))
            {

            }
            else if (User.GetType() == typeof(Doctor))
            {
                clientUserControl.Visible = false;
                clientUserControl.Enabled = false;
            }
        }
    }
}