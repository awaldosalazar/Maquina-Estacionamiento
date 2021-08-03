using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamiento
{
    public partial class Form1 : Form
    {
        int ticket_act = 0;
        public Form1()
        {
            InitializeComponent();
            
            creditosacct = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void cont_ticket_Click(object sender, EventArgs e)
        {
            ticket_act++;
            label_ticket.Text = "Tu n° de ticket" + ticket_act;
            mensaje.Text = "Estacionamiento c.v";
            var t = Task.Run(async delegate
            {
                await Task.Delay(TimeSpan.FromSeconds(1.5));
                return "TOMA TU TICKET";
            });
            label_ticket.Text = t.Result;
            llenarTabla1(ticket_act, hora());
        }
        
        public void llenarTabla1(int t,string fecha)
        {
            tabla_estacionamiento.Rows.Add(t, fecha, null, null,null,null,"no");
        }

        public void llenarTabla2(int t, string fecha)
        {
            tabla_estacionamiento.Rows.Add(t, fecha, null, null);
        }

        private void ticket_pagar_Enter(object sender, EventArgs e)
        {
            ticket_pagar.Clear();
        }

        public string hora()
        {
            var fecha = DateTime.Now.ToString("hh:mm:ss");
            return fecha;
        }

        int costo = 0;
        private void ingresar_ticket_Click(object sender, EventArgs e)
        {
            int band = 0;
             foreach (DataGridViewRow Row in tabla_estacionamiento.Rows)
             {
                  String strFila = Row.Index.ToString();
                  string Valor = Convert.ToString(Row.Cells["Ticket"].Value);
                  string valor_pagado = Convert.ToString(Row.Cells["Pagado"].Value);
                  if (Valor == this.ticket_pagar.Text)
                  {
                    band = 1;
                    if (valor_pagado == "no")
                      {                        
                           Row.Cells["Hora_salida"].Value = hora();
                        // tabla_estacionamiento.Rows[Convert.ToInt32(strFila)].DefaultCellStyle.BackColor = Color.Red;


                           string V1 = Convert.ToString(Row.Cells["Hora_entrada"].Value);
                           string V2 = Convert.ToString(Row.Cells["Hora_salida"].Value);


                           DateTime fecha1 = Convert.ToDateTime(V1);

                           DateTime fecha2 = Convert.ToDateTime(V2);

                           TimeSpan result = fecha2.Subtract(fecha1);

                           int segundo = (int)result.TotalSeconds;

                        costo = (segundo / 15) * 5;

                        if (costo == 0)
                           {
                               costo = 5;
                           }

                        Row.Cells["Total"].Value = costo;

                        total_pagar.Text = "Total A Pagar: [*" + costo.ToString()+"*]";
                        tiempo_durado.Text = "Tu tiempo en segundos fue [*"+segundo.ToString()+"*]";

                        button_1.Enabled = true;
                        button_2.Enabled = true;
                        button_5.Enabled = true;
                        button_10.Enabled = true;
                        ingresar_ticket.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Este ticket ya fue pagado", "[*ALERTA*]");
                    }

                  }
             }
            if (band == 0)
            {
                MessageBox.Show("No existe ese ticket", "[*ATENCION*]");
            }

        }

        int cambio_dar = 0;
        int auxUltimoCambio;
        int auxUltimoPago;
        private void actulizar()
        {
            creditos.Text = "Tus creditos actuales son [*" + creditosacct.ToString() + "*]";
            creditos.Refresh();
            if(creditosacct>=costo)
            {
                button_1.Enabled = false;
                button_2.Enabled = false;
                button_5.Enabled = false;
                button_10.Enabled = false;
                cambio_dar = creditosacct - costo;
                cambio.Text="Dinero a devolver [*"+cambio_dar.ToString()+"*]";
                cambioDar();
            }
            if(cambio_dar==0)
            {
                ingresar_ticket.Enabled = true;
                foreach (DataGridViewRow Row in tabla_estacionamiento.Rows)
                {
                    String strFila = Row.Index.ToString();
                    string Valor = Convert.ToString(Row.Cells["Ticket"].Value);
                    string valor_pagado = Convert.ToString(Row.Cells["Pagado"].Value);
                    if (Valor == this.ticket_pagar.Text)
                    {
                        Row.Cells["Pagado"].Value = "si";
                        Row.Cells["Pago_con"].Value = auxUltimoPago;
                        Row.Cells["Cambio_devuelto"].Value = auxUltimoCambio;
                        tabla_estacionamiento.Rows[Convert.ToInt32(strFila)].DefaultCellStyle.BackColor = Color.Red;

                        /*SE CARGA AL FORM2*/
                        string entrada = Convert.ToString(Row.Cells["Hora_entrada"].Value);
                        string salida = Convert.ToString(Row.Cells["Hora_salida"].Value);
                        string porPagar = Convert.ToString(Row.Cells["total"].Value);
                       /* Form2 tabla2 = new Form2();
                        tabla2.load_dates(Valor.ToString(),entrada.ToString(),salida.ToString(),porPagar.ToString(),auxUltimoPago.ToString(),auxUltimoCambio.ToString(), "si");
                        tabla2.Show();*/
                    }
                    
                } 
            }
        }

        int[] monedas;
        int[] sol;
        int au = 0;
        int m1, m2, m5, m10, m20;
        public void cambioDar()
        {
            au = 0;
            monedas = new int[5] { 0, 0, 0, 0, 0 };
            auxMon = new List<int>();
            monedas[au++] = 1;
            if (dos.Checked == true) 
            {
                monedas[au] = 2;
                au++;
            }
            if (cinco.Checked == true)
            {
                monedas[au] = 5;
                au++;
            }
            if (diez.Checked == true)
            {
                monedas[au] = 10;
                au++;
            }
            if (veinte.Checked == true)
            {
                monedas[au] = 20; 
            }
            monedas = monedas.Where(i => i != 0).ToArray();
            alg_darcambio();
            sol = new int[auxSol.Count];
            au = 0;
            foreach (int i in auxSol)
            {
                sol[au++] = i; // En la posición en aux agregaremos el elemento
                if (i == 1) // Si el elemento es un 1
                    m1++; // Aumentamos nuestro contador de monedas de 1
                else if (i == 2) // Si el elemento es un 2
                    m2++; // Aumentamos nuestro contador de monedas de 2
                else if (i == 5) // Si el elemento es un 5
                    m5++; // Aumentamos nuestro contador de monedas de 5
                else if (i == 10) // Si el elemento es un 10
                    m10++; // Aumentamos nuestro contador de monedas de 10
                else if (i == 20) // Si el elemento es un 20
                    m20++; // Aumentamos nuestro contador de monedas de 20
            }
            c1.Text = "$1:" + m1.ToString();
            c2.Text = "$2:" + m2.ToString();
            c5.Text = "$5:" + m5.ToString();
            c10.Text = "$10:" + m10.ToString();
            c20.Text = "$20:" + m20.ToString();
             var t = Task.Run(async delegate
             {
                 await Task.Delay(TimeSpan.FromSeconds(2));
                 return "Buen dia";
             });
            mensaje.Text = t.Result;
            auxUltimoCambio = cambio_dar;
            auxUltimoPago = creditosacct;
            volveInicio();
        }

        int creditosAux; 
        List<int> auxSol;
        List<int> auxMon;
        int auxM;
        public void alg_darcambio()
        {
            creditosAux = cambio_dar; 
            auxSol = new List<int>(); 

            foreach (int x in monedas)
            {
                auxMon.Add(x); 
            }

            while (auxMon.Count > 0) 
            {
                auxM = auxMon.Last();

                if (auxM <= creditosAux)
                {
                    auxSol.Add(auxM); 
                    creditosAux -= auxM;

                    if (creditosAux == 0)
                    {
                        return; 
                    }
                }
                else 
                {
                    auxMon.Remove(auxM); 
                }
            }
        }


        int creditosacct=0;

        public void aggCreditos(int montoPagar)
        {
            button_1.Enabled = true;
            button_2.Enabled = true;
            button_5.Enabled = true;
            button_10.Enabled = true;
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            creditosacct++;
            actulizar();
        }

        private void form_estacionamiento_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            foreach (DataGridViewRow row in tabla_estacionamiento.Rows)
            {
                
                if ("si" == row.Cells["Pagado"].Value.ToString())
                {    
                    fr2.load_dates(row.Cells["Ticket"].Value.ToString(), row.Cells["Hora_entrada"].Value.ToString(), row.Cells["Hora_salida"].Value.ToString(), row.Cells["Total"].Value.ToString(), row.Cells["Pago_con"].Value.ToString(), row.Cells["Cambio_devuelto"].Value.ToString(), "si");
                }
                if (ticket_act == Int32.Parse(row.Cells["Ticket"].Value.ToString()))
                {
                    break;
                }
            }
            this.Hide();
            fr2.ShowDialog();
            this.Show();
        }
        public string mandarultimosdatos()
        {
            return "hola";
        }
        private void button_2_Click(object sender, EventArgs e)
        {
            creditosacct+=2;
            actulizar();
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            creditosacct += 5;
            actulizar();
        }

        private void button_10_Click(object sender, EventArgs e)
        {
            creditosacct += 10;
            actulizar();
        }

        public void volveInicio()
        {
            m1 = 0;
            m2 = 0;
            m5 = 0;
            m10 = 0;
            m20 = 0;
            cambio_dar = 0;
            creditosacct = 0;
            tiempo_durado.Text = "tiempo";
            total_pagar.Text = "CANTIDAD A PAGAR";
            creditos.Text = "TUS CREDITOS";
            cambio.Text = "CAMBIO";
            c1.Text = "$1:0";
            c2.Text = "$2:0";
            c5.Text = "$5:0";
            c10.Text = "$10:0";
            c20.Text = "$20:0";
        }
    }    
}


