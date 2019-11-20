using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Reportes
{
    public partial class ventanaReporteReserva : Form
    {
        public ventanaReporteReserva()
        {
            InitializeComponent();
        }

        private void VentanaReporteReserva_Load(object sender, EventArgs e)
        {
            this.DataTable1TableAdapter.Fill(this.dataSetReservas.DataTable1);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.DataTable1TableAdapter.Fill(this.dataSetReservas.DataTable1);
            reportViewer1.RefreshReport();
        }
    }
}
