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

namespace DOAN
{
    public partial class FormDrinks : Form
    {
        //Fields
        const int id_coffee = 0;
        const int id_juice = 1;
        const int id_smoothies = 2;
        const int id_ice_blend = 3;
        EventButton eventButton = new EventButton();

        // Constructor
        public FormDrinks()
        {
            InitializeComponent();
        }
        private void FormDrinks_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.ScrollBar.PanelScrollHelper Pan = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(FLowLayoutPanel_Drinks, gunaVScrollBar1, true);
            gunaTransition1.ShowSync(Panel_Drinks);
        }


        // Mouse Move
        private void Btn_Coffee_MouseMove(object sender, MouseEventArgs e)
        {
            eventButton.ChildFormMouseMove(sender);
        }
        private void Btn_Tea_MouseMove(object sender, MouseEventArgs e)
        {
            eventButton.ChildFormMouseMove(sender);
        }
        private void Btn_Smoothies_MouseMove(object sender, MouseEventArgs e)
        {
            eventButton.ChildFormMouseMove(sender);
        }
        private void Btn_Ice_Blend_MouseMove(object sender, MouseEventArgs e)
        {
            eventButton.ChildFormMouseMove(sender);
        }


        //Mouse Leave
        private void Btn_Coffee_MouseLeave(object sender, EventArgs e)
        {
            eventButton.ChildFormDisableButton();
        }
        private void Btn_Tea_MouseLeave(object sender, EventArgs e)
        {
            eventButton.ChildFormDisableButton();
        }
        private void Btn_Smoothies_MouseLeave(object sender, EventArgs e)
        {
            eventButton.ChildFormDisableButton();
        }
        private void Btn_Ice_Blend_MouseLeave(object sender, EventArgs e)
        {
            eventButton.ChildFormDisableButton();
        }


        // Mouse Click
        private void Btn_Coffee_Click(object sender, EventArgs e)
        {
            eventButton.ChildFormDisableClickButton();
            eventButton.ClickBtn = (IconButton)sender;
            eventButton.ChildFormActiveClickButton();
            FormMain.LoadData(id_coffee, FLowLayoutPanel_Drinks);
        }
        private void Btn_Juice_Click(object sender, EventArgs e)
        {
            eventButton.ChildFormDisableClickButton();
            eventButton.ClickBtn = (IconButton)sender;
            eventButton.ChildFormActiveClickButton();
            FormMain.LoadData(id_juice, FLowLayoutPanel_Drinks);
        }
        private void Btn_Smoothies_Click(object sender, EventArgs e)
        {
            eventButton.ChildFormDisableClickButton();
            eventButton.ClickBtn = (IconButton)sender;
            eventButton.ChildFormActiveClickButton();
            FormMain.LoadData(id_smoothies, FLowLayoutPanel_Drinks);
        }
        private void Btn_IceBlend_Click(object sender, EventArgs e)
        {
            eventButton.ChildFormDisableClickButton();
            eventButton.ClickBtn = (IconButton)sender;
            eventButton.ChildFormActiveClickButton();
            FormMain.LoadData(id_ice_blend, FLowLayoutPanel_Drinks);
        }



        // Search
        int second = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (second == 0)
            {
                second = 1;
            }
            else if (second == 1)
            {
                timer1.Stop();
                second = 0;
                gunaTransition1.ShowSync(FLowLayoutPanel_Drinks);
            }
        }
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            FLowLayoutPanel_Drinks.Controls.Clear();
            FLowLayoutPanel_Drinks.Visible = false;
            if (string.IsNullOrEmpty(txt_search.Text) == false)
            {
                foreach (UserControl_Item control in FormMain.List_Item)
                {
                    if (control.GetName().Contains(txt_search.Text) || control.GetName().Contains(txt_search.Text.ToUpper()))
                    {
                        FLowLayoutPanel_Drinks.Controls.Add(control);
                    }
                }
            }
            else if (txt_search.Text == "")
            {
                foreach (IconButton btn in Panel_Drinks.Controls)
                {
                    if (eventButton.ClickBtn == btn)
                    {
                        btn.PerformClick();
                    }
                }
            }
            timer1.Start();
        }

    }
}
