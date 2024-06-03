using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using ISAD_Assignment.form;
using Microsoft.VisualBasic.ApplicationServices;
using System.Runtime.Remoting.Contexts;


namespace ISAD_Assignment
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        
        }

        //SqlConnection conn = new SqlConnection(@"Data Source=MORK-RAKSA\SQLEXPRESS;Initial Catalog=""ISAD Assignment"";User ID=""MORK-RAKSA"";Password=""@M0rkr@ksa24"";Connect Timeout=30;Encrypt=True;TrustServerCertificate=True");
        SqlConnection conn = new SqlConnection(@"Data Source = 45.119.135.148,1433; Initial Catalog = ""ISAD Assignment""; User ID = sa; Password=@M0rkr@ksa24; Connect Timeout = 30; Encrypt=True;TrustServerCertificate=True");

        private void gunaCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
                
            try
            {
                conn.Open();

                string query = "SELECT * FROM tbLogin WHERE username = '" + txtUsername.Text + "' AND password ='" + txtPassword.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                
                sda.SelectCommand.Parameters.AddWithValue("@username", username);
                sda.SelectCommand.Parameters.AddWithValue("@password", password);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    frmMain frmMain = new frmMain();
                    frmMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.");
                    txtUsername.Clear();
                    txtPassword.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnLogin_Enter(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            try
            {
                conn.Open();

                string query = "SELECT * FROM tbLogin WHERE username = '" + txtUsername.Text + "' AND password ='" + txtPassword.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);


                sda.SelectCommand.Parameters.AddWithValue("@username", username);
                sda.SelectCommand.Parameters.AddWithValue("@password", password);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    frmMain frmMain = new frmMain();
                    frmMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.");
                    txtUsername.Clear();
                    txtPassword.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
