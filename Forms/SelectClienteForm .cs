using FelixManagementApp.Models;
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
    public partial class SelectClienteForm : Form
    {
        public Cliente? ClienteSeleccionado { get; private set; }

        public SelectClienteForm(List<Cliente> clientes)
        {
            InitializeComponent();
            // Configura un DataGridView o ListBox para mostrar los clientes
            // y permitir la selección
        }
    }
}
