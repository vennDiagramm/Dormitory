namespace Laundry___Dormitory
{
    partial class frmAddBoarder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddBoarder));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddTenant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd_Tenant = new System.Windows.Forms.Button();
            this.btnAT_Back = new System.Windows.Forms.Button();
            this.txtAddPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddRoom = new System.Windows.Forms.NumericUpDown();
            this.txtSD = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Pricetxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 50);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(82)))), ((int)(((byte)(69)))));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 50);
            this.label3.TabIndex = 3;
            this.label3.Text = "Add Tenant";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tenant Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Room Number";
            // 
            // txtAddTenant
            // 
            this.txtAddTenant.Location = new System.Drawing.Point(159, 105);
            this.txtAddTenant.Name = "txtAddTenant";
            this.txtAddTenant.Size = new System.Drawing.Size(166, 30);
            this.txtAddTenant.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Rent Status";
            // 
            // btnAdd_Tenant
            // 
            this.btnAdd_Tenant.FlatAppearance.BorderSize = 0;
            this.btnAdd_Tenant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd_Tenant.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd_Tenant.Image")));
            this.btnAdd_Tenant.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd_Tenant.Location = new System.Drawing.Point(166, 282);
            this.btnAdd_Tenant.Name = "btnAdd_Tenant";
            this.btnAdd_Tenant.Size = new System.Drawing.Size(155, 78);
            this.btnAdd_Tenant.TabIndex = 7;
            this.btnAdd_Tenant.Text = "Add";
            this.btnAdd_Tenant.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd_Tenant.UseVisualStyleBackColor = true;
            this.btnAdd_Tenant.Click += new System.EventHandler(this.btnAdd_Tenant_Click);
            // 
            // btnAT_Back
            // 
            this.btnAT_Back.FlatAppearance.BorderSize = 0;
            this.btnAT_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAT_Back.Image = ((System.Drawing.Image)(resources.GetObject("btnAT_Back.Image")));
            this.btnAT_Back.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAT_Back.Location = new System.Drawing.Point(12, 282);
            this.btnAT_Back.Name = "btnAT_Back";
            this.btnAT_Back.Size = new System.Drawing.Size(148, 78);
            this.btnAT_Back.TabIndex = 8;
            this.btnAT_Back.Text = "Back";
            this.btnAT_Back.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAT_Back.UseVisualStyleBackColor = true;
            this.btnAT_Back.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAddPhone
            // 
            this.txtAddPhone.Location = new System.Drawing.Point(159, 145);
            this.txtAddPhone.Name = "txtAddPhone";
            this.txtAddPhone.Size = new System.Drawing.Size(166, 30);
            this.txtAddPhone.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone Number";
            // 
            // txtAddRoom
            // 
            this.txtAddRoom.Location = new System.Drawing.Point(159, 66);
            this.txtAddRoom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtAddRoom.Name = "txtAddRoom";
            this.txtAddRoom.Size = new System.Drawing.Size(166, 30);
            this.txtAddRoom.TabIndex = 11;
            this.txtAddRoom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtSD
            // 
            this.txtSD.FormattingEnabled = true;
            this.txtSD.Items.AddRange(new object[] {
            "Occupied",
            "Available",
            "Under Maintenance"});
            this.txtSD.Location = new System.Drawing.Point(159, 184);
            this.txtSD.Name = "txtSD";
            this.txtSD.Size = new System.Drawing.Size(166, 33);
            this.txtSD.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Room Price";
            // 
            // Pricetxt
            // 
            this.Pricetxt.Location = new System.Drawing.Point(159, 227);
            this.Pricetxt.Name = "Pricetxt";
            this.Pricetxt.Size = new System.Drawing.Size(166, 30);
            this.Pricetxt.TabIndex = 14;
            // 
            // frmAddBoarder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(346, 381);
            this.Controls.Add(this.Pricetxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSD);
            this.Controls.Add(this.txtAddRoom);
            this.Controls.Add(this.txtAddPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAT_Back);
            this.Controls.Add(this.btnAdd_Tenant);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAddTenant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmAddBoarder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Boarder";
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtAddRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddTenant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd_Tenant;
        private System.Windows.Forms.Button btnAT_Back;
        private System.Windows.Forms.TextBox txtAddPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txtAddRoom;
        private System.Windows.Forms.ComboBox txtSD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Pricetxt;
    }
}