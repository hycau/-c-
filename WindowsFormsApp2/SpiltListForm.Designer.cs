namespace WindowsFormsApp2
{
    partial class SpiltListForm
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tbData = new System.Windows.Forms.TextBox();
            this.btCreateList = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.tbEvenList = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.tbOddList = new System.Windows.Forms.TextBox();
            this.btCreate2list = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox2.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(12, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(421, 30);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "操作步骤二：输出两个顺序表";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox4.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox4.Location = new System.Drawing.Point(12, 12);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(421, 30);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "操作步骤一：输入数据（例：1,2,3）";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(12, 48);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(661, 25);
            this.tbData.TabIndex = 7;
            this.tbData.TextChanged += new System.EventHandler(this.TbData_TextChanged);
            // 
            // btCreateList
            // 
            this.btCreateList.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btCreateList.Location = new System.Drawing.Point(692, 13);
            this.btCreateList.Name = "btCreateList";
            this.btCreateList.Size = new System.Drawing.Size(228, 60);
            this.btCreateList.TabIndex = 6;
            this.btCreateList.Text = "建立数据表";
            this.btCreateList.UseVisualStyleBackColor = true;
            this.btCreateList.Click += new System.EventHandler(this.BtCreateList_Click);
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox9.Location = new System.Drawing.Point(12, 168);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(196, 30);
            this.textBox9.TabIndex = 47;
            this.textBox9.Text = "偶数位置序列表";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbEvenList
            // 
            this.tbEvenList.Location = new System.Drawing.Point(248, 172);
            this.tbEvenList.Name = "tbEvenList";
            this.tbEvenList.Size = new System.Drawing.Size(425, 25);
            this.tbEvenList.TabIndex = 46;
            // 
            // textBox16
            // 
            this.textBox16.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox16.Location = new System.Drawing.Point(12, 126);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(196, 30);
            this.textBox16.TabIndex = 45;
            this.textBox16.Text = "奇数位置序列表";
            this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbOddList
            // 
            this.tbOddList.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbOddList.Location = new System.Drawing.Point(248, 126);
            this.tbOddList.Name = "tbOddList";
            this.tbOddList.Size = new System.Drawing.Size(425, 30);
            this.tbOddList.TabIndex = 44;
            this.tbOddList.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btCreate2list
            // 
            this.btCreate2list.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btCreate2list.Location = new System.Drawing.Point(692, 92);
            this.btCreate2list.Name = "btCreate2list";
            this.btCreate2list.Size = new System.Drawing.Size(228, 90);
            this.btCreate2list.TabIndex = 48;
            this.btCreate2list.Text = "输出两个序列表";
            this.btCreate2list.UseVisualStyleBackColor = true;
            this.btCreate2list.Click += new System.EventHandler(this.BtCreate2list_Click);
            // 
            // SpiltListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 218);
            this.Controls.Add(this.btCreate2list);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.tbEvenList);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.tbOddList);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.btCreateList);
            this.Name = "SpiltListForm";
            this.Text = "SpiltListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Button btCreateList;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox tbEvenList;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox tbOddList;
        private System.Windows.Forms.Button btCreate2list;
    }
}