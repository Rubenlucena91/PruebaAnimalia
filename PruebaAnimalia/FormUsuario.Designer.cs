
namespace PruebaAnimalia
{
    partial class FormUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuario));
            this.giraffe = new System.Windows.Forms.Button();
            this.dog = new System.Windows.Forms.Button();
            this.bear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // giraffe
            // 
            this.giraffe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("giraffe.BackgroundImage")));
            this.giraffe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.giraffe.Location = new System.Drawing.Point(633, 215);
            this.giraffe.Margin = new System.Windows.Forms.Padding(2);
            this.giraffe.Name = "giraffe";
            this.giraffe.Size = new System.Drawing.Size(146, 162);
            this.giraffe.TabIndex = 2;
            this.giraffe.UseVisualStyleBackColor = true;
            this.giraffe.Click += new System.EventHandler(this.click);
            // 
            // dog
            // 
            this.dog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dog.BackgroundImage")));
            this.dog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dog.Location = new System.Drawing.Point(409, 215);
            this.dog.Margin = new System.Windows.Forms.Padding(2);
            this.dog.Name = "dog";
            this.dog.Size = new System.Drawing.Size(146, 162);
            this.dog.TabIndex = 1;
            this.dog.UseVisualStyleBackColor = true;
            this.dog.Click += new System.EventHandler(this.click);
            // 
            // bear
            // 
            this.bear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bear.BackgroundImage")));
            this.bear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bear.Location = new System.Drawing.Point(185, 215);
            this.bear.Margin = new System.Windows.Forms.Padding(2);
            this.bear.Name = "bear";
            this.bear.Size = new System.Drawing.Size(146, 162);
            this.bear.TabIndex = 0;
            this.bear.UseVisualStyleBackColor = true;
            this.bear.Click += new System.EventHandler(this.click);
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 592);
            this.Controls.Add(this.giraffe);
            this.Controls.Add(this.dog);
            this.Controls.Add(this.bear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormUsuario";
            this.Text = "FormUsuario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bear;
        private System.Windows.Forms.Button dog;
        private System.Windows.Forms.Button giraffe;
    }
}