using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ЛР_20_Webbrowser_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(textBox.Text);
        }

        private void buttonForvard_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate("youtube.com");
        }

        private void buttonSaveAs_Click(object sender, EventArgs e)
        {
            webBrowser.Print();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox.SelectedIndex)
            {
                case 0: webBrowser.Navigate("youtube.com"); break;
                case 1: webBrowser.Navigate("google.com"); break;
                case 2: webBrowser.Navigate("Gmail.com"); break;
            }

        }
    }
}
