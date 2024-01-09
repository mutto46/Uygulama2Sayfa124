using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama2Sayfa124
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] isimler=new string[5];
        int index = 0;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            isimler[index] =txtAdSoyad.Text;
            index++;   
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < isimler.Length; i++)
            {
                lbListele.Items.Add(isimler[i]);
            }
        }
    }
}
