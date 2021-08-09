
namespace CarCollection
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_modeltitle = new System.Windows.Forms.Label();
            this.lbl_enginetitle = new System.Windows.Forms.Label();
            this.lbl_yeartitle = new System.Windows.Forms.Label();
            this.lbl_vendortitle = new System.Windows.Forms.Label();
            this.lbl_model = new System.Windows.Forms.Label();
            this.lbl_vendor = new System.Windows.Forms.Label();
            this.lbl_year = new System.Windows.Forms.Label();
            this.lbl_engine = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lbl_modeltitle
            // 
            this.lbl_modeltitle.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_modeltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_modeltitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_modeltitle.Location = new System.Drawing.Point(71, 259);
            this.lbl_modeltitle.Name = "lbl_modeltitle";
            this.lbl_modeltitle.Size = new System.Drawing.Size(71, 23);
            this.lbl_modeltitle.TabIndex = 0;
            this.lbl_modeltitle.Text = "Model :";
            // 
            // lbl_enginetitle
            // 
            this.lbl_enginetitle.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_enginetitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_enginetitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_enginetitle.Location = new System.Drawing.Point(71, 368);
            this.lbl_enginetitle.Name = "lbl_enginetitle";
            this.lbl_enginetitle.Size = new System.Drawing.Size(77, 23);
            this.lbl_enginetitle.TabIndex = 1;
            this.lbl_enginetitle.Text = "Engine:";
            // 
            // lbl_yeartitle
            // 
            this.lbl_yeartitle.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_yeartitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_yeartitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_yeartitle.Location = new System.Drawing.Point(71, 330);
            this.lbl_yeartitle.Name = "lbl_yeartitle";
            this.lbl_yeartitle.Size = new System.Drawing.Size(53, 23);
            this.lbl_yeartitle.TabIndex = 2;
            this.lbl_yeartitle.Text = "Year:";
            // 
            // lbl_vendortitle
            // 
            this.lbl_vendortitle.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_vendortitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vendortitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_vendortitle.Location = new System.Drawing.Point(71, 293);
            this.lbl_vendortitle.Name = "lbl_vendortitle";
            this.lbl_vendortitle.Size = new System.Drawing.Size(71, 23);
            this.lbl_vendortitle.TabIndex = 3;
            this.lbl_vendortitle.Text = "Vendor:";
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_model.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_model.Location = new System.Drawing.Point(154, 260);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(48, 20);
            this.lbl_model.TabIndex = 5;
            this.lbl_model.Text = "label1";
            // 
            // lbl_vendor
            // 
            this.lbl_vendor.AutoSize = true;
            this.lbl_vendor.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_vendor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_vendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vendor.Location = new System.Drawing.Point(154, 294);
            this.lbl_vendor.Name = "lbl_vendor";
            this.lbl_vendor.Size = new System.Drawing.Size(48, 20);
            this.lbl_vendor.TabIndex = 6;
            this.lbl_vendor.Text = "label2";
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_year.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_year.Location = new System.Drawing.Point(154, 335);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(48, 20);
            this.lbl_year.TabIndex = 7;
            this.lbl_year.Text = "label3";
            // 
            // lbl_engine
            // 
            this.lbl_engine.AutoSize = true;
            this.lbl_engine.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_engine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_engine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_engine.Location = new System.Drawing.Point(154, 371);
            this.lbl_engine.Name = "lbl_engine";
            this.lbl_engine.Size = new System.Drawing.Size(48, 20);
            this.lbl_engine.TabIndex = 8;
            this.lbl_engine.Text = "label4";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "p1.jpg");
            this.imageList1.Images.SetKeyName(1, "p2.jpg");
            this.imageList1.Images.SetKeyName(2, "p3.jpg");
            this.imageList1.Images.SetKeyName(3, "g-class.jpg");
            // 
            // label1
            // 
            this.label1.ImageKey = "(none)";
            this.label1.ImageList = this.imageList1;
            this.label1.Location = new System.Drawing.Point(219, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 178);
            this.label1.TabIndex = 10;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 22;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.SystemColors.ButtonShadow;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(480, 307);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(107, 46);
            this.guna2Button1.TabIndex = 11;
            this.guna2Button1.Text = "Change";
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarCollection.Properties.Resources.c;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(649, 443);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_engine);
            this.Controls.Add(this.lbl_year);
            this.Controls.Add(this.lbl_vendor);
            this.Controls.Add(this.lbl_model);
            this.Controls.Add(this.lbl_vendortitle);
            this.Controls.Add(this.lbl_yeartitle);
            this.Controls.Add(this.lbl_enginetitle);
            this.Controls.Add(this.lbl_modeltitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_modeltitle;
        private System.Windows.Forms.Label lbl_enginetitle;
        private System.Windows.Forms.Label lbl_yeartitle;
        private System.Windows.Forms.Label lbl_vendortitle;
        private System.Windows.Forms.Label lbl_model;
        private System.Windows.Forms.Label lbl_vendor;
        private System.Windows.Forms.Label lbl_year;
        private System.Windows.Forms.Label lbl_engine;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}

