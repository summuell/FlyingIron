using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MiniExcelLibs;
using System.Collections.Generic;
using MiniSoftware;

namespace WindowsFormsExcel01 {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		string path = "";

		//设置路径
		private void setPath_Click(object sender, EventArgs e) {
			FolderBrowserDialog openFileDialog = new System.Windows.Forms.FolderBrowserDialog();
			if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
				pathIn.Text = openFileDialog.SelectedPath;
			}
			path = pathIn.Text;
		}

		//列出移交
		private void button1_Click(object sender, EventArgs e) {
			string pathOrig = path + @"\槐荫1号警务站.xlsx";
			var rowsYiJiao1 = MiniExcel.Query<Demo>(pathOrig).ToList();
			rowsYiJiao1.Clear();
			var rowsYiJiao2 = MiniExcel.Query<Demo>(pathOrig).ToList();
			rowsYiJiao2.Clear();
			var rowsWeiYiJiao = MiniExcel.Query<Demo>(pathOrig).ToList();
			rowsWeiYiJiao.Clear();
			var rows = MiniExcel.Query<Demo>(pathOrig).ToList();
			for (int i = 0; i < rows.Count; i++) {
				if (rows[i].报警时间 == null) {
					break;
				}
				Demo demo = new Demo();
				demo.报警时间 = rows[i].报警时间.ToString();
				demo.案发地址 = rows[i].案发地址.ToString();
				demo.报警内容 = rows[i].报警内容.ToString();
				demo.辖区单位 = rows[i].辖区单位.ToString();
				if (rows[i].辖区单位 == "兴福") {
					rowsYiJiao1.Add(demo);
				} else if (rows[i].辖区单位 == "腊山") {
					rowsYiJiao2.Add(demo);
				} else {
					rowsWeiYiJiao.Add(demo);
				}
			}
			File.Delete(path + @"\兴福移交.xlsx");
			MiniExcel.SaveAs(path + @"\兴福移交.xlsx", rowsYiJiao1);
			File.Delete(path + @"\腊山移交.xlsx");
			MiniExcel.SaveAs(path + @"\腊山移交.xlsx", rowsYiJiao2);
			File.Delete(path + @"\一号站处结.xlsx");
			MiniExcel.SaveAs(path + @"\一号站处结.xlsx", rowsWeiYiJiao);
			MessageBox.Show("列出移交完成！");
		}

		//分开单位
		public int addrJudge = 0;
		private void button2_Click(object sender, EventArgs e) {
			String pathcj = path + @"\一号站处结.xlsx";
			var rowscj = MiniExcel.Query<Demo>(pathcj).ToList();
			var rowsChuJie1 = MiniExcel.Query<Demo>(pathcj).ToList();
			rowsChuJie1.Clear();
			var rowsChuJie2 = MiniExcel.Query<Demo>(pathcj).ToList();
			rowsChuJie2.Clear();

			for (int i = 0; i < rowscj.Count; i++) {
				if (rowscj[i].报警时间 == null) {
					break;
				}
				Form2 form2 = new Form2();
				form2.addrIn = rowscj[i].案发地址.ToString();
				form2.ShowDialog(this);

				Demo demo = new Demo();
				demo.报警时间 = rowscj[i].报警时间.ToString();
				demo.案发地址 = rowscj[i].案发地址.ToString();
				demo.报警内容 = rowscj[i].报警内容.ToString();
				demo.辖区单位 = rowscj[i].辖区单位.ToString();

				if (addrJudge == 1) {
					Show();
					rowsChuJie1.Add(demo);
					addrJudge = 0;
				} else if (addrJudge == 2) {
					rowsChuJie2.Add(demo);
					addrJudge = 0;
				}
			}
			File.Delete(path + @"\兴福处结.xlsx");
			MiniExcel.SaveAs(path + @"\兴福处结.xlsx", rowsChuJie1);
			File.Delete(path + @"\腊山处结.xlsx");
			MiniExcel.SaveAs(path + @"\腊山处结.xlsx", rowsChuJie2);
			MessageBox.Show("分开单位完成！");
		}

		//生成Word
		private void button3_Click(object sender, EventArgs e) {

			string tempPath = path + @"\模板.docx";

			string outPathDate = "";
			if (radioButton1.Checked) {
				outPathDate = System.DateTime.Now.GetDateTimeFormats('M')[0].ToString();
			} else if (radioButton2.Checked) {
				outPathDate = System.DateTime.Now.AddDays(-1).GetDateTimeFormats('M')[0].ToString();
			}
			string outPathText = "";
			if (radioButton1.Checked) {
				outPathText = outPathDate + "（白班）";
			} else if (radioButton2.Checked) {
				outPathText = outPathDate + "（夜班）";
			}
			string outPath = path + @"\" + outPathText + @".docx";

			var rowsXFCJ = MiniExcel.Query<Demo>(path + @"\兴福处结.xlsx").ToList();
			var rowsXFYJ = MiniExcel.Query<Demo>(path + @"\兴福移交.xlsx").ToList();
			var rowsLSCJ = MiniExcel.Query<Demo>(path + @"\腊山处结.xlsx").ToList();
			var rowsLSYJ = MiniExcel.Query<Demo>(path + @"\腊山移交.xlsx").ToList();

			string riQi = "";
			if (radioButton1.Checked) {
				riQi = System.DateTime.Now.ToString("D") + "08:30 - " +
					System.DateTime.Now.AddDays(1).ToString("D") + "17:00";
			} else if (radioButton2.Checked) {
				riQi = System.DateTime.Now.AddDays(-1).ToString("D") +
					"17:00 - " + System.DateTime.Now.ToString("D") + "08:30";
			} else {
				MessageBox.Show("请选择白班或夜班！");
			}

			string boss2 = "";
			string member1 = "";
			string member2 = "";
			string member3 = "";
			if (textBox1.Text.Length == 2) {
				boss2 = textBox1.Text.Insert(1, "  ");
			} else {
				boss2 = textBox1.Text;
			}
			if (textBox2.Text.Length == 2) {
				member1 = textBox2.Text.Insert(1, "  ");
			} else {
				member1 = textBox2.Text;
			}
			if (textBox3.Text.Length == 2) {
				member2 = textBox3.Text.Insert(1, "  ");
			} else {
				member2 = textBox3.Text;
			}
			if (textBox4.Text.Length == 2) {
				member3 = textBox4.Text.Insert(1, "  ");
			} else {
				member3 = textBox4.Text;
			}

			//计算民警接警数量
			int totalBS = 0;
			if (checkBox1.Checked) {
				totalBS = rowsLSCJ.Count + rowsLSYJ.Count;
			} else if (checkBox15.Checked) {
				totalBS = (rowsXFCJ.Count + rowsXFYJ.Count) / 3 + (rowsXFCJ.Count + rowsXFYJ.Count) % 3;
			} else {
				totalBS = (rowsXFCJ.Count + rowsXFYJ.Count) / 3;
			}
			int totalM1 = 0;
			if (checkBox2.Checked) {
				totalM1 = rowsLSCJ.Count + rowsLSYJ.Count;
			} else if (checkBox16.Checked) {
				totalM1 = (rowsXFCJ.Count + rowsXFYJ.Count) / 3 + (rowsXFCJ.Count + rowsXFYJ.Count) % 3;
			} else {
				totalM1 = (rowsXFCJ.Count + rowsXFYJ.Count) / 3;
			}
			int totalM2 = 0;
			if (checkBox3.Checked) {
				totalM2 = rowsLSCJ.Count + rowsLSYJ.Count;
			} else if (checkBox17.Checked) {
				totalM2 = (rowsXFCJ.Count + rowsXFYJ.Count) / 3 + (rowsXFCJ.Count + rowsXFYJ.Count) % 3;
			} else {
				totalM2 = (rowsXFCJ.Count + rowsXFYJ.Count) / 3;
			}
			int totalM3 = 0;
			if (checkBox4.Checked) {
				totalM3 = rowsLSCJ.Count + rowsLSYJ.Count;
			} else if (checkBox18.Checked) {
				totalM3 = (rowsXFCJ.Count + rowsXFYJ.Count) / 3 + (rowsXFCJ.Count + rowsXFYJ.Count) % 3;
			} else {
				totalM3 = (rowsXFCJ.Count + rowsXFYJ.Count) / 3;
			}

			//计算民警移交数量
			int transferBS = 0;
			if (checkBox1.Checked) {
				transferBS = rowsLSYJ.Count;
			} else {
				transferBS = (rowsXFYJ.Count / 3) + (rowsXFYJ.Count % 3);
			}
			int transferM1 = 0;
			if (checkBox2.Checked) {
				transferM1 = rowsLSYJ.Count;
			} else {
				transferM1 = rowsXFYJ.Count / 3;
			}
			int transferM2 = 0;
			if (checkBox3.Checked) {
				transferM2 = rowsLSYJ.Count;
			} else {
				transferM2 = rowsXFYJ.Count / 3;
			}
			int transferM3 = 0;
			if (checkBox4.Checked) {
				transferM3 = rowsLSYJ.Count;
			} else {
				transferM3 = rowsXFYJ.Count / 3;
			}

			//计算民警处结
			double ratioBS = 0;
			if (checkBox1.Checked) {
				ratioBS = rowsLSCJ.Count;
			} else {
				ratioBS = ((rowsXFCJ.Count + rowsXFYJ.Count) / 3 + (rowsXFCJ.Count + rowsXFYJ.Count) % 3) -
					((rowsXFYJ.Count / 3) + (rowsXFYJ.Count % 3));
			}
			double ratioM1 = 0;
			if (checkBox2.Checked) {
				ratioM1 = rowsLSCJ.Count;
			} else {
				ratioM1 = ((rowsXFCJ.Count + rowsXFYJ.Count) / 3) - (rowsXFYJ.Count / 3);
			}
			double ratioM2 = 0;
			if (checkBox3.Checked) {
				ratioM2 = rowsLSCJ.Count;
			} else {
				ratioM2 = ((rowsXFCJ.Count + rowsXFYJ.Count) / 3) - (rowsXFYJ.Count / 3);
			}
			double ratioM3 = 0;
			if (checkBox4.Checked) {
				ratioM3 = rowsLSCJ.Count;
			} else {
				ratioM3 = ((rowsXFCJ.Count + rowsXFYJ.Count) / 3) - (rowsXFYJ.Count / 3);
			}

			//计算辅警接警数量
			string person1;
			if (checkBox8.Checked) {
				person1 = textBox5.Text + Convert.ToString(rowsLSCJ.Count + rowsLSYJ.Count);
			} else if (checkBox12.Checked) {
				person1 = textBox5.Text + "（值台）0";
			} else if (checkBox19.Checked) {
				person1 = textBox5.Text + Convert.ToString((rowsXFCJ.Count + rowsXFYJ.Count) / 3 +
					(rowsXFCJ.Count + rowsXFYJ.Count) % 3);
			} else {
				person1 = textBox5.Text + Convert.ToString((rowsXFCJ.Count + rowsXFYJ.Count) / 3);
			}
			string person2;
			if (checkBox7.Checked) {
				person2 = textBox6.Text + Convert.ToString(rowsLSCJ.Count + rowsLSYJ.Count);
			} else if (checkBox11.Checked) {
				person2 = textBox6.Text + "（值台）0";
			} else if (checkBox20.Checked) {
				person2 = textBox6.Text + Convert.ToString((rowsXFCJ.Count + rowsXFYJ.Count) / 3 +
					(rowsXFCJ.Count + rowsXFYJ.Count) % 3);
			} else {
				person2 = textBox6.Text + Convert.ToString((rowsXFCJ.Count + rowsXFYJ.Count) / 3);
			}
			string person3;
			if (checkBox6.Checked) {
				person3 = textBox7.Text + Convert.ToString(rowsLSCJ.Count + rowsLSYJ.Count);
			} else if (checkBox10.Checked) {
				person3 = textBox7.Text + "（值台）0";
			} else if (checkBox21.Checked) {
				person3 = textBox7.Text + Convert.ToString((rowsXFCJ.Count + rowsXFYJ.Count) / 3 +
					(rowsXFCJ.Count + rowsXFYJ.Count) % 3);
			} else {
				person3 = textBox7.Text + Convert.ToString((rowsXFCJ.Count + rowsXFYJ.Count) / 3);
			}
			string person4 = "";
			if (checkBox5.Checked) {
				person4 = textBox8.Text + Convert.ToString(rowsLSCJ.Count + rowsLSYJ.Count);
			} else if (checkBox9.Checked) {
				person4 = textBox8.Text + "（值台）0";
			} else if (checkBox22.Checked) {
				person4 = textBox8.Text + Convert.ToString((rowsXFCJ.Count + rowsXFYJ.Count) / 3 +
					(rowsXFCJ.Count + rowsXFYJ.Count) % 3);
			} else {
				person4 = textBox8.Text + Convert.ToString((rowsXFCJ.Count + rowsXFYJ.Count) / 3);
			}
			string person5;
			if (checkBox14.Checked) {
				person5 = textBox9.Text + Convert.ToString(rowsLSCJ.Count + rowsLSYJ.Count);
			} else if (checkBox13.Checked) {
				person5 = textBox9.Text + "（值台）0";
			} else if (checkBox23.Checked) {
				person5 = textBox9.Text + Convert.ToString((rowsXFCJ.Count + rowsXFYJ.Count) / 3 +
					(rowsXFCJ.Count + rowsXFYJ.Count) % 3);
			} else {
				person5 = textBox9.Text + Convert.ToString((rowsXFCJ.Count + rowsXFYJ.Count) / 3);
			}

			//处结内容和移交内容
			string knotXFCon = "";
			int a = 1;
			for (int i = rowsXFCJ.Count; i > 0; i--) {
				knotXFCon += Convert.ToString(a) + "、" + rowsXFCJ[i - 1].报警时间 + rowsXFCJ[i - 1].案发地址 +
					rowsXFCJ[i - 1].报警内容 + "\r\n";
				a += 1;
			}
			string knotLSCon = "";
			int b = 1;
			for (int i = rowsLSCJ.Count; i > 0; i--) {
				knotLSCon += Convert.ToString(b) + "、" + rowsLSCJ[i - 1].报警时间 + rowsLSCJ[i - 1].案发地址 +
					rowsLSCJ[i - 1].报警内容 + "\r\n";
				b += 1;
			}
			string transferXFCon = "";
			int c = 1;
			for (int i = rowsXFYJ.Count; i > 0; i--) {
				transferXFCon += Convert.ToString(c) + "、" + rowsXFYJ[i - 1].报警时间 + rowsXFYJ[i - 1].案发地址 +
					rowsXFYJ[i - 1].报警内容 + "\r\n";
				c += 1;
			}
			string transferLSCon = "";
			int d = 1;
			for (int i = rowsLSYJ.Count; i > 0; i--) {
				transferLSCon += Convert.ToString(d) + "、" + rowsLSYJ[i - 1].报警时间 + rowsLSYJ[i - 1].案发地址 +
					rowsLSYJ[i - 1].报警内容 + "\r\n";
				d += 1;
			}

			var value = new Dictionary<string, object>() {
				["date"] = riQi,
				["boss"] = textBox1.Text,
				["leader"] = textBox2.Text,
				["member"] = textBox2.Text + "、" + textBox3.Text + "、" + textBox4.Text,
				["preson"] = textBox5.Text + "、" + textBox6.Text + "、" + textBox7.Text + "、" + textBox8.Text +
				"、" + textBox9.Text,
				["total"] = rowsXFCJ.Count + rowsXFYJ.Count + rowsLSCJ.Count + rowsLSYJ.Count,
				["totalXF"] = rowsXFCJ.Count + rowsXFYJ.Count,
				["totalLS"] = rowsLSCJ.Count + rowsLSYJ.Count,
				["dispose"] = rowsXFCJ.Count + rowsLSCJ.Count,
				["transferXF"] = rowsXFYJ.Count,
				["transferLS"] = rowsLSYJ.Count,
				["ratio"] = 100 * (Math.Round(Convert.ToDouble(rowsXFCJ.Count + rowsLSCJ.Count) /
				Convert.ToDouble(rowsXFCJ.Count + rowsXFYJ.Count + rowsLSCJ.Count + rowsLSYJ.Count), 2)),
				["boss2"] = boss2,
				["member1"] = member1,
				["member2"] = member2,
				["member3"] = member3,
				["totalBS"] = totalBS,
				["totalM1"] = totalM1,
				["totalM2"] = totalM2,
				["totalM3"] = totalM3,
				["transferBS"] = transferBS,
				["transferM1"] = transferM1,
				["transferM2"] = transferM2,
				["transferM3"] = transferM3,
				["ratioBS"] = 100 * (Math.Round(Convert.ToDouble(ratioBS) / Convert.ToDouble(totalBS), 2)),
				["ratioM1"] = 100 * (Math.Round(Convert.ToDouble(ratioM1) / Convert.ToDouble(totalM1), 2)),
				["ratioM2"] = 100 * (Math.Round(Convert.ToDouble(ratioM2) / Convert.ToDouble(totalM2), 2)),
				["ratioM3"] = 100 * (Math.Round(Convert.ToDouble(ratioM3) / Convert.ToDouble(totalM3), 2)),
				["person1"] = person1,
				["person2"] = person2,
				["person3"] = person3,
				["person4"] = person4,
				["person5"] = person5,
				["knotXF"] = rowsXFCJ.Count,
				["knotLS"] = rowsLSCJ.Count,
				["transferXF"] = rowsXFYJ.Count,
				["transferLS"] = rowsLSYJ.Count,
				["knotXFCon"] = knotXFCon,
				["knotLSCon"] = knotLSCon,
				["transferXFCon"] = transferXFCon,
				["transferLSCon"] = transferLSCon
			};

			File.Delete(outPath);
			MiniWord.SaveAsByTemplate(outPath, tempPath, value);
			MessageBox.Show("生成完成！");

			//删除无用文件
			File.Delete(path + @"\腊山处结.xlsx");
			File.Delete(path + @"\腊山移交.xlsx");
			File.Delete(path + @"\兴福处结.xlsx");
			File.Delete(path + @"\兴福移交.xlsx");
			File.Delete(path + @"\一号站处结.xlsx");
		}

		public class Demo {
			public string 报警时间 {
				get; set;
			}
			public string 案发地址 {
				get; set;
			}
			public string 报警内容 {
				get; set;
			}
			public string 辖区单位 {
				get; set;
			}
		}

		private void Form1_Load(object sender, EventArgs e) {
			textBox1.Text = "方华";
			textBox2.Text = "董波";
			textBox3.Text = "刘育鲁";
			textBox4.Text = "孟洪亮";
			textBox5.Text = "葛晓光";
			textBox6.Text = "陈邦鑫";
			textBox7.Text = "崔同辉";
			textBox8.Text = "杨晨";
			textBox9.Text = "孔文超";
		}
	}
}
