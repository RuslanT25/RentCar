namespace RentCar.Views.User_Controls
{
    partial class Uc_CarAdd
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
            label1 = new Label();
            panel1 = new Panel();
            btnImport = new Button();
            pictureBox1 = new PictureBox();
            cbInsurance = new ComboBox();
            cbAir = new ComboBox();
            numMileage = new NumericUpDown();
            btnClear = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            txtPrice = new TextBox();
            numPassenger = new NumericUpDown();
            label10 = new Label();
            label3 = new Label();
            cbCategory = new ComboBox();
            label2 = new Label();
            label9 = new Label();
            txtName = new TextBox();
            label8 = new Label();
            label6 = new Label();
            cbTransmission = new ComboBox();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            cbStatus = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMileage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPassenger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(45, 21);
            label1.TabIndex = 0;
            label1.Text = "Adı :";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(cbStatus);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnImport);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(cbInsurance);
            panel1.Controls.Add(cbAir);
            panel1.Controls.Add(numMileage);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(txtPrice);
            panel1.Controls.Add(numPassenger);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cbCategory);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cbTransmission);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(308, 530);
            panel1.TabIndex = 1;
            // 
            // btnImport
            // 
            btnImport.BackColor = SystemColors.AppWorkspace;
            btnImport.FlatStyle = FlatStyle.Flat;
            btnImport.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnImport.Location = new Point(175, 418);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(125, 29);
            btnImport.TabIndex = 45;
            btnImport.Text = "Daxil et";
            btnImport.UseVisualStyleBackColor = false;
            btnImport.Click += btnImport_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(175, 307);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // cbInsurance
            // 
            cbInsurance.FormattingEnabled = true;
            cbInsurance.Location = new Point(123, 215);
            cbInsurance.Name = "cbInsurance";
            cbInsurance.Size = new Size(151, 28);
            cbInsurance.TabIndex = 43;
            // 
            // cbAir
            // 
            cbAir.FormattingEnabled = true;
            cbAir.Location = new Point(120, 166);
            cbAir.Name = "cbAir";
            cbAir.Size = new Size(151, 28);
            cbAir.TabIndex = 42;
            // 
            // numMileage
            // 
            numMileage.Location = new Point(98, 307);
            numMileage.Name = "numMileage";
            numMileage.Size = new Size(50, 27);
            numMileage.TabIndex = 41;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 128, 0);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(115, 490);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(103, 32);
            btnClear.TabIndex = 40;
            btnClear.Text = "Təmizlə";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Lime;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(5, 490);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(103, 32);
            btnUpdate.TabIndex = 39;
            btnUpdate.Text = "Dəyiş";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(115, 455);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(103, 32);
            btnDelete.TabIndex = 38;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Cyan;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(6, 455);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(103, 32);
            btnAdd.TabIndex = 37;
            btnAdd.Text = "Əlavə et";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(123, 258);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(151, 27);
            txtPrice.TabIndex = 36;
            // 
            // numPassenger
            // 
            numPassenger.Location = new Point(115, 89);
            numPassenger.Name = "numPassenger";
            numPassenger.Size = new Size(50, 27);
            numPassenger.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(3, 260);
            label10.Name = "label10";
            label10.Size = new Size(74, 21);
            label10.TabIndex = 35;
            label10.Text = "Qiymət :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 89);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 4;
            label3.Text = "Oturacaq :";
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(120, 45);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(151, 28);
            cbCategory.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 47);
            label2.Name = "label2";
            label2.Size = new Size(100, 21);
            label2.TabIndex = 2;
            label2.Text = "Kateqoriya :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(6, 215);
            label9.Name = "label9";
            label9.Size = new Size(73, 21);
            label9.TabIndex = 32;
            label9.Text = "Sığorta :";
            // 
            // txtName
            // 
            txtName.Location = new Point(120, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(151, 27);
            txtName.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(2, 308);
            label8.Name = "label8";
            label8.Size = new Size(90, 21);
            label8.TabIndex = 31;
            label8.Text = "Sərfiyyat  :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(3, 132);
            label6.Name = "label6";
            label6.Size = new Size(64, 21);
            label6.TabIndex = 26;
            label6.Text = "Motor :";
            // 
            // cbTransmission
            // 
            cbTransmission.FormattingEnabled = true;
            cbTransmission.Location = new Point(120, 132);
            cbTransmission.Name = "cbTransmission";
            cbTransmission.Size = new Size(151, 28);
            cbTransmission.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(3, 168);
            label7.Name = "label7";
            label7.Size = new Size(103, 21);
            label7.TabIndex = 28;
            label7.Text = "Kondisoner :";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(308, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(668, 530);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 354);
            label4.Name = "label4";
            label4.Size = new Size(68, 21);
            label4.TabIndex = 46;
            label4.Text = "Status :";
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(3, 378);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(145, 28);
            cbStatus.TabIndex = 47;
            // 
            // Uc_CarAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Uc_CarAdd";
            Size = new Size(976, 530);
            Load += Uc_CarAdd_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMileage).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPassenger).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private ComboBox cbCategory;
        private Label label2;
        private TextBox txtName;
        private NumericUpDown numPassenger;
        private Label label3;
        private DataGridView dataGridView1;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private TextBox txtPrice;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label6;
        private ComboBox cbTransmission;
        private Label label7;
        private NumericUpDown numMileage;
        private ComboBox cbInsurance;
        private ComboBox cbAir;
        private Button btnImport;
        private PictureBox pictureBox1;
        private ComboBox cbStatus;
        private Label label4;
    }
}
