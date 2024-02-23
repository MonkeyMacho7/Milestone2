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
            btnOpenFile = new Button();
            openFileDialog1 = new OpenFileDialog();
            lblTitle = new Label();
            btnExit = new Button();
            lblVersion = new Label();
            lblStatus = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // btnOpenFile
            // 
            btnOpenFile.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnOpenFile.Location = new Point(364, 374);
            btnOpenFile.Margin = new Padding(2, 3, 2, 3);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(695, 109);
            btnOpenFile.TabIndex = 0;
            btnOpenFile.Text = "Value at Memory Location 9:";
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
            lblTitle.Location = new Point(430, 85);
            lblTitle.Margin = new Padding(7, 0, 7, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(543, 133);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "UVSim GUI";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(797, 654);
            btnExit.Margin = new Padding(7, 8, 7, 8);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(515, 180);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new Point(962, 159);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(71, 41);
            lblVersion.TabIndex = 3;
            lblVersion.Text = "v2.0";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BorderStyle = BorderStyle.Fixed3D;
            lblStatus.Location = new Point(364, 249);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(225, 43);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "No file selected";
            // 
            // button2
            // 
            button2.Location = new Point(321, 692);
            button2.Name = "button2";
            button2.Size = new Size(188, 58);
            button2.TabIndex = 5;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1826, 1333);
            Controls.Add(button2);
            Controls.Add(lblStatus);
            Controls.Add(lblVersion);
            Controls.Add(btnExit);
            Controls.Add(lblTitle);
            Controls.Add(btnOpenFile);
            Margin = new Padding(2, 3, 2, 3);
            Name = "MainForm";
            Text = "Wireframe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOpenFile;
        private OpenFileDialog openFileDialog1;
        private Label lblTitle;
        private Button btnExit;
        private Label lblVersion;
        private Label lblStatus;
        private Button button2;
    }
}