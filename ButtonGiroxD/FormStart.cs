using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonGiroxD
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void FormStart_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double bmpspeed = 0;
            double repeattime = 0;
            int maxNotes = 0;
            int wait = 0;
            double bmpadd = 0;
            String music = "";
            try
            {
                 bmpspeed = double.Parse(txtSpeed.Text);
                 repeattime = double.Parse(txtRepeat.Text);
                 maxNotes = int.Parse(txtMaxNotes.Text);
                 wait = int.Parse(txtWaitTime.Text);
                 music = txtMusic.Text;
                bmpadd = double.Parse(textBox1  .Text);
            }
            catch (Exception f)
            {
                MessageBox.Show(f.ToString());
            }

            

            Form1 form = new Form1(bmpspeed, repeattime, maxNotes, wait, bmpadd, music);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "C# Corner Open File Dialog";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                txtMusic.Text = fdlg.FileName;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
