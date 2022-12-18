using RegLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ColorCars = RegLog.ColorCars;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CsharpLoginAndRegister
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }
        MY_DB dB= new MY_DB();

        private void pictureBoxclose3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string automatemodel = comboBoxAutomate.Text;
            string manuelmodel = comboBoxManuell.Text;
            string color = comboBoxColor.Text;
            string time = comboBoxTime.Text;
            string date = dateTimePickerDate.Text;

            Cars cars = new Cars();
            AutomatModel obja = comboBoxAutomate.SelectedItem as AutomatModel;
            ColorCars objc = comboBoxColor.SelectedItem as ColorCars;
            Time objt = comboBoxTime.SelectedItem as Time;
            if (cars.insertCarsInfo(automatemodel, manuelmodel, color, time, date))
            {
                if (obja != null)
                {
                    DialogResult dialog = MessageBox.Show(string.Format("You Have Choosen Model {0} Color {1} in {2}", obja.Name, objc.Name, objt.Name, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information));
                    if (dialog == DialogResult.OK)
                        Application.ExitThread();
                }
            }
            else if (cars.insertCarsInfo(automatemodel, manuelmodel, color, time, date))
            {
                ManuellModel objm = comboBoxAutomate.SelectedItem as ManuellModel;
                if (objm != null)
                {
                    MessageBox.Show(string.Format("You Have Choosen Model {0} Color {1} in Clock {2}", objm.Name, objc.Name, objt.Name, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information));
                    Application.ExitThread();

                }
            }
            else
            {
                MessageBox.Show("Somthing Wrong", "Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
            
        }

        private void panelMenu_Load(object sender, PaintEventArgs e)
        {
            List<AutomatModel> atomatelist = new List<AutomatModel>();
            atomatelist.Add(new AutomatModel() { Name = "-----" });
            atomatelist.Add(new AutomatModel() { Name = "T-Cross (278 400,00 kr)" });
            atomatelist.Add(new AutomatModel() { Name = "Taigo (276 900,00 kr)" });
            atomatelist.Add(new AutomatModel() { Name = "T-Roc (312 900,00 kr)" });
            atomatelist.Add(new AutomatModel() { Name = "Golf (389 400,00 kr)" });
            atomatelist.Add(new AutomatModel() { Name = "Golf Sportscombi (313 900,00 kr)" });
            atomatelist.Add(new AutomatModel() { Name = "Touran (347 900,00 kr)" });
            comboBoxAutomate.DataSource = atomatelist;
            comboBoxAutomate.DisplayMember = "Name";

            List<ManuellModel> manuelllist = new List<ManuellModel>();
            manuelllist.Add(new ManuellModel() { Name = "-----" });
            manuelllist.Add(new ManuellModel() { Name = "ID.3 (479 900,00)" });
            manuelllist.Add(new ManuellModel() { Name = "ID.4 (566 900,00 kr)" });
            manuelllist.Add(new ManuellModel() { Name = "ID.5 (591 900,00kr)" });
            manuelllist.Add(new ManuellModel() { Name = "ID. Buzz (625 000,00 kr)" });
            manuelllist.Add(new ManuellModel() { Name = "ID. Buzz Cargo (611 250,00 kr)" });
            manuelllist.Add(new ManuellModel() { Name = "T- Cross (239 900,00 kr)" });
            comboBoxManuell.DataSource = manuelllist;
            comboBoxManuell.DisplayMember = "Name";

            List<ColorCars> colorlist = new List<ColorCars>();
            colorlist.Add(new ColorCars() { Name = "Blue" });
            colorlist.Add(new ColorCars() { Name = "Black" });
            colorlist.Add(new ColorCars() { Name = "Red" });
            colorlist.Add(new ColorCars() { Name = "Gray" });
            colorlist.Add(new ColorCars() { Name = "White" });
            comboBoxColor.DataSource = colorlist;
            comboBoxColor.DisplayMember = "Name";

            List<Time> timelist = new List<Time>();
            timelist.Add(new Time() { Name = "8.00 - 9.00" });
            timelist.Add(new Time() { Name = "9.00 - 10.00" });
            timelist.Add(new Time() { Name = "10.00 - 11.00" });
            timelist.Add(new Time() { Name = "11.00 - 12.00" });
            timelist.Add(new Time() { Name = "13.00 - 14.00" });
            timelist.Add(new Time() { Name = "14.00 - 15.00" });
            comboBoxTime.DataSource = timelist;
            comboBoxTime.DisplayMember = "Name";
        }

    }
}
