using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace JoesAutoPlus {
    public partial class DatabaseMenu : Form {
        public DatabaseMenu() {
            InitializeComponent();
        }

        private void DatabaseMenu_Load(object sender, EventArgs e)
        {
            string str = string.Empty;
            SqlConnection myConn = new SqlConnection("Server=localhost;Integrated security=SSPI;database=JoesAutoDB");

            str = "SELECT * FROM SalesInfo";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(str, myConn);
            DataSet myData = new DataSet();

            // If the connection was NOT successful, attempt to 
            try
            {
                myConn.Open();
                dataAdapter.Fill(myData, "SalesInfo");
            }
            catch (Exception ge)
            {
                MessageBox.Show("ERROR : " + ge.ToString());
                this.Close();
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
                salesDataGrid.DataSource = myData;
                salesDataGrid.DataMember = "SalesInfo";
                salesDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
        }
    }
}
