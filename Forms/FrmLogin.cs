using System;
using System.Collections.Generic;
using System;
using System.Windows.Forms;
using FelixManagementApp.Services;
using FelixManagementApp.Models;

namespace FelixManagementApp.Forms
{
    public partial class FrmLogin : Form
    {
        private readonly IClienteService _clienteService;
        private readonly IEquipoService _equipoService;
        private readonly IOrdenService _ordenService;
        private readonly ITecnicoService _tecnicoService;
        public FrmLogin(IClienteService clienteService, IEquipoService equipoService, IOrdenService ordenService, ITecnicoService tecnicoService)
        {
            InitializeComponent();
            //Center form
            StartPosition = FormStartPosition.CenterScreen;
            _clienteService = clienteService;
            _equipoService = equipoService;
            _ordenService = ordenService;
            _tecnicoService = tecnicoService;
        }

        private async void BtnOk_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Ingresar un correo y una contraseña", "Error");
                return;
            }
            Tecnico login = await _tecnicoService.IniciarSesionAsync(txtUsername.Text, txtPassword.Text);
            if (login == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmCliente frmCliente = new FrmCliente(_clienteService, _equipoService, _ordenService, _tecnicoService);
                frmCliente.Show();
                this.Hide();
            }
        }
    }
}
