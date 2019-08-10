namespace C19_Ex01_LiorFridman_206081085_DorCohen_307993959
{
	public partial class UserChoiceForm
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
			this.m_YesBtn = new System.Windows.Forms.Button();
			this.m_NoBtn = new System.Windows.Forms.Button();
			this.m_QuestionLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// m_YesBtn
			// 
			this.m_YesBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.m_YesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.m_YesBtn.Location = new System.Drawing.Point(34, 90);
			this.m_YesBtn.Name = "m_YesBtn";
			this.m_YesBtn.Size = new System.Drawing.Size(103, 38);
			this.m_YesBtn.TabIndex = 0;
			this.m_YesBtn.Text = "Yes";
			this.m_YesBtn.UseVisualStyleBackColor = false;
			this.m_YesBtn.Click += new System.EventHandler(this.m_YesBtn_Click);
			// 
			// m_NoBtn
			// 
			this.m_NoBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.m_NoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.m_NoBtn.Location = new System.Drawing.Point(153, 90);
			this.m_NoBtn.Name = "m_NoBtn";
			this.m_NoBtn.Size = new System.Drawing.Size(103, 38);
			this.m_NoBtn.TabIndex = 1;
			this.m_NoBtn.Text = "No";
			this.m_NoBtn.UseVisualStyleBackColor = false;
			this.m_NoBtn.Click += new System.EventHandler(this.m_NoBtn_Click);
			// 
			// m_QuestionLabel
			// 
			this.m_QuestionLabel.AutoSize = true;
			this.m_QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.m_QuestionLabel.Location = new System.Drawing.Point(34, 23);
			this.m_QuestionLabel.Name = "m_QuestionLabel";
			this.m_QuestionLabel.Size = new System.Drawing.Size(0, 20);
			this.m_QuestionLabel.TabIndex = 2;
			// 
			// UserChoice
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(312, 164);
			this.Controls.Add(this.m_QuestionLabel);
			this.Controls.Add(this.m_NoBtn);
			this.Controls.Add(this.m_YesBtn);
			this.Name = "UserChoice";
			this.Text = "UserChoice";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button m_YesBtn;
		private System.Windows.Forms.Button m_NoBtn;
		private System.Windows.Forms.Label m_QuestionLabel;
	}
}