using FelixManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelixManagementApp.Services
{
    public class OrdenService : IOrdenService
    {
        private readonly FelixManagementAppContext _context;

        public OrdenService(FelixManagementAppContext context)
        {
            _context = context;
        }
        public Task CrearOrdenConEquiposAsync(int clienteId, List<Equipo> equipos)
        {
            try 
        }
    }
}
