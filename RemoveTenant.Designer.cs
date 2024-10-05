namespace Laundry___Dormitory
{
    partial class RemoveTenant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveTenant));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRM_RemoveTenant = new System.Windows.Forms.TextBox();
            this.btnRM_Back = new System.Windows.Forms.Button();
            this.btnRM_Delete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 48);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Location = new System.Drawing.Point(96, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Remove Tenant";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tenant ID";
            // 
            // txtRM_RemoveTenant
            // 
            this.txtRM_RemoveTenant.Location = new System.Drawing.Point(118, 84);
            this.txtRM_RemoveTenant.Name = "txtRM_RemoveTenant";
            this.txtRM_RemoveTenant.Size = new System.Drawing.Size(240, 27);
            this.txtRM_RemoveTenant.TabIndex = 2;
            // 
            // btnRM_Back
            // 
            this.btnRM_Back.FlatAppearance.BorderSize = 0;
            this.btnRM_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRM_Back.Image = ((System.Drawing.Image)(resources.GetObject("btnRM_Back.Image")));
            this.btnRM_Back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRM_Back.Location = new System.Drawing.Point(16, 133);
            this.btnRM_Back.Name = "btnRM_Back";
            this.btnRM_Back.Size = new System.Drawing.Size(112, 72);
            this.btnRM_Back.TabIndex = 3;
            this.btnRM_Back.Text = "Back";
            this.btnRM_Back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRM_Back.UseVisualStyleBackColor = true;
            this.btnRM_Back.Click += new System.EventHandler(this.btnRM_Back_Click);
            // 
            // btnRM_Delete
            // 
            this.btnRM_Delete.FlatAppearance.BorderSize = 0;
            this.btnRM_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRM_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btnRM_Delete.Image")));
            this.btnRM_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRM_Delete.Location = new System.Drawing.Point(180, 133);
            this.btnRM_Delete.Name = "btnRM_Delete";
            this.btnRM_Delete.Size = new System.Drawing.Size(202, 72);
            this.btnRM_Delete.TabIndex = 4;
            this.btnRM_Delete.Text = "Remove Tenant";
            this.btnRM_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRM_Delete.UseVisualStyleBackColor = true;
            // 
            // RemoveTenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(415, 217);
            this.Controls.Add(this.btnRM_Delete);
            this.Controls.Add(this.btnRM_Back);
            this.Controls.Add(this.txtRM_RemoveTenant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "RemoveTenant";
            this.Text = "RemoveTenant";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRM_RemoveTenant;
        private System.Windows.Forms.Button btnRM_Back;
        private System.Windows.Forms.Button btnRM_Delete;
    }
}