using FelixManagementApp.Models;
using FelixManagementApp.Services;
using Microsoft.Data.SqlClient;

namespace FelixManagementApp.Forms
{
    public partial class FrmAgregarCliente : Form
    {
        private readonly IOrdenService _ordenService;
        private readonly IClienteService _clienteService;
        private readonly IEquipoService _equipoService;
        private readonly ITecnicoService _tecnicoService;
        private List<Equipo> equiposTemp = new();
        private Cliente? clienteSeleccionado;

        public FrmAgregarCliente(
            IOrdenService ordenService,
            IClienteService clienteService,
            IEquipoService equipoService,
            ITecnicoService tecnicoService)
        {
            InitializeComponent();
            _ordenService = ordenService;
            _clienteService = clienteService;
            _equipoService = equipoService;
            _tecnicoService = tecnicoService;
            SetupForm();
        }

        private void SetupForm()
        {
            // Panel Cliente
            var pnlCliente = new Panel
            {
                Dock = DockStyle.Top,
                Height = 150,
                Padding = new Padding(10)
            };

            var lblBuscarCliente = new Label { Text = "Buscar Cliente:", AutoSize = true };
            var txtBuscarCliente = new TextBox { Width = 200 };
            var btnBuscarCliente = new Button { Text = "Buscar", Width = 100 };
            var btnNuevoCliente = new Button { Text = "Nuevo Cliente", Width = 120 };

            lblClienteSeleccionado = new Label
            {
                AutoSize = true,
                Font = new Font(this.Font, FontStyle.Bold)
            };

            pnlCliente.Controls.AddRange(new Control[]
            {
            lblBuscarCliente, txtBuscarCliente,
            btnBuscarCliente, btnNuevoCliente,
            lblClienteSeleccionado
            });

            // Panel Equipos
            var pnlEquipos = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(10)
            };

            var lblEquipos = new Label { Text = "Equipos:", Dock = DockStyle.Top };
            dgvEquipos = new DataGridView
            {
                Dock = DockStyle.Fill,
                AllowUserToAddRows = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };

            var btnAgregarEquipo = new Button
            {
                Text = "Agregar Equipo",
                Dock = DockStyle.Bottom,
                Height = 40
            };

            pnlEquipos.Controls.AddRange(new Control[]
            {
            lblEquipos, dgvEquipos, btnAgregarEquipo
            });

            // Panel Botones
            var pnlBotones = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 60,
                Padding = new Padding(10)
            };

            var btnGuardar = new Button
            {
                Text = "Guardar Orden",
                Width = 150,
                Height = 40
            };
            var btnCancelar = new Button
            {
                Text = "Cancelar",
                Width = 150,
                Height = 40
            };

            pnlBotones.Controls.AddRange(new Control[] { btnGuardar, btnCancelar });

            // Agregar paneles al formulario
            this.Controls.AddRange(new Control[] { pnlCliente, pnlEquipos, pnlBotones });

            // Eventos
            btnBuscarCliente.Click += async (s, e) => await BuscarCliente(txtBuscarCliente.Text);
            btnNuevoCliente.Click += (s, e) => AbrirFormularioNuevoCliente();
            btnAgregarEquipo.Click += (s, e) => AbrirFormularioEquipo();
            btnGuardar.Click += async (s, e) => await GuardarOrden();
            btnCancelar.Click += (s, e) => this.Close();

            ActualizarGridEquipos();
        }

        private async Task BuscarCliente(string criterio)
        {
            try
            {
                // Convertir el criterio a int si es posible, o usar un método de búsqueda alternativo
                if (int.TryParse(criterio, out int clienteId))
                {
                    var cliente = await _clienteService.GetClienteByIdAsync(clienteId);
                    if (cliente != null)
                    {
                        clienteSeleccionado = cliente;
                        ActualizarLabelCliente();
                    }
                    else
                    {
                        MessageBox.Show("Cliente no encontrado", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor ingrese un ID válido", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar clientes: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AbrirFormularioNuevoCliente()
        {
            using var clienteForm = new FrmCliente(_clienteService);
            if (clienteForm.ShowDialog() == DialogResult.OK)
            {
                clienteSeleccionado = clienteForm.ClienteCreado;
                ActualizarLabelCliente();
            }
        }

        private void AbrirFormularioEquipo()
        {
            if (clienteSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un cliente primero", "Aviso",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var equipoForm = new FrmEquipo(_equipoService, _tecnicoService);
            if (equipoForm.ShowDialog() == DialogResult.OK)
            {
                equiposTemp.Add(equipoForm.EquipoCreado);
                ActualizarGridEquipos();
            }
        }

        private async Task GuardarOrden()
        {
            if (clienteSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un cliente", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!equiposTemp.Any())
            {
                MessageBox.Show("Debe agregar al menos un equipo", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                await _ordenService.CrearOrdenConEquiposAsync(
                    clienteSeleccionado.id_cliente,
                    equiposTemp);

                MessageBox.Show("Orden creada exitosamente", "Éxito",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la orden: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarLabelCliente()
        {
            lblClienteSeleccionado.Text = clienteSeleccionado == null
                ? "No hay cliente seleccionado"
                : $"Cliente: {clienteSeleccionado.nombre} {clienteSeleccionado.apellido_paterno}";
        }

        private void ActualizarGridEquipos()
        {
            dgvEquipos.DataSource = null;
            dgvEquipos.DataSource = equiposTemp.Select(e => new
            {
                Marca = e.marca,
                Modelo = e.modelo,
                Problema = e.problema,
                Estatus = e.estatus
            }).ToList();
        }

        private Label lblClienteSeleccionado;
        private DataGridView dgvEquipos;
    }
}
