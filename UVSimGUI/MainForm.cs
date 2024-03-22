using System;
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
            processInstructions = new Instructions();
            InitializeComponent();
            InitializeDataGridView();
            txtStatus.Visible = false;
            txtInput.Visible = false;
            btnCompute.Visible = false;
            lblInput.Visible = false;
            // Initialize the timer
            loadingTimer = new System.Windows.Forms.Timer();
            loadingTimer.Interval = 2000; // Set timer for 2 seconds
            loadingTimer.Tick += new EventHandler(LoadingTimer_Tick);

            // Make sure it's initially not visible
            lblLoading.Visible = false;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            ApplySavedColors();
        }

        public void ApplySavedColors()
        {
            var primaryColor = Properties.Settings.Default.PrimaryColor;
            var offColor = Properties.Settings.Default.OffColor;

            this.BackColor = primaryColor;

            btnExit.ForeColor = offColor;
            btnCompute.ForeColor = offColor;
            btnOpenFile.ForeColor = offColor;
            txtStatus.ForeColor = offColor;
            lblInput.ForeColor = offColor;
            txtInput.ForeColor = offColor;


            menuStrip1.ForeColor = offColor;
        }


        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Owner = this; // Set MainForm as the owner
            settingsForm.ShowDialog();
        }
        private void InitializeDataGridView()
        {
            // Adding columns to dataGridView
            dataGridView.Columns.Add("Line", "Line Number");
            dataGridView.Columns.Add("Instruction", "Instruction");

            // Example column setup - modify as needed
            dataGridView.Columns["Line"].Width = 50;
            dataGridView.Columns["Instruction"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Other DataGridView settings
            dataGridView.AllowUserToAddRows = true;
            dataGridView.AllowUserToDeleteRows = true;
            dataGridView.ReadOnly = false; // Set to true if you don't want users to edit directly

            for (int i = 0; i < 99; i++)
            {
                dataGridView.Rows.Add();
            }

            // Optionally, you can set the first column to show line numbers (00 to 98)
            for (int i = 0; i < 99; i++)
            {
                dataGridView.Rows[i].Cells["Line"].Value = i.ToString("D2"); // Format as 2 digits
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                fileInstructions = new FileReader(filePath);

                if (fileInstructions.GetInstructions().Count > 0)
                {
                    LoadDataIntoDataGridView(fileInstructions.GetInstructions());
                    // Hide the controls for execution initially
                    txtStatus.Visible = false;
                    txtInput.Visible = false;
                    btnCompute.Visible = false;
                    // Show the DataGridView with the file content
                    dataGridView.Visible = true;
                }
                else
                {
                    MessageBox.Show("File is empty or cannot be processed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LoadDataIntoDataGridView(List<string> instructions)
        {
            dataGridView.Rows.Clear();
            foreach (string instruction in instructions)
            {
                // Assuming each instruction is a single string, you might want to split or process it
                // For simple display: Add the entire instruction string as a row
                dataGridView.Rows.Add(new object[] { instruction });
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
                txtStatus.Text += $"***** ERROR Not enough input parameters ****{Environment.NewLine}";
                btnCompute.Visible = false;
                txtInput.Focus();
                return;
            }
            processInstructions.Reset();
            processInstructions.LoadInsructions(fileInstructions.GetInstructions(), txtInput.Text);
            var status = processInstructions.Process();
            txtStatus.Text += status;

        }



        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            if (!btnCompute.Visible)
            {
                btnCompute.Visible = true;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void colorSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Owner = this; // Set MainForm as the owner
            settingsForm.ShowDialog(); // Show the settings form as a dialog
        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStartSimulation_Click(object sender, EventArgs e)
        {
            
        }
    }
}
