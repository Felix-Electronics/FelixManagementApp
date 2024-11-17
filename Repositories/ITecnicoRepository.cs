using FelixManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelixManagementApp.Repositories
{
    public interface ITecnicoRepository : IRepository<Tecnico>
    {
        Task<Tecnico> IniciarSesionAsync(string correo, string contrasenia);
    }
}
