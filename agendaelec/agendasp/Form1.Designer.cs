
namespace agendasp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tdireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tapellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbuscar = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1limpiar = new System.Windows.Forms.Button();
            this.button2registrar = new System.Windows.Forms.Button();
            this.button3eliminar = new System.Windows.Forms.Button();
            this.button4modificar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.tid);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tdireccion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tapellido);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tnombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Text", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Purple;
            this.groupBox1.Location = new System.Drawing.Point(1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 136);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // tid
            // 
            this.tid.Enabled = false;
            this.tid.Location = new System.Drawing.Point(110, 41);
            this.tid.Name = "tid";
            this.tid.Size = new System.Drawing.Size(157, 31);
            this.tid.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 28);
            this.label5.TabIndex = 26;
            this.label5.Text = "id:";
            // 
            // tdireccion
            // 
            this.tdireccion.Location = new System.Drawing.Point(447, 91);
            this.tdireccion.Name = "tdireccion";
            this.tdireccion.Size = new System.Drawing.Size(199, 31);
            this.tdireccion.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dirección";
            // 
            // tapellido
            // 
            this.tapellido.Location = new System.Drawing.Point(447, 41);
            this.tapellido.Name = "tapellido";
            this.tapellido.Size = new System.Drawing.Size(199, 31);
            this.tapellido.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // tnombre
            // 
            this.tnombre.Location = new System.Drawing.Point(110, 91);
            this.tnombre.Name = "tnombre";
            this.tnombre.Size = new System.Drawing.Size(199, 31);
            this.tnombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gray;
            this.groupBox2.Controls.Add(this.tbuscar);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Font = new System.Drawing.Font("Sitka Text", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Purple;
            this.groupBox2.Location = new System.Drawing.Point(1, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(657, 73);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar";
            // 
            // tbuscar
            // 
            this.tbuscar.Location = new System.Drawing.Point(97, 36);
            this.tbuscar.Name = "tbuscar";
            this.tbuscar.Size = new System.Drawing.Size(549, 31);
            this.tbuscar.TabIndex = 1;
            this.tbuscar.TextChanged += new System.EventHandler(this.tbuscar_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 34);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 28);
            this.label18.TabIndex = 0;
            this.label18.Text = "Nombre";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gray;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Sitka Text", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Purple;
            this.groupBox3.Location = new System.Drawing.Point(1, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(657, 186);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(651, 156);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1limpiar
            // 
            this.button1limpiar.Location = new System.Drawing.Point(664, 12);
            this.button1limpiar.Name = "button1limpiar";
            this.button1limpiar.Size = new System.Drawing.Size(86, 67);
            this.button1limpiar.TabIndex = 4;
            this.button1limpiar.Text = "Limpiar";
            this.button1limpiar.UseVisualStyleBackColor = true;
            this.button1limpiar.Click += new System.EventHandler(this.button1limpiar_Click);
            // 
            // button2registrar
            // 
            this.button2registrar.Location = new System.Drawing.Point(664, 352);
            this.button2registrar.Name = "button2registrar";
            this.button2registrar.Size = new System.Drawing.Size(86, 67);
            this.button2registrar.TabIndex = 5;
            this.button2registrar.Text = "Registrar";
            this.button2registrar.UseVisualStyleBackColor = true;
            this.button2registrar.Click += new System.EventHandler(this.button2registrar_Click);
            // 
            // button3eliminar
            // 
            this.button3eliminar.Location = new System.Drawing.Point(664, 236);
            this.button3eliminar.Name = "button3eliminar";
            this.button3eliminar.Size = new System.Drawing.Size(86, 67);
            this.button3eliminar.TabIndex = 6;
            this.button3eliminar.Text = "Eliminar";
            this.button3eliminar.UseVisualStyleBackColor = true;
            this.button3eliminar.Click += new System.EventHandler(this.button3eliminar_Click);
            // 
            // button4modificar
            // 
            this.button4modificar.Location = new System.Drawing.Point(664, 122);
            this.button4modificar.Name = "button4modificar";
            this.button4modificar.Size = new System.Drawing.Size(86, 67);
            this.button4modificar.TabIndex = 7;
            this.button4modificar.Text = "Modificar";
            this.button4modificar.UseVisualStyleBackColor = true;
            this.button4modificar.Click += new System.EventHandler(this.button4modificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(762, 430);
            this.Controls.Add(this.button4modificar);
            this.Controls.Add(this.button3eliminar);
            this.Controls.Add(this.button2registrar);
            this.Controls.Add(this.button1limpiar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Indigo;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Agenda electronica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tdireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tapellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbuscar;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1limpiar;
        private System.Windows.Forms.Button button2registrar;
        private System.Windows.Forms.Button button3eliminar;
        private System.Windows.Forms.Button button4modificar;
    }
}

