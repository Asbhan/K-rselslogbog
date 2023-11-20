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
    public partial class LoginMenu : Form
    {
        public LoginMenu()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(500, 100);
        }
        SqlConnection sqlConn = new SqlConnection(@"Data Source=WIN-R76V3RD7H1E;Initial Catalog=Kørselslog;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void usernameInput_TextChanged(object sender, EventArgs e)
        {

        } 
        private void Adgangskode_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_knap_Click(object sender, EventArgs e)
        {
            String username, password, adminUsername, adminPassword;
          
                String querry = "SELECT * FROM LOGIN WHERE Brugernavn = '" + usernameInput.Text + "' AND Adgangskode = '" + Adgangskode_input.Text + "'";
                String adminQuerry = "SELECT * FROM ADMINLOGIN WHERE AdminBrugernavn = '" + usernameInput.Text + "' AND AdminAdgangskode = '" + Adgangskode_input.Text + "'";
                
                SqlDataAdapter sda = new SqlDataAdapter(querry, sqlConn);
                SqlDataAdapter adminDa = new SqlDataAdapter(adminQuerry, sqlConn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                DataTable aTable = new DataTable();
                adminDa.Fill(aTable);

                if (dtable.Rows.Count > 0) 
                {
                    username = usernameInput.Text;
                    password = Adgangskode_input.Text;

                    Variables.brugerId = Convert.ToInt32(dtable.Rows[0]["BrugerId"]);
                    Hovedmenu mainMenu = new Hovedmenu();
                    mainMenu.Show();
                    Hide();
                }
                else if (aTable.Rows.Count > 0)
                {
                    adminUsername = usernameInput.Text;
                    adminPassword = Adgangskode_input.Text;

                    AdminMenu adminPage = new AdminMenu();
                    adminPage.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Brugernavn eller adgangskode er forkert", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernameInput.Clear();
                    Adgangskode_input.Clear();

                    usernameInput.Focus();
         
                    sqlConn.Close();
                }
        }

        private void Hovedmenu_text_Click(object sender, EventArgs e)
        {

        }
    }
}
