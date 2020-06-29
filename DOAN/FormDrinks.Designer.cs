namespace DOAN
{
    partial class FormDrinks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDrinks));
            this.LayoutPanelDrinks = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_Coffee = new FontAwesome.Sharp.IconButton();
            this.Btn_Tea = new FontAwesome.Sharp.IconButton();
            this.Btn_Juice = new FontAwesome.Sharp.IconButton();
            this.Btn_IceBlend = new FontAwesome.Sharp.IconButton();
            this.FLowLayoutPanel_Drinks = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_Drinks = new Guna.UI.WinForms.GunaGradient2Panel();
            this.gunaTransition1 = new Guna.UI.WinForms.GunaTransition(this.components);
            this.gunaVScrollBar1 = new Guna.UI.WinForms.GunaVScrollBar();
            this.txt_search = new Guna.UI.WinForms.GunaLineTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Panel_Drinks.SuspendLayout();
            this.SuspendLayout();
            // 
            // LayoutPanelDrinks
            // 
            this.gunaTransition1.SetDecoration(this.LayoutPanelDrinks, Guna.UI.Animation.DecorationType.None);
            this.LayoutPanelDrinks.Location = new System.Drawing.Point(80, 100);
            this.LayoutPanelDrinks.Name = "LayoutPanelDrinks";
            this.LayoutPanelDrinks.Size = new System.Drawing.Size(0, 0);
            this.LayoutPanelDrinks.TabIndex = 0;
            // 
            // Btn_Coffee
            // 
            this.Btn_Coffee.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Coffee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaTransition1.SetDecoration(this.Btn_Coffee, Guna.UI.Animation.DecorationType.None);
            this.Btn_Coffee.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.Btn_Coffee.FlatAppearance.BorderSize = 0;
            this.Btn_Coffee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Coffee.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Btn_Coffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Coffee.ForeColor = System.Drawing.Color.DimGray;
            this.Btn_Coffee.IconChar = FontAwesome.Sharp.IconChar.Coffee;
            this.Btn_Coffee.IconColor = System.Drawing.Color.DimGray;
            this.Btn_Coffee.IconSize = 50;
            this.Btn_Coffee.Location = new System.Drawing.Point(-5, 15);
            this.Btn_Coffee.Name = "Btn_Coffee";
            this.Btn_Coffee.Rotation = 0D;
            this.Btn_Coffee.Size = new System.Drawing.Size(88, 80);
            this.Btn_Coffee.TabIndex = 12;
            this.Btn_Coffee.Text = "Cà phê";
            this.Btn_Coffee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Coffee.UseVisualStyleBackColor = false;
            this.Btn_Coffee.Click += new System.EventHandler(this.Btn_Coffee_Click);
            this.Btn_Coffee.MouseLeave += new System.EventHandler(this.Btn_Coffee_MouseLeave);
            this.Btn_Coffee.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Coffee_MouseMove);
            // 
            // Btn_Tea
            // 
            this.Btn_Tea.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Tea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaTransition1.SetDecoration(this.Btn_Tea, Guna.UI.Animation.DecorationType.None);
            this.Btn_Tea.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.Btn_Tea.FlatAppearance.BorderSize = 0;
            this.Btn_Tea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Tea.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Btn_Tea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Tea.ForeColor = System.Drawing.Color.DimGray;
            this.Btn_Tea.IconChar = FontAwesome.Sharp.IconChar.GlassWhiskey;
            this.Btn_Tea.IconColor = System.Drawing.Color.DimGray;
            this.Btn_Tea.IconSize = 50;
            this.Btn_Tea.Location = new System.Drawing.Point(0, 109);
            this.Btn_Tea.Name = "Btn_Tea";
            this.Btn_Tea.Rotation = 0D;
            this.Btn_Tea.Size = new System.Drawing.Size(80, 80);
            this.Btn_Tea.TabIndex = 14;
            this.Btn_Tea.Text = "Trà";
            this.Btn_Tea.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Tea.UseVisualStyleBackColor = false;
            this.Btn_Tea.Click += new System.EventHandler(this.Btn_Juice_Click);
            this.Btn_Tea.MouseLeave += new System.EventHandler(this.Btn_Tea_MouseLeave);
            this.Btn_Tea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Tea_MouseMove);
            // 
            // Btn_Juice
            // 
            this.Btn_Juice.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Juice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaTransition1.SetDecoration(this.Btn_Juice, Guna.UI.Animation.DecorationType.None);
            this.Btn_Juice.FlatAppearance.BorderSize = 0;
            this.Btn_Juice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Juice.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Btn_Juice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Juice.ForeColor = System.Drawing.Color.DimGray;
            this.Btn_Juice.IconChar = FontAwesome.Sharp.IconChar.Cocktail;
            this.Btn_Juice.IconColor = System.Drawing.Color.DimGray;
            this.Btn_Juice.IconSize = 60;
            this.Btn_Juice.Location = new System.Drawing.Point(-4, 299);
            this.Btn_Juice.Name = "Btn_Juice";
            this.Btn_Juice.Rotation = 0D;
            this.Btn_Juice.Size = new System.Drawing.Size(98, 80);
            this.Btn_Juice.TabIndex = 15;
            this.Btn_Juice.Text = " Nước ép";
            this.Btn_Juice.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Btn_Juice.UseVisualStyleBackColor = false;
            this.Btn_Juice.Click += new System.EventHandler(this.Btn_IceBlend_Click);
            this.Btn_Juice.MouseLeave += new System.EventHandler(this.Btn_Ice_Blend_MouseLeave);
            this.Btn_Juice.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Ice_Blend_MouseMove);
            // 
            // Btn_IceBlend
            // 
            this.Btn_IceBlend.BackColor = System.Drawing.Color.Transparent;
            this.Btn_IceBlend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaTransition1.SetDecoration(this.Btn_IceBlend, Guna.UI.Animation.DecorationType.None);
            this.Btn_IceBlend.FlatAppearance.BorderSize = 0;
            this.Btn_IceBlend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_IceBlend.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Btn_IceBlend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_IceBlend.ForeColor = System.Drawing.Color.DimGray;
            this.Btn_IceBlend.IconChar = FontAwesome.Sharp.IconChar.IceCream;
            this.Btn_IceBlend.IconColor = System.Drawing.Color.DimGray;
            this.Btn_IceBlend.IconSize = 50;
            this.Btn_IceBlend.Location = new System.Drawing.Point(-8, 208);
            this.Btn_IceBlend.Name = "Btn_IceBlend";
            this.Btn_IceBlend.Rotation = 0D;
            this.Btn_IceBlend.Size = new System.Drawing.Size(96, 80);
            this.Btn_IceBlend.TabIndex = 14;
            this.Btn_IceBlend.Text = "Đá xay";
            this.Btn_IceBlend.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_IceBlend.UseVisualStyleBackColor = false;
            this.Btn_IceBlend.Click += new System.EventHandler(this.Btn_Smoothies_Click);
            this.Btn_IceBlend.MouseLeave += new System.EventHandler(this.Btn_Smoothies_MouseLeave);
            this.Btn_IceBlend.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Smoothies_MouseMove);
            // 
            // FLowLayoutPanel_Drinks
            // 
            this.FLowLayoutPanel_Drinks.AutoScroll = true;
            this.gunaTransition1.SetDecoration(this.FLowLayoutPanel_Drinks, Guna.UI.Animation.DecorationType.None);
            this.FLowLayoutPanel_Drinks.Location = new System.Drawing.Point(120, 115);
            this.FLowLayoutPanel_Drinks.Name = "FLowLayoutPanel_Drinks";
            this.FLowLayoutPanel_Drinks.Size = new System.Drawing.Size(580, 500);
            this.FLowLayoutPanel_Drinks.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.gunaTransition1.SetDecoration(this.label1, Guna.UI.Animation.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            // 
            // Panel_Drinks
            // 
            this.Panel_Drinks.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Drinks.Controls.Add(this.Btn_IceBlend);
            this.Panel_Drinks.Controls.Add(this.Btn_Juice);
            this.Panel_Drinks.Controls.Add(this.Btn_Coffee);
            this.Panel_Drinks.Controls.Add(this.Btn_Tea);
            this.gunaTransition1.SetDecoration(this.Panel_Drinks, Guna.UI.Animation.DecorationType.None);
            this.Panel_Drinks.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(80)))), ((int)(((byte)(198)))));
            this.Panel_Drinks.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(183)))), ((int)(((byte)(243)))));
            this.Panel_Drinks.Location = new System.Drawing.Point(0, 0);
            this.Panel_Drinks.Name = "Panel_Drinks";
            this.Panel_Drinks.Radius = 5;
            this.Panel_Drinks.Size = new System.Drawing.Size(80, 400);
            this.Panel_Drinks.TabIndex = 0;
            this.Panel_Drinks.Visible = false;
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
            // gunaVScrollBar1
            // 
            this.gunaTransition1.SetDecoration(this.gunaVScrollBar1, Guna.UI.Animation.DecorationType.None);
            this.gunaVScrollBar1.LargeChange = 10;
            this.gunaVScrollBar1.Location = new System.Drawing.Point(708, 115);
            this.gunaVScrollBar1.Maximum = 100;
            this.gunaVScrollBar1.Name = "gunaVScrollBar1";
            this.gunaVScrollBar1.ScrollIdleColor = System.Drawing.Color.Silver;
            this.gunaVScrollBar1.Size = new System.Drawing.Size(10, 500);
            this.gunaVScrollBar1.TabIndex = 0;
            this.gunaVScrollBar1.ThumbColor = System.Drawing.Color.DimGray;
            this.gunaVScrollBar1.ThumbHoverColor = System.Drawing.Color.Gray;
            this.gunaVScrollBar1.ThumbPressedColor = System.Drawing.Color.DarkGray;
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.White;
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTransition1.SetDecoration(this.txt_search, Guna.UI.Animation.DecorationType.None);
            this.txt_search.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_search.Location = new System.Drawing.Point(240, 33);
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.SelectedText = "";
            this.txt_search.Size = new System.Drawing.Size(440, 46);
            this.txt_search.TabIndex = 4;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormDrinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 615);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.Panel_Drinks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaVScrollBar1);
            this.Controls.Add(this.FLowLayoutPanel_Drinks);
            this.Controls.Add(this.LayoutPanelDrinks);
            this.gunaTransition1.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDrinks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDrinks";
            this.Load += new System.EventHandler(this.FormDrinks_Load);
            this.Panel_Drinks.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel LayoutPanelDrinks;
        private FontAwesome.Sharp.IconButton Btn_Coffee;
        private FontAwesome.Sharp.IconButton Btn_Tea;
        private FontAwesome.Sharp.IconButton Btn_IceBlend;
        private FontAwesome.Sharp.IconButton Btn_Juice;
        private System.Windows.Forms.FlowLayoutPanel FLowLayoutPanel_Drinks;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTransition gunaTransition1;
        private Guna.UI.WinForms.GunaGradient2Panel Panel_Drinks;
        private Guna.UI.WinForms.GunaVScrollBar gunaVScrollBar1;
        private Guna.UI.WinForms.GunaLineTextBox txt_search;
        private System.Windows.Forms.Timer timer1;
    }
}