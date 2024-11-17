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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente
            {
                nombre = textBox1.Text,
                apellido_paterno = textBox2.Text,
                apellido_materno = textBox3.Text,
                correo = textBox4.Text,
                telefono = textBox4.Text
            };
            try
            {
                _clienteService.CreateClienteAsync(cliente);
                MessageBox.Show("Cliente creado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el cliente: " + ex.Message);
            }
        }
    }
}
