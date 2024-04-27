namespace ap_proj.forms_for_loging_in
{
    partial class setClientDetailsForm
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
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            heightTextbox = new DevExpress.XtraEditors.SpinEdit();
            weightTextbox = new DevExpress.XtraEditors.SpinEdit();
            insurentesCombobox = new DevExpress.XtraEditors.ComboBoxEdit();
            submitButton = new DevExpress.XtraEditors.SimpleButton();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)heightTextbox.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)weightTextbox.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)insurentesCombobox.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem4).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(heightTextbox);
            layoutControl1.Controls.Add(weightTextbox);
            layoutControl1.Controls.Add(insurentesCombobox);
            layoutControl1.Controls.Add(submitButton);
            layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl1.Location = new System.Drawing.Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new System.Drawing.Size(800, 298);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // heightTextbox
            // 
            heightTextbox.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            heightTextbox.Location = new System.Drawing.Point(73, 15);
            heightTextbox.Name = "heightTextbox";
            heightTextbox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            heightTextbox.Size = new System.Drawing.Size(322, 24);
            heightTextbox.StyleController = layoutControl1;
            heightTextbox.TabIndex = 0;
            // 
            // weightTextbox
            // 
            weightTextbox.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            weightTextbox.Location = new System.Drawing.Point(463, 15);
            weightTextbox.Name = "weightTextbox";
            weightTextbox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            weightTextbox.Size = new System.Drawing.Size(322, 24);
            weightTextbox.StyleController = layoutControl1;
            weightTextbox.TabIndex = 2;
            // 
            // insurentesCombobox
            // 
            insurentesCombobox.Location = new System.Drawing.Point(73, 49);
            insurentesCombobox.Name = "insurentesCombobox";
            insurentesCombobox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            insurentesCombobox.Size = new System.Drawing.Size(712, 22);
            insurentesCombobox.StyleController = layoutControl1;
            insurentesCombobox.TabIndex = 3;
            // 
            // submitButton
            // 
            submitButton.Location = new System.Drawing.Point(188, 225);
            submitButton.Name = "submitButton";
            submitButton.Size = new System.Drawing.Size(423, 27);
            submitButton.StyleController = layoutControl1;
            submitButton.TabIndex = 4;
            submitButton.Text = "submit";
            submitButton.Click += submitButton_Click;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { emptySpaceItem1, layoutControlItem1, layoutControlItem2, layoutControlItem3, emptySpaceItem2, layoutControlItem4, emptySpaceItem3, emptySpaceItem4 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(800, 298);
            Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new System.Drawing.Point(0, 244);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new System.Drawing.Size(780, 34);
            emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = heightTextbox;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            layoutControlItem1.Size = new System.Drawing.Size(390, 34);
            layoutControlItem1.Text = "height";
            layoutControlItem1.TextSize = new System.Drawing.Size(46, 16);
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = weightTextbox;
            layoutControlItem2.Location = new System.Drawing.Point(390, 0);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            layoutControlItem2.Size = new System.Drawing.Size(390, 34);
            layoutControlItem2.Text = "weight";
            layoutControlItem2.TextSize = new System.Drawing.Size(46, 16);
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = insurentesCombobox;
            layoutControlItem3.Location = new System.Drawing.Point(0, 34);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            layoutControlItem3.Size = new System.Drawing.Size(780, 32);
            layoutControlItem3.Text = "insurent";
            layoutControlItem3.TextSize = new System.Drawing.Size(46, 16);
            // 
            // emptySpaceItem2
            // 
            emptySpaceItem2.AllowHotTrack = false;
            emptySpaceItem2.Location = new System.Drawing.Point(0, 66);
            emptySpaceItem2.Name = "emptySpaceItem2";
            emptySpaceItem2.Size = new System.Drawing.Size(780, 147);
            emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = submitButton;
            layoutControlItem4.Location = new System.Drawing.Point(176, 213);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new System.Drawing.Size(427, 31);
            layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            emptySpaceItem3.AllowHotTrack = false;
            emptySpaceItem3.Location = new System.Drawing.Point(603, 213);
            emptySpaceItem3.Name = "emptySpaceItem3";
            emptySpaceItem3.Size = new System.Drawing.Size(177, 31);
            emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            emptySpaceItem4.AllowHotTrack = false;
            emptySpaceItem4.Location = new System.Drawing.Point(0, 213);
            emptySpaceItem4.Name = "emptySpaceItem4";
            emptySpaceItem4.Size = new System.Drawing.Size(176, 31);
            emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // setClientDetailsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 298);
            Controls.Add(layoutControl1);
            Name = "setClientDetailsForm";
            Text = "setClientDetailsForm";
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)heightTextbox.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)weightTextbox.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)insurentesCombobox.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SpinEdit heightTextbox;
        private DevExpress.XtraEditors.SpinEdit weightTextbox;
        private DevExpress.XtraEditors.ComboBoxEdit insurentesCombobox;
        private DevExpress.XtraEditors.SimpleButton submitButton;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
    }
}