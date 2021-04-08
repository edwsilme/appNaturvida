namespace appNaturvida
{
    partial class Productos
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn2Limpiar = new System.Windows.Forms.Button();
            this.btn1Guardar = new System.Windows.Forms.Button();
            this.txt4Cantidad = new System.Windows.Forms.TextBox();
            this.txt3Valor = new System.Windows.Forms.TextBox();
            this.txt2Descripcion = new System.Windows.Forms.TextBox();
            this.txt1Codigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tn3Consultar = new System.Windows.Forms.Button();
            this.GridDatos = new System.Windows.Forms.DataGridView();
            this.cb1Consultar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn5GCambios = new System.Windows.Forms.Button();
            this.btn4Modificar = new System.Windows.Forms.Button();
            this.txt8Cantidad = new System.Windows.Forms.TextBox();
            this.txt7Valor = new System.Windows.Forms.TextBox();
            this.txt6Descripcion = new System.Windows.Forms.TextBox();
            this.txt5Codigo = new System.Windows.Forms.TextBox();
            this.cb2Modificar = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn6Eliminar = new System.Windows.Forms.Button();
            this.cb3Eliminar = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDatos)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitulo.Location = new System.Drawing.Point(80, 33);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(379, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "GESTION DE PRODUCTOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(53, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 93);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(520, 351);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn2Limpiar);
            this.tabPage1.Controls.Add(this.btn1Guardar);
            this.tabPage1.Controls.Add(this.txt4Cantidad);
            this.tabPage1.Controls.Add(this.txt3Valor);
            this.tabPage1.Controls.Add(this.txt2Descripcion);
            this.tabPage1.Controls.Add(this.txt1Codigo);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(512, 325);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registrar Producto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn2Limpiar
            // 
            this.btn2Limpiar.Location = new System.Drawing.Point(329, 240);
            this.btn2Limpiar.Name = "btn2Limpiar";
            this.btn2Limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn2Limpiar.TabIndex = 10;
            this.btn2Limpiar.Text = "Limpiar";
            this.btn2Limpiar.UseVisualStyleBackColor = true;
            this.btn2Limpiar.Click += new System.EventHandler(this.btn2Limpiar_Click);
            // 
            // btn1Guardar
            // 
            this.btn1Guardar.Location = new System.Drawing.Point(92, 240);
            this.btn1Guardar.Name = "btn1Guardar";
            this.btn1Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn1Guardar.TabIndex = 9;
            this.btn1Guardar.Text = "Guardar";
            this.btn1Guardar.UseVisualStyleBackColor = true;
            this.btn1Guardar.Click += new System.EventHandler(this.btn1Guardar_Click);
            // 
            // txt4Cantidad
            // 
            this.txt4Cantidad.Location = new System.Drawing.Point(175, 155);
            this.txt4Cantidad.Name = "txt4Cantidad";
            this.txt4Cantidad.Size = new System.Drawing.Size(268, 20);
            this.txt4Cantidad.TabIndex = 8;
            this.txt4Cantidad.TextChanged += new System.EventHandler(this.txt4Cantidad_TextChanged);
            // 
            // txt3Valor
            // 
            this.txt3Valor.Location = new System.Drawing.Point(175, 114);
            this.txt3Valor.Name = "txt3Valor";
            this.txt3Valor.Size = new System.Drawing.Size(268, 20);
            this.txt3Valor.TabIndex = 7;
            this.txt3Valor.TextChanged += new System.EventHandler(this.txt3Valor_TextChanged);
            // 
            // txt2Descripcion
            // 
            this.txt2Descripcion.Location = new System.Drawing.Point(175, 76);
            this.txt2Descripcion.Name = "txt2Descripcion";
            this.txt2Descripcion.Size = new System.Drawing.Size(268, 20);
            this.txt2Descripcion.TabIndex = 6;
            this.txt2Descripcion.TextChanged += new System.EventHandler(this.txt2Descripcion_TextChanged);
            // 
            // txt1Codigo
            // 
            this.txt1Codigo.Location = new System.Drawing.Point(175, 35);
            this.txt1Codigo.Name = "txt1Codigo";
            this.txt1Codigo.Size = new System.Drawing.Size(132, 20);
            this.txt1Codigo.TabIndex = 5;
            this.txt1Codigo.TextChanged += new System.EventHandler(this.txt1Codigo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(53, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(53, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(53, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tn3Consultar);
            this.tabPage2.Controls.Add(this.GridDatos);
            this.tabPage2.Controls.Add(this.cb1Consultar);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(512, 325);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar Producto";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tn3Consultar
            // 
            this.tn3Consultar.Location = new System.Drawing.Point(213, 98);
            this.tn3Consultar.Name = "tn3Consultar";
            this.tn3Consultar.Size = new System.Drawing.Size(75, 23);
            this.tn3Consultar.TabIndex = 3;
            this.tn3Consultar.Text = "Consultar";
            this.tn3Consultar.UseVisualStyleBackColor = true;
            this.tn3Consultar.Click += new System.EventHandler(this.tn3Consultar_Click);
            // 
            // GridDatos
            // 
            this.GridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDatos.Location = new System.Drawing.Point(8, 140);
            this.GridDatos.Name = "GridDatos";
            this.GridDatos.Size = new System.Drawing.Size(496, 179);
            this.GridDatos.TabIndex = 2;
            this.GridDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDatos_CellContentClick);
            this.GridDatos.SelectionChanged += new System.EventHandler(this.GridDatos_SelectionChanged);
            // 
            // cb1Consultar
            // 
            this.cb1Consultar.FormattingEnabled = true;
            this.cb1Consultar.Location = new System.Drawing.Point(201, 59);
            this.cb1Consultar.Name = "cb1Consultar";
            this.cb1Consultar.Size = new System.Drawing.Size(194, 21);
            this.cb1Consultar.TabIndex = 1;
            this.cb1Consultar.SelectedIndexChanged += new System.EventHandler(this.cb1Consultar_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(91, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Producto";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn5GCambios);
            this.tabPage3.Controls.Add(this.btn4Modificar);
            this.tabPage3.Controls.Add(this.txt8Cantidad);
            this.tabPage3.Controls.Add(this.txt7Valor);
            this.tabPage3.Controls.Add(this.txt6Descripcion);
            this.tabPage3.Controls.Add(this.txt5Codigo);
            this.tabPage3.Controls.Add(this.cb2Modificar);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(512, 325);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Editar Producto";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn5GCambios
            // 
            this.btn5GCambios.Location = new System.Drawing.Point(162, 271);
            this.btn5GCambios.Name = "btn5GCambios";
            this.btn5GCambios.Size = new System.Drawing.Size(152, 23);
            this.btn5GCambios.TabIndex = 11;
            this.btn5GCambios.Text = "Guardar Cambios";
            this.btn5GCambios.UseVisualStyleBackColor = true;
            this.btn5GCambios.Click += new System.EventHandler(this.btn5GCambios_Click);
            // 
            // btn4Modificar
            // 
            this.btn4Modificar.Location = new System.Drawing.Point(404, 37);
            this.btn4Modificar.Name = "btn4Modificar";
            this.btn4Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn4Modificar.TabIndex = 10;
            this.btn4Modificar.Text = "Consultar";
            this.btn4Modificar.UseVisualStyleBackColor = true;
            this.btn4Modificar.Click += new System.EventHandler(this.btn4Modificar_Click);
            // 
            // txt8Cantidad
            // 
            this.txt8Cantidad.Location = new System.Drawing.Point(145, 218);
            this.txt8Cantidad.Name = "txt8Cantidad";
            this.txt8Cantidad.Size = new System.Drawing.Size(225, 20);
            this.txt8Cantidad.TabIndex = 9;
            this.txt8Cantidad.TextChanged += new System.EventHandler(this.txt8Cantidad_TextChanged);
            // 
            // txt7Valor
            // 
            this.txt7Valor.Location = new System.Drawing.Point(145, 177);
            this.txt7Valor.Name = "txt7Valor";
            this.txt7Valor.Size = new System.Drawing.Size(225, 20);
            this.txt7Valor.TabIndex = 8;
            this.txt7Valor.TextChanged += new System.EventHandler(this.txt7Valor_TextChanged);
            // 
            // txt6Descripcion
            // 
            this.txt6Descripcion.Location = new System.Drawing.Point(145, 130);
            this.txt6Descripcion.Name = "txt6Descripcion";
            this.txt6Descripcion.Size = new System.Drawing.Size(225, 20);
            this.txt6Descripcion.TabIndex = 7;
            this.txt6Descripcion.TextChanged += new System.EventHandler(this.txt6Descripcion_TextChanged);
            // 
            // txt5Codigo
            // 
            this.txt5Codigo.Location = new System.Drawing.Point(145, 84);
            this.txt5Codigo.Name = "txt5Codigo";
            this.txt5Codigo.Size = new System.Drawing.Size(148, 20);
            this.txt5Codigo.TabIndex = 6;
            this.txt5Codigo.TextChanged += new System.EventHandler(this.txt5Codigo_TextChanged);
            // 
            // cb2Modificar
            // 
            this.cb2Modificar.FormattingEnabled = true;
            this.cb2Modificar.Location = new System.Drawing.Point(145, 35);
            this.cb2Modificar.Name = "cb2Modificar";
            this.cb2Modificar.Size = new System.Drawing.Size(225, 21);
            this.cb2Modificar.TabIndex = 5;
            this.cb2Modificar.SelectedIndexChanged += new System.EventHandler(this.cb2Modificar_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(37, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Cantidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(37, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Valor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(37, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Descripción";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(37, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Código";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(37, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Producto";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn6Eliminar);
            this.tabPage4.Controls.Add(this.cb3Eliminar);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(512, 325);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Eliminar Producto";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn6Eliminar
            // 
            this.btn6Eliminar.Location = new System.Drawing.Point(208, 149);
            this.btn6Eliminar.Name = "btn6Eliminar";
            this.btn6Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn6Eliminar.TabIndex = 2;
            this.btn6Eliminar.Text = "Eliminar";
            this.btn6Eliminar.UseVisualStyleBackColor = true;
            this.btn6Eliminar.Click += new System.EventHandler(this.btn6Eliminar_Click);
            // 
            // cb3Eliminar
            // 
            this.cb3Eliminar.FormattingEnabled = true;
            this.cb3Eliminar.Location = new System.Drawing.Point(208, 72);
            this.cb3Eliminar.Name = "cb3Eliminar";
            this.cb3Eliminar.Size = new System.Drawing.Size(216, 21);
            this.cb3Eliminar.TabIndex = 1;
            this.cb3Eliminar.SelectedIndexChanged += new System.EventHandler(this.cb3Eliminar_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(91, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Producto";
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 455);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDatos)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn2Limpiar;
        private System.Windows.Forms.Button btn1Guardar;
        private System.Windows.Forms.TextBox txt4Cantidad;
        private System.Windows.Forms.TextBox txt3Valor;
        private System.Windows.Forms.TextBox txt2Descripcion;
        private System.Windows.Forms.TextBox txt1Codigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView GridDatos;
        private System.Windows.Forms.ComboBox cb1Consultar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn5GCambios;
        private System.Windows.Forms.Button btn4Modificar;
        private System.Windows.Forms.TextBox txt8Cantidad;
        private System.Windows.Forms.TextBox txt7Valor;
        private System.Windows.Forms.TextBox txt6Descripcion;
        private System.Windows.Forms.TextBox txt5Codigo;
        private System.Windows.Forms.ComboBox cb2Modificar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button tn3Consultar;
        private System.Windows.Forms.Button btn6Eliminar;
        private System.Windows.Forms.ComboBox cb3Eliminar;
        private System.Windows.Forms.Label label11;
    }
}