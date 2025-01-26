namespace Tarea1
{
    partial class Ejercicio5
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
            txtPlanilla = new TextBox();
            label4 = new Label();
            btnResolver = new Button();
            btnReset = new Button();
            groupBox1 = new GroupBox();
            btnSalir = new Button();
            label1 = new Label();
            txtTarifa = new TextBox();
            txtHoras = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtPlanilla
            // 
            txtPlanilla.Enabled = false;
            txtPlanilla.Font = new Font("Segoe UI", 9.75F);
            txtPlanilla.ForeColor = Color.MidnightBlue;
            txtPlanilla.Location = new Point(215, 204);
            txtPlanilla.Name = "txtPlanilla";
            txtPlanilla.Size = new Size(116, 25);
            txtPlanilla.TabIndex = 25;
            txtPlanilla.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(77, 207);
            label4.Name = "label4";
            label4.Size = new Size(51, 17);
            label4.TabIndex = 24;
            label4.Text = "Planilla:";
            // 
            // btnResolver
            // 
            btnResolver.BackColor = Color.OldLace;
            btnResolver.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnResolver.ForeColor = Color.MidnightBlue;
            btnResolver.Location = new Point(6, 19);
            btnResolver.Name = "btnResolver";
            btnResolver.Size = new Size(119, 40);
            btnResolver.TabIndex = 1;
            btnResolver.Text = "Resolver";
            btnResolver.UseVisualStyleBackColor = false;
            btnResolver.Click += btnResolver_Click;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(btnResolver);
            groupBox1.Controls.Add(btnReset);
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Location = new Point(13, 121);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(381, 69);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
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
            label1.Location = new Point(13, 15);
            label1.Name = "label1";
            label1.Size = new Size(381, 35);
            label1.TabIndex = 26;
            label1.Text = "Planilla De Empleados";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTarifa
            // 
            txtTarifa.Font = new Font("Segoe UI", 9.75F);
            txtTarifa.ForeColor = Color.MidnightBlue;
            txtTarifa.Location = new Point(215, 92);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(116, 25);
            txtTarifa.TabIndex = 2;
            // 
            // txtHoras
            // 
            txtHoras.Font = new Font("Segoe UI", 9.75F);
            txtHoras.ForeColor = Color.MidnightBlue;
            txtHoras.Location = new Point(215, 63);
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(116, 25);
            txtHoras.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(77, 95);
            label3.Name = "label3";
            label3.Size = new Size(106, 17);
            label3.TabIndex = 23;
            label3.Text = "Tarifa Por Horas:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(77, 64);
            label2.Name = "label2";
            label2.Size = new Size(112, 17);
            label2.TabIndex = 21;
            label2.Text = "Horas Laboradas:";
            // 
            // Ejercicio5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(406, 244);
            Controls.Add(txtPlanilla);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(txtTarifa);
            Controls.Add(txtHoras);
            Controls.Add(label3);
            Controls.Add(label2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Ejercicio5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio5";
            Load += Ejercicio5_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPlanilla;
        private Label label4;
        private Button btnResolver;
        private Button btnReset;
        private GroupBox groupBox1;
        private Button btnSalir;
        private Label label1;
        private TextBox txtTarifa;
        private TextBox txtHoras;
        private Label label3;
        private Label label2;
    }
}