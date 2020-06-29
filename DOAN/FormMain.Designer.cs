namespace DOAN
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI.Animation.Animation animation1 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.Panel_Logo = new System.Windows.Forms.Panel();
            this.Btn_Revenue = new FontAwesome.Sharp.IconButton();
            this.Btn_Table = new FontAwesome.Sharp.IconButton();
            this.Btn_Order = new FontAwesome.Sharp.IconButton();
            this.Btn_Home = new FontAwesome.Sharp.IconButton();
            this.Btn_Foods = new FontAwesome.Sharp.IconButton();
            this.Btn_Drinks = new FontAwesome.Sharp.IconButton();
            this.Panel_Main = new System.Windows.Forms.Panel();
            this.Panel_Add = new System.Windows.Forms.Panel();
            this.Panel_Menu = new System.Windows.Forms.Panel();
            this.Btn_Close = new Guna.UI.WinForms.GunaControlBox();
            this.Btn_minimize = new Guna.UI.WinForms.GunaControlBox();
            this.gunaTransition1 = new Guna.UI.WinForms.GunaTransition(this.components);
            this.Btn_Maximize = new Guna.UI.WinForms.GunaControlBox();
            this.Panel_Logo.SuspendLayout();
            this.Panel_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Logo
            // 
            this.Panel_Logo.Controls.Add(this.Btn_Revenue);
            this.Panel_Logo.Controls.Add(this.Btn_Table);
            this.Panel_Logo.Controls.Add(this.Btn_Order);
            this.Panel_Logo.Controls.Add(this.Btn_Home);
            this.Panel_Logo.Controls.Add(this.Btn_Foods);
            this.Panel_Logo.Controls.Add(this.Btn_Drinks);
            this.gunaTransition1.SetDecoration(this.Panel_Logo, Guna.UI.Animation.DecorationType.None);
            this.Panel_Logo.Location = new System.Drawing.Point(0, 0);
            this.Panel_Logo.Name = "Panel_Logo";
            this.Panel_Logo.Size = new System.Drawing.Size(100, 650);
            this.Panel_Logo.TabIndex = 2;
            // 
            // Btn_Revenue
            // 
            this.Btn_Revenue.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Revenue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaTransition1.SetDecoration(this.Btn_Revenue, Guna.UI.Animation.DecorationType.None);
            this.Btn_Revenue.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.Btn_Revenue.FlatAppearance.BorderSize = 0;
            this.Btn_Revenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Revenue.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Btn_Revenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Revenue.ForeColor = System.Drawing.Color.DimGray;
            this.Btn_Revenue.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.Btn_Revenue.IconColor = System.Drawing.Color.DimGray;
            this.Btn_Revenue.IconSize = 50;
            this.Btn_Revenue.Location = new System.Drawing.Point(-5, 434);
            this.Btn_Revenue.Name = "Btn_Revenue";
            this.Btn_Revenue.Rotation = 0D;
            this.Btn_Revenue.Size = new System.Drawing.Size(113, 80);
            this.Btn_Revenue.TabIndex = 12;
            this.Btn_Revenue.Text = "Doanh thu";
            this.Btn_Revenue.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Btn_Revenue.UseVisualStyleBackColor = false;
            this.Btn_Revenue.Click += new System.EventHandler(this.Btn_Revenue_Click);
            this.Btn_Revenue.MouseLeave += new System.EventHandler(this.Btn_Revenue_MouseLeave);
            this.Btn_Revenue.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Revenue_MouseMove);
            // 
            // Btn_Table
            // 
            this.Btn_Table.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Table.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaTransition1.SetDecoration(this.Btn_Table, Guna.UI.Animation.DecorationType.None);
            this.Btn_Table.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.Btn_Table.FlatAppearance.BorderSize = 0;
            this.Btn_Table.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Table.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Btn_Table.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Table.ForeColor = System.Drawing.Color.DimGray;
            this.Btn_Table.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.Btn_Table.IconColor = System.Drawing.Color.DimGray;
            this.Btn_Table.IconSize = 47;
            this.Btn_Table.Location = new System.Drawing.Point(0, 354);
            this.Btn_Table.Name = "Btn_Table";
            this.Btn_Table.Rotation = 0D;
            this.Btn_Table.Size = new System.Drawing.Size(100, 80);
            this.Btn_Table.TabIndex = 11;
            this.Btn_Table.Text = "Bàn";
            this.Btn_Table.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Table.UseVisualStyleBackColor = false;
            this.Btn_Table.Click += new System.EventHandler(this.Btn_Table_Click);
            this.Btn_Table.MouseLeave += new System.EventHandler(this.Btn_Table_MouseLeave);
            this.Btn_Table.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Table_MouseMove);
            // 
            // Btn_Order
            // 
            this.Btn_Order.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Order.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaTransition1.SetDecoration(this.Btn_Order, Guna.UI.Animation.DecorationType.None);
            this.Btn_Order.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.Btn_Order.FlatAppearance.BorderSize = 0;
            this.Btn_Order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Order.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Btn_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Order.ForeColor = System.Drawing.Color.DimGray;
            this.Btn_Order.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.Btn_Order.IconColor = System.Drawing.Color.DimGray;
            this.Btn_Order.IconSize = 47;
            this.Btn_Order.Location = new System.Drawing.Point(0, 274);
            this.Btn_Order.Name = "Btn_Order";
            this.Btn_Order.Rotation = 0D;
            this.Btn_Order.Size = new System.Drawing.Size(100, 80);
            this.Btn_Order.TabIndex = 10;
            this.Btn_Order.Text = "Order";
            this.Btn_Order.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Order.UseVisualStyleBackColor = false;
            this.Btn_Order.Click += new System.EventHandler(this.Btn_Order_Click);
            this.Btn_Order.MouseLeave += new System.EventHandler(this.Btn_Order_MouseLeave);
            this.Btn_Order.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Order_MouseMove);
            // 
            // Btn_Home
            // 
            this.Btn_Home.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaTransition1.SetDecoration(this.Btn_Home, Guna.UI.Animation.DecorationType.None);
            this.Btn_Home.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.Btn_Home.FlatAppearance.BorderSize = 0;
            this.Btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Home.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Btn_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Home.ForeColor = System.Drawing.Color.DimGray;
            this.Btn_Home.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.Btn_Home.IconColor = System.Drawing.Color.DimGray;
            this.Btn_Home.IconSize = 45;
            this.Btn_Home.Location = new System.Drawing.Point(0, 34);
            this.Btn_Home.Name = "Btn_Home";
            this.Btn_Home.Rotation = 0D;
            this.Btn_Home.Size = new System.Drawing.Size(100, 80);
            this.Btn_Home.TabIndex = 11;
            this.Btn_Home.Text = "Home";
            this.Btn_Home.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Home.UseVisualStyleBackColor = false;
            this.Btn_Home.Click += new System.EventHandler(this.Btn_Home_Click);
            this.Btn_Home.MouseLeave += new System.EventHandler(this.Btn_Home_MouseLeave);
            this.Btn_Home.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Home_MouseMove);
            // 
            // Btn_Foods
            // 
            this.Btn_Foods.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Foods.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaTransition1.SetDecoration(this.Btn_Foods, Guna.UI.Animation.DecorationType.None);
            this.Btn_Foods.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.Btn_Foods.FlatAppearance.BorderSize = 0;
            this.Btn_Foods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Foods.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Btn_Foods.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Foods.ForeColor = System.Drawing.Color.DimGray;
            this.Btn_Foods.IconChar = FontAwesome.Sharp.IconChar.Hamburger;
            this.Btn_Foods.IconColor = System.Drawing.Color.DimGray;
            this.Btn_Foods.IconSize = 40;
            this.Btn_Foods.Location = new System.Drawing.Point(0, 114);
            this.Btn_Foods.Name = "Btn_Foods";
            this.Btn_Foods.Rotation = 0D;
            this.Btn_Foods.Size = new System.Drawing.Size(100, 80);
            this.Btn_Foods.TabIndex = 10;
            this.Btn_Foods.Text = "Thức ăn";
            this.Btn_Foods.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Foods.UseVisualStyleBackColor = false;
            this.Btn_Foods.Click += new System.EventHandler(this.Btn_Foods_Click);
            this.Btn_Foods.MouseLeave += new System.EventHandler(this.Btn_Foods_MouseLeave);
            this.Btn_Foods.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Foods_MouseMove);
            // 
            // Btn_Drinks
            // 
            this.Btn_Drinks.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Drinks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaTransition1.SetDecoration(this.Btn_Drinks, Guna.UI.Animation.DecorationType.None);
            this.Btn_Drinks.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.Btn_Drinks.FlatAppearance.BorderSize = 0;
            this.Btn_Drinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Drinks.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Btn_Drinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Drinks.ForeColor = System.Drawing.Color.DimGray;
            this.Btn_Drinks.IconChar = FontAwesome.Sharp.IconChar.GlassCheers;
            this.Btn_Drinks.IconColor = System.Drawing.Color.DimGray;
            this.Btn_Drinks.IconSize = 50;
            this.Btn_Drinks.Location = new System.Drawing.Point(0, 194);
            this.Btn_Drinks.Name = "Btn_Drinks";
            this.Btn_Drinks.Rotation = 0D;
            this.Btn_Drinks.Size = new System.Drawing.Size(100, 80);
            this.Btn_Drinks.TabIndex = 9;
            this.Btn_Drinks.Text = "Đồ uống";
            this.Btn_Drinks.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Drinks.UseVisualStyleBackColor = false;
            this.Btn_Drinks.Click += new System.EventHandler(this.Btn_Drinks_Click);
            this.Btn_Drinks.MouseLeave += new System.EventHandler(this.Btn_Drinks_MouseLeave);
            this.Btn_Drinks.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Drinks_MouseMove);
            // 
            // Panel_Main
            // 
            this.Panel_Main.Controls.Add(this.Panel_Add);
            this.Panel_Main.Controls.Add(this.Panel_Menu);
            this.gunaTransition1.SetDecoration(this.Panel_Main, Guna.UI.Animation.DecorationType.None);
            this.Panel_Main.Location = new System.Drawing.Point(100, 30);
            this.Panel_Main.Name = "Panel_Main";
            this.Panel_Main.Size = new System.Drawing.Size(1200, 620);
            this.Panel_Main.TabIndex = 3;
            // 
            // Panel_Add
            // 
            this.gunaTransition1.SetDecoration(this.Panel_Add, Guna.UI.Animation.DecorationType.None);
            this.Panel_Add.Location = new System.Drawing.Point(730, 4);
            this.Panel_Add.Name = "Panel_Add";
            this.Panel_Add.Size = new System.Drawing.Size(470, 615);
            this.Panel_Add.TabIndex = 1;
            this.Panel_Add.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_Maximize_MouseDown);
            // 
            // Panel_Menu
            // 
            this.gunaTransition1.SetDecoration(this.Panel_Menu, Guna.UI.Animation.DecorationType.None);
            this.Panel_Menu.Location = new System.Drawing.Point(0, 4);
            this.Panel_Menu.Name = "Panel_Menu";
            this.Panel_Menu.Size = new System.Drawing.Size(730, 615);
            this.Panel_Menu.TabIndex = 0;
            this.Panel_Menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Menu_MouseDown);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Close.AnimationHoverSpeed = 0.07F;
            this.Btn_Close.AnimationSpeed = 0.03F;
            this.gunaTransition1.SetDecoration(this.Btn_Close, Guna.UI.Animation.DecorationType.None);
            this.Btn_Close.IconColor = System.Drawing.Color.Black;
            this.Btn_Close.IconSize = 15F;
            this.Btn_Close.Location = new System.Drawing.Point(1255, 0);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.Btn_Close.OnHoverIconColor = System.Drawing.Color.White;
            this.Btn_Close.OnPressedColor = System.Drawing.Color.Black;
            this.Btn_Close.Size = new System.Drawing.Size(45, 29);
            this.Btn_Close.TabIndex = 4;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Btn_minimize
            // 
            this.Btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_minimize.AnimationHoverSpeed = 0.07F;
            this.Btn_minimize.AnimationSpeed = 0.03F;
            this.Btn_minimize.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaTransition1.SetDecoration(this.Btn_minimize, Guna.UI.Animation.DecorationType.None);
            this.Btn_minimize.IconColor = System.Drawing.Color.Black;
            this.Btn_minimize.IconSize = 15F;
            this.Btn_minimize.Location = new System.Drawing.Point(1153, -1);
            this.Btn_minimize.Name = "Btn_minimize";
            this.Btn_minimize.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.Btn_minimize.OnHoverIconColor = System.Drawing.Color.White;
            this.Btn_minimize.OnPressedColor = System.Drawing.Color.Black;
            this.Btn_minimize.Size = new System.Drawing.Size(45, 29);
            this.Btn_minimize.TabIndex = 5;
            this.Btn_minimize.Click += new System.EventHandler(this.Btn_minimize_Click);
            // 
            // gunaTransition1
            // 
            this.gunaTransition1.AnimationType = Guna.UI.Animation.AnimationType.Transparent;
            this.gunaTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.gunaTransition1.DefaultAnimation = animation1;
            // 
            // Btn_Maximize
            // 
            this.Btn_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Maximize.AnimationHoverSpeed = 0.07F;
            this.Btn_Maximize.AnimationSpeed = 0.03F;
            this.Btn_Maximize.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox;
            this.gunaTransition1.SetDecoration(this.Btn_Maximize, Guna.UI.Animation.DecorationType.None);
            this.Btn_Maximize.IconColor = System.Drawing.Color.Black;
            this.Btn_Maximize.IconSize = 15F;
            this.Btn_Maximize.Location = new System.Drawing.Point(1204, 0);
            this.Btn_Maximize.Name = "Btn_Maximize";
            this.Btn_Maximize.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.Btn_Maximize.OnHoverIconColor = System.Drawing.Color.White;
            this.Btn_Maximize.OnPressedColor = System.Drawing.Color.Black;
            this.Btn_Maximize.Size = new System.Drawing.Size(45, 29);
            this.Btn_Maximize.TabIndex = 6;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.Btn_Maximize);
            this.Controls.Add(this.Btn_minimize);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Panel_Main);
            this.Controls.Add(this.Panel_Logo);
            this.gunaTransition1.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.Panel_Logo.ResumeLayout(false);
            this.Panel_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel_Logo;
        private System.Windows.Forms.Panel Panel_Main;
        private FontAwesome.Sharp.IconButton Btn_Home;
        private FontAwesome.Sharp.IconButton Btn_Order;
        private Guna.UI.WinForms.GunaControlBox Btn_Close;
        private Guna.UI.WinForms.GunaControlBox Btn_minimize;
        private System.Windows.Forms.Panel Panel_Menu;
        private System.Windows.Forms.Panel Panel_Add;
        private FontAwesome.Sharp.IconButton Btn_Table;
        private Guna.UI.WinForms.GunaTransition gunaTransition1;
        private Guna.UI.WinForms.GunaControlBox Btn_Maximize;
        private FontAwesome.Sharp.IconButton Btn_Revenue;
        private FontAwesome.Sharp.IconButton Btn_Drinks;
        public FontAwesome.Sharp.IconButton Btn_Foods;
    }
}