
namespace clubNauticoProyecto
{
    partial class Form_Inicio_Club
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Inicio_Club));
            this.btn_Pais = new System.Windows.Forms.Button();
            this.btn_Ciudad = new System.Windows.Forms.Button();
            this.btn_Puerto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Pais
            // 
            this.btn_Pais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Pais.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Pais.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.btn_Pais.FlatAppearance.BorderSize = 2;
            this.btn_Pais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pais.Location = new System.Drawing.Point(197, 25);
            this.btn_Pais.Name = "btn_Pais";
            this.btn_Pais.Size = new System.Drawing.Size(172, 28);
            this.btn_Pais.TabIndex = 0;
            this.btn_Pais.Text = "PAIS";
            this.btn_Pais.UseVisualStyleBackColor = false;
            this.btn_Pais.Click += new System.EventHandler(this.btn_Pais_Click);
            // 
            // btn_Ciudad
            // 
            this.btn_Ciudad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Ciudad.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Ciudad.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.btn_Ciudad.FlatAppearance.BorderSize = 2;
            this.btn_Ciudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ciudad.Location = new System.Drawing.Point(197, 75);
            this.btn_Ciudad.Name = "btn_Ciudad";
            this.btn_Ciudad.Size = new System.Drawing.Size(172, 28);
            this.btn_Ciudad.TabIndex = 1;
            this.btn_Ciudad.Text = "CIUDAD";
            this.btn_Ciudad.UseVisualStyleBackColor = false;
            this.btn_Ciudad.Click += new System.EventHandler(this.btn_Ciudad_Click);
            // 
            // btn_Puerto
            // 
            this.btn_Puerto.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Puerto.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.btn_Puerto.FlatAppearance.BorderSize = 2;
            this.btn_Puerto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Puerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Puerto.Location = new System.Drawing.Point(197, 125);
            this.btn_Puerto.Name = "btn_Puerto";
            this.btn_Puerto.Size = new System.Drawing.Size(172, 28);
            this.btn_Puerto.TabIndex = 2;
            this.btn_Puerto.Text = "PUERTO DESTINO";
            this.btn_Puerto.UseVisualStyleBackColor = false;
            this.btn_Puerto.Click += new System.EventHandler(this.btn_Puerto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(377, 193);
            this.Controls.Add(this.btn_Puerto);
            this.Controls.Add(this.btn_Ciudad);
            this.Controls.Add(this.btn_Pais);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Club Nautico";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Pais;
        private System.Windows.Forms.Button btn_Ciudad;
        private System.Windows.Forms.Button btn_Puerto;
    }
}

