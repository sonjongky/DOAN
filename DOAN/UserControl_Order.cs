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
    public partial class UserControl_Order : UserControl
    {
        // Fields
        int minute = 0, second = 0;
        LinkedList<UserControl_Add> Child_List_Add;
        public static int ID_Order = 1;
        
        
        // constructor
        public UserControl_Order()
        {
            InitializeComponent();
            timer1.Start();
        }

        // Properties
        public LinkedList<UserControl_Add> ChildListAdd
        {
            get { return Child_List_Add; }
            set { Child_List_Add = value; }
        }

        // Methods
        public void SetChildListAdd()
        {
            this.Label_ID_Order.Text = ID_Order.ToString();
            Child_List_Add = new LinkedList<UserControl_Add>();
            LinkedListNode<UserControl_Add> node_list = FormAdd.List_Add.First;
            while (node_list != null)
            {
                Child_List_Add.AddLast(node_list.Value);
                node_list = node_list.Next;
            }
        }
        public void SetTotal(string total)
        {
            this.Label_Total.Text = total;
        }
        public string GetTotal()
        {
           return this.Label_Total.Text;
        }
        public string GetID_Order()
        {
            return this.Label_ID_Order.Text;
        }


        public void Remove_UserControlAdd(UserControl_Add usercontrol_add)
        {
            foreach (UserControl_Order control in FormMain._FormOrder.FlowLayoutPanel_Order.Controls)
            {
                if (control.Label_ID_Order.Text == FormMain._FormOrder.Label_ID_Order.Text)
                {
                    control.Child_List_Add.Remove(usercontrol_add);
                }
            }
        }
        public void Update(LinkedList<UserControl_Add> listusercontrol_add)
        {
            FormMain._FormOrder.FlowLayoutPanel_Bill.Controls.Clear();
            LinkedListNode<UserControl_Add> node = listusercontrol_add.First;
            LinkedListNode<UserControl_Add> node_this = this.Child_List_Add.First;
            bool found = false;
            while (node != null)
            {
                while (node_this != null)
                {
                    if (node_this.Value.GetName() == node.Value.GetName())
                    {
                        found = true;
                        int soluong = node_this.Value.GetQuantity() + node.Value.GetQuantity();
                        node_this.Value.SetQuantity(soluong);
                        break;
                    }
                    else node_this = node_this.Next;
                }
                if (found == false)
                {
                    this.Child_List_Add.AddLast(node.Value);
                }
                else
                {
                    found = false;
                }
                this.Label_Total.Text = this.ChildListAdd.Last.Value.Total(ChildListAdd);
                node = node.Next;
                node_this = this.Child_List_Add.First;
            }
        }
        
        
        // Click
        private void click()
        {
            FormMain._FormOrder.FlowLayoutPanel_Bill.Controls.Clear();
            foreach (UserControl_Add control in Child_List_Add)
            {
                FormMain._FormOrder.FlowLayoutPanel_Bill.Controls.Add(control);
                control.Show();
            }
            FormMain._FormOrder.Label_ID_Order.Text = this.Label_ID_Order.Text;
            FormMain._FormOrder.Combobox_ID_Table.Text = this.Label_ID_Table.Text;
            FormMain._FormOrder.Label_Total.Text = this.Label_Total.Text;
        }
        private void UserControl_Order_Click(object sender, EventArgs e)
        {
            click();
        }
        private void gunaGradient2Panel1_Click(object sender, EventArgs e)
        {
            click();
        }
        private void gunaGradient2Panel2_Click(object sender, EventArgs e)
        {
            click();
        }
        private void gunaGradient2Panel3_Click(object sender, EventArgs e)
        {
            click();
        }
        private void gunaGradient2Panel4_Click(object sender, EventArgs e)
        {
            click();
        }
        
        public void Btn_Delete_Click(object sender, EventArgs e)
        {
            foreach (UserControl_Order control in FormMain._FormOrder.FlowLayoutPanel_Order.Controls)
            {
                if (control == this)
                {
                    if (control.Label_ID_Order.Text == FormMain._FormOrder.Label_ID_Order.Text)
                    {
                        FormMain._FormOrder.FlowLayoutPanel_Bill.Controls.Clear();
                    }
                    FormOrder.List_Order.Remove(control);
                    control.Dispose();
                    break;
                }
            }
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (second < 59)
            {
                second++;
                Label_Clock.Text = minute.ToString() + ":" + second.ToString();
            }
            else
            {
                second = 0;
                minute++;
                Label_Clock.Text = minute.ToString()+":" + second.ToString();
            }
        }
    }
}
