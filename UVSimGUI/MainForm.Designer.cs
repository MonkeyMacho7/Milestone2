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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnOpenFile
            // 
            btnOpenFile.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnOpenFile.Location = new Point(256, 123);
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
            btnExit.Location = new Point(-3, 410);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(743, 66);
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
            txtInput.Location = new Point(359, 289);
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
            lblLoading.Location = new Point(239, 168);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new Size(258, 72);
            lblLoading.TabIndex = 11;
            lblLoading.Text = "Loading...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(547, 479);
            label1.Name = "label1";
            label1.Size = new Size(205, 15);
            label1.TabIndex = 13;
            label1.Text = "Ethan Larson, Sony Smith, Brock Terry";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(37, 113);
            txtStatus.Multiline = true;
            txtStatus.Name = "txtStatus";
            txtStatus.ScrollBars = ScrollBars.Vertical;
            txtStatus.Size = new Size(671, 170);
            txtStatus.TabIndex = 14;
            txtStatus.TextChanged += txtStatus_TextChanged;
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblInput.Location = new Point(76, 295);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(282, 25);
            lblInput.TabIndex = 15;
            lblInput.Text = "Input  values (comma delimited)";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { colorSettingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(752, 24);
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(752, 503);
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
    }
}