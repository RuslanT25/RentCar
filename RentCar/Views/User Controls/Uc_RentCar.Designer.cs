namespace RentCar.Views.User_Controls
{
    partial class Uc_RentCar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelRentCar = new Panel();
            panelCarInfo = new Panel();
            panel5 = new Panel();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label11 = new Label();
            label9 = new Label();
            cbReturn = new ComboBox();
            label8 = new Label();
            cbRent = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            panel4 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel3 = new Panel();
            label5 = new Label();
            lblTotal = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label13 = new Label();
            label12 = new Label();
            label10 = new Label();
            label4 = new Label();
            btnRent = new Button();
            label1 = new Label();
            txtEmail = new TextBox();
            rbWoman = new RadioButton();
            txtName = new TextBox();
            txtSurname = new TextBox();
            rbMan = new RadioButton();
            txtPhone = new TextBox();
            panelRentCar.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelRentCar
            // 
            panelRentCar.Controls.Add(panelCarInfo);
            panelRentCar.Controls.Add(panel5);
            panelRentCar.Controls.Add(panel1);
            panelRentCar.Dock = DockStyle.Fill;
            panelRentCar.Location = new Point(0, 0);
            panelRentCar.Name = "panelRentCar";
            panelRentCar.Size = new Size(964, 755);
            panelRentCar.TabIndex = 0;
            // 
            // panelCarInfo
            // 
            panelCarInfo.Dock = DockStyle.Fill;
            panelCarInfo.Location = new Point(0, 0);
            panelCarInfo.Name = "panelCarInfo";
            panelCarInfo.Size = new Size(694, 436);
            panelCarInfo.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Goldenrod;
            panel5.Controls.Add(dateTimePicker2);
            panel5.Controls.Add(dateTimePicker1);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(cbReturn);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(cbRent);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label6);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(694, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(270, 436);
            panel5.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(13, 377);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(244, 27);
            dateTimePicker2.TabIndex = 22;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(13, 289);
            dateTimePicker1.MinDate = new DateTime(2023, 12, 25, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(244, 27);
            dateTimePicker1.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(13, 344);
            label11.Name = "label11";
            label11.Size = new Size(136, 21);
            label11.TabIndex = 20;
            label11.Text = "Qaytarma tarixi :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(13, 255);
            label9.Name = "label9";
            label9.Size = new Size(127, 21);
            label9.TabIndex = 16;
            label9.Text = "Götürmə tarixi :";
            // 
            // cbReturn
            // 
            cbReturn.FormattingEnabled = true;
            cbReturn.Location = new Point(13, 199);
            cbReturn.Name = "cbReturn";
            cbReturn.Size = new Size(244, 28);
            cbReturn.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(13, 166);
            label8.Name = "label8";
            label8.Size = new Size(126, 21);
            label8.TabIndex = 14;
            label8.Text = "Qaytarma yeri :";
            // 
            // cbRent
            // 
            cbRent.FormattingEnabled = true;
            cbRent.Location = new Point(13, 109);
            cbRent.Name = "cbRent";
            cbRent.Size = new Size(244, 28);
            cbRent.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(13, 76);
            label7.Name = "label7";
            label7.Size = new Size(117, 21);
            label7.TabIndex = 12;
            label7.Text = "Götürmə yeri :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(77, 10);
            label6.Name = "label6";
            label6.Size = new Size(131, 26);
            label6.TabIndex = 11;
            label6.Text = "Rezervasiya :";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 436);
            panel1.Name = "panel1";
            panel1.Size = new Size(964, 319);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(flowLayoutPanel1);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 54);
            panel4.Name = "panel4";
            panel4.Size = new Size(519, 203);
            panel4.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(519, 203);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label5);
            panel3.Controls.Add(lblTotal);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 257);
            panel3.Name = "panel3";
            panel3.Size = new Size(519, 60);
            panel3.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(155, 17);
            label5.Name = "label5";
            label5.Size = new Size(46, 24);
            label5.TabIndex = 2;
            label5.Text = "AZN";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(119, 17);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(21, 24);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(33, 17);
            label3.Name = "label3";
            label3.Size = new Size(89, 24);
            label3.TabIndex = 0;
            label3.Text = "TOTAL : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(183, 19);
            label2.Name = "label2";
            label2.Size = new Size(103, 26);
            label2.TabIndex = 8;
            label2.Text = "Ekstralar :";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnRent);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(rbWoman);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(txtSurname);
            panel2.Controls.Add(rbMan);
            panel2.Controls.Add(txtPhone);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(519, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(443, 317);
            panel2.TabIndex = 0;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(39, 200);
            label13.Name = "label13";
            label13.Size = new Size(62, 21);
            label13.TabIndex = 26;
            label13.Text = "Email :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(245, 120);
            label12.Name = "label12";
            label12.Size = new Size(65, 21);
            label12.TabIndex = 25;
            label12.Text = "Soyad :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(245, 200);
            label10.Name = "label10";
            label10.Size = new Size(70, 21);
            label10.TabIndex = 24;
            label10.Text = "Nömrə :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(39, 120);
            label4.Name = "label4";
            label4.Size = new Size(41, 21);
            label4.TabIndex = 23;
            label4.Text = "Ad :";
            // 
            // btnRent
            // 
            btnRent.BackColor = Color.Cyan;
            btnRent.Cursor = Cursors.Hand;
            btnRent.FlatStyle = FlatStyle.Flat;
            btnRent.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnRent.Location = new Point(327, 268);
            btnRent.Name = "btnRent";
            btnRent.Size = new Size(110, 38);
            btnRent.TabIndex = 7;
            btnRent.Text = "Rent";
            btnRent.UseVisualStyleBackColor = false;
            btnRent.Click += btnRent_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(113, 19);
            label1.Name = "label1";
            label1.Size = new Size(203, 26);
            label1.TabIndex = 0;
            label1.Text = "Müştəri məlumatları :";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ButtonHighlight;
            txtEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(38, 224);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(192, 35);
            txtEmail.TabIndex = 4;
            // 
            // rbWoman
            // 
            rbWoman.AutoSize = true;
            rbWoman.Location = new Point(103, 76);
            rbWoman.Name = "rbWoman";
            rbWoman.Size = new Size(70, 24);
            rbWoman.TabIndex = 2;
            rbWoman.TabStop = true;
            rbWoman.Text = "Qadın";
            rbWoman.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.ButtonHighlight;
            txtName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = Color.Black;
            txtName.Location = new Point(38, 144);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(192, 35);
            txtName.TabIndex = 3;
            // 
            // txtSurname
            // 
            txtSurname.BackColor = SystemColors.ButtonHighlight;
            txtSurname.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtSurname.ForeColor = Color.Black;
            txtSurname.Location = new Point(245, 144);
            txtSurname.Multiline = true;
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(192, 35);
            txtSurname.TabIndex = 5;
            // 
            // rbMan
            // 
            rbMan.AutoSize = true;
            rbMan.Location = new Point(44, 76);
            rbMan.Name = "rbMan";
            rbMan.Size = new Size(53, 24);
            rbMan.TabIndex = 1;
            rbMan.TabStop = true;
            rbMan.Text = "Kişi";
            rbMan.UseVisualStyleBackColor = true;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = SystemColors.ButtonHighlight;
            txtPhone.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.ForeColor = Color.Black;
            txtPhone.Location = new Point(245, 224);
            txtPhone.Multiline = true;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(192, 35);
            txtPhone.TabIndex = 6;
            // 
            // Uc_RentCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelRentCar);
            Name = "Uc_RentCar";
            Size = new Size(964, 755);
            Load += Uc_RentCar_Load;
            panelRentCar.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelRentCar;
        private Panel panel1;
        private RadioButton rbWoman;
        private RadioButton rbMan;
        private Label label1;
        private TextBox txtPhone;
        private TextBox txtSurname;
        private TextBox txtEmail;
        private TextBox txtName;
        private Button btnRent;
        private Panel panel2;
        private Label label2;
        private Panel panel4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel3;
        private Label label5;
        private Label lblTotal;
        private Label label3;
        private Panel panel5;
        private Label label7;
        private Label label6;
        private Label label11;
        private Label label9;
        private ComboBox cbReturn;
        private Label label8;
        private ComboBox cbRent;
        private Panel panelCarInfo;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label13;
        private Label label12;
        private Label label10;
        private Label label4;
    }
}
