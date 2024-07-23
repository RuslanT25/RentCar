namespace RentCar
{
    partial class Frm_Main
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
            lblExit = new Label();
            panel1 = new Panel();
            button1 = new Button();
            toolStrip1 = new ToolStrip();
            tsbDashboard = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            tsddbRent = new ToolStripDropDownButton();
            tsmiEconomy = new ToolStripMenuItem();
            tsmiMiddle = new ToolStripMenuItem();
            tsmiSuv = new ToolStripMenuItem();
            tamiVan = new ToolStripMenuItem();
            tsmiBusiness = new ToolStripMenuItem();
            tsbReturn = new ToolStripButton();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            panelUserControllers = new Panel();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.BorderStyle = BorderStyle.FixedSingle;
            lblExit.Cursor = Cursors.Hand;
            lblExit.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblExit.ForeColor = Color.Red;
            lblExit.Location = new Point(1226, 3);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(27, 30);
            lblExit.TabIndex = 0;
            lblExit.Text = "X";
            lblExit.Click += lblExit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(74, 101, 114);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(toolStrip1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(272, 758);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(22, 704);
            button1.Name = "button1";
            button1.Size = new Size(96, 42);
            button1.TabIndex = 0;
            button1.Text = "Çıxış";
            button1.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = Color.FromArgb(74, 101, 114);
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbDashboard, toolStripButton1, tsddbRent, tsbReturn });
            toolStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            toolStrip1.Location = new Point(22, 225);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.Professional;
            toolStrip1.Size = new Size(225, 328);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbDashboard
            // 
            tsbDashboard.AutoSize = false;
            tsbDashboard.BackColor = Color.FromArgb(74, 101, 114);
            tsbDashboard.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tsbDashboard.ForeColor = Color.White;
            tsbDashboard.Image = Properties.Resources.dashboard2;
            tsbDashboard.ImageScaling = ToolStripItemImageScaling.None;
            tsbDashboard.ImageTransparentColor = Color.Magenta;
            tsbDashboard.Name = "tsbDashboard";
            tsbDashboard.Size = new Size(223, 60);
            tsbDashboard.Text = "    Dashboard";
            tsbDashboard.Click += tsbDashboard_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.AutoSize = false;
            toolStripButton1.BackColor = Color.FromArgb(74, 101, 114);
            toolStripButton1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripButton1.ForeColor = Color.White;
            toolStripButton1.Image = Properties.Resources.admin3;
            toolStripButton1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(223, 60);
            toolStripButton1.Text = "      Admin Panel";
            toolStripButton1.Click += tsbAdmin_Click;
            // 
            // tsddbRent
            // 
            tsddbRent.AutoSize = false;
            tsddbRent.BackColor = Color.FromArgb(74, 101, 114);
            tsddbRent.DropDownItems.AddRange(new ToolStripItem[] { tsmiEconomy, tsmiMiddle, tsmiSuv, tamiVan, tsmiBusiness });
            tsddbRent.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            tsddbRent.ForeColor = Color.White;
            tsddbRent.Image = Properties.Resources.rental_car;
            tsddbRent.ImageScaling = ToolStripItemImageScaling.None;
            tsddbRent.ImageTransparentColor = Color.Magenta;
            tsddbRent.Name = "tsddbRent";
            tsddbRent.Size = new Size(223, 60);
            tsddbRent.Text = "   Rent a Car";
            // 
            // tsmiEconomy
            // 
            tsmiEconomy.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsmiEconomy.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            tsmiEconomy.Name = "tsmiEconomy";
            tsmiEconomy.Size = new Size(224, 26);
            tsmiEconomy.Text = "Ekonom";
            tsmiEconomy.Click += ToolStripMenuItem_Click;
            // 
            // tsmiMiddle
            // 
            tsmiMiddle.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsmiMiddle.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            tsmiMiddle.Name = "tsmiMiddle";
            tsmiMiddle.Size = new Size(224, 26);
            tsmiMiddle.Text = "Komfort";
            tsmiMiddle.Click += ToolStripMenuItem_Click;
            // 
            // tsmiSuv
            // 
            tsmiSuv.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsmiSuv.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            tsmiSuv.Name = "tsmiSuv";
            tsmiSuv.Size = new Size(224, 26);
            tsmiSuv.Text = "SUV 4x4 Drive";
            tsmiSuv.Click += ToolStripMenuItem_Click;
            // 
            // tamiVan
            // 
            tamiVan.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tamiVan.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            tamiVan.Name = "tamiVan";
            tamiVan.Size = new Size(224, 26);
            tamiVan.Text = "Minivans";
            tamiVan.Click += ToolStripMenuItem_Click;
            // 
            // tsmiBusiness
            // 
            tsmiBusiness.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsmiBusiness.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            tsmiBusiness.Name = "tsmiBusiness";
            tsmiBusiness.Size = new Size(224, 26);
            tsmiBusiness.Text = "Biznes";
            tsmiBusiness.Click += ToolStripMenuItem_Click;
            // 
            // tsbReturn
            // 
            tsbReturn.AutoSize = false;
            tsbReturn.BackColor = Color.FromArgb(74, 101, 114);
            tsbReturn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tsbReturn.ForeColor = Color.White;
            tsbReturn.Image = Properties.Resources.undo;
            tsbReturn.ImageTransparentColor = Color.Magenta;
            tsbReturn.Name = "tsbReturn";
            tsbReturn.Size = new Size(223, 60);
            tsbReturn.Text = "      Return Car";
            tsbReturn.Click += tsbReturn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.vehicle;
            pictureBox1.Location = new Point(83, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 122, 204);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblExit);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1256, 40);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(231, 21);
            label1.TabIndex = 3;
            label1.Text = "Rent-a Car İdarəetmə Sistemi";
            // 
            // panelUserControllers
            // 
            panelUserControllers.Dock = DockStyle.Fill;
            panelUserControllers.Location = new Point(272, 40);
            panelUserControllers.Name = "panelUserControllers";
            panelUserControllers.Size = new Size(984, 758);
            panelUserControllers.TabIndex = 3;
            // 
            // Frm_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1256, 798);
            Controls.Add(panelUserControllers);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Main";
            Text = "Frm_Main";
            Load += Frm_Main_Load;
            panel1.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblExit;
        private Panel panel1;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton tsddbRent;
        private ToolStripMenuItem tsmiEconomy;
        private ToolStripMenuItem tsmiMiddle;
        private ToolStripMenuItem tsmiSuv;
        private ToolStripMenuItem tamiVan;
        private ToolStripMenuItem tsmiBusiness;
        private PictureBox pictureBox1;
        private ToolStripButton tsbReturn;
        private Panel panel2;
        private Label label1;
        private Panel panelUserControllers;
        private ToolStripButton tsbDashboard;
        private Button button1;
        private ToolStripButton toolStripButton1;
    }
}