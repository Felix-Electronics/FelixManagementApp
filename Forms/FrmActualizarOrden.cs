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
    public partial class FrmActualizarOrden : Form
    {
        private readonly IClienteService _clienteService;
        private readonly IEquipoService _equipoService;
        private readonly IOrdenService _ordenService;
        private readonly ITecnicoService _tecnicoService;
        List<Cliente> clientes;
        List<Equipo> equipos;
        List<Tecnico> tecnicos;
        List<Orden> ordenes;
        List<Equipo> nuevosequipos;
        Orden orden { get; set; }
        Cliente? cliente { get; set; }
        public FrmActualizarOrden(IClienteService _clienteService, IEquipoService _equipoService, IOrdenService _ordenService, ITecnicoService _tecnicoService, Orden orden)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this._clienteService = _clienteService;
            this._equipoService = _equipoService;
            this._ordenService = _ordenService;
            this._tecnicoService = _tecnicoService;
            this.orden = orden;
            clientes = new List<Cliente>();
            equipos = new List<Equipo>();
            nuevosequipos = new List<Equipo>();
            tecnicos = new List<Tecnico>();
            ordenes = new List<Orden>();
            CargarClientes();
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
            Cliente c = clientes.FirstOrDefault(cliente => cliente.id_cliente == orden.id_cliente);
            txtCosto.Text = orden.total + "";
            cbCliente.Text = c.nombre + ", " + c.telefono;
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
        private void CargarEstatus()
        {
            cbEstatus.Items.Clear();
            cbEstatus.Items.Add("Pendiente");
            cbEstatus.Items.Add("En reparación");
            cbEstatus.Items.Add("Reparado");
            CargarComputadoras();
        }

        private async void CargarComputadoras()
        {
            var equipos = await _equipoService.GetEquiposByOrdenIdAsync(orden.id_orden);
            this.equipos = equipos.ToList();
            Computadoras();
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

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            orden.total = decimal.Parse(txtCosto.Text);
            orden.fecha_creacion = DateTime.Now;
            await _ordenService.UpdateOrdenAsync(orden);
            guardarEquipos();
        }

        private async void guardarEquipos()
        {
            foreach (var equipo in this.nuevosequipos)
            {
                equipo.id_cliente = cliente.id_cliente;
                equipo.id_orden = orden.id_orden;
                await _equipoService.CreateEquipoAsync(equipo);
            }
            limpiarElementos(true);
            MessageBox.Show("Orden actualizada", "Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            };
            nuevosequipos.Add(equipo);
            equipos.Add(equipo);
            limpiarElementos(false);
            Computadoras();
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
            if (creacion)
            {
                txtCosto.Text = "";
                equipos.Clear();
                nuevosequipos.Clear();
                Computadoras();
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmCliente frm = new FrmCliente(_clienteService, _equipoService, _ordenService, _tecnicoService);
            frm.ShowDialog();
            this.Dispose();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            FrmAgregarCliente frm = new FrmAgregarCliente(_clienteService);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarClientes();
            }
        }

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            cliente = clientes.ElementAt(cbCliente.SelectedIndex);
            FrmAgregarCliente frm = new FrmAgregarCliente(_clienteService, cliente);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarClientes();
            }
        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmOrdenes frm = new FrmOrdenes(_equipoService, _tecnicoService, _clienteService, _ordenService);
            frm.ShowDialog();
            this.Dispose();
        }
    }
}
