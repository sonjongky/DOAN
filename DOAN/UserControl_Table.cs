using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI.WinForms;
using System.Windows.Forms;
using DAO;
using DTO;

namespace DOAN
{
    public partial class UserControl_Table : UserControl
    {
        // Fields
        private LinkedList<UserControl_Add> Child_List_Add;
        private bool Collapse = false;


        // Properties
        public LinkedList<UserControl_Add> ChildListAdd
        {
            get { return Child_List_Add; }
            set { Child_List_Add = value; }
        }


        public void Remove_UserControlAdd(UserControl_Add usercontrol_add)
        {
            foreach (UserControl_Table control in FormMain._FormTable.FlowLayoutPanel_Table.Controls)
            {
                if (control.Label_ID_Table.Text == FormMain._FormTable.Label_ID_Table.Text)
                {
                    control.Child_List_Add.Remove(usercontrol_add);
                }
            }
        }
        // Constructor
        public UserControl_Table()
        {
            InitializeComponent();
        }

        // chuyen du lieu tu DAO
        public void LoadData_Table(FlowLayoutPanel flowlayoutpanel)
        {
            LinkedList<int> listDAO = TableDAO.Instance.GetIDTable();
            for (int i = 1; i <= listDAO.Count; i++)
            {
                UserControl_Table a = new UserControl_Table();
                a.Label_ID_Table.Text = i.ToString();
                flowlayoutpanel.Controls.Add(a);
            }
        }

        // Set thong tin cho US_Table
        public void SetChildListAdd(LinkedList<UserControl_Add> List)
        {
            FormMain._FormTable.FlowLayoutPanel_Bill.Controls.Clear();
            if (ChildListAdd == null)   Child_List_Add = new LinkedList<UserControl_Add>();
            LinkedListNode<UserControl_Add> node_list = List.First;
            LinkedListNode<UserControl_Add> node_this = this.ChildListAdd.First;
            bool found = false;
            while (node_list != null)
            {
                while ( node_this != null)
                {
                    if (node_this.Value.GetName() == node_list.Value.GetName())
                    {
                        found = true;
                        int soluong = node_this.Value.GetQuantity() + node_list.Value.GetQuantity();
                        node_this.Value.SetQuantity(soluong);
                        break;
                    }
                    else node_this = node_this.Next;
                }
                if ( found == false)
                {
                    this.ChildListAdd.AddLast(node_list.Value);
                }
                else
                {
                    found = false;
                }
                this.Label_Total.Text = this.ChildListAdd.Last.Value.Total(ChildListAdd);
                node_list = node_list.Next;
                node_this = this.ChildListAdd.First;
            }
        }
        public void SetTotal(string total)
        {
            this.Label_Total.Text = total;
        }


        // Click drop down panel
        private void Btn_Ellipsis_Click(object sender, EventArgs e)
        {
            if (Collapse == false)
            {
                gunaTransition1.ShowSync(panel1);
                Collapse = true;
            }
            else
            {
                gunaTransition1.HideSync(panel1);
                Collapse = false;
            }

        }


        // Click
        private void UserControl_Table_Click(object sender, EventArgs e)
        {
            if (Label_Status.Text == "Có khách")
            {
                FormMain._FormTable.FlowLayoutPanel_Bill.Controls.Clear();
                foreach (UserControl_Add control in Child_List_Add)
                {
                    FormMain._FormTable.FlowLayoutPanel_Bill.Controls.Add(control);
                    control.Show();
                }
                FormMain._FormTable.Label_ID_Table.Text = this.Label_ID_Table.Text;
                FormMain._FormTable.Label_Total.Text = this.Label_Total.Text;
            }
            else 
            {
                FormMain._FormTable.FlowLayoutPanel_Bill.Controls.Clear();
                FormMain._FormTable.Label_ID_Table.Text = this.Label_ID_Table.Text;
                FormMain._FormTable.Label_Total.Text = 0.ToString();
            }
        }

        private void Btn_TinhTien_Click(object sender, EventArgs e)
        {
            if ( ChildListAdd == null)
            {
                MessageBox.Show("Bàn Trống !");
            }
            else if (ChildListAdd.Count == 0)
            {
                MessageBox.Show("Không có món nào trong bàn này."); 
            }
            else
            {
                string id_bill;
                id_bill = ItemDAO.Instance.Get_MAX_ID_Bill();
                foreach (UserControl_Add add in Child_List_Add)
                {
                    ItemDAO.Instance.Insert(id_bill, UserCache.name, this.Label_ID_Table.Text, add.GetName(), add.GetQuantity().ToString());
                }
            }


            // transition
            gunaTransition1.HideSync(panel1);
            Collapse = false;
            Btn_HuyBill_Click(Btn_HuyBill, e);
        }

        private void Btn_ThemMon_Click(object sender, EventArgs e)
        {
            FormLogin._FormMain.Btn_Foods_Click(FormLogin._FormMain.Btn_Foods, e);
            FormMain._FormAdd.Combobox_ID_Table.Text = this.Label_ID_Table.Text;
            FormMain._FormTable.SetDefault();
            gunaTransition1.HideSync(panel1);
            Collapse = false;
        }

        private void Btn_HuyBill_Click(object sender, EventArgs e)
        {
            if (ChildListAdd == null)
            {

            }
            else
            {
                ChildListAdd.Clear();
                this.Label_Status.Text = "Trống";
                this.Label_Total.Text = "0";
                this.BackgroundImage = Image.FromFile(@"C:\Users\ABC\Desktop\DOAN_NET\image\Background\2.png");
                FormMain._FormTable.SetDefault();
                gunaTransition1.HideSync(panel1);
                Collapse = false;
            }
        }
    }
}
