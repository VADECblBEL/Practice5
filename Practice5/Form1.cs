using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice5
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

        private void Form1_Load(object sender, EventArgs e)
        {
      label1.Text = "Необходимо найти долю пробелов в строке";
        }

    private void button1_Click(object sender, EventArgs e)
    {
      int index = listBox1.SelectedIndex;
      string str = (string)listBox1.Items[index];
      int len = str.Length;
      int count = 0;
      
      int i = 0;
      while (i < len - 1)
      {
          if (str[i] == ' ')
          count++;
        i++;
      }

      double dolya = count / len;
      label1.Text = "Доля пробелов в строке: " + count.ToString() + "/" + len.ToString();

    }
  }
}
