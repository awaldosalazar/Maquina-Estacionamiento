namespace Estacionamiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cont_ticket = new System.Windows.Forms.Button();
            this.label_ticket = new System.Windows.Forms.Label();
            this.tabla_estacionamiento = new System.Windows.Forms.DataGridView();
            this.Ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora_salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pago_con = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cambio_devuelto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticket_pagar = new System.Windows.Forms.TextBox();
            this.Monedas = new System.Windows.Forms.PictureBox();
            this.dos = new System.Windows.Forms.CheckBox();
            this.cinco = new System.Windows.Forms.CheckBox();
            this.diez = new System.Windows.Forms.CheckBox();
            this.veinte = new System.Windows.Forms.CheckBox();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_10 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.total_pagar = new System.Windows.Forms.Label();
            this.ingresar_ticket = new System.Windows.Forms.Button();
            this.tiempo_durado = new System.Windows.Forms.Label();
            this.creditos = new System.Windows.Forms.Label();
            this.cambio = new System.Windows.Forms.Label();
            this.c1 = new System.Windows.Forms.Label();
            this.c2 = new System.Windows.Forms.Label();
            this.c5 = new System.Windows.Forms.Label();
            this.c10 = new System.Windows.Forms.Label();
            this.c20 = new System.Windows.Forms.Label();
            this.mostrar_cantidad_cambio = new System.Windows.Forms.Label();
            this.mensaje = new System.Windows.Forms.Label();
            this.form_estacionamiento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_estacionamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Monedas)).BeginInit();
            this.SuspendLayout();
            // 
            // cont_ticket
            // 
            this.cont_ticket.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cont_ticket.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cont_ticket.Location = new System.Drawing.Point(72, 58);
            this.cont_ticket.Name = "cont_ticket";
            this.cont_ticket.Size = new System.Drawing.Size(97, 64);
            this.cont_ticket.TabIndex = 0;
            this.cont_ticket.Text = "TOMAR TICKET";
            this.cont_ticket.UseVisualStyleBackColor = true;
            this.cont_ticket.Click += new System.EventHandler(this.cont_ticket_Click);
            // 
            // label_ticket
            // 
            this.label_ticket.Location = new System.Drawing.Point(72, 39);
            this.label_ticket.Name = "label_ticket";
            this.label_ticket.Size = new System.Drawing.Size(97, 16);
            this.label_ticket.TabIndex = 1;
            this.label_ticket.Text = "TOMA TU TICKET";
            // 
            // tabla_estacionamiento
            // 
            this.tabla_estacionamiento.AllowUserToOrderColumns = true;
            this.tabla_estacionamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_estacionamiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ticket,
            this.Hora_entrada,
            this.Hora_salida,
            this.Total,
            this.Pago_con,
            this.Cambio_devuelto,
            this.Pagado});
            this.tabla_estacionamiento.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabla_estacionamiento.Location = new System.Drawing.Point(12, 142);
            this.tabla_estacionamiento.Name = "tabla_estacionamiento";
            this.tabla_estacionamiento.Size = new System.Drawing.Size(445, 262);
            this.tabla_estacionamiento.TabIndex = 2;
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
            this.Pago_con.Visible = false;
            // 
            // Cambio_devuelto
            // 
            this.Cambio_devuelto.HeaderText = "Cambio_devuelto";
            this.Cambio_devuelto.Name = "Cambio_devuelto";
            this.Cambio_devuelto.Visible = false;
            // 
            // Pagado
            // 
            this.Pagado.HeaderText = "Pagado";
            this.Pagado.Name = "Pagado";
            this.Pagado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Pagado.Visible = false;
            // 
            // ticket_pagar
            // 
            this.ticket_pagar.Location = new System.Drawing.Point(472, 142);
            this.ticket_pagar.Name = "ticket_pagar";
            this.ticket_pagar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ticket_pagar.Size = new System.Drawing.Size(192, 20);
            this.ticket_pagar.TabIndex = 3;
            this.ticket_pagar.Text = "DIGITE SI TICKET";
            this.ticket_pagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ticket_pagar.Enter += new System.EventHandler(this.ticket_pagar_Enter);
            // 
            // Monedas
            // 
            this.Monedas.Image = ((System.Drawing.Image)(resources.GetObject("Monedas.Image")));
            this.Monedas.Location = new System.Drawing.Point(276, 12);
            this.Monedas.Name = "Monedas";
            this.Monedas.Size = new System.Drawing.Size(378, 93);
            this.Monedas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Monedas.TabIndex = 5;
            this.Monedas.TabStop = false;
            // 
            // dos
            // 
            this.dos.AutoSize = true;
            this.dos.Checked = true;
            this.dos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dos.Location = new System.Drawing.Point(364, 111);
            this.dos.Name = "dos";
            this.dos.Size = new System.Drawing.Size(15, 14);
            this.dos.TabIndex = 7;
            this.dos.UseVisualStyleBackColor = true;
            // 
            // cinco
            // 
            this.cinco.AutoSize = true;
            this.cinco.Checked = true;
            this.cinco.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cinco.Location = new System.Drawing.Point(432, 112);
            this.cinco.Name = "cinco";
            this.cinco.Size = new System.Drawing.Size(15, 14);
            this.cinco.TabIndex = 8;
            this.cinco.UseVisualStyleBackColor = true;
            // 
            // diez
            // 
            this.diez.AutoSize = true;
            this.diez.Checked = true;
            this.diez.CheckState = System.Windows.Forms.CheckState.Checked;
            this.diez.Location = new System.Drawing.Point(510, 112);
            this.diez.Name = "diez";
            this.diez.Size = new System.Drawing.Size(15, 14);
            this.diez.TabIndex = 9;
            this.diez.UseVisualStyleBackColor = true;
            // 
            // veinte
            // 
            this.veinte.AutoSize = true;
            this.veinte.Checked = true;
            this.veinte.CheckState = System.Windows.Forms.CheckState.Checked;
            this.veinte.Location = new System.Drawing.Point(598, 112);
            this.veinte.Name = "veinte";
            this.veinte.Size = new System.Drawing.Size(15, 14);
            this.veinte.TabIndex = 10;
            this.veinte.UseVisualStyleBackColor = true;
            // 
            // button_1
            // 
            this.button_1.Enabled = false;
            this.button_1.Location = new System.Drawing.Point(697, 139);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(75, 23);
            this.button_1.TabIndex = 11;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_2
            // 
            this.button_2.Enabled = false;
            this.button_2.Location = new System.Drawing.Point(697, 168);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(75, 23);
            this.button_2.TabIndex = 12;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.button_2_Click);
            // 
            // button_10
            // 
            this.button_10.Enabled = false;
            this.button_10.Location = new System.Drawing.Point(697, 226);
            this.button_10.Name = "button_10";
            this.button_10.Size = new System.Drawing.Size(75, 23);
            this.button_10.TabIndex = 13;
            this.button_10.Text = "10";
            this.button_10.UseVisualStyleBackColor = true;
            this.button_10.Click += new System.EventHandler(this.button_10_Click);
            // 
            // button_5
            // 
            this.button_5.Enabled = false;
            this.button_5.Location = new System.Drawing.Point(697, 197);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(75, 23);
            this.button_5.TabIndex = 14;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.button_5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(605, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 15;
            // 
            // total_pagar
            // 
            this.total_pagar.AutoSize = true;
            this.total_pagar.Location = new System.Drawing.Point(511, 209);
            this.total_pagar.Name = "total_pagar";
            this.total_pagar.Size = new System.Drawing.Size(112, 13);
            this.total_pagar.TabIndex = 16;
            this.total_pagar.Text = "CANTIDAD A PAGAR";
            // 
            // ingresar_ticket
            // 
            this.ingresar_ticket.Location = new System.Drawing.Point(472, 168);
            this.ingresar_ticket.Name = "ingresar_ticket";
            this.ingresar_ticket.Size = new System.Drawing.Size(192, 23);
            this.ingresar_ticket.TabIndex = 17;
            this.ingresar_ticket.Text = "INGRESAR TICKET";
            this.ingresar_ticket.UseVisualStyleBackColor = true;
            this.ingresar_ticket.Click += new System.EventHandler(this.ingresar_ticket_Click);
            // 
            // tiempo_durado
            // 
            this.tiempo_durado.AutoSize = true;
            this.tiempo_durado.Location = new System.Drawing.Point(507, 194);
            this.tiempo_durado.Name = "tiempo_durado";
            this.tiempo_durado.Size = new System.Drawing.Size(42, 13);
            this.tiempo_durado.TabIndex = 18;
            this.tiempo_durado.Text = "Tiempo";
            // 
            // creditos
            // 
            this.creditos.AutoSize = true;
            this.creditos.Location = new System.Drawing.Point(510, 224);
            this.creditos.Name = "creditos";
            this.creditos.Size = new System.Drawing.Size(87, 13);
            this.creditos.TabIndex = 19;
            this.creditos.Text = "TUS CREDITOS";
            // 
            // cambio
            // 
            this.cambio.AutoSize = true;
            this.cambio.Location = new System.Drawing.Point(513, 241);
            this.cambio.Name = "cambio";
            this.cambio.Size = new System.Drawing.Size(48, 13);
            this.cambio.TabIndex = 20;
            this.cambio.Text = "CAMBIO";
            // 
            // c1
            // 
            this.c1.AutoSize = true;
            this.c1.Location = new System.Drawing.Point(491, 276);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(28, 13);
            this.c1.TabIndex = 21;
            this.c1.Text = "$1:0";
            // 
            // c2
            // 
            this.c2.AutoSize = true;
            this.c2.Location = new System.Drawing.Point(491, 289);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(28, 13);
            this.c2.TabIndex = 22;
            this.c2.Text = "$2:0";
            // 
            // c5
            // 
            this.c5.AutoSize = true;
            this.c5.Location = new System.Drawing.Point(491, 302);
            this.c5.Name = "c5";
            this.c5.Size = new System.Drawing.Size(28, 13);
            this.c5.TabIndex = 23;
            this.c5.Text = "$5:0";
            // 
            // c10
            // 
            this.c10.AutoSize = true;
            this.c10.Location = new System.Drawing.Point(491, 315);
            this.c10.Name = "c10";
            this.c10.Size = new System.Drawing.Size(34, 13);
            this.c10.TabIndex = 24;
            this.c10.Text = "$10:0";
            // 
            // c20
            // 
            this.c20.AutoSize = true;
            this.c20.Location = new System.Drawing.Point(491, 328);
            this.c20.Name = "c20";
            this.c20.Size = new System.Drawing.Size(34, 13);
            this.c20.TabIndex = 25;
            this.c20.Text = "$20:0";
            // 
            // mostrar_cantidad_cambio
            // 
            this.mostrar_cantidad_cambio.AutoSize = true;
            this.mostrar_cantidad_cambio.Location = new System.Drawing.Point(494, 260);
            this.mostrar_cantidad_cambio.Name = "mostrar_cantidad_cambio";
            this.mostrar_cantidad_cambio.Size = new System.Drawing.Size(109, 13);
            this.mostrar_cantidad_cambio.TabIndex = 26;
            this.mostrar_cantidad_cambio.Text = "CAMBIO DEVUELTO";
            // 
            // mensaje
            // 
            this.mensaje.AutoSize = true;
            this.mensaje.Location = new System.Drawing.Point(598, 302);
            this.mensaje.Name = "mensaje";
            this.mensaje.Size = new System.Drawing.Size(103, 13);
            this.mensaje.TabIndex = 27;
            this.mensaje.Text = "Estacionamiento c.v";
            // 
            // form_estacionamiento
            // 
            this.form_estacionamiento.Location = new System.Drawing.Point(12, 415);
            this.form_estacionamiento.Name = "form_estacionamiento";
            this.form_estacionamiento.Size = new System.Drawing.Size(445, 23);
            this.form_estacionamiento.TabIndex = 28;
            this.form_estacionamiento.Text = "HISTORIAL DE TICKETS PAGADOS";
            this.form_estacionamiento.UseVisualStyleBackColor = true;
            this.form_estacionamiento.Click += new System.EventHandler(this.form_estacionamiento_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.form_estacionamiento);
            this.Controls.Add(this.mensaje);
            this.Controls.Add(this.mostrar_cantidad_cambio);
            this.Controls.Add(this.c20);
            this.Controls.Add(this.c10);
            this.Controls.Add(this.c5);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.cambio);
            this.Controls.Add(this.creditos);
            this.Controls.Add(this.tiempo_durado);
            this.Controls.Add(this.ingresar_ticket);
            this.Controls.Add(this.total_pagar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_10);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.veinte);
            this.Controls.Add(this.diez);
            this.Controls.Add(this.cinco);
            this.Controls.Add(this.dos);
            this.Controls.Add(this.Monedas);
            this.Controls.Add(this.ticket_pagar);
            this.Controls.Add(this.tabla_estacionamiento);
            this.Controls.Add(this.label_ticket);
            this.Controls.Add(this.cont_ticket);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tabla_estacionamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Monedas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cont_ticket;
        private System.Windows.Forms.Label label_ticket;
        private System.Windows.Forms.DataGridView tabla_estacionamiento;
        private System.Windows.Forms.TextBox ticket_pagar;
        private System.Windows.Forms.PictureBox Monedas;
        private System.Windows.Forms.CheckBox dos;
        private System.Windows.Forms.CheckBox cinco;
        private System.Windows.Forms.CheckBox diez;
        private System.Windows.Forms.CheckBox veinte;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_10;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label total_pagar;
        private System.Windows.Forms.Button ingresar_ticket;
        private System.Windows.Forms.Label tiempo_durado;
        private System.Windows.Forms.Label creditos;
        private System.Windows.Forms.Label cambio;
        private System.Windows.Forms.Label c1;
        private System.Windows.Forms.Label c2;
        private System.Windows.Forms.Label c5;
        private System.Windows.Forms.Label c10;
        private System.Windows.Forms.Label c20;
        private System.Windows.Forms.Label mostrar_cantidad_cambio;
        private System.Windows.Forms.Label mensaje;
        private System.Windows.Forms.Button form_estacionamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora_salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pago_con;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cambio_devuelto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagado;
    }
}

