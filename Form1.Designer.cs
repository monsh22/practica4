namespace practica4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butGUARDAR = new System.Windows.Forms.Button();
            this.CANCELAR = new System.Windows.Forms.Button();
            this.NOM = new System.Windows.Forms.TextBox();
            this.ESTA = new System.Windows.Forms.TextBox();
            this.TELE = new System.Windows.Forms.TextBox();
            this.APE = new System.Windows.Forms.TextBox();
            this.EDAD = new System.Windows.Forms.TextBox();
            this.GENER = new System.Windows.Forms.RadioButton();
            this.GEN = new System.Windows.Forms.RadioButton();
            this.GENE = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "APELLIDOS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "TELEFONO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "ESTATURA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "EDAD:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GENE);
            this.panel1.Controls.Add(this.GEN);
            this.panel1.Controls.Add(this.GENER);
            this.panel1.Location = new System.Drawing.Point(104, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 100);
            this.panel1.TabIndex = 8;
            // 
            // butGUARDAR
            // 
            this.butGUARDAR.Location = new System.Drawing.Point(107, 355);
            this.butGUARDAR.Name = "butGUARDAR";
            this.butGUARDAR.Size = new System.Drawing.Size(173, 44);
            this.butGUARDAR.TabIndex = 9;
            this.butGUARDAR.Text = "GUARDAR";
            this.butGUARDAR.UseVisualStyleBackColor = true;
            // 
            // CANCELAR
            // 
            this.CANCELAR.Location = new System.Drawing.Point(107, 405);
            this.CANCELAR.Name = "CANCELAR";
            this.CANCELAR.Size = new System.Drawing.Size(173, 49);
            this.CANCELAR.TabIndex = 10;
            this.CANCELAR.Text = "CANCELAR";
            this.CANCELAR.UseVisualStyleBackColor = true;
            // 
            // NOM
            // 
            this.NOM.Location = new System.Drawing.Point(218, 82);
            this.NOM.Name = "NOM";
            this.NOM.Size = new System.Drawing.Size(100, 22);
            this.NOM.TabIndex = 11;
            // 
            // ESTA
            // 
            this.ESTA.Location = new System.Drawing.Point(218, 176);
            this.ESTA.Name = "ESTA";
            this.ESTA.Size = new System.Drawing.Size(100, 22);
            this.ESTA.TabIndex = 12;
            // 
            // TELE
            // 
            this.TELE.Location = new System.Drawing.Point(218, 148);
            this.TELE.Name = "TELE";
            this.TELE.Size = new System.Drawing.Size(100, 22);
            this.TELE.TabIndex = 13;
            // 
            // APE
            // 
            this.APE.Location = new System.Drawing.Point(218, 110);
            this.APE.Name = "APE";
            this.APE.Size = new System.Drawing.Size(100, 22);
            this.APE.TabIndex = 14;
            // 
            // EDAD
            // 
            this.EDAD.Location = new System.Drawing.Point(218, 209);
            this.EDAD.Name = "EDAD";
            this.EDAD.Size = new System.Drawing.Size(100, 22);
            this.EDAD.TabIndex = 15;
            // 
            // GENER
            // 
            this.GENER.AutoSize = true;
            this.GENER.Location = new System.Drawing.Point(3, 39);
            this.GENER.Name = "GENER";
            this.GENER.Size = new System.Drawing.Size(87, 20);
            this.GENER.TabIndex = 0;
            this.GENER.TabStop = true;
            this.GENER.Text = "HOMBRE";
            this.GENER.UseVisualStyleBackColor = true;
            // 
            // GEN
            // 
            this.GEN.AutoSize = true;
            this.GEN.Location = new System.Drawing.Point(123, 39);
            this.GEN.Name = "GEN";
            this.GEN.Size = new System.Drawing.Size(75, 20);
            this.GEN.TabIndex = 1;
            this.GEN.TabStop = true;
            this.GEN.Text = "MUJER";
            this.GEN.UseVisualStyleBackColor = true;
            // 
            // GENE
            // 
            this.GENE.AutoSize = true;
            this.GENE.Location = new System.Drawing.Point(3, 0);
            this.GENE.Name = "GENE";
            this.GENE.Size = new System.Drawing.Size(68, 16);
            this.GENE.TabIndex = 2;
            this.GENE.Text = "GENERO:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 503);
            this.Controls.Add(this.EDAD);
            this.Controls.Add(this.APE);
            this.Controls.Add(this.TELE);
            this.Controls.Add(this.ESTA);
            this.Controls.Add(this.NOM);
            this.Controls.Add(this.CANCELAR);
            this.Controls.Add(this.butGUARDAR);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butGUARDAR;
        private System.Windows.Forms.Button CANCELAR;
        private System.Windows.Forms.TextBox NOM;
        private System.Windows.Forms.TextBox ESTA;
        private System.Windows.Forms.TextBox TELE;
        private System.Windows.Forms.TextBox APE;
        private System.Windows.Forms.TextBox EDAD;
        private System.Windows.Forms.Label GENE;
        private System.Windows.Forms.RadioButton GEN;
        private System.Windows.Forms.RadioButton GENER;
    }
}

