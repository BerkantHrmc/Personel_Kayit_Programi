using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Personel_Kayit_Programi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=Berkant-MacBook-Air;Persist Security Info=True;User ID=sa;Encrypt=False;Trust Server Certificate=True\r\n ");
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kitapYeniDataSet.personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelTableAdapter.Fill(this.kitapYeniDataSet.personel);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            


            baglantı.Close();
        }
    }
}
