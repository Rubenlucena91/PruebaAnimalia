
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
            this.pictureBoxRight = new System.Windows.Forms.PictureBox();
            this.pictureBoxLeft = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxSombra = new System.Windows.Forms.PictureBox();
            this.pictureBoxResultado = new System.Windows.Forms.PictureBox();
            this.timerCheck = new System.Windows.Forms.Timer(this.components);
            this.timerImagenes = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelTC = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTR = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelJuego.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).BeginInit();
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
            this.panelTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.panelJuego.Controls.Add(this.pictureBoxRight);
            this.panelJuego.Controls.Add(this.pictureBoxLeft);
            this.panelJuego.Controls.Add(this.pictureBox4);
            this.panelJuego.Controls.Add(this.pictureBox3);
            this.panelJuego.Controls.Add(this.pictureBox2);
            this.panelJuego.Location = new System.Drawing.Point(10, 232);
            this.panelJuego.Name = "panelJuego";
            this.panelJuego.Size = new System.Drawing.Size(988, 349);
            this.panelJuego.TabIndex = 26;
            // 
            // pictureBoxRight
            // 
            this.pictureBoxRight.BackgroundImage = global::PruebaAnimalia.Properties.Resources.cabra;
            this.pictureBoxRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxRight.Location = new System.Drawing.Point(748, 49);
            this.pictureBoxRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxRight.Name = "pictureBoxRight";
            this.pictureBoxRight.Size = new System.Drawing.Size(138, 168);
            this.pictureBoxRight.TabIndex = 32;
            this.pictureBoxRight.TabStop = false;
            this.pictureBoxRight.Tag = "cabra";
            this.pictureBoxRight.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBoxLeft
            // 
            this.pictureBoxLeft.BackgroundImage = global::PruebaAnimalia.Properties.Resources.mono;
            this.pictureBoxLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLeft.Location = new System.Drawing.Point(103, 49);
            this.pictureBoxLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxLeft.Name = "pictureBoxLeft";
            this.pictureBoxLeft.Size = new System.Drawing.Size(138, 168);
            this.pictureBoxLeft.TabIndex = 31;
            this.pictureBoxLeft.TabStop = false;
            this.pictureBoxLeft.Tag = "mono";
            this.pictureBoxLeft.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::PruebaAnimalia.Properties.Resources.cerdo;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(425, 143);
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
            this.pictureBox3.Location = new System.Drawing.Point(586, 89);
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
            this.pictureBox2.Location = new System.Drawing.Point(264, 89);
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
            this.pictureBoxResultado.Location = new System.Drawing.Point(838, 67);
            this.pictureBoxResultado.Name = "pictureBoxResultado";
            this.pictureBoxResultado.Size = new System.Drawing.Size(160, 159);
            this.pictureBoxResultado.TabIndex = 28;
            this.pictureBoxResultado.TabStop = false;
            // 
            // timerCheck
            // 
            this.timerCheck.Interval = 2000;
            this.timerCheck.Tick += new System.EventHandler(this.timerCheck_Tick);
            // 
            // timerImagenes
            // 
            this.timerImagenes.Interval = 3000;
            this.timerImagenes.Tick += new System.EventHandler(this.timerImagenes_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Tiempo check:";
            // 
            // labelTC
            // 
            this.labelTC.AutoSize = true;
            this.labelTC.Location = new System.Drawing.Point(138, 84);
            this.labelTC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTC.Name = "labelTC";
            this.labelTC.Size = new System.Drawing.Size(19, 13);
            this.labelTC.TabIndex = 30;
            this.labelTC.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 112);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Tiempo responder:";
            // 
            // labelTR
            // 
            this.labelTR.AutoSize = true;
            this.labelTR.Location = new System.Drawing.Point(140, 112);
            this.labelTR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTR.Name = "labelTR";
            this.labelTR.Size = new System.Drawing.Size(19, 13);
            this.labelTR.TabIndex = 32;
            this.labelTR.Text = "00";
            // 
            // FormJuegoA1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 592);
            this.Controls.Add(this.labelTR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelTC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxResultado);
            this.Controls.Add(this.pictureBoxSombra);
            this.Controls.Add(this.panelJuego);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormJuegoA1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Juego Agudeza";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormJuegoA1_FormClosed);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelJuego.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).EndInit();
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
        private System.Windows.Forms.Timer timerCheck;
        private System.Windows.Forms.Timer timerImagenes;
        private System.Windows.Forms.PictureBox pictureBoxRight;
        private System.Windows.Forms.PictureBox pictureBoxLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTR;
    }
}