using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Library;
using DAO;
using DTO;

namespace DOAN
{
    public partial class FormOrder : Form
    {
        public static LinkedList<UserControl_Order> List_Order = new LinkedList<UserControl_Order>();
        public FormOrder()
        {
            InitializeComponent();
        }

        private void SetDefault()
        {
            this.FlowLayoutPanel_Bill.Controls.Clear();
            this.Label_ID_Order.Text = "";
            this.Combobox_ID_Table.Text = "";
            this.Label_Total.Text = "0";
        }

        // Load
        private void FormOrder_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.ScrollBar.PanelScrollHelper Pan = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(FlowLayoutPanel_Bill,gunaVScrollBar1,true);
            Guna.UI.Lib.ScrollBar.PanelScrollHelper Pan1 = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(FlowLayoutPanel_Order, gunaVScrollBar2, true);
            TableDAO.Instance.FillComboBox(this.Combobox_ID_Table);
            gunaTransition1.ShowSync(Panel);
        }


        // Click
        private void Btn_ThemMon_Click(object sender, EventArgs e)
        {
            try
            {
                FormLogin._FormMain.Btn_Foods_Click(FormLogin._FormMain.Btn_Foods, e);
                FormMain._FormAdd.Combobox_ID_Table.Text = FormMain._FormOrder.Combobox_ID_Table.Text;
                FormMain._FormAdd.Combobox_ID_Table.Enabled = false;
                FormMain._FormAdd.Label_ID_Order.Text = FormMain._FormOrder.Label_ID_Order.Text;
                FormMain._FormAdd.gunaLabel3.Visible = true;
                FormMain._FormAdd.Label_ID_Order.Visible = true;
                UserControl_Order.ID_Order = Convert.ToInt32(FormMain._FormOrder.Label_ID_Order.Text);
                FormMain._FormAdd.Panel_Button.Visible = false;
                FormMain._FormAdd.Panel_ButtonThem.Visible = true;
                FormMain._FormAdd.Panel_ButtonThem.BringToFront();
            }
            catch
            {
            }
            finally
            {
                SetDefault();
            }
        }
        private void Btn_Finish_Click(object sender, EventArgs e)
        {
            if (FormMain._FormOrder.Combobox_ID_Table.Text == "Mua về")
            {
                string id_bill;
                id_bill = ItemDAO.Instance.Get_MAX_ID_Bill();
                foreach (UserControl_Order order in FormMain._FormOrder.FlowLayoutPanel_Order.Controls)
                {
                    if (order.GetID_Order() == FormMain._FormOrder.Label_ID_Order.Text)
                    {
                        if (order.ChildListAdd.Count == 0)
                        {
                            MessageBox.Show("Không có món nào trong Order");
                            order.Btn_Delete_Click(order, e);
                            break;
                        }
                        else
                        {
                            foreach (UserControl_Add add in order.ChildListAdd)
                            {
                                ItemDAO.Instance.Insert(id_bill, UserCache.name, "0", add.GetName(), add.GetQuantity().ToString());
                            }
                            order.Btn_Delete_Click(order, e);
                            SetDefault();
                            MessageBox.Show("Tạo hóa đơn thành công");
                            break;
                        }
                        
                    }
                }
            }


            if (FormMain._FormOrder.Combobox_ID_Table.Text == "" && FormMain._FormOrder.FlowLayoutPanel_Bill.Controls.Count != 0)
            {
                MessageBox.Show("Vui lòng nhập ID Table");
            }
            else
            {
                foreach (UserControl_Table control in FormMain._FormTable.FlowLayoutPanel_Table.Controls)
                {
                    if (control.Label_ID_Table.Text == FormMain._FormOrder.Combobox_ID_Table.Text)
                    {
                        foreach (UserControl_Order order in FormMain._FormOrder.FlowLayoutPanel_Order.Controls)
                        {
                            if (control.Label_ID_Table.Text == order.Label_ID_Table.Text)
                            {
                                if (order.ChildListAdd.Count == 0)
                                {
                                    MessageBox.Show("Không có món nào trong Order");
                                    order.Btn_Delete_Click(order, e);
                                    break;
                                }
                                else
                                {
                                    control.SetChildListAdd(order.ChildListAdd);
                                    control.SetTotal(control.ChildListAdd.First.Value.Total(control.ChildListAdd));
                                    control.Label_Status.Text = "Có khách";
                                    control.BackgroundImage = Image.FromFile(@"C:\Users\ABC\Desktop\DOAN_NET\image\Background\3.png");
                                    order.Btn_Delete_Click(order, e);
                                    break;
                                }
                            }
                        }
                        SetDefault();
                        break;
                    }
                }
            }
            FormMain._FormTable.SetDefault();
        }


        // Combobox
        private void Combobox_ID_Table_MouseClick(object sender, MouseEventArgs e)
        {
            Combobox_ID_Table.BaseColor = Color.White;
        }
        private void Combobox_ID_Table_SelectedValueChanged(object sender, EventArgs e)
        {
            Combobox_ID_Table.BaseColor = Color.Transparent;
            foreach (UserControl_Order control in FlowLayoutPanel_Order.Controls)
            {
                if (control.GetID_Order() == this.Label_ID_Order.Text)
                {
                    control.Label_ID_Table.Text = this.Combobox_ID_Table.Text;
                    break;
                }
            }
        }

    }
}
