using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Speech.Synthesis;

namespace GuessingGameProject
{
    public partial class GuessingGameForm : Form
    {
        int intNumber = 0;
        int intNumberOfTries = 0;
        int intPlayCount = 0;
        int intWinCount = 0;
        bool blnStartFlag = false;
        bool blnSuccess = false;
        private SoundPlayer Win;
        private SoundPlayer Lose;
        private SpeechSynthesizer voice;

      
        public static GuessingGameForm objGuessing = new GuessingGameForm();
        public GuessingGameForm()
        {
            InitializeComponent();
            Win = new SoundPlayer("Tada-sound.wav");
            Lose = new SoundPlayer("game-lose.wav");
            
        }
        private int GetNumber()
        {
            double dblValue;
            Random ranObj = new Random();
            dblValue = ranObj.NextDouble();
            return ((int)(100 * dblValue));
        }
        private bool CheckValidInput(int intInput)
        {
            if ((intInput >= 0) && (intInput <= 100))
                return true;
            else
                return false;
        }
        private int CompareWithNumber(int intInput)
        {
            if (intInput == intNumber)
                return 0; //Input is equal
            else if (intInput < intNumber)
                return -1; //Input is lower
            else
                return 1; //Input is higher
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            intPlayCount++;
            intNumber = GetNumber();
            blnStartFlag = true;
            intNumberOfTries = 0;
            blnSuccess = false;
            messageLabel.Text = "The game has started now!\n";
            numTriesLabel.Text = "0";
            numberLabel.BackColor = Color.White;
            messageLabel.ForeColor = Color.Black;
            guessesLeftBar.Value = 0;

            StreamReader sw = new StreamReader(LoginForm.strLoginName + ".txt");
            nameLabel.Text = sw.ReadLine();
            userLabel.Visible = true;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int intTemp;
            int intStatus; //local variable to contain returned value

            if(blnStartFlag == false)
            {
                MessageBox.Show("Please click the start button to start the game","Start Game",MessageBoxButtons.OK,MessageBoxIcon.Information);
      
                return;
            }
            try
            {
                intTemp = int.Parse(numberLabel.Text);
            }
            catch
            {
                MessageBox.Show("Please enter your guessing number!","Enter guessing number",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (CheckValidInput(intTemp) == false)
            {
                messageLabel.Text = "Invalid Input Number!!!";
            }
            else if ((intNumberOfTries >= 8) || (blnSuccess == true))
            {
                blnStartFlag = false;
                messageLabel.Text = "The Game has already ended.\nClick the Start Button for another game!";

                Lose.Play();
                var voice = new SpeechSynthesizer();
                voice.Speak("The Game has already ended.\nClick the Start Button for another game!");

            }
            else
            {
                intNumberOfTries++;
                numTriesLabel.Text = intNumberOfTries.ToString();
                intStatus = CompareWithNumber(intTemp);
                guessesLeftBar.Increment(13);
                if (intStatus == 0)
                {
                    intWinCount++;
                    messageLabel.Text = "Congratulations! It's correct";
                    blnSuccess = true;
                    numberLabel.BackColor = Color.Green;
                    messageLabel.ForeColor = Color.Green;

                    Win.Play();
                                
                }
                else if (intStatus == -1)
                {

                    messageLabel.Text = "Too Low!!";
                    numberLabel.BackColor = Color.Red;
                    messageLabel.ForeColor = Color.Red;

                }
                else
                {
                    messageLabel.Text = "Too High!!";
                    numberLabel.BackColor = Color.Red;
                    messageLabel.ForeColor = Color.Red;
                }
                    
                    
            }
                
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            StreamWriter ex = new StreamWriter(@"C:\Users\User\Desktop\Documents\Stuff\APPG\Guessing Game\Log.txt", true);
                ex.Write("Exit Log: ");
                ex.WriteLine(DateTime.Now.ToLongTimeString() + "  " + DateTime.Now.ToLongDateString());
                ex.WriteLine("User: " + LoginForm.strLoginName);
                ex.WriteLine("Play Count: " + intPlayCount);
                ex.WriteLine("Win Count: " + intWinCount);
                ex.WriteLine("------------------------------------------------------------------");
                ex.Close();
            
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dtNow = DateTime.Now;
            dateLabel.Text = dtNow.ToLongDateString() + "\n" + dtNow.ToLongTimeString();
        }

        private void numberTrackBar_Scroll(object sender, EventArgs e)
        {
            numberLabel.Text = numberTrackBar.Value.ToString();
        }

        private void GuessingGameForm_Load(object sender, EventArgs e)
        {

        }
    }
}
