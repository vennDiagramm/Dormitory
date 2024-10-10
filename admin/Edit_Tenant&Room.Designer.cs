namespace Laundry___Dormitory
{
    partial class Edit_Tenant_Room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Tenant_Room));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtET_TenantName = new System.Windows.Forms.TextBox();
            this.txtET_PhoneNum = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.btnE_Back_Click = new System.Windows.Forms.Button();
            this.txtET_RentStatus = new System.Windows.Forms.ComboBox();
            this.txtET_RoomNumber = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtET_RoomNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 51);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(487, 51);
            this.label5.TabIndex = 0;
            this.label5.Text = "Edit Tenant/Room";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tenant Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Status of Rent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Room Number";
            // 
            // txtET_TenantName
            // 
            this.txtET_TenantName.Location = new System.Drawing.Point(193, 127);
            this.txtET_TenantName.Name = "txtET_TenantName";
            this.txtET_TenantName.Size = new System.Drawing.Size(262, 26);
            this.txtET_TenantName.TabIndex = 5;
            // 
            // txtET_PhoneNum
            // 
            this.txtET_PhoneNum.Location = new System.Drawing.Point(193, 168);
            this.txtET_PhoneNum.Name = "txtET_PhoneNum";
            this.txtET_PhoneNum.Size = new System.Drawing.Size(262, 26);
            this.txtET_PhoneNum.TabIndex = 8;
            // 
            // editButton
            // 
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Image = ((System.Drawing.Image)(resources.GetObject("editButton.Image")));
            this.editButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editButton.Location = new System.Drawing.Point(277, 273);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(192, 53);
            this.editButton.TabIndex = 10;
            this.editButton.Text = "Edit Data";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // btnE_Back_Click
            // 
            this.btnE_Back_Click.FlatAppearance.BorderSize = 0;
            this.btnE_Back_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnE_Back_Click.Image = ((System.Drawing.Image)(resources.GetObject("btnE_Back_Click.Image")));
            this.btnE_Back_Click.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnE_Back_Click.Location = new System.Drawing.Point(21, 273);
            this.btnE_Back_Click.Name = "btnE_Back_Click";
            this.btnE_Back_Click.Size = new System.Drawing.Size(192, 53);
            this.btnE_Back_Click.TabIndex = 11;
            this.btnE_Back_Click.Text = "Back";
            this.btnE_Back_Click.UseVisualStyleBackColor = true;
            this.btnE_Back_Click.Click += new System.EventHandler(this.btnE_Back_Click_Click);
            // 
            // txtET_RentStatus
            // 
            this.txtET_RentStatus.FormattingEnabled = true;
            this.txtET_RentStatus.Items.AddRange(new object[] {
            "Available",
            "Occupied",
            "Under Maintenance"});
            this.txtET_RentStatus.Location = new System.Drawing.Point(193, 208);
            this.txtET_RentStatus.Name = "txtET_RentStatus";
            this.txtET_RentStatus.Size = new System.Drawing.Size(262, 28);
            this.txtET_RentStatus.TabIndex = 12;
            // 
            // txtET_RoomNumber
            // 
            this.txtET_RoomNumber.Location = new System.Drawing.Point(193, 82);
            this.txtET_RoomNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtET_RoomNumber.Name = "txtET_RoomNumber";
            this.txtET_RoomNumber.Size = new System.Drawing.Size(262, 26);
            this.txtET_RoomNumber.TabIndex = 14;
            this.txtET_RoomNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Edit_Tenant_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(481, 338);
            this.Controls.Add(this.txtET_RoomNumber);
            this.Controls.Add(this.txtET_RentStatus);
            this.Controls.Add(this.btnE_Back_Click);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.txtET_PhoneNum);
            this.Controls.Add(this.txtET_TenantName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Edit_Tenant_Room";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit_Tenant_Room";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtET_RoomNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtET_TenantName;
        private System.Windows.Forms.TextBox txtET_PhoneNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button btnE_Back_Click;
        private System.Windows.Forms.ComboBox txtET_RentStatus;
        private System.Windows.Forms.NumericUpDown txtET_RoomNumber;
    }
}