namespace Manejo_Eventos
{
    partial class Form2
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
            this.lblTell = new System.Windows.Forms.Label();
            this.lblAp = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTell
            // 
            this.lblTell.AutoSize = true;
            this.lblTell.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTell.Location = new System.Drawing.Point(12, 116);
            this.lblTell.Name = "lblTell";
            this.lblTell.Size = new System.Drawing.Size(76, 25);
            this.lblTell.TabIndex = 5;
            this.lblTell.Text = "label3";
            // 
            // lblAp
            // 
            this.lblAp.AutoSize = true;
            this.lblAp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAp.Location = new System.Drawing.Point(12, 60);
            this.lblAp.Name = "lblAp";
            this.lblAp.Size = new System.Drawing.Size(76, 25);
            this.lblAp.TabIndex = 4;
            this.lblAp.Text = "label2";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(12, 9);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(76, 25);
            this.lblNom.TabIndex = 3;
            this.lblNom.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(149, 190);
            this.Controls.Add(this.lblTell);
            this.Controls.Add(this.lblAp);
            this.Controls.Add(this.lblNom);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTell;
        public System.Windows.Forms.Label lblAp;
        public System.Windows.Forms.Label lblNom;
    }
}