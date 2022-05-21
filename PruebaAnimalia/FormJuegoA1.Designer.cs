
namespace PruebaAnimalia
{
    partial class FormJuegoA1
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.lb_puntos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timerPartida = new System.Windows.Forms.Timer(this.components);
            this.panelJuego = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxSombra = new System.Windows.Forms.PictureBox();
            this.pictureBoxResultado = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelJuego.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSombra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Controls.Add(this.labelTime);
            this.panelTop.Controls.Add(this.lb_puntos);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1008, 53);
            this.panelTop.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AccessibleName = "lb_aciertos";
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.label4.Location = new System.Drawing.Point(865, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tiempo:";
            // 
            // labelTime
            // 
            this.labelTime.AccessibleName = "lb_timer";
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(214)))), ((int)(((byte)(195)))));
            this.labelTime.Location = new System.Drawing.Point(932, 16);
            this.labelTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(30, 23);
            this.labelTime.TabIndex = 25;
            this.labelTime.Text = "30";
            // 
            // lb_puntos
            // 
            this.lb_puntos.AccessibleName = "lb_puntos";
            this.lb_puntos.AutoSize = true;
            this.lb_puntos.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_puntos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(214)))), ((int)(((byte)(195)))));
            this.lb_puntos.Location = new System.Drawing.Point(137, 16);
            this.lb_puntos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_puntos.Name = "lb_puntos";
            this.lb_puntos.Size = new System.Drawing.Size(20, 23);
            this.lb_puntos.TabIndex = 25;
            this.lb_puntos.Text = "0";
            // 
            // label3
            // 
            this.label3.AccessibleName = "lb_aciertos";
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.label3.Location = new System.Drawing.Point(38, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "Puntuacion:";
            // 
            // timerPartida
            // 
            this.timerPartida.Interval = 1000;
            this.timerPartida.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // panelJuego
            // 
            this.panelJuego.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelJuego.Controls.Add(this.pictureBox4);
            this.panelJuego.Controls.Add(this.pictureBox3);
            this.panelJuego.Controls.Add(this.pictureBox2);
            this.panelJuego.Location = new System.Drawing.Point(194, 232);
            this.panelJuego.Name = "panelJuego";
            this.panelJuego.Size = new System.Drawing.Size(629, 298);
            this.panelJuego.TabIndex = 26;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::PruebaAnimalia.Properties.Resources.cerdo;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(241, 99);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(138, 168);
            this.pictureBox4.TabIndex = 30;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "cerdo";
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::PruebaAnimalia.Properties.Resources.mapache;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(488, 51);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(138, 168);
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "mapache";
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::PruebaAnimalia.Properties.Resources.lobo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(13, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(138, 168);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "lobo";
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBoxSombra
            // 
            this.pictureBoxSombra.BackgroundImage = global::PruebaAnimalia.Properties.Resources.lobo_sombra;
            this.pictureBoxSombra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxSombra.Location = new System.Drawing.Point(435, 58);
            this.pictureBoxSombra.Name = "pictureBoxSombra";
            this.pictureBoxSombra.Size = new System.Drawing.Size(138, 168);
            this.pictureBoxSombra.TabIndex = 27;
            this.pictureBoxSombra.TabStop = false;
            this.pictureBoxSombra.Tag = "lobo_sombra";
            // 
            // pictureBoxResultado
            // 
            this.pictureBoxResultado.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBoxResultado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxResultado.Location = new System.Drawing.Point(836, 76);
            this.pictureBoxResultado.Name = "pictureBoxResultado";
            this.pictureBoxResultado.Size = new System.Drawing.Size(160, 159);
            this.pictureBoxResultado.TabIndex = 28;
            this.pictureBoxResultado.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 533);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(477, 533);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "label2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(744, 533);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "label5";
            // 
            // FormJuegoA1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 592);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBoxResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxSombra);
            this.Controls.Add(this.panelJuego);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormJuegoA1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Juego Agudeza";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelJuego.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSombra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label lb_puntos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timerPartida;
        private System.Windows.Forms.Panel panelJuego;
        private System.Windows.Forms.PictureBox pictureBoxSombra;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}