namespace Actualizar_Categoría
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DGV_CATEGORÍA = new System.Windows.Forms.DataGridView();
            this.btnBuscarID = new System.Windows.Forms.Button();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.btnActualizarDatos = new System.Windows.Forms.Button();
            this.txtNameCat = new System.Windows.Forms.TextBox();
            this.txtCategoríaID = new System.Windows.Forms.TextBox();
            this.txtBuscarID = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CATEGORÍA)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_CATEGORÍA
            // 
            this.DGV_CATEGORÍA.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGV_CATEGORÍA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CATEGORÍA.Location = new System.Drawing.Point(315, 22);
            this.DGV_CATEGORÍA.Name = "DGV_CATEGORÍA";
            this.DGV_CATEGORÍA.Size = new System.Drawing.Size(454, 250);
            this.DGV_CATEGORÍA.TabIndex = 0;
            // 
            // btnBuscarID
            // 
            this.btnBuscarID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBuscarID.Location = new System.Drawing.Point(315, 330);
            this.btnBuscarID.Name = "btnBuscarID";
            this.btnBuscarID.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarID.TabIndex = 1;
            this.btnBuscarID.Text = "Buscar";
            this.btnBuscarID.UseVisualStyleBackColor = false;
            this.btnBuscarID.Click += new System.EventHandler(this.btnBuscarID_Click);
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCargarDatos.Location = new System.Drawing.Point(470, 330);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(108, 23);
            this.btnCargarDatos.TabIndex = 2;
            this.btnCargarDatos.Text = "Cargar Datos";
            this.btnCargarDatos.UseVisualStyleBackColor = false;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // btnActualizarDatos
            // 
            this.btnActualizarDatos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnActualizarDatos.Location = new System.Drawing.Point(658, 330);
            this.btnActualizarDatos.Name = "btnActualizarDatos";
            this.btnActualizarDatos.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarDatos.TabIndex = 3;
            this.btnActualizarDatos.Text = "Actualizar";
            this.btnActualizarDatos.UseVisualStyleBackColor = false;
            this.btnActualizarDatos.Click += new System.EventHandler(this.btnActualizarDatos_Click);
            // 
            // txtNameCat
            // 
            this.txtNameCat.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNameCat.Location = new System.Drawing.Point(131, 153);
            this.txtNameCat.Name = "txtNameCat";
            this.txtNameCat.Size = new System.Drawing.Size(115, 20);
            this.txtNameCat.TabIndex = 4;
            // 
            // txtCategoríaID
            // 
            this.txtCategoríaID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCategoríaID.Location = new System.Drawing.Point(131, 323);
            this.txtCategoríaID.Name = "txtCategoríaID";
            this.txtCategoríaID.Size = new System.Drawing.Size(100, 20);
            this.txtCategoríaID.TabIndex = 5;
            // 
            // txtBuscarID
            // 
            this.txtBuscarID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBuscarID.Location = new System.Drawing.Point(131, 83);
            this.txtBuscarID.Name = "txtBuscarID";
            this.txtBuscarID.Size = new System.Drawing.Size(115, 20);
            this.txtBuscarID.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDescripcion.Location = new System.Drawing.Point(131, 252);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(115, 20);
            this.txtDescripcion.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(38, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID Categoría";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(17, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre Categoría";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(43, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(68, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(109, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "BUSCAR POR ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(67, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "GESTIÓN Y ACTUALIZACIÓN:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtBuscarID);
            this.Controls.Add(this.txtCategoríaID);
            this.Controls.Add(this.txtNameCat);
            this.Controls.Add(this.btnActualizarDatos);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.btnBuscarID);
            this.Controls.Add(this.DGV_CATEGORÍA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CATEGORÍA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_CATEGORÍA;
        private System.Windows.Forms.Button btnBuscarID;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.Button btnActualizarDatos;
        private System.Windows.Forms.TextBox txtNameCat;
        private System.Windows.Forms.TextBox txtCategoríaID;
        private System.Windows.Forms.TextBox txtBuscarID;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

