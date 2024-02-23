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
            txtOne = new TextBox();
            txtTwo = new TextBox();
            btnCompute = new Button();
            lblMemory = new Label();
            txtValue = new TextBox();
            lblLoading = new Label();
            lblValue = new Label();
            label1 = new Label();
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
            // txtOne
            // 
            txtOne.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtOne.Location = new Point(141, 191);
            txtOne.Name = "txtOne";
            txtOne.Size = new Size(167, 34);
            txtOne.TabIndex = 6;
            txtOne.TextChanged += txtOne_TextChanged;
            // 
            // txtTwo
            // 
            txtTwo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtTwo.Location = new Point(445, 191);
            txtTwo.Name = "txtTwo";
            txtTwo.Size = new Size(176, 34);
            txtTwo.TabIndex = 7;
            txtTwo.TextChanged += txtTwo_TextChanged;
            // 
            // btnCompute
            // 
            btnCompute.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            btnCompute.Location = new Point(256, 284);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(216, 75);
            btnCompute.TabIndex = 8;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = true;
            btnCompute.Click += btnCompute_Click;
            // 
            // lblMemory
            // 
            lblMemory.AutoSize = true;
            lblMemory.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblMemory.Location = new Point(139, 122);
            lblMemory.Name = "lblMemory";
            lblMemory.Size = new Size(333, 37);
            lblMemory.TabIndex = 9;
            lblMemory.Text = "Value at Memory Location:";
            lblMemory.Click += lblMemory_Click;
            // 
            // txtValue
            // 
            txtValue.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtValue.Location = new Point(478, 122);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(77, 43);
            txtValue.TabIndex = 10;
            txtValue.Text = "Value";
            txtValue.TextChanged += txtValue_TextChanged;
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
            lblLoading.Click += lblLoading_Click;
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblValue.Location = new Point(225, 123);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(272, 54);
            lblValue.TabIndex = 12;
            lblValue.Text = "Enter 2 Values";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 0);
            label1.Name = "label1";
            label1.Size = new Size(205, 15);
            label1.TabIndex = 13;
            label1.Text = "Ethan Larson, Sony Smith, Brock Terry";
            label1.Click += label1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(752, 488);
            Controls.Add(label1);
            Controls.Add(lblValue);
            Controls.Add(lblLoading);
            Controls.Add(txtValue);
            Controls.Add(lblMemory);
            Controls.Add(btnCompute);
            Controls.Add(txtTwo);
            Controls.Add(txtOne);
            Controls.Add(lblVersion);
            Controls.Add(btnExit);
            Controls.Add(lblTitle);
            Controls.Add(btnOpenFile);
            Margin = new Padding(1);
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
        private System.Windows.Forms.Timer loadingTimer;
        private TextBox txtOne;
        private TextBox txtTwo;
        private Button btnCompute;
        private Label lblMemory;
        private TextBox txtValue;
        private Label lblLoading;
        private Label lblValue;
        private Label label1;
    }
}