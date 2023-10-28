using System;
using System.Windows.Forms;

namespace WindowsFormsExcel01 {
	public partial class Form2 : Form {
		public Form2() {
			InitializeComponent();
		}

		public string addrIn;
		public int judge = 0;

		private void Form2_Load(object sender, EventArgs e) {
			textBox1.Text = addrIn;
		}

		private void button1_Click(object sender, EventArgs e) {
			Form1 form1 = (Form1)this.Owner;
			form1.addrJudge = 1;
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e) {
			Form1 form1 = (Form1)this.Owner;
			form1.addrJudge = 2;
			this.Close();
		}
	}
}
