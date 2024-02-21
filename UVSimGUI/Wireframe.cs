namespace UVSimGUI
{
    public partial class Wireframe : Form
    {
        public Wireframe()
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

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}