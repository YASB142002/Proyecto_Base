
namespace Programa_Principal.View.FormButtons
{
    partial class Home_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_Form));
            this.tmFechaHora = new System.Windows.Forms.Timer(this.components);
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblHora = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblFecha = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuGradientPanel2 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmFechaHora
            // 
            this.tmFechaHora.Tick += new System.EventHandler(this.tmFechaHora_Tick);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 1;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuGradientPanel2);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuLabel1);
            this.bunifuGradientPanel1.Controls.Add(this.lblHora);
            this.bunifuGradientPanel1.Controls.Add(this.lblFecha);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DimGray;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Gray;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Silver;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(800, 450);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuLabel1.Location = new System.Drawing.Point(660, 417);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(128, 21);
            this.bunifuLabel1.TabIndex = 5;
            this.bunifuLabel1.Text = "Software Fenix S.A";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = false;
            this.bunifuPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuPictureBox1.BorderRadius = 20;
            this.bunifuPictureBox1.Image = global::Programa_Principal.Properties.Resources.Ave_roja_Sin_fondo;
            this.bunifuPictureBox1.IsCircle = false;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(-1, 4);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(195, 193);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 4;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            // 
            // lblHora
            // 
            this.lblHora.AllowParentOverrides = false;
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHora.AutoEllipsis = false;
            this.lblHora.CursorType = null;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHora.Location = new System.Drawing.Point(12, 366);
            this.lblHora.Name = "lblHora";
            this.lblHora.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHora.Size = new System.Drawing.Size(70, 45);
            this.lblHora.TabIndex = 3;
            this.lblHora.Text = "Time";
            this.lblHora.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblHora.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblFecha
            // 
            this.lblFecha.AllowParentOverrides = false;
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFecha.AutoEllipsis = false;
            this.lblFecha.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFecha.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFecha.Location = new System.Drawing.Point(12, 417);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFecha.Size = new System.Drawing.Size(32, 21);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Date";
            this.lblFecha.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblFecha.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuGradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.BorderRadius = 100;
            this.bunifuGradientPanel2.Controls.Add(this.bunifuPictureBox1);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.DimGray;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.Silver;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.Gray;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(302, 100);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(199, 207);
            this.bunifuGradientPanel2.TabIndex = 6;
            // 
            // Home_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "Home_Form";
            this.Text = "Home_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_Form_FormClosing);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmFechaHora;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.UI.WinForms.BunifuLabel lblHora;
        private Bunifu.UI.WinForms.BunifuLabel lblFecha;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel2;
    }
}