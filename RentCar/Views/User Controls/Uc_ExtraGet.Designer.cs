namespace RentCar.Views.User_Controls
{
    partial class Uc_ExtraGet
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
            chbExtra = new CheckBox();
            SuspendLayout();
            // 
            // chbExtra
            // 
            chbExtra.AutoSize = true;
            chbExtra.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            chbExtra.Location = new Point(3, 3);
            chbExtra.Name = "chbExtra";
            chbExtra.Size = new Size(110, 25);
            chbExtra.TabIndex = 0;
            chbExtra.Text = "checkBox1";
            chbExtra.UseVisualStyleBackColor = true;
            chbExtra.CheckedChanged += ChbExtra_CheckedChanged;
            // 
            // Uc_ExtraGet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(chbExtra);
            Name = "Uc_ExtraGet";
            Size = new Size(192, 32);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chbExtra;
    }
}
