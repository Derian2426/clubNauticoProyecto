
namespace clubNauticoProyecto.Vistas
{
    partial class Form_Vista_Puerto
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
            this.cmb_ListaCiudades = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_pais = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_edit_ciudad = new System.Windows.Forms.ComboBox();
            this.cmb_edit_pais = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grb_registro.SuspendLayout();
            this.grb_Acciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_registro
            // 
            this.grb_registro.Controls.Add(this.label3);
            this.grb_registro.Controls.Add(this.cmb_ListaCiudades);
            this.grb_registro.Controls.Add(this.label4);
            this.grb_registro.Controls.Add(this.cmb_pais);
            this.grb_registro.Controls.Add(this.label2);
            this.grb_registro.Location = new System.Drawing.Point(437, 75);
            this.grb_registro.Size = new System.Drawing.Size(255, 217);
            this.grb_registro.Text = "AGREGAR NUEVO PUERTO";
            this.grb_registro.Controls.SetChildIndex(this.btn_agregar, 0);
            this.grb_registro.Controls.SetChildIndex(this.txt_datos_registro, 0);
            this.grb_registro.Controls.SetChildIndex(this.label2, 0);
            this.grb_registro.Controls.SetChildIndex(this.cmb_pais, 0);
            this.grb_registro.Controls.SetChildIndex(this.label4, 0);
            this.grb_registro.Controls.SetChildIndex(this.cmb_ListaCiudades, 0);
            this.grb_registro.Controls.SetChildIndex(this.label3, 0);
            // 
            // grb_Acciones
            // 
            this.grb_Acciones.Controls.Add(this.cmb_edit_ciudad);
            this.grb_Acciones.Controls.Add(this.cmb_edit_pais);
            this.grb_Acciones.Controls.Add(this.label7);
            this.grb_Acciones.Controls.Add(this.label6);
            this.grb_Acciones.Controls.Add(this.label5);
            this.grb_Acciones.Location = new System.Drawing.Point(437, 75);
            this.grb_Acciones.Size = new System.Drawing.Size(255, 217);
            this.grb_Acciones.Text = "ACCIONES PUERTO";
            this.grb_Acciones.Controls.SetChildIndex(this.btn_modificar, 0);
            this.grb_Acciones.Controls.SetChildIndex(this.btn_eliminar, 0);
            this.grb_Acciones.Controls.SetChildIndex(this.btn_activar_agregar, 0);
            this.grb_Acciones.Controls.SetChildIndex(this.txt_datos_modificar, 0);
            this.grb_Acciones.Controls.SetChildIndex(this.label5, 0);
            this.grb_Acciones.Controls.SetChildIndex(this.label6, 0);
            this.grb_Acciones.Controls.SetChildIndex(this.label7, 0);
            this.grb_Acciones.Controls.SetChildIndex(this.cmb_edit_pais, 0);
            this.grb_Acciones.Controls.SetChildIndex(this.cmb_edit_ciudad, 0);
            // 
            // txt_datos_modificar
            // 
            this.txt_datos_modificar.Location = new System.Drawing.Point(6, 42);
            this.txt_datos_modificar.Size = new System.Drawing.Size(243, 21);
            // 
            // txt_datos_registro
            // 
            this.txt_datos_registro.Location = new System.Drawing.Point(6, 45);
            this.txt_datos_registro.Size = new System.Drawing.Size(243, 21);
            // 
            // btn_agregar
            // 
            this.btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btn_agregar.Location = new System.Drawing.Point(64, 184);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btn_eliminar.Location = new System.Drawing.Point(114, 184);
            // 
            // btn_modificar
            // 
            this.btn_modificar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btn_modificar.Location = new System.Drawing.Point(15, 184);
            // 
            // btn_activar_agregar
            // 
            this.btn_activar_agregar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btn_activar_agregar.Location = new System.Drawing.Point(213, 184);
            // 
            // cmb_ListaCiudades
            // 
            this.cmb_ListaCiudades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ListaCiudades.FormattingEnabled = true;
            this.cmb_ListaCiudades.Location = new System.Drawing.Point(6, 137);
            this.cmb_ListaCiudades.Name = "cmb_ListaCiudades";
            this.cmb_ListaCiudades.Size = new System.Drawing.Size(243, 23);
            this.cmb_ListaCiudades.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "ELEGIR CIUDAD :";
            // 
            // cmb_pais
            // 
            this.cmb_pais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_pais.FormattingEnabled = true;
            this.cmb_pais.Location = new System.Drawing.Point(6, 93);
            this.cmb_pais.Name = "cmb_pais";
            this.cmb_pais.Size = new System.Drawing.Size(243, 23);
            this.cmb_pais.TabIndex = 15;
            this.cmb_pais.SelectionChangeCommitted += new System.EventHandler(this.seleccionar_pais_change_ciudad);
            this.cmb_pais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buscra_pais);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "ELEGIR PAIS :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "NOMBRE PUERTO :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "NOMBRE PUERTO :";
            // 
            // cmb_edit_ciudad
            // 
            this.cmb_edit_ciudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_edit_ciudad.FormattingEnabled = true;
            this.cmb_edit_ciudad.Location = new System.Drawing.Point(5, 126);
            this.cmb_edit_ciudad.Name = "cmb_edit_ciudad";
            this.cmb_edit_ciudad.Size = new System.Drawing.Size(244, 23);
            this.cmb_edit_ciudad.TabIndex = 20;
            this.cmb_edit_ciudad.SelectionChangeCommitted += new System.EventHandler(this.seleccion_edit_ciudad);
            this.cmb_edit_ciudad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lista_ciudad_edit);
            // 
            // cmb_edit_pais
            // 
            this.cmb_edit_pais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_edit_pais.FormattingEnabled = true;
            this.cmb_edit_pais.Location = new System.Drawing.Point(5, 82);
            this.cmb_edit_pais.Name = "cmb_edit_pais";
            this.cmb_edit_pais.Size = new System.Drawing.Size(244, 23);
            this.cmb_edit_pais.TabIndex = 19;
            this.cmb_edit_pais.SelectionChangeCommitted += new System.EventHandler(this.selecction_edit_pais);
            this.cmb_edit_pais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buscar_edit_pais);
            this.cmb_edit_pais.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listar_pais);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "NOMBRE CIUDAD :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "NOMBRE PAIS :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "PUERTO DESTINO";
            // 
            // Form_Vista_Puerto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 306);
            this.Controls.Add(this.label1);
            this.Name = "Form_Vista_Puerto";
            this.Text = "Form_Vista_Puerto";
            this.Controls.SetChildIndex(this.grb_registro, 0);
            this.Controls.SetChildIndex(this.txtBuscador, 0);
            this.Controls.SetChildIndex(this.grb_Acciones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.grb_registro.ResumeLayout(false);
            this.grb_registro.PerformLayout();
            this.grb_Acciones.ResumeLayout(false);
            this.grb_Acciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_ListaCiudades;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_pais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_edit_ciudad;
        private System.Windows.Forms.ComboBox cmb_edit_pais;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}