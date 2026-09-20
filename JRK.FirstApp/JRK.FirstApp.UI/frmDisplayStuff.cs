namespace JRK.FirstApp.UI
{
    public partial class frmDisplayStuff : Form
    {
        public frmDisplayStuff()
        {
            InitializeComponent();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            // Code that executes when the user clicks the button
            // exit the application

            Application.Exit();
        }

        private void btnDisplayInfo_Click(object sender, EventArgs e)
        {
            // Show the lblName Text in the lblInformation Text.

            // object.property = value;

            lblInformation.Text = "C# Introduction to Programming";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the lblInformation
            // object.property = value;

            lblInformation.Text = string.Empty;
        }
    }
} 