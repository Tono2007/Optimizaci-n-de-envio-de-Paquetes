﻿namespace Paquetes
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lbResultados = new System.Windows.Forms.ListView();
            this.Paquetes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPesoTotal = new System.Windows.Forms.Label();
            this.lbGananciaTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbIndividuo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Paquetes que se deben de enviar";
            // 
            // btnGuardarResultados
            // 
            this.btnGuardarResultados.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGuardarResultados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarResultados.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuardarResultados.Location = new System.Drawing.Point(482, 316);
            this.btnGuardarResultados.Name = "btnGuardarResultados";
            this.btnGuardarResultados.Size = new System.Drawing.Size(218, 40);
            this.btnGuardarResultados.TabIndex = 4;
            this.btnGuardarResultados.Text = "Guardar Resutados";
            this.btnGuardarResultados.UseVisualStyleBackColor = false;
            this.btnGuardarResultados.Click += new System.EventHandler(this.btnGuardarResultados_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegresar.Location = new System.Drawing.Point(538, 398);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(109, 38);
            this.btnRegresar.TabIndex = 5;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lbResultados
            // 
            this.lbResultados.BackColor = System.Drawing.SystemColors.Control;
            this.lbResultados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Paquetes});
            this.lbResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultados.Location = new System.Drawing.Point(107, 152);
            this.lbResultados.Name = "lbResultados";
            this.lbResultados.Size = new System.Drawing.Size(241, 303);
            this.lbResultados.TabIndex = 6;
            this.lbResultados.UseCompatibleStateImageBehavior = false;
            this.lbResultados.View = System.Windows.Forms.View.List;
            // 
            // Paquetes
            // 
            this.Paquetes.Text = "Paquetes";
            this.Paquetes.Width = 121;
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
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.SeaGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(-2, -3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(809, 56);
            this.label4.TabIndex = 11;
            this.label4.Text = "Optimización de envio de paquetes";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbIndividuo
            // 
            this.lbIndividuo.AutoSize = true;
            this.lbIndividuo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIndividuo.Location = new System.Drawing.Point(446, 254);
            this.lbIndividuo.Name = "lbIndividuo";
            this.lbIndividuo.Size = new System.Drawing.Size(16, 24);
            this.lbIndividuo.TabIndex = 13;
            this.lbIndividuo.Text = "-";
            // 
            // FormResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(795, 490);
            this.Controls.Add(this.lbIndividuo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbGananciaTotal);
            this.Controls.Add(this.lbPesoTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbResultados);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnGuardarResultados);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormResultados";
            this.Text = "FormResultados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardarResultados;
        private System.Windows.Forms.Button btnRegresar;
        public System.Windows.Forms.ListView lbResultados;
        private System.Windows.Forms.ColumnHeader Paquetes;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbPesoTotal;
        public System.Windows.Forms.Label lbGananciaTotal;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lbIndividuo;
    }
}