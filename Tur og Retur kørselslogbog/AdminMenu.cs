using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tur_og_Retur_kørselslogbog
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
            loadusernames();
            Variables.opdaterId = true;
        }
        private void ReloadForm()
        {
            AdminMenu newForm = new AdminMenu();
            newForm.Show();

            Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void l_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Variables.brugerId != -1)
            {
                using (SqlConnection sqlConn = new SqlConnection(@"Data Source=WIN-R76V3RD7H1E;Initial Catalog=Kørselslog;Integrated Security=True"))
                {
                    sqlConn.Open();

                    string deleteQuery = "DELETE FROM login WHERE BrugerId = @BrugerId";

                    using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, sqlConn))
                    {
                        deleteCommand.Parameters.AddWithValue("@BrugerId", Variables.brugerId);

                        int rowsAffected = deleteCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Den valgte bruger, er blevet slettet.");
                            ReloadForm();
                        }
                        else
                        {
                            MessageBox.Show("Du skal vælge en bruger først.");
                        }
                    }
                }
            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void loadusernames()
        {
            using (SqlConnection sqlConn = new SqlConnection(@"Data Source=WIN-R76V3RD7H1E;Initial Catalog=Kørselslog;Integrated Security=True"))
            {
                sqlConn.Open();
                using (SqlCommand viewLog = new SqlCommand("SELECT Brugernavn From login", sqlConn))
                {
                    using (SqlDataReader reader = viewLog.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string usernames = reader.GetString(0);
                            userBox.Items.Add(usernames);
                        }
                        reader.Close();
                    }
                }
            }
        }
        private void userBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userBox.SelectedItem != null) 
            {
                if (Variables.opdaterId == true )
                {
                    Variables.brugerNavn = userBox.SelectedItem.ToString();

                    int brugerId = -1;
                    string valget = userBox.SelectedItem.ToString();
                    userBox.Items.Clear();
                    using (SqlConnection sqlConn = new SqlConnection(@"Data Source=WIN-R76V3RD7H1E;Initial Catalog=Kørselslog;Integrated Security=True"))
                    {
                        SqlCommand getId = new SqlCommand("SELECT BrugerId From login WHERE Brugernavn = @Brugernavn", sqlConn);
                        getId.Parameters.AddWithValue("@Brugernavn", valget);
                        sqlConn.Open();
                        var result = getId.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out brugerId))
                        {
                            Variables.brugerId = brugerId;
                            Console.WriteLine(Variables.brugerId.ToString());
                            Variables.opdaterId = false;
                            userInfo();
                        }
                    }
                }
               
            }
        }

        private void userInfo()
        {
            string query = "SELECT Start, Slut, Kilometer FROM kørselslog WHERE BrugerId = @BrugerId";
            using (SqlConnection sqlConn = new SqlConnection(@"Data Source=WIN-R76V3RD7H1E;Initial Catalog=Kørselslog;Integrated Security=True"))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConn);
                sqlCommand.Parameters.AddWithValue("@BrugerId", Variables.brugerId);
                sqlConn.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                userBox.Items.Clear();
                userBox.Items.Add(Variables.brugerNavn);

                while (reader.Read())
                {
                    string start = reader.GetString(0);
                    string slut = reader.GetString(1);
                    int kilometer = reader.GetInt32(2);

                    userBox.Items.Add($"Fra: {start}    Til: {slut}    Afstand: {kilometer}");
                }
                reader.Close();
            }
        }

        private void sletLog_Click(object sender, EventArgs e)
        {            
            if (Variables.brugerId != -1)
            {
                using (SqlConnection sqlConn = new SqlConnection(@"Data Source=WIN-R76V3RD7H1E;Initial Catalog=Kørselslog;Integrated Security=True"))
                {
                    sqlConn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT TOP 1 LogId FROM kørselslog ORDER BY LogId DESC", sqlConn);
                    object result = cmd.ExecuteScalar();
                    
                    int logId = Convert.ToInt32(result);

                    string deleteQuery = "DELETE FROM kørselslog WHERE LogId = @LogId";

                    using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, sqlConn))
                    {
                        deleteCommand.Parameters.AddWithValue("@LogId", logId);

                        int rowsAffected = deleteCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Kørselsloggen fra den valgte bruger, er blevet slettet.");
                            ReloadForm();
                        }
                        else
                        {
                            MessageBox.Show("Du skal vælge en bruger eller kørselslog først.");
                        }
                    }   
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginMenu loginMenu = new LoginMenu();
            loginMenu.Show();
            this.Hide();
        }

        private void opretBruger_Click(object sender, EventArgs e)
        {
            TilføjBruger addUser = new TilføjBruger();
            addUser.Show();
        }
    }
}