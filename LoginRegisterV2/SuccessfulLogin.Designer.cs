namespace LoginRegisterV2
{
    partial class SuccessfulLogin
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
            buttonLogOut = new Button();
            labelloggedInExit = new Label();
            SuspendLayout();
            // 
            // buttonLogOut
            // 
            buttonLogOut.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogOut.Location = new Point(171, 184);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(162, 63);
            buttonLogOut.TabIndex = 0;
            buttonLogOut.Text = "Log Out";
            buttonLogOut.UseVisualStyleBackColor = true;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // labelloggedInExit
            // 
            labelloggedInExit.AutoSize = true;
            labelloggedInExit.Cursor = Cursors.Hand;
            labelloggedInExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelloggedInExit.Location = new Point(461, 23);
            labelloggedInExit.Name = "labelloggedInExit";
            labelloggedInExit.Size = new Size(20, 21);
            labelloggedInExit.TabIndex = 1;
            labelloggedInExit.Text = "X";
            labelloggedInExit.Click += labelloggedInExit_Click;
            // 
            // SuccessfulLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 450);
            Controls.Add(labelloggedInExit);
            Controls.Add(buttonLogOut);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SuccessfulLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SuccessfulLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogOut;
        private Label labelloggedInExit;
    }
}