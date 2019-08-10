using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C19_Ex01_LiorFridman_206081085_DorCohen_307993959
{
	public partial class UserChoiceForm : Form
	{
		public string m_Question { get; set; }

		public bool Choice { get; set; }

		public UserChoiceForm(string i_Question)
		{
			InitializeComponent();
			m_Question = i_Question;
			m_QuestionLabel.Text = i_Question;
		}

		private void m_YesBtn_Click(object sender, EventArgs e)
		{
			Choice = true;
			this.Dispose();
		}

		private void m_NoBtn_Click(object sender, EventArgs e)
		{
			Choice = false;
			this.Dispose();
		}
	}
}
