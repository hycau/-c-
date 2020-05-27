using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class CreateListForm : Form
    {
        public CreateListForm()
        {
            InitializeComponent();
            tbData.Text = null;
            tbShowList.Text = null;
            btCreateList.Enabled = false;
            btShowList.Enabled = false;
            btShowSum.Enabled = false;
            btShowElement.Enabled = false;
            btShowNumber.Enabled = false;
            btInsert.Enabled = false;
            btDeleteE.Enabled = false;
        }
        private void TbData_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbData.Text))
            {
                btCreateList.Enabled = false;
            }
            else
                btCreateList.Enabled = true;
        }
        private void UpdateUI()
        {
            btShowList.Enabled = true;
            btShowSum.Enabled = true;
            btShowElement.Enabled = true;
            btShowNumber.Enabled = true;
            btInsert.Enabled = true;
            btDeleteE.Enabled = true;
        }
        SqlListClass work = new SqlListClass();
        private void Button1_Click(object sender, EventArgs e)
        {
            CreateList();
            UpdateUI();
        }

        private void CreateList()
        {
            try
            {
                string s = tbData.Text;
                string[] stringData = s.Split(',');
                work.CreateList(stringData);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            tbShowList.Text = work.DispList();
        }
        private void Button1_Click_1(object sender, EventArgs e)
        {
            tbSumNunber.Text = work.ListLength.ToString();
        }

        private void BtShowElement_Click(object sender, EventArgs e)
        {
            string s = null;
            if (work.GetItem(Convert.ToInt32(tbNumber.Text), ref s))
            {
                tbElement.Text = s;
            }
            else
                MessageBox.Show("请输入有效序号");

        }

        private void BtShowNumber_Click(object sender, EventArgs e)
        {
            string s = tbNElement.Text;
            int n = work.LocItem(ref s);
            if (n != 0)
            {
                tbNNumber.Text = n.ToString();
            }
            else
                MessageBox.Show("找不到该元素,请重新输入");
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(tbInsertNumber.Text);
            string s = tbInsertElement.Text;
            if (work.ListInsert(n, ref s))
            {
                tbInsertData.Text = work.DispList();
            }
            else
                MessageBox.Show("序号无效，请重新输入");
        }

        private void BtDeleteE_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(tbDNumber.Text);
            if (work.ListDelete(n))
            {
                tbDeleteData.Text = work.DispList();
            }
            else
                MessageBox.Show("序号无效，请重新输入");
        }
    }
}
