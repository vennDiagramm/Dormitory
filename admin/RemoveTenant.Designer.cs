﻿namespace Laundry___Dormitory
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
            this.btnRM_Back = new System.Windows.Forms.Button();
            this.btnRM_Delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRM_RoomNumber = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-22, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 51);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Location = new System.Drawing.Point(71, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Remove Tenant";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            // 
            // btnRM_Back
            // 
            this.btnRM_Back.FlatAppearance.BorderSize = 0;
            this.btnRM_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRM_Back.Image = ((System.Drawing.Image)(resources.GetObject("btnRM_Back.Image")));
            this.btnRM_Back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRM_Back.Location = new System.Drawing.Point(21, 154);
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
            this.btnRM_Delete.Location = new System.Drawing.Point(220, 153);
            this.btnRM_Delete.Name = "btnRM_Delete";
            this.btnRM_Delete.Size = new System.Drawing.Size(202, 72);
            this.btnRM_Delete.TabIndex = 4;
            this.btnRM_Delete.Text = "Remove Tenant";
            this.btnRM_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRM_Delete.UseVisualStyleBackColor = true;
            this.btnRM_Delete.Click += new System.EventHandler(this.btnRM_Delete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Room Number";
            // 
            // txtRM_RoomNumber
            // 
            this.txtRM_RoomNumber.Location = new System.Drawing.Point(182, 93);
            this.txtRM_RoomNumber.Name = "txtRM_RoomNumber";
            this.txtRM_RoomNumber.Size = new System.Drawing.Size(240, 30);
            this.txtRM_RoomNumber.TabIndex = 6;
            // 
            // RemoveTenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(456, 247);
            this.Controls.Add(this.txtRM_RoomNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRM_Delete);
            this.Controls.Add(this.btnRM_Back);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
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
        private System.Windows.Forms.Button btnRM_Back;
        private System.Windows.Forms.Button btnRM_Delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRM_RoomNumber;
    }
}