namespace JRK.HelloWorld.UI
{
    public partial class frmHelloWorld : Form
    {
        public frmHelloWorld()
        {
            InitializeComponent();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear lblDisplayInformation text when the Clear button is clicked 
            // object.property = value;

            lblDisplayInformation.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Code that will close the application when the Exit button is clicked
            // exit the application

            Application.Exit();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            // Code that will display welcome text when the Display button is clicked
            // object.property = value;

            lblDisplayInformation.Text = "Welcome to Visual Studio ~C#!";
        }
    }
}
