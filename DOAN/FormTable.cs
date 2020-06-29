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
    public partial class FormTable : Form
    {
        public FormTable()
        {
            InitializeComponent();
            UserControl_Table usercontrol_table = new UserControl_Table();
            usercontrol_table.LoadData_Table(FlowLayoutPanel_Table);
        }

        private void FormTable_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.ScrollBar.PanelScrollHelper Pan = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(FlowLayoutPanel_Table,gunaVScrollBar1,true);
            Guna.UI.Lib.ScrollBar.PanelScrollHelper Pan1 = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(FlowLayoutPanel_Bill, gunaVScrollBar2, true);
        }

        public void SetDefault()
        {
            this.Label_ID_Table.Text = "";
            this.Label_Total.Text = "0";
            this.FlowLayoutPanel_Bill.Controls.Clear();
        }
    }
}
