using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using DAO;
using DTO;

namespace DOAN
{
    public partial class FormRevenue_Child : Form
    {
        string id_bill;
        string name_staff;
        string table;
        string ten;
        string id_item;
        string time;
        public FormRevenue_Child()
        {
            InitializeComponent();
        }


        // load , set  data
        private void load(string id ,string ten , string soluong)
        {
            RevenueDAO.Instance.Fill_Child_ComboBox(Cbb_ten);
            lbl_ID.Text = id;
            Cbb_ten.Text = ten;
            this.id_item = Cbb_ten.SelectedValue.ToString();
            txt_soluong.Text = soluong;
        }
        public void set_data(string id, string name_staff, string table, string ten, string soluong, string time)
        {
            this.id_bill = id;
            this.name_staff = name_staff;
            this.table = table;
            this.ten = ten;
            this.time = time;
            load(id, ten, soluong);
        }


        // click
        private void Btn_them_Click(object sender, EventArgs e)
        {
            bool b = true;
            try
            {
                int check = Convert.ToInt32(txt_soluong.Text);
                if (check <= 0)
                {
                    b = false;
                    MessageBox.Show("Nhập sai số lượng");
                }
            }
            catch
            {
                b = false;
                MessageBox.Show("Nhập sai số lượng");
            }
            if ( b == true)
            {
                try
                {
                    RevenueDAO.Instance.Insert(this.id_bill, this.name_staff, this.table, Cbb_ten.SelectedValue.ToString(), txt_soluong.Text, this.time);
                }
                catch
                {
                    b = false;
                    MessageBox.Show("Món này đã có trong bill");
                }
            }
            if (b == true)
            {
                MessageBox.Show("Thêm thành công");
                this.Close();
            }
        }
        private void Btn_Sua_Click(object sender, EventArgs e)
        {
            bool b = true;
            try
            {
                int check = Convert.ToInt32(txt_soluong.Text);
                if (check <= 0)
                {
                    b = false;
                    MessageBox.Show("Nhập sai số lượng");
                }
            }
            catch
            {
                b = false;
                MessageBox.Show("Nhập sai số lượng");
            }
            if (b == true)
            {
                try
                {
                    RevenueDAO.Instance.Update(Cbb_ten.SelectedValue.ToString(), this.txt_soluong.Text, this.id_bill, this.table, this.id_item);
                }
                catch
                {
                    b = false;
                    MessageBox.Show("Món này đã có trong Bill");
                }
            }
            if (b == true)
            {
                MessageBox.Show("Sửa thành công");
                this.Close();
            }
        }
    }
}
