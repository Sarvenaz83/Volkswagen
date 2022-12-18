namespace CsharpLoginAndRegister
{
    partial class MenuForm
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
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxTime = new System.Windows.Forms.ComboBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.comboBoxManuell = new System.Windows.Forms.ComboBox();
            this.comboBoxAutomate = new System.Windows.Forms.ComboBox();
            this.labelManuell = new System.Windows.Forms.Label();
            this.panelGearMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxclose3 = new System.Windows.Forms.PictureBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelAutomat = new System.Windows.Forms.Label();
            this.dataSetCars = new RegLog.DataSetCars();
            this.dataSetCarsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelMenu.SuspendLayout();
            this.panelGearMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxclose3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCarsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelMenu.Controls.Add(this.labelDate);
            this.panelMenu.Controls.Add(this.dateTimePickerDate);
            this.panelMenu.Controls.Add(this.comboBoxTime);
            this.panelMenu.Controls.Add(this.labelTime);
            this.panelMenu.Controls.Add(this.comboBoxColor);
            this.panelMenu.Controls.Add(this.labelColor);
            this.panelMenu.Controls.Add(this.comboBoxManuell);
            this.panelMenu.Controls.Add(this.comboBoxAutomate);
            this.panelMenu.Controls.Add(this.labelManuell);
            this.panelMenu.Controls.Add(this.panelGearMenu);
            this.panelMenu.Controls.Add(this.buttonOk);
            this.panelMenu.Controls.Add(this.labelAutomat);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(797, 482);
            this.panelMenu.TabIndex = 2;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Load);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelDate.Location = new System.Drawing.Point(97, 308);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(78, 32);
            this.labelDate.TabIndex = 18;
            this.labelDate.Text = "Date";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CalendarForeColor = System.Drawing.Color.AliceBlue;
            this.dateTimePickerDate.CalendarMonthBackground = System.Drawing.Color.RoyalBlue;
            this.dateTimePickerDate.CalendarTitleBackColor = System.Drawing.Color.CornflowerBlue;
            this.dateTimePickerDate.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.dateTimePickerDate.CalendarTrailingForeColor = System.Drawing.Color.AliceBlue;
            this.dateTimePickerDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePickerDate.CustomFormat = "";
            this.dateTimePickerDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDate.Location = new System.Drawing.Point(197, 308);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(510, 35);
            this.dateTimePickerDate.TabIndex = 17;
            // 
            // comboBoxTime
            // 
            this.comboBoxTime.BackColor = System.Drawing.Color.RoyalBlue;
            this.comboBoxTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTime.ForeColor = System.Drawing.Color.AliceBlue;
            this.comboBoxTime.FormattingEnabled = true;
            this.comboBoxTime.Items.AddRange(new object[] {
            "ID.3                    479 900,00",
            "ID.4                    566 900,00 kr",
            "ID.5                    591 900,00",
            "ID. Buzz              625 000,00 kr",
            "ID. Buzz Cargo   611 250,00 kr",
            "T-Cross              239 900,00 kr"});
            this.comboBoxTime.Location = new System.Drawing.Point(197, 255);
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(510, 37);
            this.comboBoxTime.TabIndex = 16;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelTime.Location = new System.Drawing.Point(94, 260);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(81, 32);
            this.labelTime.TabIndex = 15;
            this.labelTime.Text = "Time";
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.BackColor = System.Drawing.Color.RoyalBlue;
            this.comboBoxColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxColor.ForeColor = System.Drawing.Color.AliceBlue;
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Items.AddRange(new object[] {
            "ID.3                    479 900,00",
            "ID.4                    566 900,00 kr",
            "ID.5                    591 900,00",
            "ID. Buzz              625 000,00 kr",
            "ID. Buzz Cargo   611 250,00 kr",
            "T-Cross              239 900,00 kr"});
            this.comboBoxColor.Location = new System.Drawing.Point(197, 203);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(510, 37);
            this.comboBoxColor.TabIndex = 14;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelColor.Location = new System.Drawing.Point(88, 203);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(87, 32);
            this.labelColor.TabIndex = 13;
            this.labelColor.Text = "Color";
            // 
            // comboBoxManuell
            // 
            this.comboBoxManuell.BackColor = System.Drawing.Color.RoyalBlue;
            this.comboBoxManuell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxManuell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxManuell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxManuell.ForeColor = System.Drawing.Color.AliceBlue;
            this.comboBoxManuell.FormattingEnabled = true;
            this.comboBoxManuell.Items.AddRange(new object[] {
            "ID.3                    479 900,00",
            "ID.4                    566 900,00 kr",
            "ID.5                    591 900,00",
            "ID. Buzz              625 000,00 kr",
            "ID. Buzz Cargo   611 250,00 kr",
            "T-Cross              239 900,00 kr"});
            this.comboBoxManuell.Location = new System.Drawing.Point(197, 150);
            this.comboBoxManuell.Name = "comboBoxManuell";
            this.comboBoxManuell.Size = new System.Drawing.Size(510, 37);
            this.comboBoxManuell.TabIndex = 12;
            // 
            // comboBoxAutomate
            // 
            this.comboBoxAutomate.BackColor = System.Drawing.Color.RoyalBlue;
            this.comboBoxAutomate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxAutomate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxAutomate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAutomate.ForeColor = System.Drawing.Color.AliceBlue;
            this.comboBoxAutomate.FormattingEnabled = true;
            this.comboBoxAutomate.Location = new System.Drawing.Point(197, 96);
            this.comboBoxAutomate.Name = "comboBoxAutomate";
            this.comboBoxAutomate.Size = new System.Drawing.Size(510, 37);
            this.comboBoxAutomate.TabIndex = 11;
            // 
            // labelManuell
            // 
            this.labelManuell.AutoSize = true;
            this.labelManuell.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManuell.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelManuell.Location = new System.Drawing.Point(53, 150);
            this.labelManuell.Name = "labelManuell";
            this.labelManuell.Size = new System.Drawing.Size(122, 32);
            this.labelManuell.TabIndex = 10;
            this.labelManuell.Text = "Manuell";
            // 
            // panelGearMenu
            // 
            this.panelGearMenu.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelGearMenu.Controls.Add(this.label1);
            this.panelGearMenu.Controls.Add(this.pictureBoxclose3);
            this.panelGearMenu.Location = new System.Drawing.Point(0, 0);
            this.panelGearMenu.Name = "panelGearMenu";
            this.panelGearMenu.Size = new System.Drawing.Size(797, 73);
            this.panelGearMenu.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(287, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Volkswagen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxclose3
            // 
            this.pictureBoxclose3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxclose3.Image = global::RegLog.Properties.Resources.xx;
            this.pictureBoxclose3.ImageLocation = "";
            this.pictureBoxclose3.Location = new System.Drawing.Point(759, 12);
            this.pictureBoxclose3.Name = "pictureBoxclose3";
            this.pictureBoxclose3.Size = new System.Drawing.Size(26, 21);
            this.pictureBoxclose3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxclose3.TabIndex = 7;
            this.pictureBoxclose3.TabStop = false;
            this.pictureBoxclose3.Click += new System.EventHandler(this.pictureBoxclose3_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOk.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.buttonOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.buttonOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOk.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOk.Location = new System.Drawing.Point(230, 369);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(420, 61);
            this.buttonOk.TabIndex = 7;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelAutomat
            // 
            this.labelAutomat.AutoSize = true;
            this.labelAutomat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutomat.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelAutomat.Location = new System.Drawing.Point(48, 96);
            this.labelAutomat.Name = "labelAutomat";
            this.labelAutomat.Size = new System.Drawing.Size(127, 32);
            this.labelAutomat.TabIndex = 2;
            this.labelAutomat.Text = "Automat";
            // 
            // dataSetCars
            // 
            this.dataSetCars.DataSetName = "DataSetCars";
            this.dataSetCars.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetCarsBindingSource
            // 
            this.dataSetCarsBindingSource.DataSource = this.dataSetCars;
            this.dataSetCarsBindingSource.Position = 0;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 482);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenueForm";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelGearMenu.ResumeLayout(false);
            this.panelGearMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxclose3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCarsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label labelAutomat;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Panel panelGearMenu;
        private System.Windows.Forms.PictureBox pictureBoxclose3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelManuell;
        private System.Windows.Forms.ComboBox comboBoxAutomate;
        private RegLog.DataSetCars dataSetCars;
        private System.Windows.Forms.BindingSource dataSetCarsBindingSource;
        private System.Windows.Forms.ComboBox comboBoxManuell;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.ComboBox comboBoxTime;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Label labelColor;
    }
}