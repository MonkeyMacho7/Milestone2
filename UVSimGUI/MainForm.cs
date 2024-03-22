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
            dataGridView.Visible = false;
            btnStartSimulation.Visible = false;
            btnCut.Visible = false;
            btnCopy.Visible = false;
            btnPaste.Visible = false;
            btnDeleteRow.Visible = false;
            btnSaveChanges.Visible = false;
            btnAddRow.Visible = false;
            lblLoading.Visible = false;
            //loadingTimer = new System.Windows.Forms.Timer();
            //loadingTimer.Interval = 2000; // Set timer for 2 seconds
            //loadingTimer.Tick += new EventHandler(LoadingTimer_Tick);

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
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ReadOnly = false;

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
                    txtStatus.Visible = false;
                    txtInput.Visible = false;
                    btnCompute.Visible = false;
                    lblInput.Visible = false;
                    // Show the DataGridView with the file content
                    dataGridView.Visible = true;
                    btnStartSimulation.Visible = true;
                    btnCut.Visible = true;
                    btnCopy.Visible = true;
                    btnSaveChanges.Visible = true;
                    btnPaste.Visible = true;
                    btnDeleteRow.Visible = true;
                    btnAddRow.Visible = true;
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
                if (!string.IsNullOrWhiteSpace(instruction))
                {
                    // Split the instruction 
                    string operationCode = instruction.Substring(0, 2);
                    string instructionDetails = instruction.Substring(2);

                    // Add the operation 
                    dataGridView.Rows.Add(new object[] { operationCode, instructionDetails });
                }
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
        private void btnStartSimulation_Click(object sender, EventArgs e)
        {
            var commandsFromGrid = ReadCommandsFromDataGridView();



            // Show the controls for execution result
            txtStatus.Visible = true;
            txtInput.Visible = true;
            btnCompute.Visible = true;
            lblInput.Visible = true;

            // Hide the DataGridView
            btnSaveChanges.Visible = false;
            btnCut.Visible = false;
            btnCopy.Visible = false;
            btnPaste.Visible = false;
            btnDeleteRow.Visible = false;
            btnAddRow.Visible = false;
            dataGridView.Visible = false;
            btnStartSimulation.Visible = false;
        }
        private List<string> ReadCommandsFromDataGridView()
        {
            var commands = new List<string>();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["Instruction"].Value != null)
                {
                    commands.Add(row.Cells["Instruction"].Value.ToString());
                }
            }
            return commands;
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            CopyToClipboard(true);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            CopyToClipboard(false);
        }
        private void CopyToClipboard(bool cut)
        {
            if (dataGridView.CurrentCell != null)
            {
                Clipboard.SetText(dataGridView.CurrentCell.Value.ToString());
                if (cut)
                {
                    dataGridView.CurrentCell.Value = "";
                }
            }
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentCell != null && Clipboard.ContainsText())
            {
                dataGridView.CurrentCell.Value = Clipboard.GetText();
            }
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count < 100)
            {
                dataGridView.Rows.Insert(dataGridView.CurrentRow.Index, new DataGridViewRow());

            }
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                dataGridView.Rows.RemoveAt(dataGridView.CurrentRow.Index);

            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string line = "";
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                line += cell.Value?.ToString() ?? "";
                            }
                            sw.WriteLine(line);
                        }
                    }
                }
                MessageBox.Show("File saved successfully.");
            }
        }
    }
}
