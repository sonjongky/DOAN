namespace DOAN
{
    partial class FormFood
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
            Guna.UI.Animation.Animation animation7 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFood));
            this.gunaVScrollBar2 = new Guna.UI.WinForms.GunaVScrollBar();
            this.FlowLayoutPanel_Food = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_Food = new Guna.UI.WinForms.GunaGradient2Panel();
            this.txt_search = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaTransition1 = new Guna.UI.WinForms.GunaTransition(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // gunaVScrollBar2
            // 
            this.gunaTransition1.SetDecoration(this.gunaVScrollBar2, Guna.UI.Animation.DecorationType.None);
            this.gunaVScrollBar2.LargeChange = 10;
            this.gunaVScrollBar2.Location = new System.Drawing.Point(708, 115);
            this.gunaVScrollBar2.Maximum = 100;
            this.gunaVScrollBar2.Name = "gunaVScrollBar2";
            this.gunaVScrollBar2.ScrollIdleColor = System.Drawing.Color.Silver;
            this.gunaVScrollBar2.Size = new System.Drawing.Size(10, 500);
            this.gunaVScrollBar2.TabIndex = 13;
            this.gunaVScrollBar2.ThumbColor = System.Drawing.Color.DimGray;
            this.gunaVScrollBar2.ThumbHoverColor = System.Drawing.Color.Gray;
            this.gunaVScrollBar2.ThumbPressedColor = System.Drawing.Color.DarkGray;
            // 
            // FlowLayoutPanel_Food
            // 
            this.gunaTransition1.SetDecoration(this.FlowLayoutPanel_Food, Guna.UI.Animation.DecorationType.None);
            this.FlowLayoutPanel_Food.Location = new System.Drawing.Point(120, 116);
            this.FlowLayoutPanel_Food.Name = "FlowLayoutPanel_Food";
            this.FlowLayoutPanel_Food.Size = new System.Drawing.Size(580, 500);
            this.FlowLayoutPanel_Food.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.gunaTransition1.SetDecoration(this.label1, Guna.UI.Animation.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 33);
            this.label1.TabIndex = 14;
            this.label1.Text = "Search";
            // 
            // Panel_Food
            // 
            this.Panel_Food.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransition1.SetDecoration(this.Panel_Food, Guna.UI.Animation.DecorationType.None);
            this.Panel_Food.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(80)))), ((int)(((byte)(198)))));
            this.Panel_Food.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(183)))), ((int)(((byte)(243)))));
            this.Panel_Food.Location = new System.Drawing.Point(0, 0);
            this.Panel_Food.Name = "Panel_Food";
            this.Panel_Food.Radius = 5;
            this.Panel_Food.Size = new System.Drawing.Size(80, 400);
            this.Panel_Food.TabIndex = 16;
            this.Panel_Food.Visible = false;
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
            this.txt_search.TabIndex = 17;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // gunaTransition1
            // 
            this.gunaTransition1.AnimationType = Guna.UI.Animation.AnimationType.Transparent;
            this.gunaTransition1.Cursor = null;
            animation7.AnimateOnlyDifferences = true;
            animation7.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.BlindCoeff")));
            animation7.LeafCoeff = 0F;
            animation7.MaxTime = 1F;
            animation7.MinTime = 0F;
            animation7.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicCoeff")));
            animation7.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicShift")));
            animation7.MosaicSize = 0;
            animation7.Padding = new System.Windows.Forms.Padding(0);
            animation7.RotateCoeff = 0F;
            animation7.RotateLimit = 0F;
            animation7.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.ScaleCoeff")));
            animation7.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.SlideCoeff")));
            animation7.TimeCoeff = 0F;
            animation7.TransparencyCoeff = 1F;
            this.gunaTransition1.DefaultAnimation = animation7;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 615);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.Panel_Food);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FlowLayoutPanel_Food);
            this.Controls.Add(this.gunaVScrollBar2);
            this.gunaTransition1.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFood";
            this.Text = "FormFood";
            this.Load += new System.EventHandler(this.FormFood_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaVScrollBar gunaVScrollBar2;
        public System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel_Food;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaGradient2Panel Panel_Food;
        private Guna.UI.WinForms.GunaLineTextBox txt_search;
        private Guna.UI.WinForms.GunaTransition gunaTransition1;
        private System.Windows.Forms.Timer timer1;
    }
}