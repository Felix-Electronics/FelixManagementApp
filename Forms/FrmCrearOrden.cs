using FelixManagementApp.Models;
using FelixManagementApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FelixManagementApp.Forms
{
    public partial class FrmCrearOrden : Form
    {
        private readonly IClienteService _clienteService;
        private readonly IEquipoService _equipoService;
        private readonly IOrdenService _ordenService;
        private readonly ITecnicoService _tecnicoService;
        List<Cliente> clientes;
        List<Equipo> equipos;
        List<Tecnico> tecnicos;


        public FrmCrearOrden(IClienteService _clienteService, IEquipoService _equipoService, IOrdenService _ordenService, ITecnicoService _tecnicoService)
        {
            InitializeComponent();
            this._clienteService = _clienteService;
            this._equipoService = _equipoService;
            this._ordenService = _ordenService;
            this._tecnicoService = _tecnicoService;
            CargarClientes();
            CargarTecnicos();
            CargarEstatus();
        }
        private void CargarEstatus()
        {
            cbEstatus.Items.Clear();
            cbEstatus.Items.Add("Pendiente");
            cbEstatus.Items.Add("En reparación");
            cbEstatus.Items.Add("Reparado");
        }

        private async void CargarClientes()
        {
            cbCliente.Items.Clear();
            var clientes = await _clienteService.GetAllClientesAsync();
            this.clientes = clientes.ToList();
            string ncliente = "";
            foreach (var cliente in clientes)
            {
                ncliente = cliente.nombre + ", " + cliente.telefono;
                cbCliente.Items.Add(ncliente);
                ncliente = "";
            }
        }

        private async void CargarTecnicos()
        {
            cbTecnico.Items.Clear();
            var tecnicos = await _tecnicoService.GetAllTecnicosAsync();
            this.tecnicos = tecnicos.ToList();
            foreach (var tecnico in tecnicos)
            {
                cbTecnico.Items.Add(tecnico.nombre);
            }
        }

        private void Computadoras()
        {
            dgvComputadoras.DataSource = equipos;
            dgvComputadoras.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvComputadoras.Columns["Tecnico"].Visible = false;
            dgvComputadoras.Columns["Orden"].Visible = false;
            dgvComputadoras.Columns["Cliente"].Visible = false;
            dgvComputadoras.Columns["id_equipo"].Visible = false;
            dgvComputadoras.Columns["marca"].HeaderText = "Marca";
            dgvComputadoras.Columns["modelo"].HeaderText = "Modelo";
            dgvComputadoras.Columns["contrasenia_equipo"].HeaderText = "Contraseña";
            dgvComputadoras.Columns["accesorios"].HeaderText = "Accesorios";
            dgvComputadoras.Columns["problema"].HeaderText = "Problema";
            dgvComputadoras.Columns["estatus"].HeaderText = "Estatus";
            dgvComputadoras.Columns["fecha_entrega"].HeaderText = "Fecha Entrega";
            dgvComputadoras.Columns["id_orden"].Visible = false;
            dgvComputadoras.Columns["id_tecnico"].Visible = false;
            dgvComputadoras.Columns["id_cliente"].Visible = false;
            dgvComputadoras.Columns["Cliente"].Visible = false;
            dgvComputadoras.Columns["Orden"].Visible = false;
            dgvComputadoras.Columns["Tecnico"].Visible = false;

        }

        private void btnAgregarComp_Click(object sender, EventArgs e)
        {

            DateTime fecha = timePicker.Value;
            Tecnico t = tecnicos.ElementAt(cbTecnico.SelectedIndex);
            Equipo equipo = new Equipo()
            {
                marca = txtMarca.Text,
                modelo = txtModelo.Text,
                contrasenia_equipo = txtContra.Text,
                accesorios = txtAccesorios.Text,
                problema = txtProblema.Text,
                estatus = cbEstatus.Text,
                fecha_entrega = fecha,
                id_tecnico = t.id_tecnico
                //falta orden y tecnico xd
            };
            equipos.Add( equipo );
        }


    }
}
