namespace RentCar.Views.User_Controls
{
    partial class Uc_CarPhoto
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
            panel3 = new Panel();
            btnRent = new Button();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(btnRent);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(340, 252);
            panel3.TabIndex = 2;
            // 
            // btnRent
            // 
            btnRent.BackColor = Color.Aqua;
            btnRent.FlatStyle = FlatStyle.Flat;
            btnRent.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnRent.Location = new Point(19, 209);
            btnRent.Name = "btnRent";
            btnRent.Size = new Size(247, 29);
            btnRent.TabIndex = 2;
            btnRent.Text = "İracə et";
            btnRent.UseVisualStyleBackColor = false;
            btnRent.Click += btnRent_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.AppWorkspace;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(19, 13);
            label2.Name = "label2";
            label2.Size = new Size(33, 24);
            label2.TabIndex = 1;
            label2.Text = "Ad";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(19, 52);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(247, 151);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // Uc_CarPhoto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Name = "Uc_CarPhoto";
            Size = new Size(340, 252);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label2;
        private PictureBox pictureBox2;
        private Button btnRent;
    }
}
