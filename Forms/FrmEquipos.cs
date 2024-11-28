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
    public partial class FrmEquipos : Form
    {
        private readonly IEquipoService _equipoService;
        private readonly ITecnicoService _tecnicoService;
        private readonly IClienteService _clienteService;
        private readonly IOrdenService _ordenService;
        List<Equipo> equipos;

        public FrmEquipos(IEquipoService equipoService, ITecnicoService tecnicoService, IClienteService clienteService, IOrdenService ordenService)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _equipoService = equipoService;
            _tecnicoService = tecnicoService;
            _clienteService = clienteService;
            _ordenService = ordenService;
            equipos = new List<Equipo>();
            Equipos();
        }

        private async void Equipos()
        {
            dgvEquipos.DataSource = null;
            var equip = await _equipoService.GetAllEquiposAsync();
            this.equipos = equip.ToList();
            dgvEquipos.DataSource = this.equipos;
            dgvEquipos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEquipos.Columns["id_equipo"].Visible = true;
            dgvEquipos.Columns["marca"].HeaderText = "Marca";
            dgvEquipos.Columns["modelo"].HeaderText = "Modelo";
            dgvEquipos.Columns["contrasenia_equipo"].HeaderText = "Contraseña";
            dgvEquipos.Columns["accesorios"].HeaderText = "Accesorios";
            dgvEquipos.Columns["problema"].HeaderText = "Problema";
            dgvEquipos.Columns["estatus"].HeaderText = "Estatus";
            dgvEquipos.Columns["fecha_entrega"].HeaderText = "Fecha Entrega";
            dgvEquipos.Columns["id_cliente"].Visible = false;
            dgvEquipos.Columns["Cliente"].Visible = false;
            dgvEquipos.Columns["Orden"].Visible = false;
            dgvEquipos.Columns["id_orden"].Visible = false;
            dgvEquipos.Columns["Tecnico"].Visible = false;
            dgvEquipos.Columns["id_tecnico"].Visible = false;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmCliente frm = new FrmCliente(_clienteService, _equipoService, _ordenService, _tecnicoService);
            frm.ShowDialog();
        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            FrmOrdenes frm = new FrmOrdenes(_equipoService, _tecnicoService, _clienteService, _ordenService);
            frm.ShowDialog();
        }
    }
}
