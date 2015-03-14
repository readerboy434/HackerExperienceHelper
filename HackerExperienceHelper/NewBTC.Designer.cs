﻿namespace HackerExperienceHelper
{
    partial class NewBTC
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PublicTextBox = new System.Windows.Forms.TextBox();
            this.PrivateTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Public Key:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Private Key:";
            // 
            // PublicTextBox
            // 
            this.PublicTextBox.Location = new System.Drawing.Point(78, 6);
            this.PublicTextBox.Name = "PublicTextBox";
            this.PublicTextBox.Size = new System.Drawing.Size(251, 20);
            this.PublicTextBox.TabIndex = 2;
            // 
            // PrivateTextBox
            // 
            this.PrivateTextBox.Location = new System.Drawing.Point(402, 6);
            this.PrivateTextBox.Name = "PrivateTextBox";
            this.PrivateTextBox.Size = new System.Drawing.Size(250, 20);
            this.PrivateTextBox.TabIndex = 3;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(658, 6);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 20);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // NewBTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 33);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PrivateTextBox);
            this.Controls.Add(this.PublicTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(754, 72);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(754, 72);
            this.Name = "NewBTC";
            this.Text = "New Bitcoin Address";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PublicTextBox;
        private System.Windows.Forms.TextBox PrivateTextBox;
        private System.Windows.Forms.Button AddButton;
    }
}