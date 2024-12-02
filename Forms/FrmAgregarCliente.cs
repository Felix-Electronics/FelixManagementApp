using FelixManagementApp.Models;
using FelixManagementApp.Services;

namespace FelixManagementApp.Forms
{
    public partial class FrmAgregarCliente : Form
    {

        private readonly IClienteService _clienteService;
        public Cliente? ClienteCreado { get; private set; }

        public FrmAgregarCliente(IClienteService clienteService, Cliente? clienteExistente = null)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _clienteService = clienteService;

            if (clienteExistente != null)
            {
                CargarDatosCliente(clienteExistente);
                Text = "Actualizar Cliente"; // Cambia el título
                lblTitulo.Text = "Actualizar Cliente"; // Cambia el título
            }
            else
            {
                Text = "Agregar Cliente"; // Título para agregar
                lblTitulo.Text = "Nuevo Cliente"; // Título para agregar
            }
        }
        private void CargarDatosCliente(Cliente cliente)
        {
            txtNombre.Text = cliente.nombre;
            txtApellidoPaterno.Text = cliente.apellido_paterno;
            txtApellidoMaterno.Text = cliente.apellido_materno;
            txtCorreo.Text = cliente.correo;
            txtTelefono.Text = cliente.telefono;
            this.ClienteCreado = cliente;
            btnGuardar.Text = "Actualizar"; // Cambia el texto del botón
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellidoPaterno.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Por favor completa los campos requeridos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!IsValidEmail(txtCorreo.Text))
            {
                MessageBox.Show("Por favor ingresa un correo válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            var cliente = new Cliente
            {
                nombre = txtNombre.Text,
                apellido_paterno = txtApellidoPaterno.Text,
                apellido_materno = txtApellidoMaterno.Text,
                correo = txtCorreo.Text,
                telefono = txtTelefono.Text
            };

            if (ClienteCreado != null)
            {
                cliente.id_cliente = ClienteCreado.id_cliente;
                await _clienteService.UpdateClienteAsync(cliente);
                MessageBox.Show("Cliente actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                await _clienteService.CreateClienteAsync(cliente);
                MessageBox.Show("Cliente creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
