namespace Paquetes
{
    partial class FormResultados
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardarResultados = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Paquetes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPesoTotal = new System.Windows.Forms.Label();
            this.lbGananciaTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Paquetes que se deben de enviar";
            // 
            // btnGuardarResultados
            // 
            this.btnGuardarResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarResultados.Location = new System.Drawing.Point(520, 316);
            this.btnGuardarResultados.Name = "btnGuardarResultados";
            this.btnGuardarResultados.Size = new System.Drawing.Size(180, 31);
            this.btnGuardarResultados.TabIndex = 4;
            this.btnGuardarResultados.Text = "Guardar Resutados";
            this.btnGuardarResultados.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(520, 385);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(109, 38);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Regresar";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Paquetes});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(128, 105);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(177, 303);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(446, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Peso total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(446, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ganancia total:";
            // 
            // lbPesoTotal
            // 
            this.lbPesoTotal.AutoSize = true;
            this.lbPesoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPesoTotal.Location = new System.Drawing.Point(675, 135);
            this.lbPesoTotal.Name = "lbPesoTotal";
            this.lbPesoTotal.Size = new System.Drawing.Size(16, 24);
            this.lbPesoTotal.TabIndex = 9;
            this.lbPesoTotal.Text = "-";
            // 
            // lbGananciaTotal
            // 
            this.lbGananciaTotal.AutoSize = true;
            this.lbGananciaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGananciaTotal.Location = new System.Drawing.Point(675, 186);
            this.lbGananciaTotal.Name = "lbGananciaTotal";
            this.lbGananciaTotal.Size = new System.Drawing.Size(16, 24);
            this.lbGananciaTotal.TabIndex = 10;
            this.lbGananciaTotal.Text = "-";
            // 
            // FormResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(795, 490);
            this.Controls.Add(this.lbGananciaTotal);
            this.Controls.Add(this.lbPesoTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnGuardarResultados);
            this.Controls.Add(this.label2);
            this.Name = "FormResultados";
            this.Text = "FormResultados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardarResultados;
        private System.Windows.Forms.Button btnCalcular;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Paquetes;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbPesoTotal;
        public System.Windows.Forms.Label lbGananciaTotal;
    }
}