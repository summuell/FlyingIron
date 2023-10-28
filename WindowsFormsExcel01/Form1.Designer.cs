namespace WindowsFormsExcel01 {
	partial class Form1 {
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.pathIn = new System.Windows.Forms.TextBox();
			this.setPath = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.checkBox13 = new System.Windows.Forms.CheckBox();
			this.checkBox14 = new System.Windows.Forms.CheckBox();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.checkBox9 = new System.Windows.Forms.CheckBox();
			this.checkBox10 = new System.Windows.Forms.CheckBox();
			this.checkBox11 = new System.Windows.Forms.CheckBox();
			this.checkBox12 = new System.Windows.Forms.CheckBox();
			this.label6 = new System.Windows.Forms.Label();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.checkBox6 = new System.Windows.Forms.CheckBox();
			this.checkBox7 = new System.Windows.Forms.CheckBox();
			this.checkBox8 = new System.Windows.Forms.CheckBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.班次 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// pathIn
			// 
			this.pathIn.Font = new System.Drawing.Font("宋体", 12F);
			this.pathIn.Location = new System.Drawing.Point(12, 11);
			this.pathIn.Margin = new System.Windows.Forms.Padding(2);
			this.pathIn.Name = "pathIn";
			this.pathIn.Size = new System.Drawing.Size(309, 35);
			this.pathIn.TabIndex = 0;
			// 
			// setPath
			// 
			this.setPath.Location = new System.Drawing.Point(325, 11);
			this.setPath.Margin = new System.Windows.Forms.Padding(2);
			this.setPath.Name = "setPath";
			this.setPath.Size = new System.Drawing.Size(81, 33);
			this.setPath.TabIndex = 1;
			this.setPath.Text = "1.设置路径";
			this.setPath.UseVisualStyleBackColor = true;
			this.setPath.Click += new System.EventHandler(this.setPath_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(33, 61);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(115, 33);
			this.button1.TabIndex = 2;
			this.button1.Text = "2.列出移交";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(152, 61);
			this.button2.Margin = new System.Windows.Forms.Padding(2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(115, 33);
			this.button2.TabIndex = 3;
			this.button2.Text = "3.分开单位";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(271, 61);
			this.button3.Margin = new System.Windows.Forms.Padding(2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(115, 33);
			this.button3.TabIndex = 4;
			this.button3.Text = "4.生成Word";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Font = new System.Drawing.Font("宋体", 9F);
			this.radioButton1.Location = new System.Drawing.Point(159, 18);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(69, 22);
			this.radioButton1.TabIndex = 5;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "白班";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Font = new System.Drawing.Font("宋体", 9F);
			this.radioButton2.Location = new System.Drawing.Point(233, 18);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(69, 22);
			this.radioButton2.TabIndex = 6;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "夜班";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBox13);
			this.groupBox1.Controls.Add(this.checkBox14);
			this.groupBox1.Controls.Add(this.textBox9);
			this.groupBox1.Controls.Add(this.checkBox9);
			this.groupBox1.Controls.Add(this.checkBox10);
			this.groupBox1.Controls.Add(this.checkBox11);
			this.groupBox1.Controls.Add(this.checkBox12);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.checkBox5);
			this.groupBox1.Controls.Add(this.checkBox6);
			this.groupBox1.Controls.Add(this.checkBox7);
			this.groupBox1.Controls.Add(this.checkBox8);
			this.groupBox1.Controls.Add(this.checkBox4);
			this.groupBox1.Controls.Add(this.checkBox3);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.textBox8);
			this.groupBox1.Controls.Add(this.textBox7);
			this.groupBox1.Controls.Add(this.textBox6);
			this.groupBox1.Controls.Add(this.textBox5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.textBox4);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Location = new System.Drawing.Point(12, 159);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(394, 409);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			// 
			// checkBox13
			// 
			this.checkBox13.AutoSize = true;
			this.checkBox13.Location = new System.Drawing.Point(298, 359);
			this.checkBox13.Name = "checkBox13";
			this.checkBox13.Size = new System.Drawing.Size(22, 21);
			this.checkBox13.TabIndex = 37;
			this.checkBox13.UseVisualStyleBackColor = true;
			// 
			// checkBox14
			// 
			this.checkBox14.AutoSize = true;
			this.checkBox14.Location = new System.Drawing.Point(233, 359);
			this.checkBox14.Name = "checkBox14";
			this.checkBox14.Size = new System.Drawing.Size(22, 21);
			this.checkBox14.TabIndex = 36;
			this.checkBox14.UseVisualStyleBackColor = true;
			// 
			// textBox9
			// 
			this.textBox9.Font = new System.Drawing.Font("宋体", 10F);
			this.textBox9.Location = new System.Drawing.Point(109, 359);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(103, 30);
			this.textBox9.TabIndex = 35;
			// 
			// checkBox9
			// 
			this.checkBox9.AutoSize = true;
			this.checkBox9.Location = new System.Drawing.Point(298, 323);
			this.checkBox9.Name = "checkBox9";
			this.checkBox9.Size = new System.Drawing.Size(22, 21);
			this.checkBox9.TabIndex = 34;
			this.checkBox9.UseVisualStyleBackColor = true;
			// 
			// checkBox10
			// 
			this.checkBox10.AutoSize = true;
			this.checkBox10.Location = new System.Drawing.Point(298, 287);
			this.checkBox10.Name = "checkBox10";
			this.checkBox10.Size = new System.Drawing.Size(22, 21);
			this.checkBox10.TabIndex = 33;
			this.checkBox10.UseVisualStyleBackColor = true;
			// 
			// checkBox11
			// 
			this.checkBox11.AutoSize = true;
			this.checkBox11.Location = new System.Drawing.Point(298, 251);
			this.checkBox11.Name = "checkBox11";
			this.checkBox11.Size = new System.Drawing.Size(22, 21);
			this.checkBox11.TabIndex = 32;
			this.checkBox11.UseVisualStyleBackColor = true;
			// 
			// checkBox12
			// 
			this.checkBox12.AutoSize = true;
			this.checkBox12.Location = new System.Drawing.Point(298, 215);
			this.checkBox12.Name = "checkBox12";
			this.checkBox12.Size = new System.Drawing.Size(22, 21);
			this.checkBox12.TabIndex = 31;
			this.checkBox12.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("宋体", 9F);
			this.label6.Location = new System.Drawing.Point(288, 194);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(44, 18);
			this.label6.TabIndex = 30;
			this.label6.Text = "值班";
			// 
			// checkBox5
			// 
			this.checkBox5.AutoSize = true;
			this.checkBox5.Location = new System.Drawing.Point(233, 323);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(22, 21);
			this.checkBox5.TabIndex = 29;
			this.checkBox5.UseVisualStyleBackColor = true;
			// 
			// checkBox6
			// 
			this.checkBox6.AutoSize = true;
			this.checkBox6.Location = new System.Drawing.Point(233, 287);
			this.checkBox6.Name = "checkBox6";
			this.checkBox6.Size = new System.Drawing.Size(22, 21);
			this.checkBox6.TabIndex = 28;
			this.checkBox6.UseVisualStyleBackColor = true;
			// 
			// checkBox7
			// 
			this.checkBox7.AutoSize = true;
			this.checkBox7.Location = new System.Drawing.Point(233, 251);
			this.checkBox7.Name = "checkBox7";
			this.checkBox7.Size = new System.Drawing.Size(22, 21);
			this.checkBox7.TabIndex = 27;
			this.checkBox7.UseVisualStyleBackColor = true;
			// 
			// checkBox8
			// 
			this.checkBox8.AutoSize = true;
			this.checkBox8.Location = new System.Drawing.Point(233, 215);
			this.checkBox8.Name = "checkBox8";
			this.checkBox8.Size = new System.Drawing.Size(22, 21);
			this.checkBox8.TabIndex = 26;
			this.checkBox8.UseVisualStyleBackColor = true;
			// 
			// checkBox4
			// 
			this.checkBox4.AutoSize = true;
			this.checkBox4.Location = new System.Drawing.Point(233, 166);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(22, 21);
			this.checkBox4.TabIndex = 25;
			this.checkBox4.UseVisualStyleBackColor = true;
			// 
			// checkBox3
			// 
			this.checkBox3.AutoSize = true;
			this.checkBox3.Location = new System.Drawing.Point(233, 130);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(22, 21);
			this.checkBox3.TabIndex = 24;
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(233, 94);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(22, 21);
			this.checkBox2.TabIndex = 23;
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(233, 61);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(22, 21);
			this.checkBox1.TabIndex = 22;
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("宋体", 9F);
			this.label5.Location = new System.Drawing.Point(223, 36);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 18);
			this.label5.TabIndex = 21;
			this.label5.Text = "腊山";
			// 
			// textBox8
			// 
			this.textBox8.Font = new System.Drawing.Font("宋体", 10F);
			this.textBox8.Location = new System.Drawing.Point(109, 323);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(103, 30);
			this.textBox8.TabIndex = 20;
			// 
			// textBox7
			// 
			this.textBox7.Font = new System.Drawing.Font("宋体", 10F);
			this.textBox7.Location = new System.Drawing.Point(109, 287);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(103, 30);
			this.textBox7.TabIndex = 19;
			// 
			// textBox6
			// 
			this.textBox6.Font = new System.Drawing.Font("宋体", 10F);
			this.textBox6.Location = new System.Drawing.Point(109, 251);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(103, 30);
			this.textBox6.TabIndex = 18;
			// 
			// textBox5
			// 
			this.textBox5.Font = new System.Drawing.Font("宋体", 10F);
			this.textBox5.Location = new System.Drawing.Point(109, 215);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(103, 30);
			this.textBox5.TabIndex = 17;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("宋体", 10F);
			this.label4.Location = new System.Drawing.Point(14, 218);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(89, 20);
			this.label4.TabIndex = 16;
			this.label4.Text = "值班辅警";
			// 
			// textBox4
			// 
			this.textBox4.Font = new System.Drawing.Font("宋体", 10F);
			this.textBox4.Location = new System.Drawing.Point(109, 166);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(103, 30);
			this.textBox4.TabIndex = 15;
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("宋体", 10F);
			this.textBox3.Location = new System.Drawing.Point(109, 130);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(103, 30);
			this.textBox3.TabIndex = 14;
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("宋体", 10F);
			this.textBox2.Location = new System.Drawing.Point(109, 94);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(103, 30);
			this.textBox2.TabIndex = 13;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("宋体", 10F);
			this.label3.Location = new System.Drawing.Point(14, 133);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 20);
			this.label3.TabIndex = 11;
			this.label3.Text = "值班民警";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("宋体", 10F);
			this.label2.Location = new System.Drawing.Point(14, 97);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 20);
			this.label2.TabIndex = 10;
			this.label2.Text = "值班组长";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("宋体", 10F);
			this.label1.Location = new System.Drawing.Point(14, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 20);
			this.label1.TabIndex = 9;
			this.label1.Text = "带班领导";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("宋体", 10F);
			this.textBox1.Location = new System.Drawing.Point(109, 58);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(103, 30);
			this.textBox1.TabIndex = 0;
			// 
			// 班次
			// 
			this.班次.AutoSize = true;
			this.班次.Font = new System.Drawing.Font("宋体", 10F);
			this.班次.Location = new System.Drawing.Point(94, 18);
			this.班次.Name = "班次";
			this.班次.Size = new System.Drawing.Size(59, 20);
			this.班次.TabIndex = 9;
			this.班次.Text = "班次:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.班次);
			this.groupBox2.Controls.Add(this.radioButton2);
			this.groupBox2.Controls.Add(this.radioButton1);
			this.groupBox2.Location = new System.Drawing.Point(12, 99);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(394, 54);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("宋体", 10F);
			this.label7.ForeColor = System.Drawing.Color.Silver;
			this.label7.Location = new System.Drawing.Point(276, 572);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(129, 20);
			this.label7.TabIndex = 10;
			this.label7.Text = "Version：1.0";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(418, 600);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.setPath);
			this.Controls.Add(this.pathIn);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.Text = "飞天大烙铁 ";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox pathIn;
		private System.Windows.Forms.Button setPath;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.CheckBox checkBox6;
		private System.Windows.Forms.CheckBox checkBox7;
		private System.Windows.Forms.CheckBox checkBox8;
		private System.Windows.Forms.CheckBox checkBox9;
		private System.Windows.Forms.CheckBox checkBox10;
		private System.Windows.Forms.CheckBox checkBox11;
		private System.Windows.Forms.CheckBox checkBox12;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox checkBox13;
		private System.Windows.Forms.CheckBox checkBox14;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.Label 班次;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label7;
	}
}

