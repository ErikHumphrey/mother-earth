using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mother_earth
{
    public partial class frmLoader : Form
    {
        Random rnd = new Random();
        int i = 0;

        String[] step = new String[13];

        public frmLoader()
        {
            InitializeComponent();
        }

        private void frmLoader_Load(object sender, EventArgs e)
        {
            prgFakeLoading.Value = 0;
            tmrPrithviSimulator.Start();
            tmrHumor.Start();

            step[0] = "Loading the program...";
            step[1] = "Assassinating Gandhi...";
            step[2] = "Installing viruses...";
            step[3] = "Downloading more RAM...";
            step[4] = "Ça c'est non...";
            step[5] = "Manually breathing...";
            step[6] = "Have you really been far even as decided to use go want to look more like?";
            step[7] = "Stealing credit card info...";
            step[8] = "Downloading a car...";
            step[9] = "Torrenting the entire Yu-Gi-Oh! series...";
            step[10] = "Making an axolotl totem...";
            step[11] = "Reading your personal files...";
            step[12] = "We now own your house!";
        }

        private void tmrPrithviSimulator_Tick(object sender, EventArgs e)
        {
            if (prgFakeLoading.Value == 1450)
            {
                tmrHumor.Stop();
            tmrPrithviSimulator.Stop();
                frmMain main = new frmMain();
                main.Show();
                this.Hide();
            }
            int valueToAdd = 0;
            valueToAdd = rnd.Next(0, 8);
            if (prgFakeLoading.Value + valueToAdd > 1450)
                prgFakeLoading.Value = 1450;
            else
                prgFakeLoading.Value += valueToAdd;
        }

        private void tmrHumor_Tick(object sender, EventArgs e)
        {
            lblLoadMessage.Text = step[i];

            if (i == 12)
                i = 0;
            else
                i++;
        }
    }
}
