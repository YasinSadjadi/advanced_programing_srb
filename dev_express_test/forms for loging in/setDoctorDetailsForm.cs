using DevExpress.XtraGantt.Base.Scheduling;
using DevExpress.XtraScheduler;
using System.Windows.Forms;
using System;
using System.Data;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraLayout;
using LayoutMode = DevExpress.Export.LayoutMode;

namespace ap_proj.forms_for_loging_in
{
    public partial class setDoctorDetailsForm : DevExpress.XtraEditors.XtraForm
    {
        public setDoctorDetailsForm(string doctorName, string doctorPassword, bool doctorGender)
        {
            InitializeComponent();
            _name = doctorName;
            _password = doctorPassword;
            _gender = doctorGender;
            specialityTextbox.Properties.Items.AddRange(_specialityObjects);
        }
        private string _name;
        private string _password;
        private bool _gender;

        private readonly object[] _specialityObjects =
        {
            "متخصص قلب",
            "دندان پزشک",
            "متخصص مغز و اعصاب",
            "پزشک عمومی"
        };

        private void setDoctorDetailsForm_Load(object sender, EventArgs e)
        {
            var dataGridView = new DataGridView();
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.AllowUserToAddRows = false; // Disable adding new rows
            dataGridView.ReadOnly = false; // Allow editing

            // Set the number of columns and rows
            dataGridView.ColumnCount = 9;
            dataGridView.RowCount = 8;

            // Set the first column and first row to read-only
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                dataGridView[0, i].ReadOnly = true;
            }
            for (int j = 0; j < dataGridView.ColumnCount; j++)
            {
                dataGridView[j, 0].ReadOnly = true;
            }

            // Add the DataGridView to the form
            Controls.Add(dataGridView);
        }
    }
}
