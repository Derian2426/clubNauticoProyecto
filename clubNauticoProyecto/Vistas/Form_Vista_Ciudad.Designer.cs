
namespace clubNauticoProyecto.Vistas
{
    partial class Form_Vista_Ciudad
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
            this.cmb_pais = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_edit_pais = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grb_registro.SuspendLayout();
            this.grb_Acciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_registro
            // 
            this.grb_registro.Controls.Add(this.label3);
            this.grb_registro.Controls.Add(this.cmb_pais);
            this.grb_registro.Location = new System.Drawing.Point(431, 118);
            this.grb_registro.Size = new System.Drawing.Size(240, 125);
            this.grb_registro.Controls.SetChildIndex(this.btn_agregar, 0);
            this.grb_registro.Controls.SetChildIndex(this.txt_datos_registro, 0);
            this.grb_registro.Controls.SetChildIndex(this.cmb_pais, 0);
            this.grb_registro.Controls.SetChildIndex(this.label3, 0);
            // 
            // grb_Acciones
            // 
            this.grb_Acciones.Controls.Add(this.label1);
            this.grb_Acciones.Controls.Add(this.cmb_edit_pais);
            this.grb_Acciones.Location = new System.Drawing.Point(431, 135);
            this.grb_Acciones.Size = new System.Drawing.Size(240, 125);
            this.grb_Acciones.TabIndex = 8;
            this.grb_Acciones.Controls.SetChildIndex(this.btn_modificar, 0);
            this.grb_Acciones.Controls.SetChildIndex(this.btn_activar_agregar, 0);
            this.grb_Acciones.Controls.SetChildIndex(this.txt_datos_modificar, 0);
            this.grb_Acciones.Controls.SetChildIndex(this.cmb_edit_pais, 0);
            this.grb_Acciones.Controls.SetChildIndex(this.label1, 0);
            this.grb_Acciones.Controls.SetChildIndex(this.btn_eliminar, 0);
            // 
            // txt_datos_modificar
            // 
            this.txt_datos_modificar.Location = new System.Drawing.Point(6, 36);
            this.txt_datos_modificar.TabIndex = 9;
            // 
            // txt_datos_registro
            // 
            this.txt_datos_registro.Location = new System.Drawing.Point(6, 35);
            // 
            // btn_agregar
            // 
            this.btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btn_agregar.Location = new System.Drawing.Point(61, 92);
            this.btn_agregar.TabIndex = 7;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btn_eliminar.Location = new System.Drawing.Point(108, 92);
            this.btn_eliminar.TabIndex = 12;
            // 
            // btn_modificar
            // 
            this.btn_modificar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btn_modificar.Location = new System.Drawing.Point(9, 92);
            this.btn_modificar.TabIndex = 11;
            // 
            // btn_activar_agregar
            // 
            this.btn_activar_agregar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btn_activar_agregar.Location = new System.Drawing.Point(207, 92);
            this.btn_activar_agregar.TabIndex = 13;
            // 
            // cmb_pais
            // 
            this.cmb_pais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_pais.FormattingEnabled = true;
            this.cmb_pais.Location = new System.Drawing.Point(6, 62);
            this.cmb_pais.Name = "cmb_pais";
            this.cmb_pais.Size = new System.Drawing.Size(228, 23);
            this.cmb_pais.TabIndex = 6;
            this.cmb_pais.SelectionChangeCommitted += new System.EventHandler(this.seleccionar_pais_ciudad);
            this.cmb_pais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buscar_cob_pais);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "NOMBRE CIUDAD :";
            // 
            // cmb_edit_pais
            // 
            this.cmb_edit_pais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_edit_pais.FormattingEnabled = true;
            this.cmb_edit_pais.Location = new System.Drawing.Point(6, 63);
            this.cmb_edit_pais.Name = "cmb_edit_pais";
            this.cmb_edit_pais.Size = new System.Drawing.Size(228, 23);
            this.cmb_edit_pais.TabIndex = 10;
            this.cmb_edit_pais.SelectionChangeCommitted += new System.EventHandler(this.edit_selection_pais);
            this.cmb_edit_pais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buscar_por_letra);
            this.cmb_edit_pais.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cargar_lista_paises);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "NOMBRE CIUDAD :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "CIUDADES";
            // 
            // Form_Vista_Ciudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 302);
            this.Controls.Add(this.label2);
            this.Name = "Form_Vista_Ciudad";
            this.Text = "Formulario Ciudad ";
            this.Controls.SetChildIndex(this.txtBuscador, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.grb_Acciones, 0);
            this.Controls.SetChildIndex(this.grb_registro, 0);
            this.grb_registro.ResumeLayout(false);
            this.grb_registro.PerformLayout();
            this.grb_Acciones.ResumeLayout(false);
            this.grb_Acciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_pais;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_edit_pais;
        private System.Windows.Forms.Label label2;
    }
}