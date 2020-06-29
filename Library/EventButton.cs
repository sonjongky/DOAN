using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public class EventButton
    {
        //Fields
        public IconButton CurrentBtn;
        public IconButton ClickBtn;


        // Methods
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                CurrentBtn = (IconButton)senderBtn;
                CurrentBtn.BackgroundImage = Image.FromFile(@"C:\Users\ABC\Desktop\DOAN_NET\image\Background\1.png");
                CurrentBtn.ForeColor = Color.White;
                CurrentBtn.IconColor = Color.White;
            }
        }
        public void DisableButton()
        {
            if (CurrentBtn != null && ClickBtn != CurrentBtn)
            {
                CurrentBtn.BackgroundImage = null;
                CurrentBtn.ForeColor = Color.DimGray;
                CurrentBtn.IconColor = Color.DimGray;
            }
        }
        public void DisableClickButton()
        {
            if (ClickBtn != null)
            {
                ClickBtn.BackgroundImage = null;
                ClickBtn.ForeColor = Color.DimGray;
                ClickBtn.IconColor = Color.DimGray;
            }
        }

        // Child Form
        public void ChildFormMouseMove(object senderBtn)
        {
            if (senderBtn != null)
            {
                CurrentBtn = (IconButton)senderBtn;
                CurrentBtn.BackgroundImage = Image.FromFile(@"C:\Users\ABC\Desktop\DOAN_NET\image\Background\2.png");
                /*CurrentBtn.UseVisualStyleBackColor = false; 
                CurrentBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, Color.Black);*/
                CurrentBtn.ForeColor = Color.White;
                CurrentBtn.IconColor = Color.White;
            }
        }
        public void ChildFormActiveClickButton()
        {
            if (ClickBtn != null)
            {
                ClickBtn.BackgroundImage = null;
                ClickBtn.ForeColor = Color.White;
                ClickBtn.IconColor = Color.White;
            }
        }
        public void ChildFormDisableButton()
        {
            if (CurrentBtn != null && ClickBtn != CurrentBtn)
            {
                CurrentBtn.BackgroundImage = null;
                CurrentBtn.BackColor = Color.Transparent;
                CurrentBtn.ForeColor = Color.DimGray;
                CurrentBtn.IconColor = Color.DimGray;
            }
            else if (ClickBtn == CurrentBtn)
            {
                ClickBtn.BackgroundImage = null;
            }
        }
        public void ChildFormDisableClickButton()
        {
            if (ClickBtn != null)
            {
                ClickBtn.BackgroundImage = null;
                ClickBtn.BackColor = Color.Transparent;
                ClickBtn.ForeColor = Color.DimGray;
                ClickBtn.IconColor = Color.DimGray;
            }
        }
        public static void OpenchildForm(Form ChildForm ,Panel panel)
        {
            panel.BringToFront();
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel.Controls.Add(ChildForm);
            ChildForm.BringToFront();
            ChildForm.Show();
        }
    }
}
