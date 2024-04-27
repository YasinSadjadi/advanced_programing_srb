namespace ap_proj.forms_for_loging_in
{
    partial class setDoctorDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            schedulerDataStorage1 = new DevExpress.XtraScheduler.SchedulerDataStorage(components);
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            comboBoxEdit1 = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            specialityTextbox = new DevExpress.XtraEditors.ComboBoxEdit();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)schedulerDataStorage1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)specialityTextbox.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(specialityTextbox);
            layoutControl1.Controls.Add(comboBoxEdit1);
            layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl1.Location = new System.Drawing.Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new System.Drawing.Size(1073, 388);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, emptySpaceItem1, layoutControlItem3 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(1073, 388);
            Root.TextVisible = false;
            // 
            // schedulerDataStorage1
            // 
            // 
            // 
            // 
            schedulerDataStorage1.AppointmentDependencies.AutoReload = false;
            // 
            // 
            // 
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(0, "None", "&None", System.Drawing.SystemColors.Window);
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(1, "Important", "&Important", System.Drawing.Color.FromArgb(255, 194, 190));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(2, "Business", "&Business", System.Drawing.Color.FromArgb(168, 213, 255));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(3, "Personal", "&Personal", System.Drawing.Color.FromArgb(193, 244, 156));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(4, "Vacation", "&Vacation", System.Drawing.Color.FromArgb(243, 228, 199));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(5, "Must Attend", "Must &Attend", System.Drawing.Color.FromArgb(244, 206, 147));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(6, "Travel Required", "&Travel Required", System.Drawing.Color.FromArgb(199, 244, 255));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(7, "Needs Preparation", "&Needs Preparation", System.Drawing.Color.FromArgb(207, 219, 152));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(8, "Birthday", "&Birthday", System.Drawing.Color.FromArgb(224, 207, 233));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(9, "Anniversary", "&Anniversary", System.Drawing.Color.FromArgb(141, 233, 223));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(10, "Phone Call", "Phone &Call", System.Drawing.Color.FromArgb(255, 247, 165));
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = comboBoxEdit1;
            layoutControlItem3.Location = new System.Drawing.Point(526, 0);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            layoutControlItem3.Size = new System.Drawing.Size(527, 32);
            layoutControlItem3.Text = "insurence";
            layoutControlItem3.TextSize = new System.Drawing.Size(55, 16);
            // 
            // comboBoxEdit1
            // 
            comboBoxEdit1.EditValue = "";
            comboBoxEdit1.Location = new System.Drawing.Point(608, 15);
            comboBoxEdit1.Name = "comboBoxEdit1";
            comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboBoxEdit1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] { new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "ایران"), new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "تامین اجتماعی"), new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "البرز") });
            comboBoxEdit1.Size = new System.Drawing.Size(450, 22);
            comboBoxEdit1.StyleController = layoutControl1;
            comboBoxEdit1.TabIndex = 2;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = specialityTextbox;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            layoutControlItem1.Size = new System.Drawing.Size(526, 32);
            layoutControlItem1.Text = "speciality";
            layoutControlItem1.TextSize = new System.Drawing.Size(55, 16);
            // 
            // specialityTextbox
            // 
            specialityTextbox.Location = new System.Drawing.Point(82, 15);
            specialityTextbox.Name = "specialityTextbox";
            specialityTextbox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            specialityTextbox.Size = new System.Drawing.Size(449, 22);
            specialityTextbox.StyleController = layoutControl1;
            specialityTextbox.TabIndex = 0;
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new System.Drawing.Point(0, 32);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new System.Drawing.Size(1053, 336);
            emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // setDoctorDetailsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1073, 388);
            Controls.Add(layoutControl1);
            Name = "setDoctorDetailsForm";
            Text = "setDoctorDetailsForm";
            Load += setDoctorDetailsForm_Load;
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)schedulerDataStorage1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)specialityTextbox.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraScheduler.SchedulerDataStorage schedulerDataStorage1;
        private DevExpress.XtraEditors.ComboBoxEdit specialityTextbox;
        private DevExpress.XtraEditors.CheckedComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}