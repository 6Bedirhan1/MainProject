using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace c_access
{
    public partial class Form1 : Form
    {
        public Form1()
        { 
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=bilgiler.mdb");
        DataTable tablo = new DataTable();
        
        private void listele()
        {
            baglanti.Open();
            string sorgu = "SELECT * FROM kayitbilgileri";
            OleDbDataAdapter adtr = new OleDbDataAdapter(sorgu, baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txadi.Text) || string.IsNullOrWhiteSpace(txsoyadi.Text) || string.IsNullOrWhiteSpace(txadres.Text) || string.IsNullOrWhiteSpace(txtel.Text) || string.IsNullOrWhiteSpace(txmail.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı");
                return; 
            }
            if (btnekle.Text =="EKLE")
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("insert into kayitbilgileri(ad,soyad,adres,telefon,mail)values('" + txadi.Text + "','" + txsoyadi.Text + "','" + txadres.Text + "','" + txtel.Text + "','" + txmail.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Eklendi !", "Kayıt");
                tablo.Clear();
                listele();
                for (int i = 0; i < Controls.Count; i++)
                {
                    if (Controls[i] is TextBox)
                    {
                        Controls[i].Text = "";
                    }

                }

            }
            if (btnekle.Text =="GÜNCELLE")
            {
                baglanti.Open();
                OleDbCommand komut2 = new OleDbCommand("update kayitbilgileri set ad ='"+txadi.Text + "',soyad ='"+txsoyadi .Text +"',adres ='"+txadres .Text +"',telefon='"+txtel .Text +"',mail='"+txmail.Text+ "'where telefon='"+txtel.Text +"'", baglanti);
                komut2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Güncellendi !", "Kayıt");
                tablo.Clear();
                listele();
                for (int i = 0; i < Controls.Count; i++)
                {
                    if (Controls[i] is TextBox)
                    {
                        Controls[i].Text = "";
                    }

                }
                btnekle.Text = "EKLE";
            }
           
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete *from kayitbilgileri where ad='" + dataGridView1.CurrentRow.Cells["ad"].Value.ToString() + "'and telefon='" + dataGridView1.CurrentRow.Cells["telefon"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi !", "Kayıt");
            tablo.Clear();
            listele();
        }

        private void txadtlfn_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "SELECT * FROM kayitbilgileri where ad like '"+txadtlfn.Text +"%'or telefon like '"+txadtlfn.Text +"%'";
            OleDbDataAdapter adtr = new OleDbDataAdapter(sorgu, baglanti);
            DataTable tablo2 = new DataTable();  
            adtr.Fill(tablo2);
            dataGridView1.DataSource = tablo2;
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txadi.Text = dataGridView1.CurrentRow.Cells["ad"].Value .ToString();
            txsoyadi .Text = dataGridView1.CurrentRow.Cells["soyad"].Value.ToString();
            txadres .Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            txtel .Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString ();
            txmail .Text = dataGridView1.CurrentRow.Cells["mail"].Value.ToString();
            btnekle.Text = "GÜNCELLE";
        }
    }
}
