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
    public partial class FormLoading : Form
    {
        public FormLoading()
        {
            InitializeComponent();
            this.BackColor = Color.LightSeaGreen;
            this.TransparencyKey = Color.LightSeaGreen;
        }
        // hien form tu tu
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.04;
            if (this.Opacity == 1)
            {
                timer1.Stop();
                timer2.Start();
            }
        }
        // thuc hien lam mo form
        private void timer2_Tick(object sender, EventArgs e) 
        {
            this.Opacity -= 0.1;
            if ( this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }
        }
        private void FormLoading_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            timer1.Start();
        }
    }
}
