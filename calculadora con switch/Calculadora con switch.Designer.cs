namespace calculadora_con_switch
{
    partial class Calculadoraconswitch
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
            this.components = new System.ComponentModel.Container();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnpunto = new System.Windows.Forms.Button();
            this.btnmultiplicar = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnigual = new System.Windows.Forms.Button();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnmas = new System.Windows.Forms.Button();
            this.btnmenos = new System.Windows.Forms.Button();
            this.btndividir = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.txtletras = new System.Windows.Forms.TextBox();
            this.lblletras = new System.Windows.Forms.Label();
            this.timerhora = new System.Windows.Forms.Timer(this.components);
            this.lbltiempocalculadora = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Blue;
            this.btnsalir.Location = new System.Drawing.Point(100, 72);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(42, 40);
            this.btnsalir.TabIndex = 37;
            this.btnsalir.Text = "OFF";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnpunto
            // 
            this.btnpunto.BackColor = System.Drawing.Color.Silver;
            this.btnpunto.Location = new System.Drawing.Point(62, 222);
            this.btnpunto.Name = "btnpunto";
            this.btnpunto.Size = new System.Drawing.Size(42, 40);
            this.btnpunto.TabIndex = 36;
            this.btnpunto.Text = ".";
            this.btnpunto.UseVisualStyleBackColor = false;
            this.btnpunto.Click += new System.EventHandler(this.btnpunto_Click);
            // 
            // btnmultiplicar
            // 
            this.btnmultiplicar.BackColor = System.Drawing.Color.Green;
            this.btnmultiplicar.Location = new System.Drawing.Point(139, 222);
            this.btnmultiplicar.Name = "btnmultiplicar";
            this.btnmultiplicar.Size = new System.Drawing.Size(42, 40);
            this.btnmultiplicar.TabIndex = 35;
            this.btnmultiplicar.Text = "*";
            this.btnmultiplicar.UseVisualStyleBackColor = false;
            this.btnmultiplicar.Click += new System.EventHandler(this.btnmultiplicar_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Silver;
            this.btn0.Location = new System.Drawing.Point(23, 222);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(42, 40);
            this.btn0.TabIndex = 34;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnigual
            // 
            this.btnigual.BackColor = System.Drawing.Color.Green;
            this.btnigual.Location = new System.Drawing.Point(100, 222);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(42, 40);
            this.btnigual.TabIndex = 33;
            this.btnigual.Text = "=";
            this.btnigual.UseVisualStyleBackColor = false;
            this.btnigual.Click += new System.EventHandler(this.btnigual_Click);
            // 
            // txtresultado
            // 
            this.txtresultado.BackColor = System.Drawing.Color.LightYellow;
            this.txtresultado.Font = new System.Drawing.Font("LCDMono2", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresultado.Location = new System.Drawing.Point(16, 37);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(174, 27);
            this.txtresultado.TabIndex = 32;
            this.txtresultado.Text = "0.";
            this.txtresultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.Blue;
            this.btnlimpiar.Location = new System.Drawing.Point(139, 72);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(42, 40);
            this.btnlimpiar.TabIndex = 31;
            this.btnlimpiar.Text = "CE";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnmas
            // 
            this.btnmas.BackColor = System.Drawing.Color.Green;
            this.btnmas.Location = new System.Drawing.Point(139, 111);
            this.btnmas.Name = "btnmas";
            this.btnmas.Size = new System.Drawing.Size(42, 40);
            this.btnmas.TabIndex = 30;
            this.btnmas.Text = "+";
            this.btnmas.UseVisualStyleBackColor = false;
            this.btnmas.Click += new System.EventHandler(this.btnmas_Click);
            // 
            // btnmenos
            // 
            this.btnmenos.BackColor = System.Drawing.Color.Green;
            this.btnmenos.Location = new System.Drawing.Point(139, 148);
            this.btnmenos.Name = "btnmenos";
            this.btnmenos.Size = new System.Drawing.Size(42, 40);
            this.btnmenos.TabIndex = 29;
            this.btnmenos.Text = "-";
            this.btnmenos.UseVisualStyleBackColor = false;
            this.btnmenos.Click += new System.EventHandler(this.btnmenos_Click);
            // 
            // btndividir
            // 
            this.btndividir.BackColor = System.Drawing.Color.Green;
            this.btndividir.Location = new System.Drawing.Point(139, 185);
            this.btndividir.Name = "btndividir";
            this.btndividir.Size = new System.Drawing.Size(42, 40);
            this.btndividir.TabIndex = 28;
            this.btndividir.Text = "/";
            this.btndividir.UseVisualStyleBackColor = false;
            this.btndividir.Click += new System.EventHandler(this.btndividir_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Silver;
            this.btn9.Location = new System.Drawing.Point(100, 185);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(42, 40);
            this.btn9.TabIndex = 27;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Silver;
            this.btn8.Location = new System.Drawing.Point(62, 185);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(42, 40);
            this.btn8.TabIndex = 26;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Silver;
            this.btn7.Location = new System.Drawing.Point(23, 185);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(42, 40);
            this.btn7.TabIndex = 25;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Silver;
            this.btn6.Location = new System.Drawing.Point(100, 148);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(42, 40);
            this.btn6.TabIndex = 24;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Silver;
            this.btn5.Location = new System.Drawing.Point(62, 148);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(42, 40);
            this.btn5.TabIndex = 23;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Silver;
            this.btn4.Location = new System.Drawing.Point(23, 148);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(42, 40);
            this.btn4.TabIndex = 22;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Silver;
            this.btn3.Location = new System.Drawing.Point(100, 111);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(42, 40);
            this.btn3.TabIndex = 21;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Silver;
            this.btn2.Location = new System.Drawing.Point(62, 111);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(42, 40);
            this.btn2.TabIndex = 20;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Silver;
            this.btn1.Location = new System.Drawing.Point(23, 111);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(42, 40);
            this.btn1.TabIndex = 19;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txtletras
            // 
            this.txtletras.Location = new System.Drawing.Point(12, 295);
            this.txtletras.Name = "txtletras";
            this.txtletras.Size = new System.Drawing.Size(178, 20);
            this.txtletras.TabIndex = 60;
            // 
            // lblletras
            // 
            this.lblletras.AutoSize = true;
            this.lblletras.BackColor = System.Drawing.Color.Transparent;
            this.lblletras.Font = new System.Drawing.Font("LCDMono2", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblletras.ForeColor = System.Drawing.Color.Black;
            this.lblletras.Location = new System.Drawing.Point(15, 271);
            this.lblletras.Name = "lblletras";
            this.lblletras.Size = new System.Drawing.Size(159, 14);
            this.lblletras.TabIndex = 59;
            this.lblletras.Text = "Resultado en letras";
            // 
            // timerhora
            // 
            this.timerhora.Enabled = true;
            this.timerhora.Interval = 1000;
            this.timerhora.Tick += new System.EventHandler(this.timerhora_Tick);
            // 
            // lbltiempocalculadora
            // 
            this.lbltiempocalculadora.AutoSize = true;
            this.lbltiempocalculadora.Font = new System.Drawing.Font("LCDMono2", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltiempocalculadora.Location = new System.Drawing.Point(62, 18);
            this.lbltiempocalculadora.Name = "lbltiempocalculadora";
            this.lbltiempocalculadora.Size = new System.Drawing.Size(0, 11);
            this.lbltiempocalculadora.TabIndex = 61;
            // 
            // Calculadoraconswitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 327);
            this.Controls.Add(this.lbltiempocalculadora);
            this.Controls.Add(this.txtletras);
            this.Controls.Add(this.lblletras);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnpunto);
            this.Controls.Add(this.btnmultiplicar);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnigual);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnmas);
            this.Controls.Add(this.btnmenos);
            this.Controls.Add(this.btndividir);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "Calculadoraconswitch";
            this.Text = "Calculadora Con Switch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnpunto;
        private System.Windows.Forms.Button btnmultiplicar;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnigual;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnmas;
        private System.Windows.Forms.Button btnmenos;
        private System.Windows.Forms.Button btndividir;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtletras;
        private System.Windows.Forms.Label lblletras;
        private System.Windows.Forms.Timer timerhora;
        private System.Windows.Forms.Label lbltiempocalculadora;
    }
}

