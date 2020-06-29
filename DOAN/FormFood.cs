using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN
{
    public partial class FormFood : Form
    {
        const int id_food = 4;

        // Constructor
        public FormFood()
        {
            InitializeComponent();

        }

        // Load
        private void FormFood_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.ScrollBar.PanelScrollHelper Pan = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(FlowLayoutPanel_Food, gunaVScrollBar2, true);
            gunaTransition1.ShowSync(Panel_Food);
            FormMain.LoadData(id_food, FlowLayoutPanel_Food);
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
                gunaTransition1.ShowSync(FlowLayoutPanel_Food);
            }
        }
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            FlowLayoutPanel_Food.Controls.Clear();
            FlowLayoutPanel_Food.Visible = false;
            if (string.IsNullOrEmpty(txt_search.Text) == false)
            {
                foreach (UserControl_Item control in FormMain.List_Item)
                {
                    if (control.GetName().Contains(txt_search.Text) || control.GetName().Contains(txt_search.Text.ToUpper()) )
                    {
                        FlowLayoutPanel_Food.Controls.Add(control);
                    }
                }
            }
            else if (txt_search.Text == "")
            {
                FormMain.LoadData(id_food, FlowLayoutPanel_Food);
            }
            timer1.Start();
        }

    }
}
