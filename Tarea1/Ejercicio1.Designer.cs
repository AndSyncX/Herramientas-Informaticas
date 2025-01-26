namespace Tarea1
{
    partial class Ejercicio1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtVelocidad = new TextBox();
            txtTiempo = new TextBox();
            txtDistancia = new TextBox();
            btnDistancia = new Button();
            btnReset = new Button();
            btnSalir = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(381, 35);
            label1.TabIndex = 10;
            label1.Text = "Distancia Recorrida En (m) Por Un Móvil";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(76, 58);
            label2.Name = "label2";
            label2.Size = new Size(130, 17);
            label2.TabIndex = 1;
            label2.Text = "Velocidad Constante:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(76, 89);
            label3.Name = "label3";
            label3.Size = new Size(55, 17);
            label3.TabIndex = 2;
            label3.Text = "Tiempo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(76, 201);
            label4.Name = "label4";
            label4.Size = new Size(124, 17);
            label4.TabIndex = 3;
            label4.Text = "Distancia Recorrida:";
            // 
            // txtVelocidad
            // 
            txtVelocidad.Font = new Font("Segoe UI", 9.75F);
            txtVelocidad.ForeColor = Color.MidnightBlue;
            txtVelocidad.Location = new Point(214, 57);
            txtVelocidad.Name = "txtVelocidad";
            txtVelocidad.Size = new Size(116, 25);
            txtVelocidad.TabIndex = 1;
            // 
            // txtTiempo
            // 
            txtTiempo.Font = new Font("Segoe UI", 9.75F);
            txtTiempo.ForeColor = Color.MidnightBlue;
            txtTiempo.Location = new Point(214, 86);
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new Size(116, 25);
            txtTiempo.TabIndex = 2;
            // 
            // txtDistancia
            // 
            txtDistancia.Enabled = false;
            txtDistancia.Font = new Font("Segoe UI", 9.75F);
            txtDistancia.ForeColor = Color.MidnightBlue;
            txtDistancia.Location = new Point(214, 198);
            txtDistancia.Name = "txtDistancia";
            txtDistancia.Size = new Size(116, 25);
            txtDistancia.TabIndex = 6;
            txtDistancia.TextAlign = HorizontalAlignment.Center;
            // 
            // btnDistancia
            // 
            btnDistancia.BackColor = Color.OldLace;
            btnDistancia.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnDistancia.ForeColor = Color.MidnightBlue;
            btnDistancia.Location = new Point(6, 19);
            btnDistancia.Name = "btnDistancia";
            btnDistancia.Size = new Size(119, 40);
            btnDistancia.TabIndex = 3;
            btnDistancia.Text = "Distancia";
            btnDistancia.UseVisualStyleBackColor = false;
            btnDistancia.Click += btnDistancia_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.OldLace;
            btnReset.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnReset.ForeColor = Color.MidnightBlue;
            btnReset.Location = new Point(131, 19);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(119, 40);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.OldLace;
            btnSalir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnSalir.ForeColor = Color.MidnightBlue;
            btnSalir.Location = new Point(256, 19);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(119, 40);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDistancia);
            groupBox1.Controls.Add(btnReset);
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Location = new Point(12, 115);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(381, 69);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // Ejercicio1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(406, 244);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(txtDistancia);
            Controls.Add(txtTiempo);
            Controls.Add(txtVelocidad);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Ejercicio1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtVelocidad;
        private TextBox txtTiempo;
        private TextBox txtDistancia;
        private Button btnDistancia;
        private Button btnReset;
        private Button btnSalir;
        private GroupBox groupBox1;
    }
}
