using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAO;

namespace DOAN
{
    public partial class UserControl_Item : UserControl
    {
        // Fields
        private string _id;
        private int _category;
        private UserControl_Add _usercontroladd;

        // Properties
        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public int Category
        {
            get { return _category; }
            set { _category = value; }
        }
        public UserControl_Add UserControlAdd
        {
            get { return _usercontroladd; }
            set { _usercontroladd = value; }
        }
        public UserControl_Item()
        {
            InitializeComponent();
        }

        // Methods
        public string GetName()
        {
            return Label_Name.Text;
        }
        public int GetPrice()
        {
            return Convert.ToInt32(Label_Price.Text);
        }
        public void Change(Item item)
        {
            this.ID = item.ID_Item;
            this.Category = item.ID_Category;
            this.Label_Name.Text = item.Name;
            this.Label_Price.Text = Convert.ToString(item.Price);
            this.BackgroundImage =item.Photo;
        }

        //Click
        // Phu : click truyen du lieu
        private void Click_UserControl()
        {
            this.UserControlAdd = new UserControl_Add();
            FormAdd.List_Add.AddLast(this.UserControlAdd);
            FormMain._FormAdd.FlowLayoutPanel_ListAdd.Controls.Add(FormAdd.List_Add.Last.Value);
            FormAdd.List_Add.Last.Value.Show();
            FormAdd.List_Add.Last.Value.ChangeLabel(this.GetName(), this.GetPrice(), 1);
            FormMain._FormAdd.Label_Total.Text = this.UserControlAdd.Total(FormAdd.List_Add);
        }
        // Quynh Anh : click khung anh
        private void UserControl_Item_Click(object sender, EventArgs e)
        {
            if (gunaGradientButton_tick.Visible == false)
            {
                Click_UserControl();
                gunaGradientButton_tick.Visible = true;
                gunaLinePanel_tick.Visible = true;
            }
            else
            {
                gunaGradientButton_tick.Visible = false;
                gunaLinePanel_tick.Visible = false;
            }
        }

        private void gunaLinePanel_tick_Click(object sender, EventArgs e)
        {
            if (gunaGradientButton_tick.Visible == false)
            {
                gunaGradientButton_tick.Visible = true;
                gunaLinePanel_tick.Visible = true;
            }
            else
            {
                // Phu
                foreach (UserControl_Add control in FormMain._FormAdd.FlowLayoutPanel_ListAdd.Controls)
                {
                    if (control == _usercontroladd)
                    {
                        control.SetQuantity(0);
                        FormAdd.List_Add.Remove(control);
                        control.Dispose();
                    }
                }
                gunaGradientButton_tick.Visible = false;
                gunaLinePanel_tick.Visible = false;
            }
        }
    }
}
