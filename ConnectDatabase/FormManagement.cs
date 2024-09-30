using System.Data.SqlClient;
using System.Data;
namespace ConnectDatabase
{
    public partial class FormManagement : Form
    {
        String strCon = @"Data Source=DESKTOP-0PJCAJ8\SQLEXPRESS;Initial Catalog=Home;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
        SqlConnection sqlCon = null;
        public FormManagement()
        {
            InitializeComponent();
        }
        public void btn1_connect_Click(Object sender, EventArgs e)
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                    MessageBox.Show("Connect successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn2_Close_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                    MessageBox.Show("Close successfully!");
                }
                else
                {
                    MessageBox.Show("Connection is not open!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        DataTable dt1 = new DataTable();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btn3_LoadData_Click(object sender, EventArgs e)
        {
            try
            {
                if(sqlCon.State==ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                
                String sql = "SELECT * FROM Employees";
                SqlDataAdapter adt = new SqlDataAdapter(sql, sqlCon);
                adt.Fill(dt1);
                dataGridView1.DataSource = dt1;
                if(sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
