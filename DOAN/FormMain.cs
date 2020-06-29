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
using Guna.UI.WinForms;
using Library;
using DAO;
using DTO;

namespace DOAN
{
    public partial class FormMain : Form
    {
        //Fields
        EventButton _EventBtn = new EventButton();
        public static FormAdd _FormAdd = new FormAdd();
        public static FormOrder _FormOrder = new FormOrder();
        public static FormTable _FormTable = new FormTable();
        public static LinkedList<UserControl_Item> List_Item = new LinkedList<UserControl_Item>();
        //Constructor
        public FormMain()
        {
            InitializeComponent();
        }


        // Methods
        // Data
        private void FormMain_Load(object sender, EventArgs e)
        {
            GetData();
        }
        private void GetData()
        {
            LinkedList<Item> listDAO = ItemDAO.Instance.GetItems();
            LinkedListNode<Item> nodeDAO = listDAO.First;
            while (nodeDAO != null)
            {
                UserControl_Item item = new UserControl_Item();
                item.Change(nodeDAO.Value);
                FormMain.List_Item.AddLast(item);
                nodeDAO = nodeDAO.Next;
            }
        }
        public static void LoadData(int category, Panel flowlayoutpanel)
        {
            GunaTransition guna = new GunaTransition();
            guna.AnimationType = Guna.UI.Animation.AnimationType.Transparent;
            flowlayoutpanel.Controls.Clear();
            flowlayoutpanel.Visible = false;
            LinkedListNode<UserControl_Item> node = List_Item.First;
            while (node != null)
            {
                if (node.Value.Category == category)
                {
                    flowlayoutpanel.Controls.Add(node.Value);
                    node = node.Next;
                }
                else node = node.Next;
            }
            guna.ShowSync(flowlayoutpanel);
        }
        // Click
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Btn_Home_Click(object sender, EventArgs e)
        {
            _EventBtn.DisableClickButton();
            _EventBtn.ClickBtn = (IconButton)sender;
            _EventBtn.ActivateButton(sender);
            Panel_Main.Visible = false;
        }
        public void Btn_Foods_Click(object sender, EventArgs e)
        {
            Panel_Main.Visible = false;
            _EventBtn.DisableClickButton();
            _EventBtn.ClickBtn = (IconButton)sender;
            _EventBtn.ActivateButton(sender);
            EventButton.OpenchildForm(new FormFood(), Panel_Menu);
            EventButton.OpenchildForm(_FormAdd, Panel_Add);
            Panel_Main.Visible = true;
        }
        private void Btn_Drinks_Click(object sender, EventArgs e)
        {
            Panel_Main.Visible = false;
            _EventBtn.DisableClickButton();
            _EventBtn.ClickBtn = (IconButton)sender;
            _EventBtn.ActivateButton(sender);
            EventButton.OpenchildForm(new FormDrinks(), Panel_Menu);
            EventButton.OpenchildForm(_FormAdd, Panel_Add);
            Panel_Main.Visible = true;
        }
        private void Btn_Order_Click(object sender, EventArgs e)
        {
            Panel_Main.Visible = false;
            _EventBtn.DisableClickButton();
            _EventBtn.ClickBtn = (IconButton)sender;
            _EventBtn.ActivateButton(sender);
            EventButton.OpenchildForm(_FormOrder, Panel_Main);
            Panel_Main.Visible = true;
        }
        private void Btn_Table_Click(object sender, EventArgs e)
        {
            Panel_Main.Visible = false;
            _EventBtn.DisableClickButton();
            _EventBtn.ClickBtn = (IconButton)sender;
            _EventBtn.ActivateButton(sender);
            EventButton.OpenchildForm(_FormTable, Panel_Main);
            Panel_Main.Visible = true;
        }
        private void Btn_Revenue_Click(object sender, EventArgs e)
        {
            Panel_Main.Visible = false;
            if (UserCache.permission == 0)
            {
                MessageBox.Show("Dành cho Admin");
            }
            else
            {
                _EventBtn.DisableClickButton();
                _EventBtn.ClickBtn = (IconButton)sender;
                _EventBtn.ActivateButton(sender);
                EventButton.OpenchildForm(new FormRevenue(), Panel_Main);
            }
            Panel_Main.Visible = true;
        }

        // mouse move
        private void Btn_Home_MouseMove(object sender, MouseEventArgs e)
        {
            _EventBtn.DisableButton();
            _EventBtn.ActivateButton(sender);
        }
        private void Btn_Foods_MouseMove(object sender, MouseEventArgs e)
        {
            _EventBtn.DisableButton();
            _EventBtn.ActivateButton(sender);
        }
        private void Btn_Drinks_MouseMove(object sender, MouseEventArgs e)
        {
            _EventBtn.DisableButton();
            _EventBtn.ActivateButton(sender);
        }
        private void Btn_Order_MouseMove(object sender, MouseEventArgs e)
        {
            _EventBtn.DisableButton();
            _EventBtn.ActivateButton(sender);
        }
        private void Btn_Table_MouseMove(object sender, MouseEventArgs e)
        {
            _EventBtn.DisableButton();
            _EventBtn.ActivateButton(sender);
        }
        private void Btn_Revenue_MouseMove(object sender, MouseEventArgs e)
        {
            _EventBtn.DisableButton();
            _EventBtn.ActivateButton(sender);
        }

        // Mouse Leave
        private void Btn_Home_MouseLeave(object sender, EventArgs e)
        {
            _EventBtn.DisableButton();
        }
        private void Btn_Foods_MouseLeave(object sender, EventArgs e)
        {
            _EventBtn.DisableButton();
        }
        private void Btn_Drinks_MouseLeave(object sender, EventArgs e)
        {
            _EventBtn.DisableButton();
        }
        private void Btn_Order_MouseLeave(object sender, EventArgs e)
        {
            _EventBtn.DisableButton();
        }
        private void Btn_Table_MouseLeave(object sender, EventArgs e)
        {
            _EventBtn.DisableButton();
        }
        private void Btn_Revenue_MouseLeave(object sender, EventArgs e)
        {
            _EventBtn.DisableButton();
        }


        // Mouse Down
        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                EventButton.ReleaseCapture();
                EventButton.SendMessage(this.Handle, EventButton.WM_NCLBUTTONDOWN, EventButton.HT_CAPTION, 0);
            }
        }
        private void Panel_Menu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                EventButton.ReleaseCapture();
                EventButton.SendMessage(this.Handle, EventButton.WM_NCLBUTTONDOWN, EventButton.HT_CAPTION, 0);
            }
        }
        private void Btn_Maximize_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                EventButton.ReleaseCapture();
                EventButton.SendMessage(this.Handle, EventButton.WM_NCLBUTTONDOWN, EventButton.HT_CAPTION, 0);
            }
        }

    }
}
