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
        public Cliente? ClienteCreado { get; private set; }

        public FrmCliente(IClienteService clienteService)
        {
            InitializeComponent();
            _clienteService = clienteService;
        }

    }
}
