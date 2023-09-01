namespace Practico_4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnFuncion = new System.Windows.Forms.Button();
            this.btnNumPar = new System.Windows.Forms.Button();
            this.btnNumImpar = new System.Windows.Forms.Button();
            this.btnNumPrimos = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.btnNumPrimos);
            this.panel1.Controls.Add(this.btnNumImpar);
            this.panel1.Controls.Add(this.btnNumPar);
            this.panel1.Controls.Add(this.btnFuncion);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.txtHasta);
            this.panel1.Controls.Add(this.txtDesde);
            this.panel1.Controls.Add(this.lblHasta);
            this.panel1.Controls.Add(this.lblDesde);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(12, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 428);
            this.panel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(152, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(157, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Lista de Números";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(19, 63);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(48, 16);
            this.lblDesde.TabIndex = 1;
            this.lblDesde.Text = "Desde";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(19, 105);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(43, 16);
            this.lblHasta.TabIndex = 2;
            this.lblHasta.Text = "Hasta";
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(86, 63);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(130, 20);
            this.txtDesde.TabIndex = 3;
            this.txtDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesde_KeyPress);
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(86, 101);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(130, 20);
            this.txtHasta.TabIndex = 4;
            this.txtHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHasta_KeyPress);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(236, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(193, 199);
            this.listBox1.TabIndex = 5;
            // 
            // btnFuncion
            // 
            this.btnFuncion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncion.Location = new System.Drawing.Point(86, 144);
            this.btnFuncion.Name = "btnFuncion";
            this.btnFuncion.Size = new System.Drawing.Size(130, 25);
            this.btnFuncion.TabIndex = 6;
            this.btnFuncion.Text = "Generar Función";
            this.btnFuncion.UseVisualStyleBackColor = true;
            this.btnFuncion.Click += new System.EventHandler(this.btnFuncion_Click);
            // 
            // btnNumPar
            // 
            this.btnNumPar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumPar.Location = new System.Drawing.Point(86, 175);
            this.btnNumPar.Name = "btnNumPar";
            this.btnNumPar.Size = new System.Drawing.Size(130, 25);
            this.btnNumPar.TabIndex = 7;
            this.btnNumPar.Text = "Números Pares";
            this.btnNumPar.UseVisualStyleBackColor = true;
            this.btnNumPar.Click += new System.EventHandler(this.btnNumPar_Click);
            // 
            // btnNumImpar
            // 
            this.btnNumImpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumImpar.Location = new System.Drawing.Point(86, 206);
            this.btnNumImpar.Name = "btnNumImpar";
            this.btnNumImpar.Size = new System.Drawing.Size(130, 25);
            this.btnNumImpar.TabIndex = 8;
            this.btnNumImpar.Text = "Números Impares";
            this.btnNumImpar.UseVisualStyleBackColor = true;
            this.btnNumImpar.Click += new System.EventHandler(this.btnNumImpar_Click);
            // 
            // btnNumPrimos
            // 
            this.btnNumPrimos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumPrimos.Location = new System.Drawing.Point(86, 237);
            this.btnNumPrimos.Name = "btnNumPrimos";
            this.btnNumPrimos.Size = new System.Drawing.Size(130, 25);
            this.btnNumPrimos.TabIndex = 9;
            this.btnNumPrimos.Text = "Números Primos";
            this.btnNumPrimos.UseVisualStyleBackColor = true;
            this.btnNumPrimos.Click += new System.EventHandler(this.btnNumPrimos_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(22, 302);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(407, 101);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnNumPar;
        private System.Windows.Forms.Button btnFuncion;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Button btnNumPrimos;
        private System.Windows.Forms.Button btnNumImpar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

