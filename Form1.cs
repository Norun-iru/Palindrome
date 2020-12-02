using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace kaibunjyenerate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string s, d, t;
            int i;

            s = txtSrc.Text;
            if (s.Length > 0)
            {
               
                if(checkBox1.Checked == false)
                {
                    d = s;
                    t = s.Substring(0, s.Length - 1);
                    for (i = t.Length - 1; i >= 0; i--)
                    {
                        d += t.Substring(i, 1);
                    }
                    txtDest.Text = d;
                }
                if(checkBox1.Checked == true)
                {
                    d = s;
                    d = string.Concat(d.Reverse());
                    t = s + d;
                    txtDest.Text = t;
                }
                             
            }
               if(checkBox1.Checked == true)
               {
                   d = s;
                   d = string.Concat(d.Reverse());
                   t = s + d;
                   txtDest.Text = t;
               }
            




            if (txtSrc.Text == "")
            {
                txtDest.Text = "";
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSrc.Text = "";
            txtDest.Text = "";
            txtSrc.Focus();
            txtCheck.Text = "";
            txtOut.Text = "";

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtCheck_TextChanged(object sender, EventArgs e)
        {
            string c, o;
            c = txtCheck.Text;
            o = string.Concat(c.Reverse());
            txtOut.Text = o;

            if (c == o)
            {
                lblTrue.Text = "回文です。";
            }
            else
            {
                lblTrue.Text = "回文ではありません。";
            }

            if (txtCheck.Text == "")
            {
                lblTrue.Text = "原文に文を入力してください。";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           if ( this.BackColor == Color.FromArgb(64,64,64))
            {
               this.BackColor = System.Drawing.Color.White;
               this.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                this.BackColor = System.Drawing.Color.FromArgb(64,64,64);
                this.ForeColor = System.Drawing.Color.White;
            }
            
        }

        private void 色変更ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.FromArgb(64, 64, 64))
            {
                this.BackColor = System.Drawing.Color.White;
                this.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                this.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
                this.ForeColor = System.Drawing.Color.White;
            }
        }

        private void 名前を付けて保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "テキストファイル(*.txt)|*.txt";
            dialog.Title = "保存";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName, txtDest.Text);
            }
        }

        private void 閉じるToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string s, d, t;
            int i;
            s = txtSrc.Text;
            if(s.Length > 0)
            {
               if (checkBox1.Checked == true)
               {
                   s = txtSrc.Text;
                   d = s;
                   d = string.Concat(d.Reverse());
                   t = s + d;
                   txtDest.Text = t;
               }
               if (checkBox1.Checked == false)
               {
                   s = txtSrc.Text;
                   d = s;
                   t = s.Substring(0, s.Length - 1);
                   for (i = t.Length - 1; i >= 0; i--)
                   {
                       d += t.Substring(i, 1);
                   }
                   txtDest.Text = d;
               }
            


            }
        }

        private void 背景画像変更ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void excelで保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excelブック(*.xls)|*.xls";
            dialog.Title = "保存";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName, txtDest.Text);
            }
        }
    }
}
