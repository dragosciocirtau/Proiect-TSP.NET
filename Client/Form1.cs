using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        int dif_width, dif_height;
        public Form1()
        {
            InitializeComponent(); 
            dif_width = this.Width - tabControl1.Width;
            dif_height = this.Height - tabControl1.Height;

            if (ResultList.Items.Count == 0)
            {
                previousBtn.Enabled = false;
                nextBtn.Enabled = false;
                deleteBtn.Enabled = false;
                editBtn.Enabled = false;
            }

            addBtn.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" && addPathTextBox.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Please select a valid path and media type !");
            }
            
            else if (addPathTextBox.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Path cannot be empty!!");
            }
            
            else if (comboBox1.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Please select item's type!!");
            }

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

        }

        private void FolderBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.Description = "Select your folder";
            fbd.ShowNewFolderButton = false;

            if(fbd.ShowDialog() == DialogResult.OK)
            {
                FolderTextBox.Text = fbd.SelectedPath;
            } 
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void editBtn_Click(object sender, EventArgs e)
        {

        }

        private void addPathTextBox_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && addPathTextBox.Text != "")
            {
                addBtn.Enabled = true;
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && addPathTextBox.Text != "")
            {
                addBtn.Enabled = true;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            tabControl1.Width = this.Width - dif_width;
            tabControl1.Height = this.Height - dif_height;
        }
    }
}
