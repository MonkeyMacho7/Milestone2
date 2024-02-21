namespace UVSimGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "swagger";
            openFileDialog1.ShowDialog(this);

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBox.Show("File selected: " + openFileDialog1.FileName);
        }
    }
}