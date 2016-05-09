// Created by: Jacob Gillenwater
// Started on: May 6th, 2016
// Completed : May 9th, 2016
// Coding time: (Est.) 6hrs
//
// Email: JakeGill70@Gmail.com
// Phone: 423-438-6828
// Addr: 1122 Qualls Rd, Kingsport, TN 37660


using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace JoesAutoPlus {
    public partial class mainForm : Form {

        public double oilPrice = 0.0;
        public double lubePrice = 0.0;
        public double tirePrice = 0.0;
        public double transmissionPrice = 0.0;
        public double mufflerPrice = 0.0;
        public double radiatorPrice = 0.0;
        public double inspectionPrice = 0.0;
        public double hourPrice = 0.0;
        public double taxRatePercent = 0.0;

        public mainForm() {
            getPrices();
            InitializeComponent();
        }

        private void optionsToolStripMenuItem1_Click(object sender, EventArgs e) {
            // Create a new instance of the Form2 class
            OptionsMenu optmnu = new OptionsMenu();

            // Show the settings form
            optmnu.Show();
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e) {
            DatabaseMenu optmnu = new DatabaseMenu();

            // Show the settings form
            optmnu.Show();
        }

        private double getRoutineCost() {
            double charge = 0.0;
            if (chk_oil.Checked)
            {
                charge += oilPrice;
            }
            if (chk_lube.Checked)
            {
                charge += lubePrice;
            }
            if (chk_tire.Checked)
            {
                charge += tirePrice;
            }
            if (chk_transmission.Checked)
            {
                charge += transmissionPrice;
            }
            if (chk_muffler.Checked)
            {
                charge += mufflerPrice;
            }
            if (chk_radiator.Checked)
            {
                charge += radiatorPrice;
            }
            if (chk_inspection.Checked)
            {
                charge += inspectionPrice;
            }
            return charge;
        }

        private double getPartsCost() {
            double partsCost = 0.0;
            if (!txt_parts.Text.Equals(String.Empty) && !Double.TryParse(txt_parts.Text, out partsCost))
            {
                MessageBox.Show("Please enter only enter numbers for the parts cost.");
            }
            return partsCost;
        }

        private double getLaborHours()
        {
            double laborHours = 0.0;
            if (!txt_labor.Text.Equals(String.Empty) && !Double.TryParse(txt_labor.Text, out laborHours))
            {
                MessageBox.Show("Please enter only enter numbers for the number of hours worked.");
            }
            return laborHours;
        }

        private double getSubTotal() {
            return (getRoutineCost() + getPartsCost() + (getLaborHours() * hourPrice));
        }

        private double getTaxAmount()
        {
            return ((getRoutineCost() + getPartsCost()) * (taxRatePercent / 100));
        }

        private double getTotalAmount() {
            return (getTaxAmount() + getSubTotal());
        }

        private void btn_calc_Click(object sender, EventArgs e) {

            getPrices();
            
            lbl_sub.Text = "Sub-total: $" + getSubTotal();
            lbl_tax.Text = "Tax: $" + getTaxAmount();
            lbl_total.Text = "Total: $" + getTotalAmount();
        }

        private void btn_exit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btn_clear_Click(object sender, EventArgs e) {
            chk_oil.Checked = false;
            chk_lube.Checked = false;
            chk_tire.Checked = false;
            chk_transmission.Checked = false;
            chk_muffler.Checked = false;
            chk_radiator.Checked = false;
            chk_inspection.Checked = false;

            txt_parts.Text = String.Empty;
            txt_labor.Text = String.Empty;
            txt_name.Text = String.Empty;
            txt_phone.Text = String.Empty;
            txt_make.Text = String.Empty;
            txt_model.Text = String.Empty;
            txt_year.Text = String.Empty;
            txt_comments.Text = String.Empty;

            lbl_sub.Text = "Sub-total: $0.00";
            lbl_tax.Text = "Tax: $0.00";
            lbl_total.Text = "Total: $0.00";

            cmb_condition.SelectedIndex = -1;
        }

        private void txt_comments_TextChanged(object sender, EventArgs e) {
            txt_comments.MaxLength = 140;
            lbl_comments.Text = "Comments (" + (140 - txt_comments.TextLength) + ")";
        }

        private void getPrices() {
            if (System.IO.File.Exists(Directory.GetCurrentDirectory() + @"\Options.txt")) {
                string[] lines = System.IO.File.ReadAllLines(Directory.GetCurrentDirectory() + @"\Options.txt");
                
                Double.TryParse(lines[0], out oilPrice);
                Double.TryParse(lines[1], out lubePrice        );
                Double.TryParse(lines[2], out tirePrice        );
                Double.TryParse(lines[3], out transmissionPrice);
                Double.TryParse(lines[4], out mufflerPrice     );
                Double.TryParse(lines[5], out radiatorPrice    );
                Double.TryParse(lines[6], out inspectionPrice  );
                Double.TryParse(lines[7], out hourPrice        );
                Double.TryParse(lines[8], out taxRatePercent   );


            }
            else {
                MessageBox.Show("Options.txt not found. Calculating using default values. Please save & apply options to resolve this error.");
                oilPrice = 32;
                lubePrice = 22;
                tirePrice = 26;
                transmissionPrice = 128;
                mufflerPrice = 82;
                radiatorPrice = 44;
                inspectionPrice = 28;
                hourPrice = 20;
                taxRatePercent = 0.1;
            }
        }

        private string getRountineServices() {
            string str = String.Empty;
            if (chk_oil.Checked) {
                str += "Oil Change, ";
            }
            if (chk_lube.Checked)
            {
                str += "Lube Job, ";
            }
            if (chk_tire.Checked) {
                str += "Tires Checked, ";
            }
            if (chk_transmission.Checked) {
                str += "Transmission flushed, ";
            }
            if (chk_muffler.Checked) {
                str += "Muffler Replaced, ";
            }
            if (chk_radiator.Checked)
            {
                str += "Radiator Flushed, ";
            }
            if (chk_inspection.Checked)
            {
                str += "Radiator Flushed";
            }
            return str;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string str = String.Empty;
            SqlConnection myConn = new SqlConnection("Server=localhost;Integrated security=SSPI;database=JoesAutoDB");
            // TODO: Format and sanitize all of this to avoid Injection (running out of time)
            try
            {
                str = "INSERT INTO[dbo].[SalesInfo]" +
                "([CustomerName]" +
                ",[CustomerPhone]" +
                ",[SaleDate]" +
                ",[Make]" +
                ",[Model]" +
                ",[Year]" +
                ",[Condition]" +
                ",[RoutineServices]" +
                ",[PartsCost]" +
                ",[HoursWorked]" +
                ",[LaborCost]" +
                ",[SubTotal]" +
                ",[Tax]" +
                ",[Total]" +
                ",[Comments])" +
                " VALUES" +
                "('" + txt_name.Text + "', " +
                "'" + txt_phone.Text + "', " +
                "GETDATE(), " +
                "'" + txt_make.Text + "', " +
                "'" + txt_model.Text + "', " +
                "'" + txt_year.Text + "', " +
                "'" + (String)cmb_condition.SelectedItem + "', " +
                "'" + getRountineServices() + "', " +
                "" + getPartsCost() + ", " +
                "" + getLaborHours() + ", " +
                "" + (getLaborHours() * hourPrice) + ", " +
                "" + getSubTotal() + ", " +
                "" + getTaxAmount() + ", " +
                "" + getTotalAmount() + ", " +
                "'" + txt_comments.Text + "') ";
            }
            catch (Exception ee) {
                MessageBox.Show(ee.ToString());
            }



            SqlCommand cmd = new SqlCommand(str, myConn);

            try
            {
                myConn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Information Saved");
            }
            catch (SqlException se) // se = Sql Exception
            {
                MessageBox.Show("Uh-oh. Looks like the database in either unreachable, " +
                    "or something went wrong when attempting to write data to the database" +
                    "\r\nFind more info here: \r\n" + se.ToString());
            }
            catch (Exception ge) // ge = General Exception
            {
                MessageBox.Show("ERROR : " + ge.ToString());
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_save_Click(this, EventArgs.Empty);
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_calc_Click(this, EventArgs.Empty);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_clear_Click(this, EventArgs.Empty);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_exit_Click(this, EventArgs.Empty);
        }
    }
}
