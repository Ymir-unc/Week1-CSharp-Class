namespace JRK.HelloWorld.UI
{
    partial class frmHelloWorld
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
            lblDisplayInformation = new Label();
            btnDisplay = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Arial", 18F);
            lblName.Location = new Point(55, 32);
            lblName.Name = "lblName";
            lblName.Size = new Size(146, 27);
            lblName.TabIndex = 0;
            lblName.Text = "Hello World!";
            // 
            // lblDisplayInformation
            // 
            lblDisplayInformation.Font = new Font("Arial", 18F);
            lblDisplayInformation.Location = new Point(55, 88);
            lblDisplayInformation.Name = "lblDisplayInformation";
            lblDisplayInformation.Size = new Size(354, 122);
            lblDisplayInformation.TabIndex = 1;
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(55, 258);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(100, 45);
            btnDisplay.TabIndex = 2;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(182, 258);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 45);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(309, 258);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 45);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmHelloWorld
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 335);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnDisplay);
            Controls.Add(lblDisplayInformation);
            Controls.Add(lblName);
            Name = "frmHelloWorld";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hello World";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblDisplayInformation;
        private Button btnDisplay;
        private Button btnClear;
        private Button btnExit;
    }
}
