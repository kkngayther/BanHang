using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHang
{
    
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        int tienHang = 0;
        double khuyenMai = 0;
        double tongTien = 0;
        int dem = 0;
        Boolean kiemTra = false;
        ArrayList priceTea = new ArrayList();
        
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Clear();
            dt.Columns.Add("Ten", typeof(string));
            dt.Columns.Add("So luong", typeof(int));
            dt.Columns.Add("Don gia", typeof(string));
            dt.Columns.Add("Thanh tien", typeof(string));
            txtTienHang.Text = tienHang.ToString();
            txtKhuyenMai.Text = khuyenMai.ToString();
            txtTongTien.Text = tongTien.ToString();
            createPrice();
        }
        private void tinhTien()
        {
            int tam = Convert.ToInt32(dataGridView1.Rows[dem - 1].Cells[3].Value);
            tienHang += tam;
            txtTienHang.Text = tienHang.ToString();
        }
        private void setDefault()
        {
            if (kiemTra)
            {
                dt.Clear();
                dataGridView1.DataSource = dt;
                txtTongTien.Text = "0";
                txtKhuyenMai.Text = khuyenMai.ToString();
                tienHang = 0;
                khuyenMai = 0;
                dem = 0;
                kiemTra = false;
            }
        }

        private void createPrice()
        {
            priceTea.Add("12000");
            priceTea.Add("15000");
            priceTea.Add("12000");
            priceTea.Add("12000");
            priceTea.Add("18000");
            priceTea.Add("20000");
            priceTea.Add("22000");
            priceTea.Add("20000");
            priceTea.Add("16000");
            priceTea.Add("15000");

            priceTea.Add("32000");
            priceTea.Add("25000");
            priceTea.Add("33000");
            priceTea.Add("30000");
            priceTea.Add("40000");
            priceTea.Add("29000");
            priceTea.Add("28000");
            priceTea.Add("26000");
            priceTea.Add("36000");
            priceTea.Add("55000");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setDefault();
            dt.Rows.Add(button2.Text, 1, priceTea[0], priceTea[0]);
            dataGridView1.DataSource = dt; dem = dem + 1;
            tinhTien();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setDefault();
            dt.Rows.Add(button3.Text, 1, priceTea[1], priceTea[1]);
            dataGridView1.DataSource = dt; dem = dem + 1;
            tinhTien();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            setDefault();
            dt.Rows.Add(button7.Text, 1, priceTea[2], priceTea[2]);
            dataGridView1.DataSource = dt; dem = dem + 1;
            tinhTien();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            setDefault();
            dt.Rows.Add(button8.Text, 1, priceTea[3], priceTea[3]);
            dataGridView1.DataSource = dt; dem = dem + 1;
            tinhTien();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            setDefault();
            dt.Rows.Add(button9.Text, 1, priceTea[4], priceTea[4]);
            dataGridView1.DataSource = dt; dem = dem + 1;
            tinhTien();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            setDefault();
            dt.Rows.Add(button10.Text, 1, priceTea[5], priceTea[5]);
            dataGridView1.DataSource = dt; dem = dem + 1;
            tinhTien();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            setDefault();
            dt.Rows.Add(button11.Text, 1, priceTea[6], priceTea[6]);
            dataGridView1.DataSource = dt; dem = dem + 1;
            tinhTien();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            setDefault();
            dt.Rows.Add(button12.Text, 1, priceTea[7], priceTea[7]);
            dataGridView1.DataSource = dt; dem = dem + 1;
            tinhTien();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            setDefault();
            dt.Rows.Add(button13.Text, 1, priceTea[8], priceTea[8]);
            dataGridView1.DataSource = dt; dem = dem + 1;
            tinhTien();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            setDefault();
            dt.Rows.Add(button14.Text, 1, priceTea[9], priceTea[9]);
            dataGridView1.DataSource = dt; dem = dem + 1;
            tinhTien();
        }
        private void btn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            dt.Rows.Add(btn.Text, 1, priceTea[9], priceTea[9]);
            dataGridView1.DataSource = dt; dem = dem + 1;
            tinhTien();
        }

        private void txtTongTien_DoubleClick(object sender, EventArgs e)
        {
            int tam = Convert.ToInt32(txtTienHang.Text);
            double km = Double.Parse(txtKhuyenMai.Text);
            tongTien = tam * km / 100;
            txtTongTien.Text = (tienHang - tongTien).ToString();
            kiemTra = true;
;        }

        private void txtKhuyenMai_Click(object sender, EventArgs e)
        {
            txtKhuyenMai.Text = "";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            setDefault();
            dt.Rows.Add(button24.Text, 1, priceTea[10], priceTea[10]);
            dataGridView1.DataSource = dt; dem = dem + 1;
            tinhTien();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            setDefault();
            dt.Rows.Add(button23.Text, 1, priceTea[11], priceTea[11]);
            dataGridView1.DataSource = dt; dem = dem + 1;
            tinhTien();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            setDefault();
            dt.Rows.Add(button22.Text, 1, priceTea[12], priceTea[12]);
            dataGridView1.DataSource = dt; dem = dem + 1;
            tinhTien();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            setDefault();
            dt.Rows.Add(button21.Text, 1, priceTea[13], priceTea[13]);
            dataGridView1.DataSource = dt; dem = dem + 1;
            tinhTien();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            setDefault();
            dt.Rows.Add(button20.Text, 1, priceTea[14], priceTea[14]);
            dataGridView1.DataSource = dt; dem = dem + 1;
            tinhTien();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            setDefault();
            dt.Rows.Add(button19.Text, 1, priceTea[15], priceTea[15]);
            dataGridView1.DataSource = dt; dem = dem + 1;
            tinhTien();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            setDefault();
            dt.Rows.Add(button18.Text, 1, priceTea[16], priceTea[16]);
            dataGridView1.DataSource = dt; dem = dem + 1;
            tinhTien();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            setDefault();
            dt.Rows.Add(button17.Text, 1, priceTea[17], priceTea[17]);
            dataGridView1.DataSource = dt; dem = dem + 1;
            tinhTien();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            setDefault();
            dt.Rows.Add(button16.Text, 1, priceTea[18], priceTea[18]);
            dataGridView1.DataSource = dt; dem = dem + 1;
            tinhTien();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            setDefault();
            dt.Rows.Add(button15.Text, 1, priceTea[19], priceTea[19]);
            dataGridView1.DataSource = dt; dem = dem + 1;
            tinhTien();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            setDefault();
            panel4.Visible = true;
            button5.BackColor = Color.Indigo;
            button1.BackColor = Color.ForestGreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setDefault();
            panel4.Visible = false;
            button1.BackColor = Color.Indigo;
            button5.BackColor = Color.ForestGreen;
        }
    }
}
