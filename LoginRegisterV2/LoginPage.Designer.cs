namespace LoginRegisterV2
{
    partial class LoginPage
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
            buttonloginLogin = new Button();
            buttonloginRegister = new Button();
            labelregisterNow = new Label();
            textBoxloginPW = new TextBox();
            labelloginRegister = new Label();
            labelloginLogin = new Label();
            textBoxloginEM = new TextBox();
            labelloginExit = new Label();
            buttonhidelogPW = new Button();
            buttonshowlogPW = new Button();
            SuspendLayout();
            // 
            // buttonloginLogin
            // 
            buttonloginLogin.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonloginLogin.Location = new Point(187, 236);
            buttonloginLogin.Name = "buttonloginLogin";
            buttonloginLogin.Size = new Size(121, 29);
            buttonloginLogin.TabIndex = 13;
            buttonloginLogin.Text = "Login";
            buttonloginLogin.UseVisualStyleBackColor = true;
            buttonloginLogin.Click += buttonloginLogin_Click;
            // 
            // buttonloginRegister
            // 
            buttonloginRegister.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonloginRegister.Location = new Point(187, 344);
            buttonloginRegister.Name = "buttonloginRegister";
            buttonloginRegister.Size = new Size(121, 29);
            buttonloginRegister.TabIndex = 12;
            buttonloginRegister.Text = "Register";
            buttonloginRegister.UseVisualStyleBackColor = true;
            buttonloginRegister.Click += buttonloginRegister_Click;
            // 
            // labelregisterNow
            // 
            labelregisterNow.AutoSize = true;
            labelregisterNow.Location = new Point(164, 326);
            labelregisterNow.Name = "labelregisterNow";
            labelregisterNow.Size = new Size(160, 15);
            labelregisterNow.TabIndex = 11;
            labelregisterNow.Text = "No account? Create account:";
            // 
            // textBoxloginPW
            // 
            textBoxloginPW.Location = new Point(114, 147);
            textBoxloginPW.Name = "textBoxloginPW";
            textBoxloginPW.PasswordChar = '*';
            textBoxloginPW.Size = new Size(277, 23);
            textBoxloginPW.TabIndex = 10;
            // 
            // labelloginRegister
            // 
            labelloginRegister.AutoSize = true;
            labelloginRegister.Location = new Point(51, 147);
            labelloginRegister.Name = "labelloginRegister";
            labelloginRegister.Size = new Size(57, 15);
            labelloginRegister.TabIndex = 9;
            labelloginRegister.Text = "Password";
            // 
            // labelloginLogin
            // 
            labelloginLogin.AutoSize = true;
            labelloginLogin.Location = new Point(27, 91);
            labelloginLogin.Name = "labelloginLogin";
            labelloginLogin.Size = new Size(86, 15);
            labelloginLogin.TabIndex = 8;
            labelloginLogin.Text = "E-mail Address";
            // 
            // textBoxloginEM
            // 
            textBoxloginEM.Location = new Point(114, 88);
            textBoxloginEM.Name = "textBoxloginEM";
            textBoxloginEM.Size = new Size(277, 23);
            textBoxloginEM.TabIndex = 7;
            // 
            // labelloginExit
            // 
            labelloginExit.AutoSize = true;
            labelloginExit.Cursor = Cursors.Hand;
            labelloginExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelloginExit.Location = new Point(440, 9);
            labelloginExit.Name = "labelloginExit";
            labelloginExit.Size = new Size(20, 21);
            labelloginExit.TabIndex = 14;
            labelloginExit.Text = "X";
            labelloginExit.Click += labelloginExit_Click;
            // 
            // buttonhidelogPW
            // 
            buttonhidelogPW.BackColor = Color.White;
            buttonhidelogPW.FlatStyle = FlatStyle.Flat;
            buttonhidelogPW.Image = Properties.Resources.pngwing_com25close;
            buttonhidelogPW.Location = new Point(394, 149);
            buttonhidelogPW.Name = "buttonhidelogPW";
            buttonhidelogPW.Size = new Size(30, 21);
            buttonhidelogPW.TabIndex = 35;
            buttonhidelogPW.UseVisualStyleBackColor = false;
            buttonhidelogPW.Click += buttonhidelogPW_Click;
            // 
            // buttonshowlogPW
            // 
            buttonshowlogPW.BackColor = Color.White;
            buttonshowlogPW.FlatStyle = FlatStyle.Flat;
            buttonshowlogPW.Image = Properties.Resources.pngwing_com25open;
            buttonshowlogPW.Location = new Point(394, 149);
            buttonshowlogPW.Name = "buttonshowlogPW";
            buttonshowlogPW.Size = new Size(30, 21);
            buttonshowlogPW.TabIndex = 34;
            buttonshowlogPW.UseVisualStyleBackColor = false;
            buttonshowlogPW.Click += buttonshowlogPW_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 450);
            Controls.Add(buttonshowlogPW);
            Controls.Add(buttonhidelogPW);
            Controls.Add(labelloginExit);
            Controls.Add(buttonloginLogin);
            Controls.Add(buttonloginRegister);
            Controls.Add(labelregisterNow);
            Controls.Add(textBoxloginPW);
            Controls.Add(labelloginRegister);
            Controls.Add(labelloginLogin);
            Controls.Add(textBoxloginEM);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginPage";
            Load += LoginPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonloginLogin;
        private Button buttonloginRegister;
        private Label labelregisterNow;
        private TextBox textBoxloginPW;
        private Label labelloginRegister;
        private Label labelloginLogin;
        private TextBox textBoxloginEM;
        private Label labelloginExit;
        private Button buttonhidelogPW;
        private Button buttonshowlogPW;
    }
}