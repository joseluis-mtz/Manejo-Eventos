namespace Manejo_Eventos
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstNum = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbElementos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbDos = new System.Windows.Forms.RadioButton();
            this.rbUno = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Elementos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Números:";
            // 
            // lstNum
            // 
            this.lstNum.FormattingEnabled = true;
            this.lstNum.Items.AddRange(new object[] {
            "Uno",
            "Dos",
            "Tres",
            "Cuatro",
            "Cinco",
            "Seis",
            "Siete",
            "Ocho",
            "Nueve",
            "Diez"});
            this.lstNum.Location = new System.Drawing.Point(380, 22);
            this.lstNum.Name = "lstNum";
            this.lstNum.Size = new System.Drawing.Size(143, 121);
            this.lstNum.TabIndex = 26;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(222, 231);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 27);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbElementos
            // 
            this.cmbElementos.FormattingEnabled = true;
            this.cmbElementos.Items.AddRange(new object[] {
            "Elemento 1",
            "Elemento 2",
            "Elemento 3",
            "Elemento 4",
            "Elemento 5",
            "Elemento 6",
            "Elemento 7",
            "Elemento 8",
            "Elemento 9",
            "Elemento 10"});
            this.cmbElementos.Location = new System.Drawing.Point(222, 22);
            this.cmbElementos.Name = "cmbElementos";
            this.cmbElementos.Size = new System.Drawing.Size(121, 21);
            this.cmbElementos.TabIndex = 24;
            this.cmbElementos.SelectedIndexChanged += new System.EventHandler(this.cmbElementos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Teléfono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre:";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(222, 189);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(121, 20);
            this.txtTel.TabIndex = 20;
            // 
            // txtApe
            // 
            this.txtApe.Location = new System.Drawing.Point(222, 136);
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(121, 20);
            this.txtApe.TabIndex = 19;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(222, 80);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(121, 20);
            this.txtNom.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Manejo_Eventos.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(5, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // rbDos
            // 
            this.rbDos.AutoSize = true;
            this.rbDos.Location = new System.Drawing.Point(14, 26);
            this.rbDos.Name = "rbDos";
            this.rbDos.Size = new System.Drawing.Size(68, 17);
            this.rbDos.TabIndex = 16;
            this.rbDos.TabStop = true;
            this.rbDos.Text = "Opción 2";
            this.rbDos.UseVisualStyleBackColor = true;
            this.rbDos.CheckedChanged += new System.EventHandler(this.rbDos_CheckedChanged);
            // 
            // rbUno
            // 
            this.rbUno.AutoSize = true;
            this.rbUno.Location = new System.Drawing.Point(15, 3);
            this.rbUno.Name = "rbUno";
            this.rbUno.Size = new System.Drawing.Size(68, 17);
            this.rbUno.TabIndex = 15;
            this.rbUno.TabStop = true;
            this.rbUno.Text = "Opción 1";
            this.rbUno.UseVisualStyleBackColor = true;
            this.rbUno.CheckedChanged += new System.EventHandler(this.rbUno_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 265);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstNum);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbElementos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtApe);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rbDos);
            this.Controls.Add(this.rbUno);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manejar eventos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstNum;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbElementos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtTel;
        public System.Windows.Forms.TextBox txtApe;
        public System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbDos;
        private System.Windows.Forms.RadioButton rbUno;
    }
}

