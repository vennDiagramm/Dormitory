namespace Laundry___Dormitory.admin
{
    partial class Payment_History
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment_History));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_PaymentHistory = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbMonth = new System.Windows.Forms.Label();
            this.btnNextClick = new System.Windows.Forms.PictureBox();
            this.btnPrevClick = new System.Windows.Forms.PictureBox();
            this.btn_PH_Back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PaymentHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNextClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevClick)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 54);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Payment History";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            // 
            // dgv_PaymentHistory
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.dgv_PaymentHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_PaymentHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_PaymentHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_PaymentHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PaymentHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_PaymentHistory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_PaymentHistory.EnableHeadersVisualStyles = false;
            this.dgv_PaymentHistory.Location = new System.Drawing.Point(12, 83);
            this.dgv_PaymentHistory.Name = "dgv_PaymentHistory";
            this.dgv_PaymentHistory.RowHeadersVisible = false;
            this.dgv_PaymentHistory.RowHeadersWidth = 51;
            this.dgv_PaymentHistory.Size = new System.Drawing.Size(581, 447);
            this.dgv_PaymentHistory.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Payment ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Room Number";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Payment Amount";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Payment Date";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Payment Status";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(621, 83);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(738, 525);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(629, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sunday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(727, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Monday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(820, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tuesday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(909, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Wednesday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1013, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Thursday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1122, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Friday";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1203, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Saturday";
            // 
            // lbMonth
            // 
            this.lbMonth.AutoSize = true;
            this.lbMonth.Location = new System.Drawing.Point(617, 9);
            this.lbMonth.Name = "lbMonth";
            this.lbMonth.Size = new System.Drawing.Size(66, 20);
            this.lbMonth.TabIndex = 11;
            this.lbMonth.Text = "MONTH";
            // 
            // btnNextClick
            // 
            this.btnNextClick.Image = ((System.Drawing.Image)(resources.GetObject("btnNextClick.Image")));
            this.btnNextClick.Location = new System.Drawing.Point(1254, 6);
            this.btnNextClick.Name = "btnNextClick";
            this.btnNextClick.Size = new System.Drawing.Size(40, 40);
            this.btnNextClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNextClick.TabIndex = 13;
            this.btnNextClick.TabStop = false;
            this.btnNextClick.Click += new System.EventHandler(this.btnNextClick_Click);
            // 
            // btnPrevClick
            // 
            this.btnPrevClick.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevClick.Image")));
            this.btnPrevClick.Location = new System.Drawing.Point(1208, 6);
            this.btnPrevClick.Name = "btnPrevClick";
            this.btnPrevClick.Size = new System.Drawing.Size(40, 40);
            this.btnPrevClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPrevClick.TabIndex = 12;
            this.btnPrevClick.TabStop = false;
            this.btnPrevClick.Click += new System.EventHandler(this.btnPrevClick_Click);
            // 
            // btn_PH_Back
            // 
            this.btn_PH_Back.FlatAppearance.BorderSize = 0;
            this.btn_PH_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PH_Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_PH_Back.Image")));
            this.btn_PH_Back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PH_Back.Location = new System.Drawing.Point(10, 554);
            this.btn_PH_Back.Name = "btn_PH_Back";
            this.btn_PH_Back.Size = new System.Drawing.Size(583, 64);
            this.btn_PH_Back.TabIndex = 2;
            this.btn_PH_Back.Text = "Back";
            this.btn_PH_Back.UseVisualStyleBackColor = true;
            this.btn_PH_Back.Click += new System.EventHandler(this.btn_PH_Back_Click);
            // 
            // Payment_History
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1370, 627);
            this.Controls.Add(this.btnNextClick);
            this.Controls.Add(this.btnPrevClick);
            this.Controls.Add(this.lbMonth);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btn_PH_Back);
            this.Controls.Add(this.dgv_PaymentHistory);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Payment_History";
            this.Text = "Payment_History";
            this.Load += new System.EventHandler(this.Payment_History_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PaymentHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNextClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevClick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_PaymentHistory;
        private System.Windows.Forms.Button btn_PH_Back;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbMonth;
        private System.Windows.Forms.PictureBox btnPrevClick;
        private System.Windows.Forms.PictureBox btnNextClick;
    }
}