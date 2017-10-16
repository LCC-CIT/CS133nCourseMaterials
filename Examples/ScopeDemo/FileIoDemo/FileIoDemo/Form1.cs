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

namespace FileIoDemo
{
    public partial class Form1 : Form
    {
        const string PATH_NAME = @"C:\ProgramData\";
        const string FILE_NAME = "FileDemo.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void writeButton_Click(object sender, EventArgs e)
        {
            StreamWriter outFile;
            outFile = File.AppendText(PATH_NAME + FILE_NAME);
            //outFile = File.CreateText(FILE_NAME);

            outFile.WriteLine(inputTextBox.Text);

             outFile.Close();
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            StreamReader inFile;
            // inFile = File.Open("fileDemo.txt");             // show what happens with a wrong filename
            inFile = File.OpenText(PATH_NAME + FILE_NAME);

            outputListBox.Items.Clear();

            while(inFile.EndOfStream == false)
                outputListBox.Items.Add(inFile.ReadLine());

             inFile.Close();
        }
    }
}
