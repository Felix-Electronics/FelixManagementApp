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
    public partial class FrmEquipo : Form
    {
        private readonly IEquipoService _equipoService;
        private readonly ITecnicoService _tecnicoService;
        public Equipo EquipoCreado { get; private set; }

        public FrmEquipo(IEquipoService equipoService, ITecnicoService tecnicoService)
        {
            InitializeComponent();
            _equipoService = equipoService;
            _tecnicoService = tecnicoService;
        }
    }
}
