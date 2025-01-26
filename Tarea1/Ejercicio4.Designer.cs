namespace Tarea1
{
    partial class Ejercicio4
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
            groupBox1 = new GroupBox();
            btnPuntaje = new Button();
            btnReset = new Button();
            btnSalir = new Button();
            label1 = new Label();
            txtPuntajeTotal = new TextBox();
            txtPempatado = new TextBox();
            txtPganado = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnPuntaje);
            groupBox1.Controls.Add(btnReset);
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Location = new Point(12, 115);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(381, 69);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            // 
            // btnPuntaje
            // 
            btnPuntaje.BackColor = Color.OldLace;
            btnPuntaje.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnPuntaje.ForeColor = Color.MidnightBlue;
            btnPuntaje.Location = new Point(6, 19);
            btnPuntaje.Name = "btnPuntaje";
            btnPuntaje.Size = new Size(119, 40);
            btnPuntaje.TabIndex = 1;
            btnPuntaje.Text = "Puntaje";
            btnPuntaje.UseVisualStyleBackColor = false;
            btnPuntaje.Click += btnPuntaje_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.OldLace;
            btnReset.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnReset.ForeColor = Color.MidnightBlue;
            btnReset.Location = new Point(131, 19);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(119, 40);
            btnReset.TabIndex = 2;
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
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(381, 35);
            label1.TabIndex = 18;
            label1.Text = "Puntaje Total Del Torneo De Apertura";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPuntajeTotal
            // 
            txtPuntajeTotal.Enabled = false;
            txtPuntajeTotal.Font = new Font("Segoe UI", 9.75F);
            txtPuntajeTotal.ForeColor = Color.MidnightBlue;
            txtPuntajeTotal.Location = new Point(214, 198);
            txtPuntajeTotal.Name = "txtPuntajeTotal";
            txtPuntajeTotal.Size = new Size(116, 25);
            txtPuntajeTotal.TabIndex = 17;
            txtPuntajeTotal.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPempatado
            // 
            txtPempatado.Font = new Font("Segoe UI", 9.75F);
            txtPempatado.ForeColor = Color.MidnightBlue;
            txtPempatado.Location = new Point(214, 86);
            txtPempatado.Name = "txtPempatado";
            txtPempatado.Size = new Size(116, 25);
            txtPempatado.TabIndex = 2;
            // 
            // txtPganado
            // 
            txtPganado.Font = new Font("Segoe UI", 9.75F);
            txtPganado.ForeColor = Color.MidnightBlue;
            txtPganado.Location = new Point(214, 57);
            txtPganado.Name = "txtPganado";
            txtPganado.Size = new Size(116, 25);
            txtPganado.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(76, 201);
            label4.Name = "label4";
            label4.Size = new Size(85, 17);
            label4.TabIndex = 16;
            label4.Text = "Puntaje Total:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(76, 89);
            label3.Name = "label3";
            label3.Size = new Size(129, 17);
            label3.TabIndex = 15;
            label3.Text = "Partidos Empatados:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(76, 58);
            label2.Name = "label2";
            label2.Size = new Size(115, 17);
            label2.TabIndex = 13;
            label2.Text = "Partidos Ganados:";
            // 
            // Ejercicio4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(406, 244);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(txtPuntajeTotal);
            Controls.Add(txtPempatado);
            Controls.Add(txtPganado);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Ejercicio4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio4";
            Load += Ejercicio4_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnPuntaje;
        private Button btnReset;
        private Button btnSalir;
        private Label label1;
        private TextBox txtPuntajeTotal;
        private TextBox txtPempatado;
        private TextBox txtPganado;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}