using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN
{
    public partial class UserControl_Add : UserControl
    {
        public UserControl_Add()
        {
            InitializeComponent();
        }

        //Methods
        public void ChangeLabel(string label_name,int label_price, int TimesClicked)
        {
            this.Label_Add_Name.Text = label_name;
            this.Label_Add_Price.Text = label_price.ToString();
            this.Quantity.Value = TimesClicked;
        }
        public void SetQuantity(int soluong)
        {
            this.Quantity.Value = soluong;
        }
        public int GetQuantity()
        {
            return Convert.ToInt32(this.Quantity.Value);
        }
        public int GetPrice()
        {
            return Convert.ToInt32(this.Label_Add_Price.Text);
        }
        public string GetName()
        {
            return this.Label_Add_Name.Text;
        }

        // Tinh tong tien
        public string Total(LinkedList<UserControl_Add> list)
        {
            int total = 0;
            foreach (UserControl_Add add in list)
            {
                total += add.GetQuantity() * add.GetPrice();
            }
            return Convert.ToString(total);
        }

        // Event
        private void Quantity_ValueChanged(object sender, EventArgs e)
        {
            bool found = false;
            foreach (UserControl_Add control in FormMain._FormAdd.FlowLayoutPanel_ListAdd.Controls)
            {
                if (control == this)
                {
                    FormMain._FormAdd.Label_Total.Text = Total(FormAdd.List_Add);
                    found = true;
                    break;
                }
            }
            if (found == false)
            {
                foreach (UserControl_Order control in FormMain._FormOrder.FlowLayoutPanel_Order.Controls)
                {
                    if (control.GetID_Order() == FormMain._FormOrder.Label_ID_Order.Text)
                    {
                        control.SetTotal(Total(control.ChildListAdd));
                        FormMain._FormOrder.Label_Total.Text = control.GetTotal();
                        found = true;
                        break;
                    }
                }
            }
            if (found == false)
            {
                foreach (UserControl_Table control in FormMain._FormTable.FlowLayoutPanel_Table.Controls)
                {
                    if (control.Label_ID_Table.Text == FormMain._FormTable.Label_ID_Table.Text)
                    {
                        control.Label_Total.Text = Total(control.ChildListAdd);
                        FormMain._FormTable.Label_Total.Text = control.Label_Total.Text;
                        found = true;
                        break;
                    }
                }
            }

        }
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            bool found = false;
            foreach (UserControl_Add control in FormMain._FormAdd.FlowLayoutPanel_ListAdd.Controls)
            {
                if ( control == this)
                {
                    foreach (UserControl_Item item in FormMain.List_Item)
                    {
                        if (item.UserControlAdd == control)
                        {
                            item.gunaGradientButton_tick.Visible = false;
                            item.gunaLinePanel_tick.Visible = false;
                            break;
                        }
                    }
                    control.SetQuantity(0);
                    FormAdd.List_Add.Remove(control);
                    control.Dispose();
                    found = true;
                    break;
                }
            }
            if (found == false)
            {
                foreach (UserControl_Add control in FormMain._FormOrder.FlowLayoutPanel_Bill.Controls)
                {
                    if (control == this)
                    {
                        control.SetQuantity(0);
                        UserControl_Order usercontrol_order = new UserControl_Order();
                        usercontrol_order.Remove_UserControlAdd(control);
                        control.Dispose(); 
                        found = true;
                        break;
                    }
                }
            }
            if (found == false)
            {
                foreach (UserControl_Add control in FormMain._FormTable.FlowLayoutPanel_Bill.Controls)
                {
                    if ( control == this)
                    {
                        control.SetQuantity(0);
                        UserControl_Table usercontrol_table = new UserControl_Table();
                        usercontrol_table.Remove_UserControlAdd(control);
                        control.Dispose();
                        break;
                    }
                }
            }
        }
    }
}
