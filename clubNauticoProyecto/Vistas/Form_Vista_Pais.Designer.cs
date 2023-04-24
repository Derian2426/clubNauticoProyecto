
namespace clubNauticoProyecto.Vistas
{
    partial class Form_Vista_Pais
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grb_registro.SuspendLayout();
            this.grb_Acciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_registro
            // 
            this.grb_registro.Controls.Add(this.label2);
            this.grb_registro.Location = new System.Drawing.Point(431, 81);
            this.grb_registro.Controls.SetChildIndex(this.btn_agregar, 0);
            this.grb_registro.Controls.SetChildIndex(this.txt_datos_registro, 0);
            this.grb_registro.Controls.SetChildIndex(this.label2, 0);
            // 
            // grb_Acciones
            // 
            this.grb_Acciones.Controls.Add(this.label1);
            this.grb_Acciones.Location = new System.Drawing.Point(431, 114);
            this.grb_Acciones.Controls.SetChildIndex(this.btn_modificar, 0);
            this.grb_Acciones.Controls.SetChildIndex(this.btn_eliminar, 0);
            this.grb_Acciones.Controls.SetChildIndex(this.btn_activar_agregar, 0);
            this.grb_Acciones.Controls.SetChildIndex(this.txt_datos_modificar, 0);
            this.grb_Acciones.Controls.SetChildIndex(this.label1, 0);
            // 
            // txt_datos_modificar
            // 
            this.txt_datos_modificar.Location = new System.Drawing.Point(6, 60);
            // 
            // txt_datos_registro
            // 
            this.txt_datos_registro.Location = new System.Drawing.Point(6, 60);
            // 
            // btn_agregar
            // 
            this.btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            // 
            // btn_modificar
            // 
            this.btn_modificar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            // 
            // btn_activar_agregar
            // 
            this.btn_activar_agregar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "NOMBRE PAIS :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "NOMBRE PAIS :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(282, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "PAISES";
            // 
            // Form_Vista_Pais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 296);
            this.Controls.Add(this.label3);
            this.Name = "Form_Vista_Pais";
            this.Text = "Paises";
            this.Controls.SetChildIndex(this.txtBuscador, 0);
            this.Controls.SetChildIndex(this.grb_registro, 0);
            this.Controls.SetChildIndex(this.grb_Acciones, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.grb_registro.ResumeLayout(false);
            this.grb_registro.PerformLayout();
            this.grb_Acciones.ResumeLayout(false);
            this.grb_Acciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}