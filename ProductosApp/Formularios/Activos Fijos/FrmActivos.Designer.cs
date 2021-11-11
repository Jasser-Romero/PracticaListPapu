namespace ProductosApp.Formularios.Activos_Fijos
{
    partial class FrmActivos
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
            this.lbxActivosFijos = new System.Windows.Forms.ListBox();
            this.cmbTiposActivos = new System.Windows.Forms.ComboBox();
            this.lbxActivosSeleccionados = new System.Windows.Forms.ListBox();
            this.btnListas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpiarLista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxActivosFijos
            // 
            this.lbxActivosFijos.FormattingEnabled = true;
            this.lbxActivosFijos.Location = new System.Drawing.Point(22, 92);
            this.lbxActivosFijos.Name = "lbxActivosFijos";
            this.lbxActivosFijos.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbxActivosFijos.Size = new System.Drawing.Size(450, 290);
            this.lbxActivosFijos.TabIndex = 0;
            // 
            // cmbTiposActivos
            // 
            this.cmbTiposActivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTiposActivos.FormattingEnabled = true;
            this.cmbTiposActivos.Location = new System.Drawing.Point(143, 51);
            this.cmbTiposActivos.Name = "cmbTiposActivos";
            this.cmbTiposActivos.Size = new System.Drawing.Size(226, 21);
            this.cmbTiposActivos.TabIndex = 1;
            this.cmbTiposActivos.SelectedIndexChanged += new System.EventHandler(this.CmbTiposActivos_SelectedIndexChanged);
            // 
            // lbxActivosSeleccionados
            // 
            this.lbxActivosSeleccionados.FormattingEnabled = true;
            this.lbxActivosSeleccionados.Location = new System.Drawing.Point(627, 92);
            this.lbxActivosSeleccionados.Name = "lbxActivosSeleccionados";
            this.lbxActivosSeleccionados.Size = new System.Drawing.Size(450, 290);
            this.lbxActivosSeleccionados.TabIndex = 2;
            // 
            // btnListas
            // 
            this.btnListas.Location = new System.Drawing.Point(516, 202);
            this.btnListas.Name = "btnListas";
            this.btnListas.Size = new System.Drawing.Size(40, 32);
            this.btnListas.TabIndex = 3;
            this.btnListas.Text = ">>";
            this.btnListas.UseVisualStyleBackColor = true;
            this.btnListas.Click += new System.EventHandler(this.BtnListas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipos Activo Fijo";
            // 
            // btnLimpiarLista
            // 
            this.btnLimpiarLista.Location = new System.Drawing.Point(786, 40);
            this.btnLimpiarLista.Name = "btnLimpiarLista";
            this.btnLimpiarLista.Size = new System.Drawing.Size(110, 40);
            this.btnLimpiarLista.TabIndex = 5;
            this.btnLimpiarLista.Text = "Limpiar";
            this.btnLimpiarLista.UseVisualStyleBackColor = true;
            this.btnLimpiarLista.Click += new System.EventHandler(this.BtnLimpiarLista_Click);
            // 
            // FrmActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 413);
            this.Controls.Add(this.btnLimpiarLista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListas);
            this.Controls.Add(this.lbxActivosSeleccionados);
            this.Controls.Add(this.cmbTiposActivos);
            this.Controls.Add(this.lbxActivosFijos);
            this.Name = "FrmActivos";
            this.Text = "FrmActivos";
            this.Load += new System.EventHandler(this.FrmActivos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxActivosFijos;
        private System.Windows.Forms.ComboBox cmbTiposActivos;
        private System.Windows.Forms.ListBox lbxActivosSeleccionados;
        private System.Windows.Forms.Button btnListas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiarLista;
    }
}