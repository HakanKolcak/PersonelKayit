using PersonelKayıt.PersonelVTDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelKayıt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        WorkerDal _workerDal = new WorkerDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelVTDataSet.Sehirler' table. You can move, or remove it, as needed.
            this.sehirlerTableAdapter.Fill(this.personelVTDataSet.Sehirler);
            AddWorkers();
        }
        
        private void AddWorkers()
        {
            dgwWorkers.DataSource = _workerDal.GetAll("Personel");
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            string sehir;

            if(cmbSehır.Text == "DİĞER...")
            {
                sehir = txtSehirDiger.Text;
            }
            else
            {
                sehir = cmbSehır.Text;
            }
            _workerDal.Add(new Worker
            {
                Ad = tbxAd.Text,
                Soyad = tbxSoyad.Text,
                Cınsıyet = cmbCınsıyet.Text,
                Durum = cmbDurum.Text,
                Sehır = sehir,
                Maas = Convert.ToDecimal(mtbMaas.Text),
                TelNo = mtbTelNo.Text,
                Meslek = tbxMeslek.Text
            });
            AddWorkers();
            MessageBox.Show("Personel Eklendi");
        }

        private void dgwWorkers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxAdGüncelleme.Text = dgwWorkers.CurrentRow.Cells[1].Value.ToString();
            tbxSoyadGüncelleme.Text = dgwWorkers.CurrentRow.Cells[2].Value.ToString();
            cmbCınsıyetGüncelleme.Text = dgwWorkers.CurrentRow.Cells[3].Value.ToString();
            cmbDurumGüncelleme.Text = dgwWorkers.CurrentRow.Cells[4].Value.ToString();
            cmbSehırGüncelleme.Text = dgwWorkers.CurrentRow.Cells[5].Value.ToString();
            mtbMaasGüncelleme.Text = dgwWorkers.CurrentRow.Cells[6].Value.ToString();
            mtbTelNoGüncelleme.Text = dgwWorkers.CurrentRow.Cells[7].Value.ToString();
            tbxMeslekGüncelleme.Text = dgwWorkers.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            string sehir1;

            if (cmbSehır.Text == "DİĞER...")
            {
                sehir1 = txtSehirDigerGüncelleme.Text;
            }
            else
            {
                sehir1 = cmbSehır.Text;
            }

            Worker worker = new Worker
            {
                Id = Convert.ToInt32(dgwWorkers.CurrentRow.Cells[0].Value),
                Ad = tbxAdGüncelleme.Text,
                Soyad = tbxSoyadGüncelleme.Text,
                Cınsıyet = cmbCınsıyetGüncelleme.Text,
                Durum = cmbDurumGüncelleme.Text,
                Sehır = sehir1,
                Maas = Convert.ToDecimal(mtbMaasGüncelleme.Text),
                TelNo = mtbTelNoGüncelleme.Text,
                Meslek = tbxMeslekGüncelleme.Text   
            };
            _workerDal.Update(worker);
            AddWorkers();
            MessageBox.Show("Güncellendi...");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwWorkers.CurrentRow.Cells[0].Value);
            _workerDal.Delete(id);
            AddWorkers();
            MessageBox.Show("Silindi...");
        }

        private void mtbMaas_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void mtbTelNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void mtbMaasGüncelleme_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void mtbTelNoGüncelleme_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbxAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void tbxSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void tbxMeslek_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void tbxAdGüncelleme_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void tbxSoyadGüncelleme_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void tbxMeslekGüncelleme_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void cmbSehır_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSehır.Text == "DİĞER...")
            {
                txtSehirDiger.Visible = true;
            }
            else
            {
                txtSehirDiger.Visible = false;
            }
        }

        private void cmbSehırGüncelleme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSehır.Text == "DİĞER...")
            {
                txtSehirDigerGüncelleme.Visible = true;
            }
            else
            {
                txtSehirDigerGüncelleme.Visible = false;
            }
        }
    }
}
