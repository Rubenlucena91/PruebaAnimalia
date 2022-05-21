
namespace PruebaTestSiluetas_peces
{
    partial class ScreenStartSombras
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenStartSombras));
            this.pbFondoMar = new System.Windows.Forms.PictureBox();
            this.btStart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFondoMar)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFondoMar
            // 
            this.pbFondoMar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFondoMar.Image = ((System.Drawing.Image)(resources.GetObject("pbFondoMar.Image")));
            this.pbFondoMar.Location = new System.Drawing.Point(0, 0);
            this.pbFondoMar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbFondoMar.Name = "pbFondoMar";
            this.pbFondoMar.Size = new System.Drawing.Size(707, 441);
            this.pbFondoMar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFondoMar.TabIndex = 9;
            this.pbFondoMar.TabStop = false;
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.Color.Gold;
            this.btStart.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStart.ForeColor = System.Drawing.Color.White;
            this.btStart.Location = new System.Drawing.Point(257, 297);
            this.btStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(179, 47);
            this.btStart.TabIndex = 10;
            this.btStart.Text = "Acepto el reto";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(257, 366);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 47);
            this.button1.TabIndex = 11;
            this.button1.Text = "Segundo juego";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ScreenStartSombras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(707, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.pbFondoMar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "ScreenStartSombras";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFondoMar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbFondoMar;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button button1;
    }
}

