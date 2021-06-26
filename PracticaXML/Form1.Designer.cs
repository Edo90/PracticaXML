
namespace PracticaXML
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bancoTxt = new System.Windows.Forms.TextBox();
            this.beneficiarioTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cajaTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.centroCostoTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.monedaTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.suplidorTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tasaTxt = new System.Windows.Forms.NumericUpDown();
            this.montoTxt = new System.Windows.Forms.NumericUpDown();
            this.identificadorTxt = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.fechaDatePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.detalleCentroCostoTxt = new System.Windows.Forms.TextBox();
            this.detalleCreditoTxt = new System.Windows.Forms.TextBox();
            this.detalleCuentaTxt = new System.Windows.Forms.TextBox();
            this.detalleDebitoTxt = new System.Windows.Forms.TextBox();
            this.detalleProyectoTxt = new System.Windows.Forms.TextBox();
            this.detalleSubCentroTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasaTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.montoTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.identificadorTxt)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(682, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Banco";
            // 
            // bancoTxt
            // 
            this.bancoTxt.Location = new System.Drawing.Point(122, 49);
            this.bancoTxt.Name = "bancoTxt";
            this.bancoTxt.Size = new System.Drawing.Size(120, 20);
            this.bancoTxt.TabIndex = 2;
            // 
            // beneficiarioTxt
            // 
            this.beneficiarioTxt.Location = new System.Drawing.Point(122, 75);
            this.beneficiarioTxt.Name = "beneficiarioTxt";
            this.beneficiarioTxt.Size = new System.Drawing.Size(120, 20);
            this.beneficiarioTxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Beneficiario";
            // 
            // cajaTxt
            // 
            this.cajaTxt.Location = new System.Drawing.Point(122, 101);
            this.cajaTxt.Name = "cajaTxt";
            this.cajaTxt.Size = new System.Drawing.Size(120, 20);
            this.cajaTxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Caja";
            // 
            // centroCostoTxt
            // 
            this.centroCostoTxt.Location = new System.Drawing.Point(122, 127);
            this.centroCostoTxt.Name = "centroCostoTxt";
            this.centroCostoTxt.Size = new System.Drawing.Size(120, 20);
            this.centroCostoTxt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Centro Costo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(646, 249);
            this.dataGridView1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Identificador";
            // 
            // monedaTxt
            // 
            this.monedaTxt.Location = new System.Drawing.Point(123, 207);
            this.monedaTxt.Name = "monedaTxt";
            this.monedaTxt.Size = new System.Drawing.Size(119, 20);
            this.monedaTxt.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Moneda";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Monto";
            // 
            // suplidorTxt
            // 
            this.suplidorTxt.Location = new System.Drawing.Point(123, 259);
            this.suplidorTxt.Name = "suplidorTxt";
            this.suplidorTxt.Size = new System.Drawing.Size(119, 20);
            this.suplidorTxt.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Suplidor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(81, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Tasa";
            // 
            // tasaTxt
            // 
            this.tasaTxt.Location = new System.Drawing.Point(123, 286);
            this.tasaTxt.Name = "tasaTxt";
            this.tasaTxt.Size = new System.Drawing.Size(120, 20);
            this.tasaTxt.TabIndex = 19;
            // 
            // montoTxt
            // 
            this.montoTxt.Location = new System.Drawing.Point(123, 233);
            this.montoTxt.Name = "montoTxt";
            this.montoTxt.Size = new System.Drawing.Size(120, 20);
            this.montoTxt.TabIndex = 20;
            // 
            // identificadorTxt
            // 
            this.identificadorTxt.Location = new System.Drawing.Point(122, 179);
            this.identificadorTxt.Name = "identificadorTxt";
            this.identificadorTxt.Size = new System.Drawing.Size(120, 20);
            this.identificadorTxt.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Fecha";
            // 
            // fechaDatePicker
            // 
            this.fechaDatePicker.CustomFormat = "";
            this.fechaDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDatePicker.Location = new System.Drawing.Point(123, 153);
            this.fechaDatePicker.Name = "fechaDatePicker";
            this.fechaDatePicker.Size = new System.Drawing.Size(120, 20);
            this.fechaDatePicker.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 349);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asiento";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.detalleSubCentroTxt);
            this.groupBox2.Controls.Add(this.detalleProyectoTxt);
            this.groupBox2.Controls.Add(this.detalleDebitoTxt);
            this.groupBox2.Controls.Add(this.detalleCuentaTxt);
            this.groupBox2.Controls.Add(this.detalleCreditoTxt);
            this.groupBox2.Controls.Add(this.detalleCentroCostoTxt);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(278, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(712, 349);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(18, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 37);
            this.button2.TabIndex = 0;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // detalleCentroCostoTxt
            // 
            this.detalleCentroCostoTxt.Location = new System.Drawing.Point(56, 25);
            this.detalleCentroCostoTxt.Name = "detalleCentroCostoTxt";
            this.detalleCentroCostoTxt.Size = new System.Drawing.Size(101, 26);
            this.detalleCentroCostoTxt.TabIndex = 26;
            // 
            // detalleCreditoTxt
            // 
            this.detalleCreditoTxt.Location = new System.Drawing.Point(163, 25);
            this.detalleCreditoTxt.Name = "detalleCreditoTxt";
            this.detalleCreditoTxt.Size = new System.Drawing.Size(96, 26);
            this.detalleCreditoTxt.TabIndex = 27;
            // 
            // detalleCuentaTxt
            // 
            this.detalleCuentaTxt.Location = new System.Drawing.Point(265, 24);
            this.detalleCuentaTxt.Name = "detalleCuentaTxt";
            this.detalleCuentaTxt.Size = new System.Drawing.Size(94, 26);
            this.detalleCuentaTxt.TabIndex = 28;
            // 
            // detalleDebitoTxt
            // 
            this.detalleDebitoTxt.Location = new System.Drawing.Point(365, 24);
            this.detalleDebitoTxt.Name = "detalleDebitoTxt";
            this.detalleDebitoTxt.Size = new System.Drawing.Size(93, 26);
            this.detalleDebitoTxt.TabIndex = 26;
            // 
            // detalleProyectoTxt
            // 
            this.detalleProyectoTxt.Location = new System.Drawing.Point(464, 24);
            this.detalleProyectoTxt.Name = "detalleProyectoTxt";
            this.detalleProyectoTxt.Size = new System.Drawing.Size(97, 26);
            this.detalleProyectoTxt.TabIndex = 29;
            // 
            // detalleSubCentroTxt
            // 
            this.detalleSubCentroTxt.Location = new System.Drawing.Point(567, 25);
            this.detalleSubCentroTxt.Name = "detalleSubCentroTxt";
            this.detalleSubCentroTxt.Size = new System.Drawing.Size(97, 26);
            this.detalleSubCentroTxt.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 450);
            this.Controls.Add(this.fechaDatePicker);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.identificadorTxt);
            this.Controls.Add(this.montoTxt);
            this.Controls.Add(this.tasaTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.suplidorTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.monedaTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.centroCostoTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cajaTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.beneficiarioTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bancoTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasaTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.montoTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.identificadorTxt)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bancoTxt;
        private System.Windows.Forms.TextBox beneficiarioTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cajaTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox centroCostoTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox monedaTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox suplidorTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown tasaTxt;
        private System.Windows.Forms.NumericUpDown montoTxt;
        private System.Windows.Forms.NumericUpDown identificadorTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker fechaDatePicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox detalleSubCentroTxt;
        private System.Windows.Forms.TextBox detalleProyectoTxt;
        private System.Windows.Forms.TextBox detalleDebitoTxt;
        private System.Windows.Forms.TextBox detalleCuentaTxt;
        private System.Windows.Forms.TextBox detalleCreditoTxt;
        private System.Windows.Forms.TextBox detalleCentroCostoTxt;
    }
}

