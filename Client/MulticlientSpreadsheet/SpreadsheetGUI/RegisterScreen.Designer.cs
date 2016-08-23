﻿namespace SS
{
    partial class RegisterScreen
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MajorPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Username = new System.Windows.Forms.Label();
            this.ReguName = new System.Windows.Forms.TextBox();
            this.RegButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.MajorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.MajorPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RegButton, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(210, 69);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // MajorPanel
            // 
            this.MajorPanel.ColumnCount = 2;
            this.MajorPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MajorPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MajorPanel.Controls.Add(this.Username, 0, 0);
            this.MajorPanel.Controls.Add(this.ReguName, 1, 0);
            this.MajorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MajorPanel.Location = new System.Drawing.Point(3, 3);
            this.MajorPanel.Name = "MajorPanel";
            this.MajorPanel.RowCount = 1;
            this.MajorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MajorPanel.Size = new System.Drawing.Size(204, 24);
            this.MajorPanel.TabIndex = 0;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Username.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Username.Location = new System.Drawing.Point(3, 0);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(96, 24);
            this.Username.TabIndex = 9;
            this.Username.Text = "Username";
            // 
            // ReguName
            // 
            this.ReguName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReguName.Location = new System.Drawing.Point(105, 3);
            this.ReguName.Name = "ReguName";
            this.ReguName.Size = new System.Drawing.Size(96, 20);
            this.ReguName.TabIndex = 10;
            // 
            // RegButton
            // 
            this.RegButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegButton.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegButton.Location = new System.Drawing.Point(3, 33);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(204, 33);
            this.RegButton.TabIndex = 1;
            this.RegButton.Text = "Register";
            this.RegButton.UseVisualStyleBackColor = true;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // RegisterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RegisterScreen";
            this.Size = new System.Drawing.Size(210, 69);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.MajorPanel.ResumeLayout(false);
            this.MajorPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox ReguName;
        private System.Windows.Forms.TableLayoutPanel MajorPanel;
        private System.Windows.Forms.Button RegButton;

    }
}
