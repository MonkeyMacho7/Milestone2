﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UVSimGUI
{
    public partial class MainForm : Form
    {
        public string filePath = string.Empty;
        public FileReader fileInstructions;
        public Instructions processInstructions;

        public MainForm()
        {
            InitializeComponent();
            txtStatus.Visible = false;
            txtInput.Visible = false;
            btnCompute.Visible = false;
            lblInput.Visible = false;
            // Initialize the timer
            loadingTimer = new System.Windows.Forms.Timer();
            loadingTimer.Interval = 2000; // Set timer for 2 seconds
            loadingTimer.Tick += new EventHandler(LoadingTimer_Tick);

            // Assuming btnLoading is your loading button
            // Make sure it's initially not visible
            lblLoading.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                fileInstructions = new FileReader(filePath);
                if (fileInstructions.GetInstructions().Count <= 0)
                {
                    //problem select a different file
                    Application.Exit();

                }
                // File selected, now start the timer and show the loading button
                lblLoading.Visible = true;
                loadingTimer.Start();

                // Disable button1 to prevent further interaction while loading
                btnOpenFile.Enabled = false;
            }
        }
        private void LoadingTimer_Tick(object sender, EventArgs e)
        {
            // Timer ticked, 2 seconds passed
            loadingTimer.Stop();

            // Hide the loading button again
            lblLoading.Visible = false;

            // Hide the Open File & Others
            btnOpenFile.Visible = false;
            txtStatus.Visible = true;
            txtInput.Visible = true;
            lblInput.Visible = true;
            btnCompute.Visible = true;

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            //check that input text box has enough values
            var inputCount = fileInstructions.GetInputCount();
            if (inputCount != txtInput.Text.Split(',').Length)
            {
                //there was a problem 
            }
            processInstructions = new Instructions(fileInstructions.GetInstructions(), txtInput.Text);
            var status = processInstructions.Process();
            txtStatus.Text += status;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
