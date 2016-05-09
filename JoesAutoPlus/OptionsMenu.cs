using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Data.SqlClient;


namespace JoesAutoPlus {
    public partial class OptionsMenu : Form {

        private Form parentForm;

        public OptionsMenu() {
            Debug.Print("\r\n" + Directory.GetCurrentDirectory());
            parentForm = null;
            InitializeComponent();
        }

        public OptionsMenu(Form callingForm) {
            parentForm = callingForm as mainForm;
            InitializeComponent();
        }

        private void btn_saveOptions_Click(object sender, EventArgs e) {
            // TODO: Remove this comment:
            // use "\r\n" for a new line characte in C#
            string options = txt_oil.Text + "\r\n" + txt_lube.Text + "\r\n" + txt_tire.Text + "\r\n" + txt_transmission.Text +
                    "\r\n" + txt_muffler.Text + "\r\n" + txt_radiator.Text + "\r\n" + txt_inspection.Text + "\r\n" + txt_hourPrice.Text +
                    "\r\n" + txt_taxRate.Text;
            System.IO.File.WriteAllText(Directory.GetCurrentDirectory() + @"\Options.txt", options);
        }

        private void OptionsMenu_Load(object sender, EventArgs e) {
            if (System.IO.File.Exists(Directory.GetCurrentDirectory() + @"\Options.txt")) {
                string[] lines = System.IO.File.ReadAllLines(Directory.GetCurrentDirectory() + @"\Options.txt");

                txt_oil.Text = lines[0];
                txt_lube.Text = lines[1];
                txt_tire.Text = lines[2];
                txt_transmission.Text = lines[3];
                txt_muffler.Text = lines[4];
                txt_radiator.Text = lines[5];
                txt_inspection.Text = lines[6];
                txt_hourPrice.Text = lines[7];
                txt_taxRate.Text = lines[8];


            }
            else {
                txt_oil.Text = (32).ToString();
                txt_lube.Text = (22).ToString();
                txt_tire.Text = (26).ToString();
                txt_transmission.Text = (128).ToString();
                txt_muffler.Text = (82).ToString();
                txt_radiator.Text = (44).ToString();
                txt_inspection.Text = (28).ToString();
                txt_hourPrice.Text = (20).ToString();
                txt_taxRate.Text = (10).ToString();
            }
        }

        private void createDb() {
            string str;
            SqlConnection myConn = new SqlConnection("Server=localhost;Integrated security=SSPI;database=master");

            str = "CREATE DATABASE JoesAutoDB ON PRIMARY " +
                // " + Directory.GetCurrentDirectory() + @"\Options.txt" + "
                // C:\\tmp\\JoesAutoDB.mdf
                // C:\\tmp\\JoesAutoDBLog.ldf
                "(NAME = JoesAutoDb_Data, FILENAME = '" + Directory.GetCurrentDirectory() + @"\JoesAutoDB.mdf" + "', SIZE = 3MB, MAXSIZE = 20MB, FILEGROWTH = 10%) " +
                "LOG ON (NAME = JoesAutoDb_Log, FILENAME = '" + Directory.GetCurrentDirectory() + @"\JoesAutoDBLog.ldf" + "', SIZE = 3MB, MAXSIZE = 10MB, FILEGROWTH = 10%)";

            SqlCommand cmd = new SqlCommand(str, myConn);

            // If the connection was NOT successful, attempt to 
            try
            {
                myConn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Datebase was created successfully");
            }
            catch (SqlException se) {
                MessageBox.Show("Database already exist");
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR : " + e.ToString());
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }

        }

        private void createTable() {
            string str;
            SqlConnection myConn = new SqlConnection("Server=localhost;Integrated security=SSPI;database=JoesAutoDB");

            str = "CREATE TABLE [dbo].[SalesInfo]( " +
            "[SalesID][int] NOT NULL IDENTITY(1,1), " + 
            "[CustomerName] [varchar](25) NOT NULL," +
            "[CustomerPhone] [char](10) NOT NULL," +
            "[SaleDate] [date] NOT NULL," +
            "[Make] [varchar](20) NULL," +
            "[Model] [varchar](20) NULL," +
            "[Year] [char](4) NULL," +
            "[Condition] [varchar](10) NULL," +
            "[RoutineServices] [varchar](140) NULL," +
            "[PartsCost] [money] NULL," +
            "[HoursWorked] [float] NULL," +
            "[LaborCost] [money] NULL," +
            "[SubTotal] [money] NOT NULL," +
            "[Tax] [money] NOT NULL," +
            "[Total] [money] NOT NULL," +
            "[Comments] [varchar](140) NOT NULL," +
            "CONSTRAINT[PK_SalesInfo] PRIMARY KEY CLUSTERED" +
            "(" +
            "    [SalesID] ASC" +
            ")WITH(" +
            "    PAD_INDEX = OFF, " +
            "    STATISTICS_NORECOMPUTE = OFF, " +
            "    IGNORE_DUP_KEY = OFF, " +
            "    ALLOW_ROW_LOCKS = ON, " +
            "    ALLOW_PAGE_LOCKS = ON" +
            "    ) ON[PRIMARY]" +
            ") ON[PRIMARY]";

            SqlCommand cmd = new SqlCommand(str, myConn);

            try
            {
                myConn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sales Information Table was created successfully");
            }
            catch (SqlException se)
            {
                MessageBox.Show("Table already exist");
                MessageBox.Show("ERROR : " + se.ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR : " + e.ToString());
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
        }

        private void createDb_beta() {
            // DB location => D:\C# projects\JoesAutoPlus\JoesAutoPlus\JoesAutoDb.mdf

        }

        private void btn_buildDB_Click(object sender, EventArgs e) {
            createDb();
            createTable();
        }

        private void btn_clearDB_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("This will wipe the database totally clean. Are you sure you want to do this?", "WARNING! Clear database", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No)
            {
                return;
            }
            else {
                string str = string.Empty;
                SqlConnection myConn = new SqlConnection("Server=localhost;Integrated security=SSPI;database=JoesAutoDB");

                str = "SELECT * FROM SalesInfo";

                SqlCommand cmd = new SqlCommand(str, myConn);

                // If the connection was NOT successful, attempt to 
                try
                {
                    myConn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ge)
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
        }
    }
}
