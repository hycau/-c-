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
    public partial class SpiltListForm : Form
    {
        public SpiltListForm()
        {
            InitializeComponent();
            btCreateList.Enabled = false;
            btCreate2list.Enabled = false;
        }
        SqlListClass work1 = new SqlListClass();
        SqlListClass work2 = new SqlListClass();
        SqlListClass work3 = new SqlListClass();
        private void BtCreateList_Click(object sender, EventArgs e)
        {
            try
            {
                string s = tbData.Text;
                string[] stringData = s.Split(',');
                work1.CreateList(stringData);
                btCreate2list.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
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

        private void BtCreate2list_Click(object sender, EventArgs e)
        {
            Create2list(work1);
        }

        private void Create2list(SqlListClass w)
        {
            int n = w.ListLength / 2;
            int m = w.ListLength - n;
            string[] s1 = new string[m];//奇数
            string[]s2 = new string[n];
            for (int i = 0; i < w.ListLength; i++)
            {
                if((i+1)%2==0)
                {
                    s2[i/2] = w.data[i];
                }
                else
                {
                    s1[i/2] = w.data[i];
                }
            }
            string s3 = null;
            string s4 = null;
            foreach (var i in s1)
            {
                s3 += " ";
                s3 += i;
            }
            foreach (var i in s2)
            {
                s4 += " ";
                s4 += i;
            }
            tbOddList.Text = s3;
            tbEvenList.Text = s4;
        }
    }
}
