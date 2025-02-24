using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai13_tinhcanchi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] canarr = { "canh", "tân", "nhân", "Quí", "ất", "bính", "Đinh", "hậu", "kỷ" };
            string[] chiarr = { "thìn", "tỵ", "ngọ", "Mùi", "dậu", "tất", "hợi", "sửu", "dần", "mão" };
        }
    }
}
