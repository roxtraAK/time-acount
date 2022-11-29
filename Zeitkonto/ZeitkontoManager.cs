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

namespace Zeitkonto
{
    public partial class ZeitkontoManager : Form
    {
        int Zeitkonto;

        Login form1;
        public int UserID { get; internal set; }

        public ZeitkontoManager()
        {
            InitializeComponent();
        }

        private void ZeitkontoManager_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            form1 = new Login();

            this.Close();

            form1.Show();

        }

        private void labelKommen_Click(object sender, EventArgs e)
        {
            var date = DateTime.Now.ToShortDateString();

            var time = DateTime.Now.ToShortTimeString();

            using (SqlConnection connection = new SqlConnection("Data Source=DEVN-18;Initial Catalog=Zeiterfassung2;Trusted_Connection=Yes;Integrated Security=True"))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Zeitkonto (kommenZeit, UserID) VALUES (@kommenzeit, @userid); SELECT SCOPE_IDENTITY();", connection);

                cmd.Parameters.AddWithValue("kommenzeit", DateTime.Now);

                cmd.Parameters.AddWithValue("userid", UserID);

                Zeitkonto = Convert.ToInt32(cmd.ExecuteScalar());
            };

            labelKommen.Enabled = false;

            MessageBox.Show($"Arrive: {date}, {time}");
        }

        public void labelGehen_Click(object sender, EventArgs e)
        {
            var date = DateTime.Now.ToShortDateString();

            var time = DateTime.Now.ToShortTimeString();

            using (SqlConnection connection = new SqlConnection("Data Source=DEVN-18;Initial Catalog=Zeiterfassung2;Trusted_Connection=Yes;Integrated Security=True"))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("UPDATE Zeitkonto SET gehenZeit = @gehenzeit WHERE gehenZeit IS NULL", connection);


                cmd.Parameters.AddWithValue("@zeitkonto", Zeitkonto);

                cmd.Parameters.AddWithValue("gehenzeit", DateTime.Now);

                cmd.ExecuteNonQuery();
            };

            labelGehen.Enabled = false;

            MessageBox.Show($"Leave: {date}, {time}");
        }

        public void labelInfo_Click(object sender, EventArgs e)
        {
            List<TimeSpan> GeleisteteStunden = new List<TimeSpan>();

            using (SqlConnection connection = new SqlConnection("Data Source=DEVN-18;Initial Catalog=Zeiterfassung2;Trusted_Connection=Yes;Integrated Security=True"))
            {
                connection.Open();

                SqlCommand kommen = new SqlCommand("SELECT kommenZeit, gehenZeit FROM Zeitkonto WHERE UserID = @userid", connection);

                kommen.Parameters.AddWithValue("userid", UserID);

                using (SqlDataReader dr = kommen.ExecuteReader())
                {
                    int _kommenOrdinal = dr.GetOrdinal("kommenZeit");
                    int _gehenOrdinal = dr.GetOrdinal("gehenZeit");

                    while (dr.Read())
                    {
                        DateTime kommenTime = dr.GetDateTime(_kommenOrdinal);
                        DateTime gehenTime = dr.GetDateTime(_gehenOrdinal);

                        TimeSpan stundenDifferenz = gehenTime - kommenTime;
                        GeleisteteStunden.Add(stundenDifferenz);

                    }
                }
            }
            var _hoursInfo = GeleisteteStunden.Sum(p_inputTimeSpan => p_inputTimeSpan.TotalHours).ToString("N2") + " hours";
            // Linq -> Sum https://www.csharp-examples.net/linq-sum/
            MessageBox.Show(_hoursInfo, "Info");
        }


        private void lblClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void lblKommenText_Click(object sender, EventArgs e)
        {

        }

        private void labelUsermanager_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
