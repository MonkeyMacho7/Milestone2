namespace UVSimGUI
{
    partial class SettingsForm
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
            btnPrimaryColor = new Button();
            btnOffColor = new Button();
            btnApply = new Button();
            btnCancel = new Button();
            colorDialogPrimary = new ColorDialog();
            colorDialogOff = new ColorDialog();
            lblPrimaryColor = new Label();
            lblOffColor = new Label();
            SuspendLayout();
            // 
            // btnPrimaryColor
            // 
            btnPrimaryColor.Location = new Point(162, 126);
            btnPrimaryColor.Name = "btnPrimaryColor";
            btnPrimaryColor.Size = new Size(155, 65);
            btnPrimaryColor.TabIndex = 0;
            btnPrimaryColor.Text = "Choose Primary Color";
            btnPrimaryColor.UseVisualStyleBackColor = true;
            btnPrimaryColor.Click += btnPrimaryColor_Click;
            // 
            // btnOffColor
            // 
            btnOffColor.Location = new Point(409, 125);
            btnOffColor.Name = "btnOffColor";
            btnOffColor.Size = new Size(163, 66);
            btnOffColor.TabIndex = 1;
            btnOffColor.Text = "Choose Off-Color";
            btnOffColor.UseVisualStyleBackColor = true;
            btnOffColor.Click += btnOffColor_Click;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(150, 289);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(167, 67);
            btnApply.TabIndex = 2;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(409, 289);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(163, 67);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblPrimaryColor
            // 
            lblPrimaryColor.AutoSize = true;
            lblPrimaryColor.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrimaryColor.Location = new Point(129, 232);
            lblPrimaryColor.Name = "lblPrimaryColor";
            lblPrimaryColor.Size = new Size(274, 37);
            lblPrimaryColor.TabIndex = 4;
            lblPrimaryColor.Text = "Chosen Primary Color";
            // 
            // lblOffColor
            // 
            lblOffColor.AutoSize = true;
            lblOffColor.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblOffColor.Location = new Point(409, 232);
            lblOffColor.Name = "lblOffColor";
            lblOffColor.Size = new Size(224, 37);
            lblOffColor.TabIndex = 5;
            lblOffColor.Text = "Chosen Off-Color";
            lblOffColor.Click += lblOffColor_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblOffColor);
            Controls.Add(lblPrimaryColor);
            Controls.Add(btnCancel);
            Controls.Add(btnApply);
            Controls.Add(btnOffColor);
            Controls.Add(btnPrimaryColor);
            Name = "SettingsForm";
            Text = "SettingsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPrimaryColor;
        private Button btnOffColor;
        private Button btnApply;
        private Button btnCancel;
        private ColorDialog colorDialogPrimary;
        private ColorDialog colorDialogOff;
        private Label lblPrimaryColor;
        private Label lblOffColor;
        private Label tabControl1;
    }
}