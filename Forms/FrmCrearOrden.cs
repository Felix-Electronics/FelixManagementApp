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
        List<Orden> ordenes;
        Orden? orden {  get; set; }
        Cliente? cliente {  get; set; }


        public FrmCrearOrden(IClienteService _clienteService, IEquipoService _equipoService, IOrdenService _ordenService, ITecnicoService _tecnicoService)
        {
            InitializeComponent();
            this._clienteService = _clienteService;
            this._equipoService = _equipoService;
            this._ordenService = _ordenService;
            this._tecnicoService = _tecnicoService;
            clientes = new List<Cliente>();
            equipos = new List<Equipo>();
            tecnicos = new List<Tecnico>();
            ordenes = new List<Orden>();
            CargarClientes();


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
            CargarTecnicos();
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
            CargarEstatus();
        }

        private void Computadoras()
        {
            dgvComputadoras.DataSource = null;
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
            equipos.Add(equipo);
            limpiarElementos(false);
            Computadoras();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cliente = clientes.ElementAt(cbCliente.SelectedIndex);
            _ordenService.CrearOrdenConEquiposAsync(cliente.id_cliente, decimal.Parse(txtCosto.Text));
            obtenerUltimaOrden();
        }
        private async void obtenerUltimaOrden()
        {
            var ordenes = await _ordenService.GetAllOrdenesAsync();
            this.ordenes = ordenes.ToList();
            orden = ordenes.Last();
            guardarEquipos();
        }

        private async void guardarEquipos()
        {
            foreach( var equipo in this.equipos)
            {
                equipo.id_cliente = cliente.id_cliente;
                equipo.id_orden = orden.id_orden;
                await _equipoService.CreateEquipoAsync(equipo);
            }
            MessageBox.Show("Orden creada", "Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiarElementos(true);
        }

        private void limpiarElementos(bool creacion)
        {
            cbCliente.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtContra.Text = "";
            txtAccesorios.Text = "";
            txtProblema.Text = "";
            cbEstatus.Text = "";
            if ( creacion)
            {
                txtCosto.Text = "";
                equipos.Clear();
                Computadoras();
            }
        }
    }
}
