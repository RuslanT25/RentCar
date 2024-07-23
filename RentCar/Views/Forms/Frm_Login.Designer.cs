namespace RentCar
{
    partial class Frm_Login
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            label4 = new Label();
            chbShow = new CheckBox();
            btnLogin = new Button();
            lblExit = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 593);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.vehicle;
            pictureBox1.Location = new Point(104, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 238);
            label1.Name = "label1";
            label1.Size = new Size(272, 24);
            label1.TabIndex = 1;
            label1.Text = "Rent a Car İdarəetmə sistemi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(373, 75);
            label2.Name = "label2";
            label2.Size = new Size(177, 27);
            label2.TabIndex = 1;
            label2.Text = "Hesaba giriş et";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(369, 164);
            label3.Name = "label3";
            label3.Size = new Size(62, 21);
            label3.TabIndex = 2;
            label3.Text = "Email :";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(373, 188);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(347, 36);
            txtUserName.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(373, 262);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(347, 36);
            txtPassword.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(369, 238);
            label4.Name = "label4";
            label4.Size = new Size(58, 21);
            label4.TabIndex = 4;
            label4.Text = "Parol :";
            // 
            // chbShow
            // 
            chbShow.AutoSize = true;
            chbShow.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            chbShow.Location = new Point(588, 314);
            chbShow.Name = "chbShow";
            chbShow.Size = new Size(130, 25);
            chbShow.TabIndex = 6;
            chbShow.Text = "Parolu göstər";
            chbShow.UseVisualStyleBackColor = true;
            chbShow.CheckedChanged += chbShow_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(33, 11, 97);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(373, 363);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(124, 42);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "DAXİL OL";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.Cursor = Cursors.Hand;
            lblExit.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblExit.ForeColor = Color.Red;
            lblExit.Location = new Point(719, 9);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(22, 24);
            lblExit.TabIndex = 8;
            lblExit.Text = "X";
            lblExit.Click += lblExit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.2F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(369, 315);
            label5.Name = "label5";
            label5.Size = new Size(168, 21);
            label5.TabIndex = 9;
            label5.Text = "Parolu unutmusunuz?";
            // 
            // Frm_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(749, 593);
            Controls.Add(label5);
            Controls.Add(lblExit);
            Controls.Add(btnLogin);
            Controls.Add(chbShow);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(txtUserName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Frm_Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label label4;
        private CheckBox chbShow;
        private Button btnLogin;
        private Label lblExit;
        private Label label5;
    }
}