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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        public void load_dates(string t,string llegada,string salida,string total,string pago,string cambio,string pagado)
        {
            tablaCopia.Rows.Add(t.ToString(), llegada.ToString(), salida.ToString(), total.ToString(), pago.ToString(), cambio.ToString(), pagado.ToString());
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
