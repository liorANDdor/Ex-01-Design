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
	public partial class TextFillForm : Form
	{
		public string UserInput { get; set; }
		public bool isCanceled = false;
		public TextFillForm()
		{
			this.InitializeComponent();
		}

		private void m_SubmitBtn_Click(object sender, EventArgs e)
		{
			UserInput = m_TextField.Text;
			this.Dispose();
		}

		private void m_CancelBtn_Click(object sender, EventArgs e)
		{
			isCanceled = true;
			this.Dispose();

		}
	}
}
