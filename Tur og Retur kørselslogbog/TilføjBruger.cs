using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tur_og_Retur_kørselslogbog
{
    public partial class TilføjBruger : Form
    {
        public TilføjBruger()
        {
            InitializeComponent();
        }

        private void addUser_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConn = new SqlConnection(@"Data Source=WIN-R76V3RD7H1E;Initial Catalog=Kørselslog;Integrated Security=True"))
            {
                sqlConn.Open();
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 BrugerId FROM login ORDER BY BrugerId DESC", sqlConn);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    int brugerID = Convert.ToInt32(result) + 1;
                    string insertQuery = "INSERT INTO login(Brugernavn, Adgangskode, BrugerId) " + "VALUES('" + usernameBox.Text + "', '" + passwordBox.Text + "', '" + brugerID.ToString() + "')";
                    SqlCommand command = new SqlCommand(insertQuery, sqlConn);
                    command.ExecuteNonQuery();
                    Hide();
                }
            }
        }
            
    }      
}
