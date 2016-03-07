using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mother_earth
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        SoundPlayer priffast = new SoundPlayer(Properties.Resources.priffast);
        SoundPlayer prifslow = new SoundPlayer(Properties.Resources.prifslow);
        SoundPlayer prismatafast = new SoundPlayer(Properties.Resources.prismatafast);
        SoundPlayer prismataslow = new SoundPlayer(Properties.Resources.prismataslow);
        SoundPlayer bhoomifaster = new SoundPlayer(Properties.Resources.bhfast);
        SoundPlayer bhslow = new SoundPlayer(Properties.Resources.bhslow);

        private void frmMain_Load(object sender, EventArgs e)
        {
            priffast.Load();
            prifslow.Load();
            prismatafast.Load();
            prismataslow.Load();
            bhoomifaster.Load();
            bhslow.Load();

            comboBox1.Items.Add("prithvi holding stuff");
            comboBox1.Items.Add("prithvi holding less stuff");
            comboBox1.Items.Add("prithvi with a cow");
            comboBox1.Items.Add("prithvi as a cow");
            comboBox1.Items.Add("prithvi looking majestic");
            label27.Visible = pictureBox5.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label27.Visible = pictureBox5.Visible = true;

            if (comboBox1.SelectedItem.ToString() == "prithvi holding stuff")
            {
                label27.Text = "Dans cette pièce d'art éblouissant, Prithvi tient tout sauf l'évier de la cuisine. Il y a aussi des fleurs de lotus en vedette au premier plan.";
                pictureBox5.Image = Properties.Resources.priththee;
            }
            else if (comboBox1.SelectedItem.ToString() == "prithvi as a cow")
            {
                label27.Text = "moo";
                pictureBox5.Image = Properties.Resources.mongol;
            }
            else if (comboBox1.SelectedItem.ToString() == "prithvi with a cow")
            {
                label27.Text = "Prithvi est dépeint comme un maigre, plus jeune femme ici.";
                pictureBox5.Image = Properties.Resources.mangal;
            }
            else if (comboBox1.SelectedItem.ToString() == "prithvi holding less stuff")
            {
                label27.Text = "Dans celui-ci, Prithvee a quatre bras, dont deux détiennent des fleurs de lotus, on est porteur d'une urne décorative et le dernier a une main accueillante.";
                pictureBox5.Image = Properties.Resources.lake;
            }
            else if (comboBox1.SelectedItem.ToString() == "prithvi looking majestic")
            {
                label27.Text = "";
                pictureBox5.Image = Properties.Resources.majestic;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            priffast.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            prifslow.Play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            prismatafast.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            prismataslow.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bhoomifaster.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bhslow.Play();
        }
    }
}
