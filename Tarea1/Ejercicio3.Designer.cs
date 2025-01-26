namespace Tarea1
{
    partial class Ejercicio3
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
            label6 = new Label();
            txtPuntajeFinal = new TextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            btnPuntaje = new Button();
            btnReset = new Button();
            btnSalir = new Button();
            label1 = new Label();
            txtPincorrectas = new TextBox();
            txtPcorrectas = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.MidnightBlue;
            label6.Location = new Point(252, 203);
            label6.Name = "label6";
            label6.Size = new Size(213, 17);
            label6.TabIndex = 31;
            label6.Text = "Joel Anderson Fernandez Pancorvo";
            // 
            // txtPuntajeFinal
            // 
            txtPuntajeFinal.Enabled = false;
            txtPuntajeFinal.Font = new Font("Segoe UI", 9.75F);
            txtPuntajeFinal.ForeColor = Color.MidnightBlue;
            txtPuntajeFinal.Location = new Point(183, 120);
            txtPuntajeFinal.Name = "txtPuntajeFinal";
            txtPuntajeFinal.Size = new Size(130, 25);
            txtPuntajeFinal.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(12, 123);
            label5.Name = "label5";
            label5.Size = new Size(83, 17);
            label5.TabIndex = 30;
            label5.Text = "Puntaje Final:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnPuntaje);
            groupBox1.Controls.Add(btnReset);
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Location = new Point(324, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(141, 163);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            // 
            // btnPuntaje
            // 
            btnPuntaje.BackColor = Color.OldLace;
            btnPuntaje.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnPuntaje.ForeColor = Color.MidnightBlue;
            btnPuntaje.Location = new Point(11, 18);
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
            btnReset.Location = new Point(11, 64);
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
            btnSalir.Location = new Point(11, 110);
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
            label1.Size = new Size(306, 35);
            label1.TabIndex = 28;
            label1.Text = "Puntaje Correspondiente de Postulantes";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPincorrectas
            // 
            txtPincorrectas.Font = new Font("Segoe UI", 9.75F);
            txtPincorrectas.ForeColor = Color.MidnightBlue;
            txtPincorrectas.Location = new Point(183, 89);
            txtPincorrectas.Name = "txtPincorrectas";
            txtPincorrectas.Size = new Size(130, 25);
            txtPincorrectas.TabIndex = 2;
            // 
            // txtPcorrectas
            // 
            txtPcorrectas.Font = new Font("Segoe UI", 9.75F);
            txtPcorrectas.ForeColor = Color.MidnightBlue;
            txtPcorrectas.Location = new Point(183, 58);
            txtPcorrectas.Name = "txtPcorrectas";
            txtPcorrectas.Size = new Size(130, 25);
            txtPcorrectas.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(12, 92);
            label3.Name = "label3";
            label3.Size = new Size(145, 17);
            label3.TabIndex = 27;
            label3.Text = "Respuestas Incorrectas:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(137, 17);
            label2.TabIndex = 26;
            label2.Text = "Respuestas Correctas:";
            // 
            // Ejercicio3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(477, 229);
            Controls.Add(label6);
            Controls.Add(txtPuntajeFinal);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(txtPincorrectas);
            Controls.Add(txtPcorrectas);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Ejercicio3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio3";
            Load += Ejercicio3_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox txtPuntajeFinal;
        private Label label5;
        private GroupBox groupBox1;
        private Button btnPuntaje;
        private Button btnReset;
        private Button btnSalir;
        private Label label1;
        private TextBox txtPincorrectas;
        private TextBox txtPcorrectas;
        private Label label3;
        private Label label2;
    }
}