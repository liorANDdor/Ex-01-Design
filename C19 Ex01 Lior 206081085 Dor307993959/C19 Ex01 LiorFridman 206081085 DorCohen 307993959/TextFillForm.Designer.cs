﻿namespace C19_Ex01_LiorFridman_206081085_DorCohen_307993959
{
	public partial class TextFillForm
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
			this.m_TextField = new System.Windows.Forms.RichTextBox();
			this.m_CancelBtn = new System.Windows.Forms.Button();
			this.m_SubmitBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// m_TextField
			// 
			this.m_TextField.BackColor = System.Drawing.Color.White;
			this.m_TextField.Location = new System.Drawing.Point(27, 33);
			this.m_TextField.Name = "m_TextField";
			this.m_TextField.Size = new System.Drawing.Size(282, 52);
			this.m_TextField.TabIndex = 0;
            this.m_TextField.Text = string.Empty;
			// 
			// m_CancelBtn
			// 
			this.m_CancelBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.m_CancelBtn.Location = new System.Drawing.Point(153, 106);
			this.m_CancelBtn.Name = "m_CancelBtn";
			this.m_CancelBtn.Size = new System.Drawing.Size(75, 23);
			this.m_CancelBtn.TabIndex = 1;
			this.m_CancelBtn.Text = "Cancel";
			this.m_CancelBtn.UseVisualStyleBackColor = false;
			this.m_CancelBtn.Click += new System.EventHandler(this.m_CancelBtn_Click);
			// 
			// m_SubmitBtn
			// 
			this.m_SubmitBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.m_SubmitBtn.Location = new System.Drawing.Point(234, 106);
			this.m_SubmitBtn.Name = "m_SubmitBtn";
			this.m_SubmitBtn.Size = new System.Drawing.Size(75, 23);
			this.m_SubmitBtn.TabIndex = 2;
			this.m_SubmitBtn.Text = "Submit";
			this.m_SubmitBtn.UseVisualStyleBackColor = false;
			this.m_SubmitBtn.Click += new System.EventHandler(this.m_SubmitBtn_Click);
			// 
			// TextFillForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(341, 147);
			this.Controls.Add(this.m_SubmitBtn);
			this.Controls.Add(this.m_CancelBtn);
			this.Controls.Add(this.m_TextField);
			this.Name = "TextFillForm";
			this.Text = "Text Fill From";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox m_TextField;
		private System.Windows.Forms.Button m_CancelBtn;
		private System.Windows.Forms.Button m_SubmitBtn;
	}
}