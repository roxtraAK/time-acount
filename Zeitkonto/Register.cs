using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zeitkonto
{
    public partial class Register : Form
    {
        Login form1;

        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            form1 = new Login();

            // Blacklisted Usernames 
            List<string> blacklist = new List<string>();
            blacklist.Add("admin");
            blacklist.Add("master");
            blacklist.Add("Nigger");
            blacklist.Add("Neger");
            blacklist.Add("Japse");

            if (PasswordEingabe.Text.Length < 5)
            {
                MessageBox.Show("Dein Passwort ist nicht lang genug (min. 5 Zeichen)");
                return;
            }

            if (blacklist.Contains(UsernameEingabe.Text))
            {
                MessageBox.Show("Dieser Username ist nicht zulässig");
                return;
            }

            if (SpecialCharacter() == true)
            {
                MessageBox.Show("ungültiges Zeichen in Username");
                return;
            }

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                DBRegisterAccount();
                this.DialogResult = DialogResult.OK;
                form1.Show();
            }
        }

        private bool SpecialCharacter()
        {
            bool isMatch = false;

            var regex = new Regex(@"[^a-zA-Z0-9\s]");
            isMatch = regex.IsMatch(UsernameEingabe.Text.ToString());

            return isMatch;
        }

        private void DBRegisterAccount()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DEVN-18;Initial Catalog=Zeiterfassung2;Trusted_Connection=Yes;Integrated Security=True"))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO [User](Vorname, Nachname, Straße, Hausnummer, Ort, Postleitzahl, Username, Password) VALUES (@vorname, @nachname, @straße, @hausnummer, @ort, @postleitzahl, @username, @password)", connection);

                // 1. Variante
                var vorname = new SqlParameter("vorname", System.Data.SqlDbType.VarChar);
                vorname.Value = vornameEingabe.Text;
                cmd.Parameters.Add(vorname);

                // 2. Variante
                cmd.Parameters.AddWithValue("nachname", nachnameEingabe.Text);

                cmd.Parameters.AddWithValue("straße", StraßeEingabe.Text);

                cmd.Parameters.AddWithValue("hausnummer", txtHausnummer.Text);

                cmd.Parameters.AddWithValue("ort", StadtEingabe.Text);

                cmd.Parameters.AddWithValue("postleitzahl", PostleitzahlEIngabe.Text);

                cmd.Parameters.AddWithValue("username", UsernameEingabe.Text);



                cmd.Parameters.AddWithValue("password", Helper.SimpleEncrypt(PasswordEingabe.Text));

                cmd.ExecuteNonQuery();
            };
        }

        private void vornameEingabe_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(vornameEingabe.Text))
            {
                errorProvider1.SetError(vornameEingabe, "'Vorname' ist ein Pflichtfeld");
            }
            else
            {
                errorProvider1.SetError(vornameEingabe, string.Empty);
            }
        }

        private void nachnameEingabe_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nachnameEingabe.Text))
            {
                errorProvider1.SetError(nachnameEingabe, "'Nachname' ist ein Pflichtfeld");
            }
            else
            {
                errorProvider1.SetError(nachnameEingabe, string.Empty);
            }
        }

        private void StraßeEingabe_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(StraßeEingabe.Text))
            {
                errorProvider1.SetError(StraßeEingabe, "'Straße' ist ein Pflichtfeld");
            }
            else
            {
                errorProvider1.SetError(StraßeEingabe, string.Empty);
            }
        }

        private void StadtEingabe_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(StadtEingabe.Text))
            {
                errorProvider1.SetError(StadtEingabe, "'Stadt' ist ein Pflichtfeld");
            }
            else
            {
                errorProvider1.SetError(StadtEingabe, string.Empty);
            }
        }

        private void PostleitzahlEIngabe_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PostleitzahlEIngabe.Text))
            {
                errorProvider1.SetError(PostleitzahlEIngabe, "'Postleitzahl' ist ein Pflichtfeld");
            }
            else
            {
                errorProvider1.SetError(PostleitzahlEIngabe, string.Empty);
            }
        }

        private void UsernameEingabe_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameEingabe.Text))
            {
                errorProvider1.SetError(UsernameEingabe, "'Username' ist ein Pflichtfeld");
            }
            else
            {
                errorProvider1.SetError(UsernameEingabe, string.Empty);
            }
        }

        private void PasswordEingabe_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PasswordEingabe.Text))
            {
                errorProvider1.SetError(PasswordEingabe, "'Password' ist ein Pflichtfeld");
            }
            else
            {
                errorProvider1.SetError(PasswordEingabe, string.Empty);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool isToggled = false;

            if (checkBox1.Checked)
            {
                PasswordEingabe.PasswordChar = '\0';
            }
            else
            {
                PasswordEingabe.PasswordChar = '●';
            }
        }

        private void PasswordEingabe_TextChanged(object sender, EventArgs e)
        {
            // ....
        }

        private void UsernameEingabe_TextChanged(object sender, EventArgs e)
        {
            // ....
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            this.Hide();

            form1 = new Login();
            
            form1.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            vornameEingabe.Clear();
            nachnameEingabe.Clear();
            StraßeEingabe.Clear();
            txtHausnummer.Clear();
            StadtEingabe.Clear();
            PostleitzahlEIngabe.Clear();
            UsernameEingabe.Clear();
            PasswordEingabe.Clear();
        }

        private void label11_Click(object sender, EventArgs e)
        {
        
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }

}

