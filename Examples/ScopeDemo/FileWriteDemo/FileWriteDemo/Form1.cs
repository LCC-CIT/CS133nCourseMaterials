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

namespace FileWriteDemo
{
    public partial class Form1 : Form
    {
        StreamWriter outFile;       
        const string PATH_NAME = @"C:\ProgramData\";
        const string FILE_NAME = "FileDemo.txt";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                outFile = File.AppendText(PATH_NAME + FILE_NAME);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textWriteButton_Click(object sender, EventArgs e)
        {
            //StreamWriter outFile;
            // outFile = File.AppendText(PATH_NAME + FILE_NAME);
            //outFile = File.CreateText(FILE_NAME);
            outFile.WriteLine(inputTextBox.Text);
            //outFile.Close();
        }

        private void numericWriteButton_Click(object sender, EventArgs e)
        {
           // outFile = File.AppendText(PATH_NAME + FILE_NAME);
            outFile.WriteLine(inputNumericUpDown.Value);
            //outFile.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            outFile.Close();
        }
    }
}
