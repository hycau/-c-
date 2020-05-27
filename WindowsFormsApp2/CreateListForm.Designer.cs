namespace WindowsFormsApp2
{
    partial class CreateListForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btCreateList = new System.Windows.Forms.Button();
            this.tbData = new System.Windows.Forms.TextBox();
            this.tbShowList = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btShowList = new System.Windows.Forms.Button();
            this.btShowSum = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tbSumNunber = new System.Windows.Forms.TextBox();
            this.btShowElement = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tbElement = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tbNElement = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.tbNNumber = new System.Windows.Forms.TextBox();
            this.btShowNumber = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.tbInsertElement = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.tbInsertNumber = new System.Windows.Forms.TextBox();
            this.btInsert = new System.Windows.Forms.Button();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.tbInsertData = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.tbDeleteData = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.tbDNumber = new System.Windows.Forms.TextBox();
            this.btDeleteE = new System.Windows.Forms.Button();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btCreateList
            // 
            this.btCreateList.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btCreateList.Location = new System.Drawing.Point(678, 1);
            this.btCreateList.Name = "btCreateList";
            this.btCreateList.Size = new System.Drawing.Size(228, 60);
            this.btCreateList.TabIndex = 0;
            this.btCreateList.Text = "建立数据表";
            this.btCreateList.UseVisualStyleBackColor = true;
            this.btCreateList.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(-2, 36);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(661, 25);
            this.tbData.TabIndex = 1;
            this.tbData.TextChanged += new System.EventHandler(this.TbData_TextChanged);
            // 
            // tbShowList
            // 
            this.tbShowList.Location = new System.Drawing.Point(-2, 105);
            this.tbShowList.Name = "tbShowList";
            this.tbShowList.Size = new System.Drawing.Size(661, 25);
            this.tbShowList.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox4.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox4.Location = new System.Drawing.Point(-2, 0);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(421, 30);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "操作步骤一：输入数据（例：a，b，c，d）";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(-2, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(421, 30);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "操作步骤二：输出顺序表";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btShowList
            // 
            this.btShowList.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btShowList.Location = new System.Drawing.Point(678, 70);
            this.btShowList.Name = "btShowList";
            this.btShowList.Size = new System.Drawing.Size(228, 60);
            this.btShowList.TabIndex = 6;
            this.btShowList.Text = "输出数据表";
            this.btShowList.UseVisualStyleBackColor = true;
            this.btShowList.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btShowSum
            // 
            this.btShowSum.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btShowSum.Location = new System.Drawing.Point(678, 139);
            this.btShowSum.Name = "btShowSum";
            this.btShowSum.Size = new System.Drawing.Size(228, 60);
            this.btShowSum.TabIndex = 9;
            this.btShowSum.Text = "显示总数";
            this.btShowSum.UseVisualStyleBackColor = true;
            this.btShowSum.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox2.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(-2, 136);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(421, 30);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "操作步骤三：求顺序表数据总数";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSumNunber
            // 
            this.tbSumNunber.Location = new System.Drawing.Point(-2, 174);
            this.tbSumNunber.Name = "tbSumNunber";
            this.tbSumNunber.Size = new System.Drawing.Size(661, 25);
            this.tbSumNunber.TabIndex = 7;
            // 
            // btShowElement
            // 
            this.btShowElement.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btShowElement.Location = new System.Drawing.Point(678, 211);
            this.btShowElement.Name = "btShowElement";
            this.btShowElement.Size = new System.Drawing.Size(228, 60);
            this.btShowElement.TabIndex = 12;
            this.btShowElement.Text = "显示元素";
            this.btShowElement.UseVisualStyleBackColor = true;
            this.btShowElement.Click += new System.EventHandler(this.BtShowElement_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox3.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox3.Location = new System.Drawing.Point(-2, 208);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(421, 30);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "操作步骤四：按序号查找元素";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbElement
            // 
            this.tbElement.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbElement.Location = new System.Drawing.Point(441, 246);
            this.tbElement.Name = "tbElement";
            this.tbElement.Size = new System.Drawing.Size(218, 30);
            this.tbElement.TabIndex = 16;
            this.tbElement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox10.Location = new System.Drawing.Point(-2, 246);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(109, 30);
            this.textBox10.TabIndex = 17;
            this.textBox10.Text = "序号";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbNumber
            // 
            this.tbNumber.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbNumber.Location = new System.Drawing.Point(132, 246);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(126, 30);
            this.tbNumber.TabIndex = 18;
            this.tbNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox6.Location = new System.Drawing.Point(307, 246);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(112, 30);
            this.textBox6.TabIndex = 19;
            this.textBox6.Text = "元素";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox5.Location = new System.Drawing.Point(307, 320);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(112, 30);
            this.textBox5.TabIndex = 25;
            this.textBox5.Text = "序号";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbNElement
            // 
            this.tbNElement.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbNElement.Location = new System.Drawing.Point(132, 320);
            this.tbNElement.Name = "tbNElement";
            this.tbNElement.Size = new System.Drawing.Size(126, 30);
            this.tbNElement.TabIndex = 24;
            this.tbNElement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox8.Location = new System.Drawing.Point(-2, 320);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(109, 30);
            this.textBox8.TabIndex = 23;
            this.textBox8.Text = "元素";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbNNumber
            // 
            this.tbNNumber.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbNNumber.Location = new System.Drawing.Point(441, 320);
            this.tbNNumber.Name = "tbNNumber";
            this.tbNNumber.Size = new System.Drawing.Size(218, 30);
            this.tbNNumber.TabIndex = 22;
            this.tbNNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btShowNumber
            // 
            this.btShowNumber.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btShowNumber.Location = new System.Drawing.Point(678, 285);
            this.btShowNumber.Name = "btShowNumber";
            this.btShowNumber.Size = new System.Drawing.Size(228, 60);
            this.btShowNumber.TabIndex = 21;
            this.btShowNumber.Text = "显示序号";
            this.btShowNumber.UseVisualStyleBackColor = true;
            this.btShowNumber.Click += new System.EventHandler(this.BtShowNumber_Click);
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox11.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox11.Location = new System.Drawing.Point(-2, 282);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(421, 30);
            this.textBox11.TabIndex = 20;
            this.textBox11.Text = "操作步骤五：按元素查找序号";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox7.Location = new System.Drawing.Point(307, 399);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(112, 30);
            this.textBox7.TabIndex = 31;
            this.textBox7.Text = "序号";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbInsertElement
            // 
            this.tbInsertElement.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbInsertElement.Location = new System.Drawing.Point(132, 399);
            this.tbInsertElement.Name = "tbInsertElement";
            this.tbInsertElement.Size = new System.Drawing.Size(126, 30);
            this.tbInsertElement.TabIndex = 30;
            this.tbInsertElement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            this.textBox12.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox12.Location = new System.Drawing.Point(-2, 399);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(109, 30);
            this.textBox12.TabIndex = 29;
            this.textBox12.Text = "元素";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbInsertNumber
            // 
            this.tbInsertNumber.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbInsertNumber.Location = new System.Drawing.Point(441, 399);
            this.tbInsertNumber.Name = "tbInsertNumber";
            this.tbInsertNumber.Size = new System.Drawing.Size(218, 30);
            this.tbInsertNumber.TabIndex = 28;
            this.tbInsertNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btInsert
            // 
            this.btInsert.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btInsert.Location = new System.Drawing.Point(678, 374);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(228, 73);
            this.btInsert.TabIndex = 27;
            this.btInsert.Text = "插入元素";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.Button1_Click_2);
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox14.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox14.Location = new System.Drawing.Point(-2, 361);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(421, 30);
            this.textBox14.TabIndex = 26;
            this.textBox14.Text = "操作步骤六：插入元素";
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbInsertData
            // 
            this.tbInsertData.Location = new System.Drawing.Point(234, 445);
            this.tbInsertData.Name = "tbInsertData";
            this.tbInsertData.Size = new System.Drawing.Size(425, 25);
            this.tbInsertData.TabIndex = 33;
            // 
            // textBox15
            // 
            this.textBox15.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox15.Location = new System.Drawing.Point(-2, 441);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(196, 30);
            this.textBox15.TabIndex = 34;
            this.textBox15.Text = "插入结果";
            this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox9.Location = new System.Drawing.Point(-2, 559);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(196, 30);
            this.textBox9.TabIndex = 42;
            this.textBox9.Text = "删除结果";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbDeleteData
            // 
            this.tbDeleteData.Location = new System.Drawing.Point(234, 563);
            this.tbDeleteData.Name = "tbDeleteData";
            this.tbDeleteData.Size = new System.Drawing.Size(425, 25);
            this.tbDeleteData.TabIndex = 41;
            // 
            // textBox16
            // 
            this.textBox16.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox16.Location = new System.Drawing.Point(-2, 517);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(196, 30);
            this.textBox16.TabIndex = 40;
            this.textBox16.Text = "序号";
            this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbDNumber
            // 
            this.tbDNumber.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbDNumber.Location = new System.Drawing.Point(234, 517);
            this.tbDNumber.Name = "tbDNumber";
            this.tbDNumber.Size = new System.Drawing.Size(425, 30);
            this.tbDNumber.TabIndex = 37;
            this.tbDNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btDeleteE
            // 
            this.btDeleteE.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDeleteE.Location = new System.Drawing.Point(678, 492);
            this.btDeleteE.Name = "btDeleteE";
            this.btDeleteE.Size = new System.Drawing.Size(228, 73);
            this.btDeleteE.TabIndex = 36;
            this.btDeleteE.Text = "删除元素";
            this.btDeleteE.UseVisualStyleBackColor = true;
            this.btDeleteE.Click += new System.EventHandler(this.BtDeleteE_Click);
            // 
            // textBox20
            // 
            this.textBox20.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox20.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox20.Location = new System.Drawing.Point(-2, 479);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(421, 30);
            this.textBox20.TabIndex = 35;
            this.textBox20.Text = "操作步骤六：插入元素";
            this.textBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CreateListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 677);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.tbDeleteData);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.tbDNumber);
            this.Controls.Add(this.btDeleteE);
            this.Controls.Add(this.textBox20);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.tbInsertData);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.tbInsertElement);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.tbInsertNumber);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.tbNElement);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.tbNNumber);
            this.Controls.Add(this.btShowNumber);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.tbElement);
            this.Controls.Add(this.btShowElement);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btShowSum);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tbSumNunber);
            this.Controls.Add(this.btShowList);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.tbShowList);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.btCreateList);
            this.Name = "CreateListForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCreateList;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.TextBox tbShowList;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btShowList;
        private System.Windows.Forms.Button btShowSum;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox tbSumNunber;
        private System.Windows.Forms.Button btShowElement;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox tbElement;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox tbNElement;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox tbNNumber;
        private System.Windows.Forms.Button btShowNumber;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox tbInsertElement;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox tbInsertNumber;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox tbInsertData;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox tbDeleteData;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox tbDNumber;
        private System.Windows.Forms.Button btDeleteE;
        private System.Windows.Forms.TextBox textBox20;
    }
}

