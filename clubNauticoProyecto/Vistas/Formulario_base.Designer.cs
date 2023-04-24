
namespace clubNauticoProyecto.Vistas
{
    partial class Formulario_base
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.dgv_lista_registro = new System.Windows.Forms.DataGridView();
            this.grb_registro = new System.Windows.Forms.GroupBox();
            this.txt_datos_registro = new System.Windows.Forms.TextBox();
            this.grb_Acciones = new System.Windows.Forms.GroupBox();
            this.txt_datos_modificar = new System.Windows.Forms.TextBox();
            this.btn_activar_agregar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.btn_reporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista_registro)).BeginInit();
            this.grb_registro.SuspendLayout();
            this.grb_Acciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.Transparent;
            this.btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_agregar.Location = new System.Drawing.Point(63, 87);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(114, 27);
            this.btn_agregar.TabIndex = 4;
            this.btn_agregar.Text = "AGREGAR";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // dgv_lista_registro
            // 
            this.dgv_lista_registro.AllowUserToAddRows = false;
            this.dgv_lista_registro.AllowUserToDeleteRows = false;
            this.dgv_lista_registro.AllowUserToResizeColumns = false;
            this.dgv_lista_registro.AllowUserToResizeRows = false;
            this.dgv_lista_registro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_lista_registro.BackgroundColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_lista_registro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_lista_registro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lista_registro.Location = new System.Drawing.Point(12, 81);
            this.dgv_lista_registro.MultiSelect = false;
            this.dgv_lista_registro.Name = "dgv_lista_registro";
            this.dgv_lista_registro.ReadOnly = true;
            this.dgv_lista_registro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_lista_registro.RowHeadersVisible = false;
            this.dgv_lista_registro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_lista_registro.Size = new System.Drawing.Size(413, 211);
            this.dgv_lista_registro.TabIndex = 1;
            this.dgv_lista_registro.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.extraer_datos_rows);
            // 
            // grb_registro
            // 
            this.grb_registro.BackColor = System.Drawing.Color.LightBlue;
            this.grb_registro.Controls.Add(this.txt_datos_registro);
            this.grb_registro.Controls.Add(this.btn_agregar);
            this.grb_registro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_registro.Location = new System.Drawing.Point(437, 12);
            this.grb_registro.Name = "grb_registro";
            this.grb_registro.Size = new System.Drawing.Size(240, 129);
            this.grb_registro.TabIndex = 2;
            this.grb_registro.TabStop = false;
            this.grb_registro.Text = "AGREGAR";
            // 
            // txt_datos_registro
            // 
            this.txt_datos_registro.Location = new System.Drawing.Point(6, 20);
            this.txt_datos_registro.MaxLength = 30;
            this.txt_datos_registro.Name = "txt_datos_registro";
            this.txt_datos_registro.Size = new System.Drawing.Size(228, 21);
            this.txt_datos_registro.TabIndex = 3;
            // 
            // grb_Acciones
            // 
            this.grb_Acciones.BackColor = System.Drawing.Color.LightBlue;
            this.grb_Acciones.Controls.Add(this.txt_datos_modificar);
            this.grb_Acciones.Controls.Add(this.btn_activar_agregar);
            this.grb_Acciones.Controls.Add(this.btn_eliminar);
            this.grb_Acciones.Controls.Add(this.btn_modificar);
            this.grb_Acciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Acciones.Location = new System.Drawing.Point(437, 147);
            this.grb_Acciones.Name = "grb_Acciones";
            this.grb_Acciones.Size = new System.Drawing.Size(240, 129);
            this.grb_Acciones.TabIndex = 5;
            this.grb_Acciones.TabStop = false;
            this.grb_Acciones.Text = "ACCIONES";
            this.grb_Acciones.Visible = false;
            // 
            // txt_datos_modificar
            // 
            this.txt_datos_modificar.Location = new System.Drawing.Point(6, 20);
            this.txt_datos_modificar.MaxLength = 30;
            this.txt_datos_modificar.Name = "txt_datos_modificar";
            this.txt_datos_modificar.Size = new System.Drawing.Size(228, 21);
            this.txt_datos_modificar.TabIndex = 6;
            // 
            // btn_activar_agregar
            // 
            this.btn_activar_agregar.BackColor = System.Drawing.Color.Transparent;
            this.btn_activar_agregar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btn_activar_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_activar_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_activar_agregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_activar_agregar.Location = new System.Drawing.Point(207, 87);
            this.btn_activar_agregar.Name = "btn_activar_agregar";
            this.btn_activar_agregar.Size = new System.Drawing.Size(27, 27);
            this.btn_activar_agregar.TabIndex = 9;
            this.btn_activar_agregar.Text = "+";
            this.btn_activar_agregar.UseVisualStyleBackColor = false;
            this.btn_activar_agregar.Click += new System.EventHandler(this.btn_activar_agregar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.Transparent;
            this.btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_eliminar.Location = new System.Drawing.Point(108, 87);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(93, 27);
            this.btn_eliminar.TabIndex = 8;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.Transparent;
            this.btn_modificar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_modificar.Location = new System.Drawing.Point(9, 87);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(93, 27);
            this.btn_modificar.TabIndex = 7;
            this.btn_modificar.Text = "MODIFICAR";
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // txtBuscador
            // 
            this.txtBuscador.Location = new System.Drawing.Point(12, 52);
            this.txtBuscador.MaxLength = 30;
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(413, 20);
            this.txtBuscador.TabIndex = 0;
            this.txtBuscador.Text = "Buscar...";
            this.txtBuscador.Click += new System.EventHandler(this.txtBuscador_Click);
            this.txtBuscador.TextChanged += new System.EventHandler(this.buscar_registro);
            // 
            // btn_reporte
            // 
            this.btn_reporte.BackColor = System.Drawing.Color.Transparent;
            this.btn_reporte.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btn_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reporte.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_reporte.Location = new System.Drawing.Point(12, 12);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(157, 27);
            this.btn_reporte.TabIndex = 6;
            this.btn_reporte.Text = "GENERAR INFORME";
            this.btn_reporte.UseVisualStyleBackColor = false;
            this.btn_reporte.Click += new System.EventHandler(this.btn_reporte_Click);
            // 
            // Formulario_base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(683, 300);
            this.Controls.Add(this.btn_reporte);
            this.Controls.Add(this.grb_Acciones);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.grb_registro);
            this.Controls.Add(this.dgv_lista_registro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Formulario_base";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Club Nautico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.cerrarFormulario);
            this.Load += new System.EventHandler(this.Formulario_base_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista_registro)).EndInit();
            this.grb_registro.ResumeLayout(false);
            this.grb_registro.PerformLayout();
            this.grb_Acciones.ResumeLayout(false);
            this.grb_Acciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_lista_registro;
        public System.Windows.Forms.GroupBox grb_registro;
        public System.Windows.Forms.GroupBox grb_Acciones;
        public System.Windows.Forms.TextBox txt_datos_modificar;
        public System.Windows.Forms.TextBox txt_datos_registro;
        public System.Windows.Forms.TextBox txtBuscador;
        public System.Windows.Forms.Button btn_agregar;
        public System.Windows.Forms.Button btn_eliminar;
        public System.Windows.Forms.Button btn_modificar;
        public System.Windows.Forms.Button btn_activar_agregar;
        public System.Windows.Forms.Button btn_reporte;
    }
}