namespace Laundry___Dormitory
{
    partial class Search_Tenant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_Tenant));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnST_Search = new System.Windows.Forms.Button();
            this.btnST_Back = new System.Windows.Forms.Button();
            this.txtST_TenantID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 45);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Location = new System.Drawing.Point(105, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Tenant";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            // 
            // btnST_Search
            // 
            this.btnST_Search.FlatAppearance.BorderSize = 0;
            this.btnST_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnST_Search.Image = ((System.Drawing.Image)(resources.GetObject("btnST_Search.Image")));
            this.btnST_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnST_Search.Location = new System.Drawing.Point(192, 136);
            this.btnST_Search.Name = "btnST_Search";
            this.btnST_Search.Size = new System.Drawing.Size(202, 72);
            this.btnST_Search.TabIndex = 9;
            this.btnST_Search.Text = "Search Tenant";
            this.btnST_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnST_Search.UseVisualStyleBackColor = true;
            // 
            // btnST_Back
            // 
            this.btnST_Back.FlatAppearance.BorderSize = 0;
            this.btnST_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnST_Back.Image = ((System.Drawing.Image)(resources.GetObject("btnST_Back.Image")));
            this.btnST_Back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnST_Back.Location = new System.Drawing.Point(32, 136);
            this.btnST_Back.Name = "btnST_Back";
            this.btnST_Back.Size = new System.Drawing.Size(112, 72);
            this.btnST_Back.TabIndex = 8;
            this.btnST_Back.Text = "Back";
            this.btnST_Back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnST_Back.UseVisualStyleBackColor = true;
            this.btnST_Back.Click += new System.EventHandler(this.btnST_Back_Click);
            // 
            // txtST_TenantID
            // 
            this.txtST_TenantID.Location = new System.Drawing.Point(130, 75);
            this.txtST_TenantID.Name = "txtST_TenantID";
            this.txtST_TenantID.Size = new System.Drawing.Size(240, 27);
            this.txtST_TenantID.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tenant ID";
            // 
            // Search_Tenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(435, 215);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnST_Search);
            this.Controls.Add(this.btnST_Back);
            this.Controls.Add(this.txtST_TenantID);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Search_Tenant";
            this.Text = "Search_Tenant";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnST_Search;
        private System.Windows.Forms.Button btnST_Back;
        private System.Windows.Forms.TextBox txtST_TenantID;
        private System.Windows.Forms.Label label2;
    }
}