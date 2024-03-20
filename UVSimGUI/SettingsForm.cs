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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {

        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPrimaryColor_Click(object sender, EventArgs e)
        {
            if (colorDialogPrimary.ShowDialog() == DialogResult.OK)
            {
                lblPrimaryColor.BackColor = colorDialogPrimary.Color;
                lblPrimaryColor.Text = colorDialogPrimary.Color.IsKnownColor
                                       ? colorDialogPrimary.Color.Name
                                       : $"#{colorDialogPrimary.Color.ToArgb():X8}";
            }
        }

        private void btnOffColor_Click(object sender, EventArgs e)
        {
            if (colorDialogOff.ShowDialog() == DialogResult.OK)
            {
                lblOffColor.BackColor = colorDialogOff.Color;
                lblOffColor.Text = colorDialogOff.Color.IsKnownColor
                                   ? colorDialogOff.Color.Name
                                   : $"#{colorDialogOff.Color.ToArgb():X8}";
            }
        }

        private void btnApply_Click_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.PrimaryColor = colorDialogPrimary.Color;
            Properties.Settings.Default.OffColor = colorDialogOff.Color;
            Properties.Settings.Default.Save();

            ApplyColorsToMainForm();
            this.Close();
        }
        private void ApplyColorsToMainForm()
        {
            if (Owner is MainForm mainForm)
            {
                mainForm.ApplySavedColors();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblOffColor_Click(object sender, EventArgs e)
        {

        }
    }
}
