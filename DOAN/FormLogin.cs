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
using Library;

namespace DOAN
{
    public partial class FormLogin : Form
    {
        public static FormMain _FormMain = new FormMain();
        public FormLogin()
        {
            InitializeComponent();
        }
        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                EventButton.ReleaseCapture();
                EventButton.SendMessage(this.Handle, EventButton.WM_NCLBUTTONDOWN, EventButton.HT_CAPTION, 0);
            }
        }
        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                EventButton.ReleaseCapture();
                EventButton.SendMessage(this.Handle, EventButton.WM_NCLBUTTONDOWN, EventButton.HT_CAPTION, 0);
            }
        }

        private void messageError(string message)
        {
            label_Error.Text = message;
            label_Error.Visible = true;
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_user.Text != "User")
            {
                if (txt_pass.Text != "Password")
                {
                    var Valid_Login = UserDAO.Instance.Login(txt_user.Text, txt_pass.Text);
                    if (Valid_Login == true)
                    {
                        this.Hide();/*
                        FormLoading form_load = new FormLoading();
                        form_load.ShowDialog();*/
                        _FormMain.Show();
                    }
                    else
                    {
                        messageError("Sai tên đăng nhập hoăc mật khẩu ! \nVui lòng thử lại !");
                        txt_pass.Text = "";
                        txt_user.Focus();
                    }
                }
                else
                {
                    messageError("Nhập mật khẩu !");
                }
            }
            else messageError("Sai tên đăng nhập hoăc mật khẩu ! \nVui lòng thử lại !");
        }
    }
}

