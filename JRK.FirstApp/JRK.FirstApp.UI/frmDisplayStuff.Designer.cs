namespace JRK.FirstApp.UI
{
    partial class frmDisplayStuff
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            lblInformation = new Label();
            btnExit = new Button();
            btnDisplayInfo = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(68, 44);
            lblName.Name = "lblName";
            lblName.Size = new Size(182, 15);
            lblName.TabIndex = 0;
            lblName.Text = "C# Introduction to Programming";
            // 
            // lblInformation
            // 
            lblInformation.BackColor = Color.CornflowerBlue;
            lblInformation.Font = new Font("Calibri", 18F, FontStyle.Bold | FontStyle.Italic);
            lblInformation.Location = new Point(68, 86);
            lblInformation.Name = "lblInformation";
            lblInformation.Size = new Size(168, 106);
            lblInformation.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(326, 274);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(96, 25);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click_1;
            // 
            // btnDisplayInfo
            // 
            btnDisplayInfo.Location = new Point(230, 274);
            btnDisplayInfo.Name = "btnDisplayInfo";
            btnDisplayInfo.Size = new Size(96, 25);
            btnDisplayInfo.TabIndex = 4;
            btnDisplayInfo.Text = "Display";
            btnDisplayInfo.UseVisualStyleBackColor = true;
            btnDisplayInfo.Click += btnDisplayInfo_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(134, 274);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(96, 25);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // frmDisplayStuff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(434, 311);
            Controls.Add(btnClear);
            Controls.Add(btnDisplayInfo);
            Controls.Add(btnExit);
            Controls.Add(lblInformation);
            Controls.Add(lblName);
            Name = "frmDisplayStuff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Used to Display Stuff";
            Load += frmDisplayStuff_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void frmDisplayStuff_Load(object sender, EventArgs e)
        {
            // Initialization logic for the form goes here.
            // Example: set window title and initialize controls.
            this.Text = "Used to Display Stuff";
            // TODO: add any further startup initialization (data binding, control setup, etc.)
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit the application when the Exit button is clicked.
            Application.Exit();
        }

        private void lblInformation_Click(object sender, EventArgs e)
        {
            // Optional: show information when label is clicked, or leave empty if not needed.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: implement this button's action or remove the handler if unused.
        }

        #endregion

        private Label lblName;
        private Label lblInformation;
        private Button btnExit;
        private Button btnDisplayInfo;
        private Button btnClear;
    }
}
