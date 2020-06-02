namespace lab_8
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
            this.verLocal = new System.Windows.Forms.Button();
            this.crearLocal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VerLocales = new System.Windows.Forms.Panel();
            this.Tienda = new System.Windows.Forms.Panel();
            this.volverTienda = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.volver1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblTienda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.VerLocales.SuspendLayout();
            this.Tienda.SuspendLayout();
            this.SuspendLayout();
            // 
            // verLocal
            // 
            this.verLocal.BackColor = System.Drawing.Color.Sienna;
            this.verLocal.Location = new System.Drawing.Point(130, 150);
            this.verLocal.Name = "verLocal";
            this.verLocal.Size = new System.Drawing.Size(213, 87);
            this.verLocal.TabIndex = 0;
            this.verLocal.Text = "Ver locales";
            this.verLocal.UseVisualStyleBackColor = false;
            this.verLocal.Click += new System.EventHandler(this.verLocal_Click);
            // 
            // crearLocal
            // 
            this.crearLocal.BackColor = System.Drawing.Color.Sienna;
            this.crearLocal.Location = new System.Drawing.Point(130, 254);
            this.crearLocal.Name = "crearLocal";
            this.crearLocal.Size = new System.Drawing.Size(215, 87);
            this.crearLocal.TabIndex = 1;
            this.crearLocal.Text = "Crear locales";
            this.crearLocal.UseVisualStyleBackColor = false;
            this.crearLocal.Click += new System.EventHandler(this.crearLocal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::lab_8.Properties.Resources.Centro_comercial;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(596, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bienvenido al centro comercial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "¿Que desea hacer?";
            // 
            // VerLocales
            // 
            this.VerLocales.Controls.Add(this.Tienda);
            this.VerLocales.Controls.Add(this.label3);
            this.VerLocales.Controls.Add(this.volver1);
            this.VerLocales.Controls.Add(this.button5);
            this.VerLocales.Controls.Add(this.button4);
            this.VerLocales.Controls.Add(this.button3);
            this.VerLocales.Controls.Add(this.button2);
            this.VerLocales.Controls.Add(this.lblTienda);
            this.VerLocales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VerLocales.Location = new System.Drawing.Point(0, 0);
            this.VerLocales.Name = "VerLocales";
            this.VerLocales.Size = new System.Drawing.Size(800, 450);
            this.VerLocales.TabIndex = 6;
            this.VerLocales.Visible = false;
            // 
            // Tienda
            // 
            this.Tienda.Controls.Add(this.volverTienda);
            this.Tienda.Controls.Add(this.textBox3);
            this.Tienda.Controls.Add(this.textBox2);
            this.Tienda.Controls.Add(this.textBox1);
            this.Tienda.Controls.Add(this.label7);
            this.Tienda.Controls.Add(this.label6);
            this.Tienda.Controls.Add(this.label5);
            this.Tienda.Controls.Add(this.label4);
            this.Tienda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tienda.Location = new System.Drawing.Point(0, 0);
            this.Tienda.Name = "Tienda";
            this.Tienda.Size = new System.Drawing.Size(800, 450);
            this.Tienda.TabIndex = 9;
            this.Tienda.Visible = false;
            // 
            // volverTienda
            // 
            this.volverTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volverTienda.Location = new System.Drawing.Point(21, 388);
            this.volverTienda.Name = "volverTienda";
            this.volverTienda.Size = new System.Drawing.Size(95, 40);
            this.volverTienda.TabIndex = 7;
            this.volverTienda.Text = "Volver";
            this.volverTienda.UseVisualStyleBackColor = true;
            this.volverTienda.Click += new System.EventHandler(this.volverTienda_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(432, 167);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(197, 32);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(432, 208);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 32);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(432, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 32);
            this.textBox1.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(134, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 26);
            this.label7.TabIndex = 3;
            this.label7.Text = "Horario de atencion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(134, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 26);
            this.label6.TabIndex = 2;
            this.label6.Text = "Numero de identificador:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(134, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "Dueño:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(122, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 55);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tienda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(147, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 46);
            this.label3.TabIndex = 8;
            this.label3.Text = "Locales";
            // 
            // volver1
            // 
            this.volver1.Location = new System.Drawing.Point(21, 395);
            this.volver1.Name = "volver1";
            this.volver1.Size = new System.Drawing.Size(92, 43);
            this.volver1.TabIndex = 7;
            this.volver1.Text = "Volver";
            this.volver1.UseVisualStyleBackColor = true;
            this.volver1.Click += new System.EventHandler(this.volver1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Sienna;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(326, 223);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(168, 105);
            this.button5.TabIndex = 6;
            this.button5.Text = "Locales creados";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Sienna;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(325, 132);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(169, 67);
            this.button4.TabIndex = 5;
            this.button4.Text = "Recreacional";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Sienna;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(151, 277);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 67);
            this.button3.TabIndex = 4;
            this.button3.Text = "Cine";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Sienna;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(151, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 67);
            this.button2.TabIndex = 3;
            this.button2.Text = "Restaurante";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // lblTienda
            // 
            this.lblTienda.BackColor = System.Drawing.Color.Sienna;
            this.lblTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienda.Location = new System.Drawing.Point(151, 132);
            this.lblTienda.Name = "lblTienda";
            this.lblTienda.Size = new System.Drawing.Size(168, 67);
            this.lblTienda.TabIndex = 2;
            this.lblTienda.Text = "Tienda";
            this.lblTienda.UseVisualStyleBackColor = false;
            this.lblTienda.Click += new System.EventHandler(this.lblTienda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VerLocales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.crearLocal);
            this.Controls.Add(this.verLocal);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.VerLocales.ResumeLayout(false);
            this.VerLocales.PerformLayout();
            this.Tienda.ResumeLayout(false);
            this.Tienda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button verLocal;
        private System.Windows.Forms.Button crearLocal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel VerLocales;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button lblTienda;
        private System.Windows.Forms.Button volver1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel Tienda;
        private System.Windows.Forms.Button volverTienda;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

