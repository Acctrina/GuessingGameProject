using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GuessingGameProject
{
    public partial class Log : Form
    {
        public static Log objLog = new Log();
        public Log()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            StreamReader sw = new StreamReader(@"C:\Users\User\Desktop\Documents\Stuff\APPG\Guessing Game\Log.txt");
            while(sw.Peek()!= -1)
            {
                logBox.Items.Add(sw.ReadLine());
            }
            MessageBox.Show("End of File!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            sw.Close();
            displayButton.Enabled = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
