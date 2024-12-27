namespace Proje35
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.lblGrsKaydol = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnGrsGirisYap = new Guna.UI2.WinForms.Guna2Button();
            this.txtGrsSifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGrsMail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2ContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ContainerControl1
            // 
            this.guna2ContainerControl1.Controls.Add(this.guna2Separator1);
            this.guna2ContainerControl1.Controls.Add(this.label1);
            this.guna2ContainerControl1.Controls.Add(this.lblGrsKaydol);
            this.guna2ContainerControl1.Controls.Add(this.btnGrsGirisYap);
            this.guna2ContainerControl1.Controls.Add(this.txtGrsSifre);
            this.guna2ContainerControl1.Controls.Add(this.txtGrsMail);
            this.guna2ContainerControl1.Location = new System.Drawing.Point(12, 12);
            this.guna2ContainerControl1.Name = "guna2ContainerControl1";
            this.guna2ContainerControl1.Size = new System.Drawing.Size(375, 271);
            this.guna2ContainerControl1.TabIndex = 0;
            this.guna2ContainerControl1.Text = "guna2ContainerControl1";
            this.guna2ContainerControl1.Click += new System.EventHandler(this.guna2ContainerControl1_Click);
            // 
            // lblGrsKaydol
            // 
            this.lblGrsKaydol.BackColor = System.Drawing.Color.Transparent;
            this.lblGrsKaydol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGrsKaydol.ForeColor = System.Drawing.Color.Black;
            this.lblGrsKaydol.Location = new System.Drawing.Point(173, 242);
            this.lblGrsKaydol.Name = "lblGrsKaydol";
            this.lblGrsKaydol.Size = new System.Drawing.Size(35, 15);
            this.lblGrsKaydol.TabIndex = 7;
            this.lblGrsKaydol.Text = "Kaydol";
            this.lblGrsKaydol.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // btnGrsGirisYap
            // 
            this.btnGrsGirisYap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGrsGirisYap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGrsGirisYap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGrsGirisYap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGrsGirisYap.FillColor = System.Drawing.Color.Black;
            this.btnGrsGirisYap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGrsGirisYap.ForeColor = System.Drawing.Color.White;
            this.btnGrsGirisYap.Location = new System.Drawing.Point(122, 198);
            this.btnGrsGirisYap.Name = "btnGrsGirisYap";
            this.btnGrsGirisYap.Size = new System.Drawing.Size(131, 38);
            this.btnGrsGirisYap.TabIndex = 6;
            this.btnGrsGirisYap.Text = "Giriş Yap";
            this.btnGrsGirisYap.Click += new System.EventHandler(this.btnGrsGirisYap_Click);
            // 
            // txtGrsSifre
            // 
            this.txtGrsSifre.AutoRoundedCorners = true;
            this.txtGrsSifre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtGrsSifre.BorderRadius = 21;
            this.txtGrsSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGrsSifre.DefaultText = "";
            this.txtGrsSifre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGrsSifre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGrsSifre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGrsSifre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGrsSifre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGrsSifre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGrsSifre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGrsSifre.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtGrsSifre.IconLeft")));
            this.txtGrsSifre.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtGrsSifre.Location = new System.Drawing.Point(17, 137);
            this.txtGrsSifre.Name = "txtGrsSifre";
            this.txtGrsSifre.PasswordChar = '●';
            this.txtGrsSifre.PlaceholderText = "Şifre";
            this.txtGrsSifre.SelectedText = "";
            this.txtGrsSifre.ShadowDecoration.BorderRadius = 21;
            this.txtGrsSifre.Size = new System.Drawing.Size(332, 40);
            this.txtGrsSifre.TabIndex = 5;
            this.txtGrsSifre.UseSystemPasswordChar = true;
            this.txtGrsSifre.TextChanged += new System.EventHandler(this.txtGrsSifre_TextChanged);
            // 
            // txtGrsMail
            // 
            this.txtGrsMail.AutoRoundedCorners = true;
            this.txtGrsMail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtGrsMail.BorderRadius = 21;
            this.txtGrsMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGrsMail.DefaultText = "";
            this.txtGrsMail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGrsMail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGrsMail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGrsMail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGrsMail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGrsMail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGrsMail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGrsMail.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtGrsMail.IconLeft")));
            this.txtGrsMail.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtGrsMail.Location = new System.Drawing.Point(17, 87);
            this.txtGrsMail.Name = "txtGrsMail";
            this.txtGrsMail.PasswordChar = '\0';
            this.txtGrsMail.PlaceholderText = "Mail";
            this.txtGrsMail.SelectedText = "";
            this.txtGrsMail.ShadowDecoration.BorderRadius = 21;
            this.txtGrsMail.Size = new System.Drawing.Size(332, 44);
            this.txtGrsMail.TabIndex = 3;
            this.txtGrsMail.TextChanged += new System.EventHandler(this.txtGrsMail_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giriş Yap";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(0, 50);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(375, 19);
            this.guna2Separator1.TabIndex = 8;
            this.guna2Separator1.Click += new System.EventHandler(this.guna2Separator1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(399, 295);
            this.Controls.Add(this.guna2ContainerControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.guna2ContainerControl1.ResumeLayout(false);
            this.guna2ContainerControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtGrsMail;
        private Guna.UI2.WinForms.Guna2Button btnGrsGirisYap;
        private Guna.UI2.WinForms.Guna2TextBox txtGrsSifre;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblGrsKaydol;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}