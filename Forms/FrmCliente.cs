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
    public partial class FrmCliente : Form
    {

        private readonly IClienteService _clienteService;
        private readonly IEquipoService _equipoService;
        private readonly IOrdenService _ordenService;
        private readonly ITecnicoService _tecnicoService;
        public Cliente? ClienteCreado { get; private set; }

        public FrmCliente(IClienteService clienteService, IEquipoService equipoService, IOrdenService ordenService, ITecnicoService tecnicoService)
        {
            InitializeComponent();
            _clienteService = clienteService;
            _equipoService = equipoService;
            _ordenService = ordenService;
            _tecnicoService = tecnicoService;
            LoadClientes();
        }

        private async void LoadClientes()
        {
            var clientes = await _clienteService.GetAllClientesAsync();
            dataGridView1.DataSource = clientes.ToList();
            dataGridView1.DefaultCellStyle.Padding = new Padding(5);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["id_cliente"].Visible = true;
            dataGridView1.Columns["nombre"].HeaderText = "Nombre";
            dataGridView1.Columns["apellido_paterno"].HeaderText = "Apellido Paterno";
            dataGridView1.Columns["apellido_materno"].HeaderText = "Apellido Materno";
            dataGridView1.Columns["correo"].HeaderText = "Correo";
            dataGridView1.Columns["telefono"].HeaderText = "Teléfono";

            if (dataGridView1.Columns["Eliminar"] == null)
            {
                DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
                btnEliminar.Name = "Eliminar";
                btnEliminar.HeaderText = "Eliminar";
                btnEliminar.Text = "Eliminar";
                btnEliminar.FlatStyle = FlatStyle.Flat;
                btnEliminar.UseColumnTextForButtonValue = true;
                btnEliminar.Width = 150;
                dataGridView1.Columns.Add(btnEliminar);
            }
            //RealizarLogin();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            var frmAgregarCliente = new FrmAgregarCliente(_clienteService);
            frmAgregarCliente.ShowDialog();
            LoadClientes();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var clienteSeleccionado = (Cliente)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                FrmAgregarCliente frmAgregarCliente = new FrmAgregarCliente(_clienteService, clienteSeleccionado);
                if (frmAgregarCliente.ShowDialog() == DialogResult.OK)
                {
                    LoadClientes();
                }
            }
        }

        private async void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    var confirmResult = MessageBox.Show(
                        "¿Estás seguro de que deseas eliminar este cliente? Esta acción no se puede deshacer.",
                        "Confirmar Eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (confirmResult == DialogResult.Yes)
                    {
                        int idCliente = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_cliente"].Value);

                        // Verificar si existen equipos u órdenes relacionadas
                        bool puedeEliminar = await ValidarRelacionesCliente(idCliente);

                        if (puedeEliminar)
                        {
                            await _clienteService.DeleteClienteAsync(idCliente);
                            MessageBox.Show("Cliente eliminado exitosamente.", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadClientes(); // Recargar los datos
                        }
                        else
                        {
                            MessageBox.Show("No se puede eliminar el cliente porque tiene órdenes o equipos relacionados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private async Task<bool> ValidarRelacionesCliente(int clienteId)
        {
            var equiposAsociados = await _equipoService.GetEquiposByClienteIdAsync(clienteId);
            var ordenesAsociadas = await _ordenService.GetOrdenesByClienteIdAsync(clienteId);

            return equiposAsociados.Any() || ordenesAsociadas.Any();
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            {
                // Dibujar el fondo de la celda en rojo
                e.Graphics.FillRectangle(Brushes.Red, e.CellBounds);

                // Dibujar el texto centrado
                TextRenderer.DrawText(
                    e.Graphics,
                    "Eliminar",
                    dataGridView1.Font,
                    e.CellBounds,
                    Color.White,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
                // Indicar que el evento está manejado
                e.Handled = true;
            }
        }

        public async Task RealizarLogin()
        {
            Tecnico login = await _tecnicoService.IniciarSesionAsync("laura.fernandez@gmail.com", "password123");
            if (login == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTecnicos_Click(object sender, EventArgs e)
        {

        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmOrdenes frmOrdenes = new FrmOrdenes(_equipoService, _tecnicoService, _clienteService, _ordenService);
            frmOrdenes.ShowDialog();
            this.Dispose();
        }
    }
}
