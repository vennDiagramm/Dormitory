namespace Laundry___Dormitory.admin
{
    partial class Approval_Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Approval_Window));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvBoarder = new System.Windows.Forms.DataGridView();
            this.RoomNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenantNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartingDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoarder)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 49);
            this.panel1.TabIndex = 0;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.Location = new System.Drawing.Point(675, 3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(27, 25);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(0, 199);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(206, 78);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnApprove);
            this.panel2.Controls.Add(this.btnReject);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 277);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvBoarder);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(204, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(501, 277);
            this.panel3.TabIndex = 4;
            // 
            // dgvBoarder
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.dgvBoarder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBoarder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBoarder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBoarder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoarder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomNumberColumn,
            this.TenantNameColumn,
            this.PhoneNumberColumn,
            this.StartingDateColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBoarder.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBoarder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBoarder.EnableHeadersVisualStyles = false;
            this.dgvBoarder.Location = new System.Drawing.Point(0, 0);
            this.dgvBoarder.Name = "dgvBoarder";
            this.dgvBoarder.RowHeadersVisible = false;
            this.dgvBoarder.RowHeadersWidth = 51;
            this.dgvBoarder.Size = new System.Drawing.Size(501, 277);
            this.dgvBoarder.TabIndex = 1;
            // 
            // RoomNumberColumn
            // 
            this.RoomNumberColumn.HeaderText = "Room No.";
            this.RoomNumberColumn.MinimumWidth = 6;
            this.RoomNumberColumn.Name = "RoomNumberColumn";
            this.RoomNumberColumn.Width = 130;
            // 
            // TenantNameColumn
            // 
            this.TenantNameColumn.HeaderText = "Name";
            this.TenantNameColumn.MinimumWidth = 6;
            this.TenantNameColumn.Name = "TenantNameColumn";
            this.TenantNameColumn.Width = 127;
            // 
            // PhoneNumberColumn
            // 
            this.PhoneNumberColumn.HeaderText = "Phone No.";
            this.PhoneNumberColumn.MinimumWidth = 6;
            this.PhoneNumberColumn.Name = "PhoneNumberColumn";
            this.PhoneNumberColumn.Width = 125;
            // 
            // StartingDateColumn
            // 
            this.StartingDateColumn.HeaderText = "Rent Status";
            this.StartingDateColumn.MinimumWidth = 6;
            this.StartingDateColumn.Name = "StartingDateColumn";
            this.StartingDateColumn.Width = 127;
            // 
            // btnReject
            // 
            this.btnReject.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnReject.FlatAppearance.BorderSize = 0;
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.Image = ((System.Drawing.Image)(resources.GetObject("btnReject.Image")));
            this.btnReject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReject.Location = new System.Drawing.Point(0, 130);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(206, 69);
            this.btnReject.TabIndex = 3;
            this.btnReject.Text = "Deny";
            this.btnReject.UseVisualStyleBackColor = true;
            // 
            // btnApprove
            // 
            this.btnApprove.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnApprove.FlatAppearance.BorderSize = 0;
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.Image = ((System.Drawing.Image)(resources.GetObject("btnApprove.Image")));
            this.btnApprove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApprove.Location = new System.Drawing.Point(0, 58);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(206, 72);
            this.btnApprove.TabIndex = 4;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Approve Tenant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "paki butang sa time diri";
            // 
            // Approval_Window
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(705, 326);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Approval_Window";
            this.Text = "PendingWindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoarder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.DataGridView dgvBoarder;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenantNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartingDateColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}