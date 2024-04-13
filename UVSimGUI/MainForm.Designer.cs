namespace UVSimGUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnOpenFile = new Button();
            openFileDialog1 = new OpenFileDialog();
            lblTitle = new Label();
            btnExit = new Button();
            lblVersion = new Label();
            loadingTimer = new System.Windows.Forms.Timer(components);
            txtInput = new TextBox();
            btnCompute = new Button();
            lblLoading = new Label();
            label1 = new Label();
            txtStatus = new TextBox();
            lblInput = new Label();
            menuStrip1 = new MenuStrip();
            colorSettingsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            dataGridView = new DataGridView();
            CommandNumberColumn = new DataGridViewTextBoxColumn();
            CommandColumn = new DataGridViewTextBoxColumn();
            btnStartSimulation = new Button();
            btnCut = new Button();
            btnCopy = new Button();
            btnPaste = new Button();
            btnAddRow = new Button();
            btnDeleteRow = new Button();
            btnSaveChanges = new Button();
            btnConvertFile = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // btnOpenFile
            // 
            btnOpenFile.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnOpenFile.Location = new Point(617, 62);
            btnOpenFile.Margin = new Padding(1);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(232, 40);
            btnOpenFile.TabIndex = 0;
            btnOpenFile.Text = "Select a File";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(256, 31);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(216, 54);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "UVSim GUI";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(12, 494);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(907, 66);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new Point(460, 62);
            lblVersion.Margin = new Padding(1, 0, 1, 0);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(28, 15);
            lblVersion.TabIndex = 3;
            lblVersion.Text = "v2.0";
            // 
            // loadingTimer
            // 
            loadingTimer.Interval = 2000;
            loadingTimer.Tick += LoadingTimer_Tick;
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtInput.Location = new Point(404, 287);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(167, 34);
            txtInput.TabIndex = 6;
            txtInput.TextChanged += txtInput_TextChanged;
            // 
            // btnCompute
            // 
            btnCompute.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            btnCompute.Location = new Point(256, 340);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(216, 54);
            btnCompute.TabIndex = 8;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = true;
            btnCompute.Click += btnCompute_Click;
            // 
            // lblLoading
            // 
            lblLoading.AutoSize = true;
            lblLoading.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoading.Location = new Point(367, 649);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new Size(258, 72);
            lblLoading.TabIndex = 11;
            lblLoading.Text = "Loading...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(292, 614);
            label1.Name = "label1";
            label1.Size = new Size(205, 15);
            label1.TabIndex = 13;
            label1.Text = "Ethan Larson, Sony Smith, Brock Terry";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(113, 113);
            txtStatus.Multiline = true;
            txtStatus.Name = "txtStatus";
            txtStatus.ScrollBars = ScrollBars.Vertical;
            txtStatus.Size = new Size(359, 170);
            txtStatus.TabIndex = 14;
            txtStatus.TextChanged += txtStatus_TextChanged;
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblInput.Location = new Point(0, 283);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(398, 37);
            lblInput.TabIndex = 15;
            lblInput.Text = "Input  values (comma delimited)";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { colorSettingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(931, 24);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // colorSettingsToolStripMenuItem
            // 
            colorSettingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            colorSettingsToolStripMenuItem.Name = "colorSettingsToolStripMenuItem";
            colorSettingsToolStripMenuItem.Size = new Size(61, 20);
            colorSettingsToolStripMenuItem.Text = "Settings";
            colorSettingsToolStripMenuItem.Click += colorSettingsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(142, 22);
            toolStripMenuItem1.Text = "Color Theme";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { CommandNumberColumn, CommandColumn });
            dataGridView.Location = new Point(574, 136);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(305, 186);
            dataGridView.TabIndex = 17;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // CommandNumberColumn
            // 
            CommandNumberColumn.HeaderText = "Command Number";
            CommandNumberColumn.Name = "CommandNumberColumn";
            // 
            // CommandColumn
            // 
            CommandColumn.HeaderText = "Command/Instruction";
            CommandColumn.Name = "CommandColumn";
            // 
            // btnStartSimulation
            // 
            btnStartSimulation.Location = new Point(390, 186);
            btnStartSimulation.Name = "btnStartSimulation";
            btnStartSimulation.Size = new Size(107, 54);
            btnStartSimulation.TabIndex = 18;
            btnStartSimulation.Text = "Start UVSim";
            btnStartSimulation.UseVisualStyleBackColor = true;
            btnStartSimulation.Click += btnStartSimulation_Click;
            // 
            // btnCut
            // 
            btnCut.Location = new Point(584, 327);
            btnCut.Name = "btnCut";
            btnCut.Size = new Size(75, 23);
            btnCut.TabIndex = 19;
            btnCut.Text = "Cut";
            btnCut.UseVisualStyleBackColor = true;
            btnCut.Click += btnCut_Click;
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(698, 327);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(75, 23);
            btnCopy.TabIndex = 20;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // btnPaste
            // 
            btnPaste.Location = new Point(804, 327);
            btnPaste.Name = "btnPaste";
            btnPaste.Size = new Size(75, 23);
            btnPaste.TabIndex = 21;
            btnPaste.Text = "Paste";
            btnPaste.UseVisualStyleBackColor = true;
            btnPaste.Click += btnPaste_Click;
            // 
            // btnAddRow
            // 
            btnAddRow.Location = new Point(619, 366);
            btnAddRow.Name = "btnAddRow";
            btnAddRow.Size = new Size(100, 28);
            btnAddRow.TabIndex = 22;
            btnAddRow.Text = "Add Row";
            btnAddRow.UseVisualStyleBackColor = true;
            btnAddRow.Click += btnAddRow_Click;
            // 
            // btnDeleteRow
            // 
            btnDeleteRow.Location = new Point(749, 366);
            btnDeleteRow.Name = "btnDeleteRow";
            btnDeleteRow.Size = new Size(100, 28);
            btnDeleteRow.TabIndex = 23;
            btnDeleteRow.Text = "Delete Row";
            btnDeleteRow.UseVisualStyleBackColor = true;
            btnDeleteRow.Click += btnDeleteRow_Click;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(676, 415);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(101, 28);
            btnSaveChanges.TabIndex = 24;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // btnConvertFile
            // 
            btnConvertFile.Location = new Point(574, 449);
            btnConvertFile.Name = "btnConvertFile";
            btnConvertFile.Size = new Size(334, 35);
            btnConvertFile.TabIndex = 25;
            btnConvertFile.Text = "Convert 4 digit file";
            btnConvertFile.UseVisualStyleBackColor = true;
            btnConvertFile.Click += btnConvertFile_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(574, 113);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(305, 45);
            tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(297, 0);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Empty";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(297, 17);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Empty";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(931, 730);
            Controls.Add(tabControl1);
            Controls.Add(btnConvertFile);
            Controls.Add(btnSaveChanges);
            Controls.Add(btnDeleteRow);
            Controls.Add(btnAddRow);
            Controls.Add(btnPaste);
            Controls.Add(btnCopy);
            Controls.Add(btnCut);
            Controls.Add(btnStartSimulation);
            Controls.Add(dataGridView);
            Controls.Add(lblInput);
            Controls.Add(label1);
            Controls.Add(lblLoading);
            Controls.Add(btnCompute);
            Controls.Add(txtInput);
            Controls.Add(lblVersion);
            Controls.Add(btnExit);
            Controls.Add(lblTitle);
            Controls.Add(btnOpenFile);
            Controls.Add(txtStatus);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(1);
            Name = "MainForm";
            Text = "Wireframe";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOpenFile;
        private OpenFileDialog openFileDialog1;
        private Label lblTitle;
        private Button btnExit;
        private Label lblVersion;
        private System.Windows.Forms.Timer loadingTimer;
        private TextBox txtInput;
        private Button btnCompute;
        private Label lblLoading;
        private Label label1;
        private TextBox txtStatus;
        private Label lblInput;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem colorSettingsToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private DataGridView dataGridView;
        private Button btnStartSimulation;
        private Button btnCut;
        private Button btnCopy;
        private Button btnPaste;
        private Button btnAddRow;
        private Button btnDeleteRow;
        private DataGridViewTextBoxColumn CommandNumberColumn;
        private DataGridViewTextBoxColumn CommandColumn;
        private Button btnSaveChanges;
        private Button btnConvertFile;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}