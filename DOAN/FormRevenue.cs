    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace DOAN
{
    public partial class FormRevenue : Form
    {
        public FormRevenue()
        {
            InitializeComponent();
        }



        private int Total_Bill()
        {
            int total = 0;
            int price;
            foreach (DataGridViewRow row in DataGridView_Bill.Rows)
            {
                price = Convert.ToInt32(row.Cells[1].Value);
                total += price;
            }
            return total;
        }
        private int Total_Bill_Details()
        {
            int total = 0;
            int price;
            foreach (DataGridViewRow row in DataGridView_Bill_Details.Rows)
            {
                price = Convert.ToInt32(row.Cells[3].Value);
                total += price;
            }
            return total;
        }
        private void Show_Data_Bill()
        {
            DataGridView_Bill.DataSource = RevenueDAO.Instance.Data_Bill(Cbb_Nam.Text, Cbb_Thang.Text, Cbb_Ngay.Text);
            foreach (DataGridViewColumn column in DataGridView_Bill.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            DataGridView_Bill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.lbl_Total_Bill.Text = Total_Bill().ToString();
        }
        private void Show_Bill_DeTails()
        {
            int i = DataGridView_Bill.CurrentRow.Index;
            string id_bill = DataGridView_Bill.Rows[i].Cells[0].Value.ToString();
            lbl_Id_bill.Text = id_bill;
            lbl_Time.Text = DataGridView_Bill.Rows[i].Cells[2].Value.ToString();
            lbl_Table.Text = RevenueDAO.Instance.Get_Table(id_bill);
            lbl_NameStaff.Text = RevenueDAO.Instance.Get_NameStaff(id_bill);
            DataGridView_Bill_Details.DataSource = RevenueDAO.Instance.Bill_Details(id_bill);
            foreach (DataGridViewColumn column in DataGridView_Bill_Details.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            this.lbl_Bill_Details.Text = Total_Bill_Details().ToString();
            /*DataGridView_Bill_Details.AutoResizeColumn(0);
            DataGridView_Bill_Details.AutoResizeColumn(2);
            DataGridView_Bill_Details.AutoResizeColumn(3);*/
        }
        private void FormRevenue_Load(object sender, EventArgs e)
        {
            Cbb_Thang.Items.Add(" ");
            Cbb_Ngay.Items.Add(" ");
            for (int i = 1; i <= 12; i++)
            {
                Cbb_Thang.Items.Add(i.ToString());
            }
            for (int i = 1; i <= 31; i++)
            {
                Cbb_Ngay.Items.Add(i.ToString());
            }
            Cbb_Nam.Text = DateTime.Today.Year.ToString();
            Cbb_Thang.Text = DateTime.Today.Month.ToString();
            Cbb_Ngay.Text = DateTime.Today.Day.ToString();
            Show_Data_Bill();
        }

        // Click
        private void Btn_Show_Click(object sender, EventArgs e)
        {
            Show_Data_Bill();
        }
        private void DataGridView_Bill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Show_Bill_DeTails();
        }
        private void DataGridView_Bill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Show_Bill_DeTails();
        }


        private void set_select(string id_bill)
        {
            DataGridView_Bill.ClearSelection();
            foreach (DataGridViewRow row in DataGridView_Bill.Rows)
            {
                if (row.Cells[0].Value.ToString() == lbl_Id_bill.Text)
                {
                    row.Selected = true;
                    DataGridView_Bill.CurrentCell = row.Cells[0];
                    break;
                }
            }
        }
        private void Btn_Them_Bill_Click(object sender, EventArgs e)
        {
            FormLogin._FormMain.Btn_Foods_Click(FormLogin._FormMain.Btn_Foods, e);
        }
        private void Btn_Them_Click(object sender, EventArgs e)
        {
            if (lbl_Id_bill.Text == "       ")
            {
                MessageBox.Show("Chọn Bill cần thêm");
            }
            else
            {
                int i = DataGridView_Bill_Details.CurrentRow.Index;
                string ten = DataGridView_Bill_Details.Rows[i].Cells[1].Value.ToString();
                string soluong = DataGridView_Bill_Details.Rows[i].Cells[2].Value.ToString();
                FormRevenue_Child formchild = new FormRevenue_Child();
                formchild.Btn_Sua.Visible = false;
                formchild.set_data(lbl_Id_bill.Text, lbl_NameStaff.Text, lbl_Table.Text, ten, soluong, lbl_Time.Text);
                formchild.ShowDialog();
                Show_Data_Bill();
                set_select(lbl_Id_bill.Text);
                Show_Bill_DeTails();
            }
        }
        private void Btn_Xoa_Click(object sender, EventArgs e)
        {
            if (lbl_Id_bill.Text == "       ")
            {
                MessageBox.Show("Chọn Bill cần xóa");
            }
            else
            {
                int i = DataGridView_Bill.CurrentRow.Index;
                string id_bill = DataGridView_Bill.Rows[i].Cells[0].Value.ToString();
                RevenueDAO.Instance.Delete(id_bill);
                lbl_Id_bill.Text = "";
                lbl_NameStaff.Text = "";
                lbl_Table.Text = "";
                lbl_Time.Text = "";
                DataGridView_Bill_Details.DataSource = null;
                DataGridView_Bill_Details.Rows.Clear();
                Show_Data_Bill();
                MessageBox.Show("Xóa thành công");
            }
        }
        private void Btn_Sua_Click(object sender, EventArgs e)
        {
            if (lbl_Id_bill.Text == "       ")
            {
                MessageBox.Show("Chọn Bill cần sửa");
            }
            else
            {
                int i = DataGridView_Bill_Details.CurrentRow.Index;
                string ten = DataGridView_Bill_Details.Rows[i].Cells[1].Value.ToString();
                string soluong = DataGridView_Bill_Details.Rows[i].Cells[2].Value.ToString();
                FormRevenue_Child formchild = new FormRevenue_Child();
                formchild.Btn_them.Visible = false;
                formchild.set_data(lbl_Id_bill.Text, lbl_NameStaff.Text, lbl_Table.Text, ten, soluong, lbl_Time.Text);
                formchild.ShowDialog();
                Show_Data_Bill();
                set_select(lbl_Id_bill.Text);
                Show_Bill_DeTails();
            }
        }
        private void Btn_Xoamon_Click(object sender, EventArgs e)
        {
            if (lbl_Id_bill.Text == "       ")
            {
                MessageBox.Show("Chọn Bill cần xóa");
            }
            else
            {
                int i = DataGridView_Bill.CurrentRow.Index;
                int j = DataGridView_Bill_Details.CurrentRow.Index;
                string id_bill = DataGridView_Bill.Rows[i].Cells[0].Value.ToString();
                string name = DataGridView_Bill_Details.Rows[j].Cells[1].Value.ToString();
                RevenueDAO.Instance.Delete_Item(name,id_bill,lbl_Table.Text);
                if (DataGridView_Bill_Details.RowCount == 0)
                {
                    lbl_Id_bill.Text = "";
                    lbl_NameStaff.Text = "";
                    lbl_Table.Text = "";
                    lbl_Time.Text = "";
                    DataGridView_Bill_Details.DataSource = null;
                    DataGridView_Bill_Details.Rows.Clear();
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    Show_Data_Bill();
                    set_select(lbl_Id_bill.Text);
                    Show_Bill_DeTails();
                    MessageBox.Show("Xóa thành công");
                }
            }
        }

    }
}