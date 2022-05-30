
namespace PruebaAnimalia
{
    partial class ScreenGlobos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenGlobos));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.globodorado = new System.Windows.Forms.PictureBox();
            this.globoplata = new System.Windows.Forms.PictureBox();
            this.globonegro = new System.Windows.Forms.PictureBox();
            this.globorojo = new System.Windows.Forms.PictureBox();
            this.globoazul = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.globodorado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globoplata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globonegro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globorojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globoazul)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.PrincipalTimer_Tick);
            // 
            // globodorado
            // 
            this.globodorado.BackColor = System.Drawing.Color.Transparent;
            this.globodorado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.globodorado.ErrorImage = ((System.Drawing.Image)(resources.GetObject("globodorado.ErrorImage")));
            this.globodorado.Image = ((System.Drawing.Image)(resources.GetObject("globodorado.Image")));
            this.globodorado.Location = new System.Drawing.Point(270, 267);
            this.globodorado.Name = "globodorado";
            this.globodorado.Size = new System.Drawing.Size(88, 95);
            this.globodorado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.globodorado.TabIndex = 5;
            this.globodorado.TabStop = false;
            this.globodorado.Tag = "globo";
            this.globodorado.Click += new System.EventHandler(this.popBalloon);
            // 
            // globoplata
            // 
            this.globoplata.BackColor = System.Drawing.Color.Transparent;
            this.globoplata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.globoplata.ErrorImage = ((System.Drawing.Image)(resources.GetObject("globoplata.ErrorImage")));
            this.globoplata.Image = ((System.Drawing.Image)(resources.GetObject("globoplata.Image")));
            this.globoplata.Location = new System.Drawing.Point(255, 105);
            this.globoplata.Name = "globoplata";
            this.globoplata.Size = new System.Drawing.Size(103, 114);
            this.globoplata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.globoplata.TabIndex = 4;
            this.globoplata.TabStop = false;
            this.globoplata.Tag = "globo";
            this.globoplata.Click += new System.EventHandler(this.popBalloon);
            // 
            // globonegro
            // 
            this.globonegro.BackColor = System.Drawing.Color.Transparent;
            this.globonegro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.globonegro.ErrorImage = ((System.Drawing.Image)(resources.GetObject("globonegro.ErrorImage")));
            this.globonegro.Image = ((System.Drawing.Image)(resources.GetObject("globonegro.Image")));
            this.globonegro.Location = new System.Drawing.Point(38, 328);
            this.globonegro.Name = "globonegro";
            this.globonegro.Size = new System.Drawing.Size(125, 124);
            this.globonegro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.globonegro.TabIndex = 3;
            this.globonegro.TabStop = false;
            this.globonegro.Click += new System.EventHandler(this.popBlack);
            // 
            // globorojo
            // 
            this.globorojo.BackColor = System.Drawing.Color.Transparent;
            this.globorojo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.globorojo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("globorojo.ErrorImage")));
            this.globorojo.Image = ((System.Drawing.Image)(resources.GetObject("globorojo.Image")));
            this.globorojo.Location = new System.Drawing.Point(414, 406);
            this.globorojo.Name = "globorojo";
            this.globorojo.Size = new System.Drawing.Size(103, 114);
            this.globorojo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.globorojo.TabIndex = 2;
            this.globorojo.TabStop = false;
            this.globorojo.Tag = "globo";
            this.globorojo.Click += new System.EventHandler(this.popBalloon);
            // 
            // globoazul
            // 
            this.globoazul.BackColor = System.Drawing.Color.Transparent;
            this.globoazul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.globoazul.ErrorImage = ((System.Drawing.Image)(resources.GetObject("globoazul.ErrorImage")));
            this.globoazul.Image = ((System.Drawing.Image)(resources.GetObject("globoazul.Image")));
            this.globoazul.Location = new System.Drawing.Point(84, 116);
            this.globoazul.Name = "globoazul";
            this.globoazul.Size = new System.Drawing.Size(103, 114);
            this.globoazul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.globoazul.TabIndex = 1;
            this.globoazul.TabStop = false;
            this.globoazul.Tag = "globo";
            this.globoazul.Click += new System.EventHandler(this.popBalloon);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(33, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Puntos:";
            // 
            // ScreenGlobos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(585, 602);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.globorojo);
            this.Controls.Add(this.globoplata);
            this.Controls.Add(this.globodorado);
            this.Controls.Add(this.globoazul);
            this.Controls.Add(this.globonegro);
            this.Name = "ScreenGlobos";
            this.Text = "ScreenGlobos";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ScreenGlobos_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.globodorado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globoplata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globonegro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globorojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globoazul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox globorojo;
        private System.Windows.Forms.PictureBox globoazul;
        private System.Windows.Forms.PictureBox globodorado;
        private System.Windows.Forms.PictureBox globoplata;
        private System.Windows.Forms.PictureBox globonegro;
        private System.Windows.Forms.Timer gameTimer;
    }
}