namespace Estacionamiento
{
    partial class Form2
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
            this.tablaCopia = new System.Windows.Forms.DataGridView();
            this.Ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora_salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pago_con = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cambio_devuelto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCopia)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaCopia
            // 
            this.tablaCopia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCopia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ticket,
            this.Hora_entrada,
            this.Hora_salida,
            this.Total,
            this.Pago_con,
            this.Cambio_devuelto,
            this.Pagado});
            this.tablaCopia.Location = new System.Drawing.Point(12, 44);
            this.tablaCopia.Name = "tablaCopia";
            this.tablaCopia.Size = new System.Drawing.Size(745, 394);
            this.tablaCopia.TabIndex = 0;
            // 
            // Ticket
            // 
            this.Ticket.HeaderText = "Ticket";
            this.Ticket.Name = "Ticket";
            // 
            // Hora_entrada
            // 
            this.Hora_entrada.HeaderText = "Hora_entrada";
            this.Hora_entrada.Name = "Hora_entrada";
            // 
            // Hora_salida
            // 
            this.Hora_salida.HeaderText = "Hora_salida";
            this.Hora_salida.Name = "Hora_salida";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // Pago_con
            // 
            this.Pago_con.HeaderText = "Pago_con";
            this.Pago_con.Name = "Pago_con";
            // 
            // Cambio_devuelto
            // 
            this.Cambio_devuelto.HeaderText = "Cambio_devuelto";
            this.Cambio_devuelto.Name = "Cambio_devuelto";
            // 
            // Pagado
            // 
            this.Pagado.HeaderText = "Pagado";
            this.Pagado.Name = "Pagado";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(12, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.tablaCopia);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaCopia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaCopia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora_salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pago_con;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cambio_devuelto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagado;
        private System.Windows.Forms.Button Exit;
    }
}