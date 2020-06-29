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
using DTO;

namespace DOAN
{
    public partial class FormAdd : Form
    {
        //Fields
        public static LinkedList<UserControl_Add> List_Add = new LinkedList<UserControl_Add>();
        public FormAdd()
        {
            InitializeComponent();
        }

        // Loads
        private void FormAdd_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.ScrollBar.PanelScrollHelper Pan = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(FlowLayoutPanel_ListAdd, gunaVScrollBar1, true);
            TableDAO.Instance.FillComboBox(this.Combobox_ID_Table);
        }

        // Click
        private void SetDefault()
        {
            FlowLayoutPanel_ListAdd.Controls.Clear();
            List_Add.Clear();
            List_Add = new LinkedList<UserControl_Add>();
            LinkedListNode<UserControl_Item> node = FormMain.List_Item.First;
            while (node != null)
            {
                node.Value.gunaGradientButton_tick.Visible = false;
                node.Value.gunaLinePanel_tick.Visible = false;
                node = node.Next;
            }
            FormMain._FormAdd.Label_Total.Text = "0";
            FormMain._FormAdd.Combobox_ID_Table.Text = "";
        }
        private void SetIdOrder()
        {
            if (FormOrder.List_Order.Count == 0)
            {
                UserControl_Order.ID_Order = 1;
            }
            else
            {
                UserControl_Order.ID_Order = Convert.ToInt32(FormOrder.List_Order.Last.Value.GetID_Order()) + 1;
            }
        }
        private void Btn_TaoOrder_Click(object sender, EventArgs e)
        {
            if ( FormAdd.List_Add.Count == 0)
            {
                this.SetDefault();
            }
            else
            {
                SetIdOrder();
                UserControl_Order usercontrol_order = new UserControl_Order();
                usercontrol_order.Label_ID_Table.Text = this.Combobox_ID_Table.Text;
                usercontrol_order.SetTotal(FormMain._FormAdd.Label_Total.Text);
                usercontrol_order.SetChildListAdd();
                FormOrder.List_Order.AddLast(usercontrol_order);
                FormMain._FormOrder.FlowLayoutPanel_Order.Controls.Add(FormOrder.List_Order.Last.Value);
                this.SetDefault();
            }
        }
        private void Btn_ThemMon_Click(object sender, EventArgs e)
        {
            UserControl_Order usercontrol_order = new UserControl_Order();
            usercontrol_order.SetChildListAdd();
            LinkedListNode<UserControl_Order> node = FormOrder.List_Order.First;
            while( node != null)
            {
                if (node.Value.GetID_Order() == usercontrol_order.GetID_Order())
                {
                    node.Value.Update(usercontrol_order.ChildListAdd);
                    break;
                }
                else node = node.Next;
            }
            FormMain._FormAdd.Panel_Button.Visible = true;
            FormMain._FormAdd.Panel_Button.BringToFront();
            FormMain._FormAdd.Panel_ButtonThem.Visible = false;
            FormMain._FormAdd.Label_ID_Order.Visible = false;
            FormMain._FormAdd.gunaLabel3.Visible = false;
            FormMain._FormAdd.Combobox_ID_Table.Enabled = true;
            this.SetDefault();
        }
        private void Btn_HuyThem_Click(object sender, EventArgs e)
        {
            FormMain._FormAdd.Panel_Button.Visible = true;
            FormMain._FormAdd.Panel_Button.BringToFront();
            FormMain._FormAdd.Panel_ButtonThem.Visible = false;
            FormMain._FormAdd.Label_ID_Order.Visible = false;
            FormMain._FormAdd.gunaLabel3.Visible = false;
            FormMain._FormAdd.Combobox_ID_Table.Enabled = true;
            this.SetDefault();
        }
        // Combobox
        private void Combobox_ID_Table_Click(object sender, EventArgs e)
        {
            Combobox_ID_Table.BaseColor = Color.White;
        }
        private void Combobox_ID_Table_SelectedValueChanged(object sender, EventArgs e)
        {
            Combobox_ID_Table.BaseColor = Color.Transparent;
        }
    }
}
