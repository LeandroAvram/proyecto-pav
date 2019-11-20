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
    public partial class ventanaReportePagos : Form
    {
        public ventanaReportePagos()
        {
            InitializeComponent();
        }

        private void VentanaReportePagos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetPagos.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.DataSetPagos.DataTable1);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.DataTable1TableAdapter.Fill(this.DataSetPagos.DataTable1);
            this.reportViewer1.RefreshReport();
        }
    }
}
