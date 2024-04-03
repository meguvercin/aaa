using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      /*private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter = "Text Files |*.txt|All Files | *.* ";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true; 
            DialogResult openResult = openFileDialog.ShowDialog();
            if (openResult == DialogResult.OK)
            {
                lblImageName.Text = openFileDialog.FileName;
            }
        }
      */
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image File (png)|*.png|Image file (jpg)|*.jpg|All Files | *.* ";
            dialog.FilterIndex = 1;
          //openFileDialog.RestoreDirectory = true;
          //DialogResult openResult = openFileDialog.ShowDialog();
            if (dialog.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("User cancelled");
                return;
            }
            lblImageName.Text = dialog.FileName;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily family in FontFamily.Families)
            cboFontFamily.Items.Add(family.Name);
        }
        private void FontJob(object sender, EventArgs e)
        {
            if (cboFontFamily.SelectedIndex == -1)
                return;
            string familyname = cboFontFamily.Text;
            lblcboFontFamily.Font = new Font(familyname, 12);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.AllowFullOpen = true;
            dialog.ShowHelp = true;
            if (dialog.ShowDialog() == DialogResult.Cancel)
                return;

            lblColor.BackColor = dialog.Color;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            picImage.ImageLocation = lblImageName.Text;

            lblMessage.Font = new Font(cboFontFamily.Text, (int)numericUpDown1.Value);

            lblMessage.Text = txtMessage.Text;

            lblMessage.ForeColor = lblColor.BackColor;


        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Message Send! ");

            return;
        }
    }
}
