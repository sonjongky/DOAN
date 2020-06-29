namespace DOAN
{
    partial class UserControl_Add
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
            this.Label_Add_Name = new Guna.UI.WinForms.GunaLabel();
            this.Label_Add_Price = new Guna.UI.WinForms.GunaLabel();
            this.Quantity = new Guna.UI.WinForms.GunaNumeric();
            this.Btn_Delete = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // Label_Add_Name
            // 
            this.Label_Add_Name.AutoSize = true;
            this.Label_Add_Name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Label_Add_Name.Location = new System.Drawing.Point(3, 27);
            this.Label_Add_Name.Name = "Label_Add_Name";
            this.Label_Add_Name.Size = new System.Drawing.Size(68, 15);
            this.Label_Add_Name.TabIndex = 2;
            this.Label_Add_Name.Text = "gunaLabel1";
            // 
            // Label_Add_Price
            // 
            this.Label_Add_Price.AutoSize = true;
            this.Label_Add_Price.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Label_Add_Price.Location = new System.Drawing.Point(288, 27);
            this.Label_Add_Price.Name = "Label_Add_Price";
            this.Label_Add_Price.Size = new System.Drawing.Size(68, 15);
            this.Label_Add_Price.TabIndex = 4;
            this.Label_Add_Price.Text = "gunaLabel3";
            // 
            // Quantity
            // 
            this.Quantity.BaseColor = System.Drawing.Color.White;
            this.Quantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Quantity.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Quantity.ButtonForeColor = System.Drawing.Color.White;
            this.Quantity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Quantity.ForeColor = System.Drawing.Color.Black;
            this.Quantity.Location = new System.Drawing.Point(192, 15);
            this.Quantity.Maximum = ((long)(9999999));
            this.Quantity.Minimum = ((long)(0));
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(75, 30);
            this.Quantity.TabIndex = 5;
            this.Quantity.Text = "gunaNumeric1";
            this.Quantity.Value = ((long)(0));
            this.Quantity.ValueChanged += new System.EventHandler(this.Quantity_ValueChanged);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.FlatAppearance.BorderSize = 0;
            this.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Delete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Btn_Delete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.Btn_Delete.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Btn_Delete.IconSize = 30;
            this.Btn_Delete.Location = new System.Drawing.Point(371, 14);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Rotation = 0D;
            this.Btn_Delete.Size = new System.Drawing.Size(34, 41);
            this.Btn_Delete.TabIndex = 6;
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // UserControl_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Label_Add_Price);
            this.Controls.Add(this.Label_Add_Name);
            this.Name = "UserControl_Add";
            this.Size = new System.Drawing.Size(405, 70);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel Label_Add_Name;
        private Guna.UI.WinForms.GunaLabel Label_Add_Price;
        private Guna.UI.WinForms.GunaNumeric Quantity;
        private FontAwesome.Sharp.IconButton Btn_Delete;
    }
}
