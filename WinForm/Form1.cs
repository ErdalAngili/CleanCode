using Okul.Business.Abstract;
using Okul.Business.Concrete;
using Okul.Business.ValidationRules.FluentValidation;
using Okul.DataAccess.Abstract;
using Okul.DataAccess.Concrete.EntityFramework;
using Okul.DataAccess.Concrete.Nortwind;
using Okul.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            _OgrenciService = new OgrenciManager(new EfOgrenciDal());
        }
        EfOgrenciDal _efOgrenciDal = new EfOgrenciDal();
        private OgrenciService _OgrenciService;
        private void Form1_Load(object sender, EventArgs e)
        {
            getall();
            //getir();
            //LoadCategories();
        }

        private void LoadCategories()
        {
            //comboBox1.DataSource = _categoryService.GetALL();
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryId";
        }

        public void getall()
        {
            dataGridView1.DataSource = _efOgrenciDal.GetAll();
        }
        public void getir()
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _OgrenciService.ADD(new Ogrenci
                {
                    OgrenciAd = textBox1.Text,
                    OgrenciSoyad = textBox2.Text,
                    OgrenciNumara = Convert.ToInt32(textBox3.Text),
                    OgrenciAlan = textBox4.Text
                });
                getall();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox5.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _efOgrenciDal.Update(new Ogrenci
            {
                OgrenciId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                OgrenciAd=textBox5.Text,
                OgrenciSoyad=textBox6.Text,
                OgrenciNumara=Convert.ToInt32(textBox7.Text),
                OgrenciAlan=textBox8.Text
            });
            getall();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                _efOgrenciDal.Delete(new Ogrenci
                {
                    OgrenciId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)
                });
            }
            getall();
        }
    }
}
