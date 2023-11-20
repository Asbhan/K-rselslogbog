using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tur_og_Retur_kørselslogbog
{
    public partial class Hovedmenu : Form
    {
        public Hovedmenu()
        {
            InitializeComponent();
            Showlog();
            StartPosition = FormStartPosition.Manual;
                Location = new Point(500, 100);

        }
        SqlConnection sqlConn = new SqlConnection(@"Data Source=WIN-R76V3RD7H1E;Initial Catalog=Kørselslog;Integrated Security=True");

        private void Showlog()
        {
            listView1.Items.Clear();

            listView1.View = View.Details;
            listView1.Columns.Add("Fra", 120);
            listView1.Columns.Add("Til", 120);
            listView1.Columns.Add("Kilometer", 110);
            listView1.Font = new Font("Arial", 10);

            sqlConn.Open();
            SqlCommand viewLog = new SqlCommand("SELECT * FROM kørselslog WHERE BrugerId = @BrugerId", sqlConn);
            viewLog.Parameters.AddWithValue("@BrugerId", Variables.brugerId);
                SqlDataReader reader = viewLog.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["Start"].ToString());
                item.SubItems.Add(reader["Slut"].ToString());
                item.SubItems.Add(reader["Kilometer"].ToString());

                listView1.Items.Add(item);
            }
            reader.Close();
            sqlConn.Close();
        }
        private void TilføjLog_knap_Click(object sender, EventArgs e)
        {
            StartTextbox.Visible = true;
            SlutTextbox.Visible = true;
            KilometerTextbox.Visible = true;
            Start.Visible = true;
            Slut.Visible = true;
            Kilometer.Visible = true;

            TilføjLog_knap.Visible = false;
            TilføjInformationer.Visible = true;

            StartTextbox.Clear();
            SlutTextbox.Clear();
            KilometerTextbox.Clear();
        }

        private void ReloadForm()
        {
            // Create a new instance of the form and show it
            Hovedmenu mainMenu = new Hovedmenu();
            mainMenu.Show();

            // Close the current form
            this.Close();
        }

        private void Kørselslog_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Tilføj_Click(object sender, EventArgs e)
        {

        }

        private void StartTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SlutTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void KilometerTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Hovedmenu_Load(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {

        }

        private void Slut_Click(object sender, EventArgs e)
        {

        }

        private void Kilometer_Click(object sender, EventArgs e)
        {

        }

        private void TilføjInformationer_Click(object sender, EventArgs e)
        {
                sqlConn.Open();
                StartTextbox.Visible = false;
                SlutTextbox.Visible = false;
                KilometerTextbox.Visible = false;
                Start.Visible = false;
                Slut.Visible = false;
                Kilometer.Visible = false;

                TilføjLog_knap.Visible = true;
                TilføjInformationer.Visible = false;



            string insertQuery = "INSERT INTO kørselslog(Start, Slut, Kilometer, BrugerId) " + "VALUES('" + StartTextbox.Text + "', '" + SlutTextbox.Text + "', '" + KilometerTextbox.Text + "' , '" + Variables.   brugerId + "')";
            using (SqlCommand command = new SqlCommand(insertQuery, sqlConn))
            {
                command.ExecuteNonQuery();
            }

            SqlCommand reload = new SqlCommand("SELECT * FROM kørselslog", sqlConn);
            SqlDataAdapter da = new SqlDataAdapter(reload);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MessageBox.Show("Kørselslog er blevet tilføjet!");
            sqlConn.Close();
            ReloadForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginMenu loginMenu = new LoginMenu();
            loginMenu.Show();
            this.Hide();
        }
    }
    
}