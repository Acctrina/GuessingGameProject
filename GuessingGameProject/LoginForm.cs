using System;
using System.Windows.Forms;
using System.IO;


namespace GuessingGameProject
{
    public partial class LoginForm : Form
    {
        public static string strName;
        public static string strLoginName;
        public static LoginForm objLogin = new LoginForm();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                string strpassword;
                

                if ((nameTextBox.Text == "") || (passwordTextBox.Text == ""))
                    MessageBox.Show("Please enter your user ID and Password","Enter ID and Password",MessageBoxButtons.OK,MessageBoxIcon.Information);
                else
                {
                    StreamReader newUserReader = new StreamReader(nameTextBox.Text + ".txt");
                    strName = newUserReader.ReadLine();
                    strpassword = newUserReader.ReadLine();
                    newUserReader.Close();

                    if (strpassword == passwordTextBox.Text)
                    {
                        strLoginName = strName;
                        MessageBox.Show("Login successful","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        objLogin = this;
                        this.Hide();
                        GuessingGameForm.objGuessing.Show();

                        StreamWriter wr = new StreamWriter(@"C:\Users\User\Desktop\Documents\Stuff\APPG\Guessing Game", true);
                        
                            wr.Write("Log Entry: ");
                            wr.WriteLine(DateTime.Now.ToLongTimeString() + "  " + DateTime.Now.ToLongDateString());
                            wr.WriteLine("User: " + strLoginName);
                            wr.WriteLine("------------------------------------------------------------------");
                            wr.Close();
                        
                    }

                    else
                        MessageBox.Show("Login fail","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("User not found","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            objLogin = this;
            this.Hide();
            RegistrationForm.objRegForm.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void logButton_Click(object sender, EventArgs e)
        {
            objLogin = this;
            this.Hide();
            Log.objLog.Show();
        }
    }
}
