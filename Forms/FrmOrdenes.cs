using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FelixManagementApp.Models;
using FelixManagementApp.Services;

namespace FelixManagementApp.Forms
{
    public partial class FrmOrdenes : Form
    {
        private readonly IEquipoService _equipoService;
        private readonly ITecnicoService _tecnicoService;
        private readonly IClienteService _clienteService;
        private readonly IOrdenService _ordenService;
        List<Orden> ordenes;
        Orden? orden { get; set; }

        public FrmOrdenes(IEquipoService equipoService, ITecnicoService tecnicoService, IClienteService clienteService, IOrdenService ordenService)
        {
            InitializeComponent();
            _equipoService = equipoService;
            _tecnicoService = tecnicoService;
            _clienteService = clienteService;
            _ordenService = ordenService;
            ordenes = new List<Orden>();
            Ordenes();
        }

        private async void Ordenes()
        {
            dgvOrdenes.DataSource = null;
            var orden = await _ordenService.GetAllOrdenesAsync();
            this.ordenes = orden.ToList();
            dgvOrdenes.DataSource = this.ordenes;
            dgvOrdenes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrdenes.Columns["id_orden"].Visible = false;
            dgvOrdenes.Columns["fecha_creacion"].HeaderText = "Fecha Orden";
            dgvOrdenes.Columns["total"].HeaderText = "Total";
            dgvOrdenes.Columns["id_cliente"].Visible = false;
            dgvOrdenes.Columns["Cliente"].Visible = false;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmCliente frm = new FrmCliente(_clienteService, _equipoService, _ordenService, _tecnicoService);
            this.DialogResult = DialogResult.OK;
            frm.Show();
            Close();
        }

        private void dgvOrdenes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var orden = (Orden)dgvOrdenes.Rows[e.RowIndex].DataBoundItem;

                FrmActualizarOrden frmActualizarOrd = new FrmActualizarOrden(_clienteService, _equipoService, _ordenService, _tecnicoService, orden);
                if (frmActualizarOrd.ShowDialog() == DialogResult.OK)
                {
                    Ordenes();
                }
            }
        }
    }
}
