namespace RentCar.Views.User_Controls
{
    partial class Uc_CarGetDetail
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
            pictureBox1 = new PictureBox();
            lblCarName = new Label();
            lblPassanger = new Label();
            lblAir = new Label();
            lblTransmission = new Label();
            lblMileage = new Label();
            lblInsurance = new Label();
            label8 = new Label();
            panel1 = new Panel();
            label10 = new Label();
            lblPrice = new Label();
            lblStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 198);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblCarName
            // 
            lblCarName.AutoSize = true;
            lblCarName.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblCarName.Location = new Point(239, 28);
            lblCarName.Name = "lblCarName";
            lblCarName.Size = new Size(107, 28);
            lblCarName.TabIndex = 1;
            lblCarName.Text = "Mersedes";
            // 
            // lblPassanger
            // 
            lblPassanger.AutoSize = true;
            lblPassanger.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassanger.ForeColor = Color.DimGray;
            lblPassanger.Location = new Point(239, 89);
            lblPassanger.Name = "lblPassanger";
            lblPassanger.Size = new Size(80, 21);
            lblPassanger.TabIndex = 2;
            lblPassanger.Text = "4 müştəri";
            // 
            // lblAir
            // 
            lblAir.AutoSize = true;
            lblAir.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblAir.ForeColor = Color.DimGray;
            lblAir.Location = new Point(239, 160);
            lblAir.Name = "lblAir";
            lblAir.Size = new Size(120, 21);
            lblAir.TabIndex = 4;
            lblAir.Text = "Kondisoner var";
            // 
            // lblTransmission
            // 
            lblTransmission.AutoSize = true;
            lblTransmission.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTransmission.ForeColor = Color.DimGray;
            lblTransmission.Location = new Point(239, 124);
            lblTransmission.Name = "lblTransmission";
            lblTransmission.Size = new Size(135, 21);
            lblTransmission.TabIndex = 5;
            lblTransmission.Text = "Automatik motor";
            // 
            // lblMileage
            // 
            lblMileage.AutoSize = true;
            lblMileage.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblMileage.ForeColor = Color.DimGray;
            lblMileage.Location = new Point(495, 89);
            lblMileage.Name = "lblMileage";
            lblMileage.Size = new Size(117, 21);
            lblMileage.TabIndex = 7;
            lblMileage.Text = "7 km/l yandırır";
            // 
            // lblInsurance
            // 
            lblInsurance.AutoSize = true;
            lblInsurance.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblInsurance.ForeColor = Color.DimGray;
            lblInsurance.Location = new Point(495, 124);
            lblInsurance.Name = "lblInsurance";
            lblInsurance.Size = new Size(120, 21);
            lblInsurance.TabIndex = 8;
            lblInsurance.Text = "Sığorta daxildir";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(13, 18);
            label8.Name = "label8";
            label8.Size = new Size(142, 21);
            label8.TabIndex = 10;
            label8.Text = "1 Günlük qitməti :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(label10);
            panel1.Controls.Add(lblPrice);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(226, 249);
            panel1.Name = "panel1";
            panel1.Size = new Size(465, 184);
            panel1.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(130, 78);
            label10.Name = "label10";
            label10.Size = new Size(49, 28);
            label10.TabIndex = 12;
            label10.Text = "Azn";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Tahoma", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrice.Location = new Point(73, 67);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(60, 45);
            lblPrice.TabIndex = 11;
            lblPrice.Text = "85";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.DimGray;
            lblStatus.Location = new Point(492, 160);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(57, 21);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "Status";
            // 
            // Uc_CarGetDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblStatus);
            Controls.Add(panel1);
            Controls.Add(lblInsurance);
            Controls.Add(lblMileage);
            Controls.Add(lblTransmission);
            Controls.Add(lblAir);
            Controls.Add(lblPassanger);
            Controls.Add(lblCarName);
            Controls.Add(pictureBox1);
            Name = "Uc_CarGetDetail";
            Size = new Size(694, 436);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblCarName;
        private Label lblPassanger;
        private Label lblAir;
        private Label lblTransmission;
        private Label lblMileage;
        private Label lblInsurance;
        private Label label8;
        private Panel panel1;
        private Label label10;
        private Label lblPrice;
        private Label lblStatus;
    }
}
