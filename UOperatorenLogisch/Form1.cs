namespace UOperatorenLogisch
{
    public partial class MainForm : Form
    {
        private int A = 4;
        private int B = 3;
        public MainForm()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            
            LblAnzeige.Text = $"A > B [AND] -A > -B is {(A > B) && (-A > -B)}.";
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = $"A > B [OR] -A > -B is {(A > B)||(-A > -B)}.";
        }

        private void CmdBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}