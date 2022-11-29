using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Zeitkonto
{
    public partial class Login : Form
    {
        ZeitkontoManager zkm;
        Register reg;

        public Login()
        {
            reg = new Register();
            zkm = new ZeitkontoManager();
            InitializeComponent();
            this.KeyDown += Login_KeyDown;
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Environment.Exit(0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (CheckForExistingEntry(out int _userID) == false)
            {
                if (textBox1.Text == string.Empty || textBox2.Text == string.Empty)
                    MessageBox.Show("Bitte füllen sie beide Felder aus");

                if (SpecialCharacter() == true)
                    MessageBox.Show("ungültiges Zeichen in Username");

                else
                    MessageBox.Show("Der Username oder das Passwort ist falsch");
            }
            else
            {
                this.Hide();
                zkm.UserID = _userID;
                zkm.Show();
            }
        }
        private bool SpecialCharacter()
        {
            bool isMatch = false;

            var regex = new Regex(@"[^a-zA-Z0-9\s]");
            isMatch = regex.IsMatch(textBox1.Text.ToString());

            return isMatch;
        }

        private void btnREgister_Click(object sender, EventArgs e)
        {

        }

        public void DBRead()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DEVN-18;Initial Catalog=Zeiterfassung;Trusted_Connection=Yes;Integrated Security=True"))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand();
            };
        }

        public bool CheckForExistingEntry(out int p_userID)
        {
            bool existing = false;
            p_userID = -1;

            using (SqlConnection connection = new SqlConnection("Data Source=DEVN-18;Initial Catalog=Zeiterfassung2;Trusted_Connection=Yes;Integrated Security=True"))
            {
                try
                {
                    connection.Open();
                    //StringBuilder sb = new StringBuilder();

                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("IF EXISTS(SELECT Username, Password FROM [User] WHERE Username = @username AND Password = @password)");
                    sb.AppendLine("BEGIN");
                    sb.AppendLine("SELECT (SELECT TOP 1 ID FROM [User] WHERE Username = @username AND Password = @password) as Result");
                    sb.AppendLine("END");
                    sb.AppendLine("ELSE");
                    sb.AppendLine("BEGIN");
                    sb.AppendLine("SELECT 0 as Result");
                    sb.AppendLine("END");

                    SqlCommand checkforexisting = new SqlCommand(sb.ToString(), connection);

                    checkforexisting.Parameters.AddWithValue("@username", textBox1.Text);

                    checkforexisting.Parameters.AddWithValue("@password", Helper.SimpleEncrypt(textBox2.Text));

                    SqlDataReader dr = checkforexisting.ExecuteReader();

                    while (dr.Read())
                    {
                        int collum = dr.GetOrdinal("Result");
                        p_userID = dr.GetInt32(collum);
                        existing = p_userID > 0;
                    }
                    return existing;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.StackTrace);
                }
            };
        }

        internal void TranslationEnglish()
        {
            // Login
            label5.Text = "Get Started";
            label3.Text = "Username";
            label4.Text = "Password";
            checkBox2.Text = "Show Password";
            button1.Text = "Login";
            label6.Text = "Dont Have an Account?";
            label7.Text = "Create Account";

            // Register
            reg.label8.Text = "Register";
            reg.Vorname.Text = "Firstname";
            reg.label2.Text = "Lastname";
            reg.label6.Text = "Street";
            reg.label7.Text = "Nr.";
            reg.label4.Text = "City";
            reg.label3.Text = "Postalcode";
            reg.label1.Text = "Username";
            reg.label5.Text = "Password";
            reg.checkBox1.Text = "Show Password";
            reg.btnClear.Text = "Clear";
            reg.button1.Text = "Register";

            // ZeitkontoManager
            zkm.label2.Text = "Welcome";
            zkm.lblKommenText.Text = "Arrive";
            zkm.lblGehenText.Text = "Leave";
            zkm.lblInfoText.Text = "Info";
        }

        internal void TranslationGerman()
        {
            // Login
            label5.Text = "Loslegen";
            label3.Text = "Benutzername";
            label4.Text = "Passwort";
            checkBox2.Text = "Passwort anzeigen";
            button1.Text = "Anmelden";
            label6.Text = "Du hast noch kein Konto?";
            label7.Text = "Konto erstellen";

            // Register
            reg.label8.Text = "Registrieren";
            reg.Vorname.Text = "Vorname";
            reg.label2.Text = "Nachname";
            reg.label6.Text = "Straße";
            reg.label7.Text = "Hausnummer";
            reg.label4.Text = "Stadt";
            reg.label3.Text = "Postleitzahl";
            reg.label1.Text = "Benutzername";
            reg.label5.Text = "Passwort";
            reg.checkBox1.Text = "Passwort anzeigen";
            reg.btnClear.Text = "Leeren";
            reg.button1.Text = "Registrieren";

            // ZeitkontoManager
            zkm.label2.Text = "Wilkommen";
            zkm.lblKommenText.Text = "Kommen";
            zkm.lblGehenText.Text = "Gehen";
            zkm.lblInfoText.Text = "Abfrage";
        }
        internal void TranslationChinese()
        {
            // Login
            label5.Text = "入門";
            label3.Text = "用戶名";
            label4.Text = "密碼";
            checkBox2.Text = "顯示密碼";
            button1.Text = "登記";
            label6.Text = "還沒有帳戶？";
            label7.Text = "創建賬戶";

            // Register
            reg.label8.Text = "註冊";
            reg.Vorname.Text = "名";
            reg.label2.Text = "姓";
            reg.label6.Text = "街道";
            reg.label7.Text = "門牌號碼";
            reg.label4.Text = "城市";
            reg.label3.Text = "郵政編碼";
            reg.label1.Text = "用戶名";
            reg.label5.Text = "密碼";
            reg.checkBox1.Text = "顯示密碼";
            reg.btnClear.Text = "清空";
            reg.button1.Text = "註冊";

            // ZeitkontoManager
            zkm.label2.Text = "歡迎";
            zkm.lblKommenText.Text = "來";
            zkm.lblGehenText.Text = "走";
            zkm.lblInfoText.Text = "詢問";
        }

        internal void TranslationFrance()
        {
            // Login
            label5.Text = "Commencer";
            label3.Text = "Nom d'utilisateur";
            label4.Text = "le mot de passe";
            checkBox2.Text = "Montrer le mot de passe";
            button1.Text = "S'inscrire";
            label6.Text = "Vous n'avez pas encore de compte?";
            label7.Text = "créer un compte\r\n";

            // Register
            reg.label8.Text = "enregistrer";
            reg.Vorname.Text = "prénom";
            reg.label2.Text = "Nom de famille";
            reg.label6.Text = "Rue";
            reg.label7.Text = "Numéro";
            reg.label4.Text = "ville";
            reg.label3.Text = "code postal";
            reg.label1.Text = "Nom d'utilisateur";
            reg.label5.Text = "le mot de passe";
            reg.checkBox1.Text = "Montrer le mot de passe";
            reg.btnClear.Text = "À vider";
            reg.button1.Text = "enregistrer";

            // ZeitkontoManager
            zkm.label2.Text = "Accueillir";
            zkm.lblKommenText.Text = "Viens";
            zkm.lblGehenText.Text = "Marche";
            zkm.lblInfoText.Text = "requête";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '●';
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            reg.ShowDialog();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            TranslationGerman();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            TranslationEnglish();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            TranslationFrance();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            TranslationChinese();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}