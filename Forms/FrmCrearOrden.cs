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
        public FrmCrearOrden(IClienteService _clienteService, IEquipoService _equipoService, IOrdenService _ordenService, ITecnicoService _tecnicoService)
        {
            InitializeComponent();
            this._clienteService = _clienteService;
            this._equipoService = _equipoService;
            this._ordenService = _ordenService;
            this._tecnicoService = _tecnicoService;
        }
    }
}
