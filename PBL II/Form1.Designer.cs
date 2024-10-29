namespace PBL_II
{
    partial class Form1
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
            this.Title = new System.Windows.Forms.Label();
            this.Largura = new System.Windows.Forms.Label();
            this.modulo = new System.Windows.Forms.Label();
            this.modulo_correnteza = new System.Windows.Forms.Label();
            this.angulo = new System.Windows.Forms.Label();
            this.calcular = new System.Windows.Forms.Button();
            this.aviso1 = new System.Windows.Forms.Label();
            this.aviso2 = new System.Windows.Forms.Label();
            this.aviso3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numeric_largura = new System.Windows.Forms.TextBox();
            this.numeric_velocidade_motor = new System.Windows.Forms.TextBox();
            this.numeric_modulo_correnteza = new System.Windows.Forms.TextBox();
            this.numeric_angulo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Montserrat Medium", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Title.Location = new System.Drawing.Point(91, 63);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1670, 60);
            this.Title.TabIndex = 0;
            this.Title.Text = "Simulação do movimento de um barco motorizado atravessando um rio.";
            // 
            // Largura
            // 
            this.Largura.AutoSize = true;
            this.Largura.Font = new System.Drawing.Font("Montserrat Medium", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Largura.Location = new System.Drawing.Point(140, 201);
            this.Largura.Name = "Largura";
            this.Largura.Size = new System.Drawing.Size(301, 51);
            this.Largura.TabIndex = 1;
            this.Largura.Text = "Largura do rio";
            // 
            // modulo
            // 
            this.modulo.AutoSize = true;
            this.modulo.Font = new System.Drawing.Font("Montserrat Medium", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modulo.Location = new System.Drawing.Point(140, 371);
            this.modulo.Name = "modulo";
            this.modulo.Size = new System.Drawing.Size(1230, 51);
            this.modulo.TabIndex = 2;
            this.modulo.Text = "Módulo da velocidade imposta pelo motor em relação à água";
            // 
            // modulo_correnteza
            // 
            this.modulo_correnteza.AutoSize = true;
            this.modulo_correnteza.Font = new System.Drawing.Font("Montserrat Medium", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modulo_correnteza.Location = new System.Drawing.Point(140, 553);
            this.modulo_correnteza.Name = "modulo_correnteza";
            this.modulo_correnteza.Size = new System.Drawing.Size(737, 51);
            this.modulo_correnteza.TabIndex = 3;
            this.modulo_correnteza.Text = "Módulo da velocidade da correnteza";
            // 
            // angulo
            // 
            this.angulo.AutoSize = true;
            this.angulo.Font = new System.Drawing.Font("Montserrat Medium", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angulo.Location = new System.Drawing.Point(140, 746);
            this.angulo.Name = "angulo";
            this.angulo.Size = new System.Drawing.Size(1346, 51);
            this.angulo.TabIndex = 4;
            this.angulo.Text = "Ângulo, θ, de orientação do barco em relação à margem de partida";
            // 
            // calcular
            // 
            this.calcular.BackColor = System.Drawing.Color.DarkMagenta;
            this.calcular.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcular.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.calcular.Location = new System.Drawing.Point(812, 1095);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(245, 90);
            this.calcular.TabIndex = 5;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = false;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // aviso1
            // 
            this.aviso1.AutoSize = true;
            this.aviso1.Location = new System.Drawing.Point(149, 256);
            this.aviso1.Name = "aviso1";
            this.aviso1.Size = new System.Drawing.Size(187, 25);
            this.aviso1.TabIndex = 6;
            this.aviso1.Text = "Entre 20m e 100m";
            // 
            // aviso2
            // 
            this.aviso2.AutoSize = true;
            this.aviso2.Location = new System.Drawing.Point(149, 432);
            this.aviso2.Name = "aviso2";
            this.aviso2.Size = new System.Drawing.Size(197, 25);
            this.aviso2.TabIndex = 7;
            this.aviso2.Text = "Entre 2m/s e 10m/s";
            // 
            // aviso3
            // 
            this.aviso3.AutoSize = true;
            this.aviso3.Location = new System.Drawing.Point(149, 616);
            this.aviso3.Name = "aviso3";
            this.aviso3.Size = new System.Drawing.Size(185, 25);
            this.aviso3.TabIndex = 8;
            this.aviso3.Text = "Entre 1m/s e 4m/s";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 808);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "20º < θ  < 160º";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 960);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1403, 955);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // numeric_largura
            // 
            this.numeric_largura.Location = new System.Drawing.Point(468, 213);
            this.numeric_largura.Name = "numeric_largura";
            this.numeric_largura.Size = new System.Drawing.Size(100, 31);
            this.numeric_largura.TabIndex = 33;
            // 
            // numeric_velocidade_motor
            // 
            this.numeric_velocidade_motor.Location = new System.Drawing.Point(1434, 382);
            this.numeric_velocidade_motor.Name = "numeric_velocidade_motor";
            this.numeric_velocidade_motor.Size = new System.Drawing.Size(100, 31);
            this.numeric_velocidade_motor.TabIndex = 34;
            // 
            // numeric_modulo_correnteza
            // 
            this.numeric_modulo_correnteza.Location = new System.Drawing.Point(911, 569);
            this.numeric_modulo_correnteza.Name = "numeric_modulo_correnteza";
            this.numeric_modulo_correnteza.Size = new System.Drawing.Size(100, 31);
            this.numeric_modulo_correnteza.TabIndex = 35;
            // 
            // numeric_angulo
            // 
            this.numeric_angulo.Location = new System.Drawing.Point(1541, 761);
            this.numeric_angulo.Name = "numeric_angulo";
            this.numeric_angulo.Size = new System.Drawing.Size(100, 31);
            this.numeric_angulo.TabIndex = 36;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(1767, 1249);
            this.Controls.Add(this.numeric_angulo);
            this.Controls.Add(this.numeric_modulo_correnteza);
            this.Controls.Add(this.numeric_velocidade_motor);
            this.Controls.Add(this.numeric_largura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.aviso3);
            this.Controls.Add(this.aviso2);
            this.Controls.Add(this.aviso1);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.angulo);
            this.Controls.Add(this.modulo_correnteza);
            this.Controls.Add(this.modulo);
            this.Controls.Add(this.Largura);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Largura;
        private System.Windows.Forms.Label modulo;
        private System.Windows.Forms.Label modulo_correnteza;
        private System.Windows.Forms.Label angulo;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Label aviso1;
        private System.Windows.Forms.Label aviso2;
        private System.Windows.Forms.Label aviso3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numeric_largura;
        private System.Windows.Forms.TextBox numeric_velocidade_motor;
        private System.Windows.Forms.TextBox numeric_modulo_correnteza;
        private System.Windows.Forms.TextBox numeric_angulo;
    }
}

