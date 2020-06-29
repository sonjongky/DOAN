namespace DOAN
{
    partial class UserControl_Item
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI.Animation.Animation animation2 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Item));
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.Label_Price = new Guna.UI.WinForms.GunaLabel();
            this.gunaTransition1 = new Guna.UI.WinForms.GunaTransition(this.components);
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.Label_Name = new Guna.UI.WinForms.GunaLabel();
            this.gunaLinePanel_tick = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaGradientButton_tick = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaGradient2Panel1.SuspendLayout();
            this.gunaShadowPanel1.SuspendLayout();
            this.gunaLinePanel_tick.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.Controls.Add(this.Label_Price);
            this.gunaTransition1.SetDecoration(this.gunaGradient2Panel1, Guna.UI.Animation.DecorationType.None);
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(177)))), ((int)(((byte)(246)))));
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(177)))), ((int)(((byte)(246)))));
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(8, 7);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Radius = 5;
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(65, 20);
            this.gunaGradient2Panel1.TabIndex = 0;
            // 
            // Label_Price
            // 
            this.Label_Price.AutoSize = true;
            this.gunaTransition1.SetDecoration(this.Label_Price, Guna.UI.Animation.DecorationType.None);
            this.Label_Price.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Price.ForeColor = System.Drawing.SystemColors.Control;
            this.Label_Price.Location = new System.Drawing.Point(7, 1);
            this.Label_Price.Name = "Label_Price";
            this.Label_Price.Size = new System.Drawing.Size(36, 17);
            this.Label_Price.TabIndex = 2;
            this.Label_Price.Text = "label";
            // 
            // gunaTransition1
            // 
            this.gunaTransition1.AnimationType = Guna.UI.Animation.AnimationType.Transparent;
            this.gunaTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.gunaTransition1.DefaultAnimation = animation2;
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gunaShadowPanel1.Controls.Add(this.Label_Name);
            this.gunaTransition1.SetDecoration(this.gunaShadowPanel1, Guna.UI.Animation.DecorationType.None);
            this.gunaShadowPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaShadowPanel1.Location = new System.Drawing.Point(3, 140);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 4;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(174, 37);
            this.gunaShadowPanel1.TabIndex = 1;
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.gunaTransition1.SetDecoration(this.Label_Name, Guna.UI.Animation.DecorationType.None);
            this.Label_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Name.Location = new System.Drawing.Point(7, 10);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(50, 17);
            this.Label_Name.TabIndex = 0;
            this.Label_Name.Text = "asdasd";
            this.Label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLinePanel_tick
            // 
            this.gunaLinePanel_tick.BackColor = System.Drawing.Color.Transparent;
            this.gunaLinePanel_tick.Controls.Add(this.gunaGradientButton_tick);
            this.gunaTransition1.SetDecoration(this.gunaLinePanel_tick, Guna.UI.Animation.DecorationType.None);
            this.gunaLinePanel_tick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLinePanel_tick.LineBottom = 4;
            this.gunaLinePanel_tick.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(177)))), ((int)(((byte)(246)))));
            this.gunaLinePanel_tick.LineLeft = 4;
            this.gunaLinePanel_tick.LineRight = 4;
            this.gunaLinePanel_tick.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel_tick.LineTop = 4;
            this.gunaLinePanel_tick.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel_tick.Name = "gunaLinePanel_tick";
            this.gunaLinePanel_tick.Size = new System.Drawing.Size(180, 180);
            this.gunaLinePanel_tick.TabIndex = 4;
            this.gunaLinePanel_tick.Visible = false;
            this.gunaLinePanel_tick.Click += new System.EventHandler(this.gunaLinePanel_tick_Click);
            // 
            // gunaGradientButton_tick
            // 
            this.gunaGradientButton_tick.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton_tick.AnimationSpeed = 0.03F;
            this.gunaGradientButton_tick.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientButton_tick.BackgroundImage")));
            this.gunaGradientButton_tick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientButton_tick.BaseColor1 = System.Drawing.Color.Transparent;
            this.gunaGradientButton_tick.BaseColor2 = System.Drawing.Color.Transparent;
            this.gunaGradientButton_tick.BorderColor = System.Drawing.Color.Transparent;
            this.gunaTransition1.SetDecoration(this.gunaGradientButton_tick, Guna.UI.Animation.DecorationType.None);
            this.gunaGradientButton_tick.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton_tick.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton_tick.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientButton_tick.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton_tick.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gunaGradientButton_tick.Image = null;
            this.gunaGradientButton_tick.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton_tick.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaGradientButton_tick.Location = new System.Drawing.Point(151, 3);
            this.gunaGradientButton_tick.Name = "gunaGradientButton_tick";
            this.gunaGradientButton_tick.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton_tick.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton_tick.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton_tick.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton_tick.OnHoverImage = null;
            this.gunaGradientButton_tick.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton_tick.Size = new System.Drawing.Size(26, 28);
            this.gunaGradientButton_tick.TabIndex = 0;
            this.gunaGradientButton_tick.Visible = false;
            // 
            // UserControl_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.gunaShadowPanel1);
            this.Controls.Add(this.gunaGradient2Panel1);
            this.Controls.Add(this.gunaLinePanel_tick);
            this.gunaTransition1.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.Name = "UserControl_Item";
            this.Size = new System.Drawing.Size(180, 180);
            this.Click += new System.EventHandler(this.UserControl_Item_Click);
            this.gunaGradient2Panel1.ResumeLayout(false);
            this.gunaGradient2Panel1.PerformLayout();
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.gunaLinePanel_tick.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private Guna.UI.WinForms.GunaLabel Label_Price;
        private Guna.UI.WinForms.GunaTransition gunaTransition1;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaLabel Label_Name;
        public Guna.UI.WinForms.GunaLinePanel gunaLinePanel_tick;
        public Guna.UI.WinForms.GunaGradientButton gunaGradientButton_tick;
    }
}
