using FelixManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelixManagementApp.Services
{
    public interface IEquipoService
    {
        Task<Equipo> GetEquipoByIdAsync(int id);
        Task<IEnumerable<Equipo>> GetAllEquiposAsync();
        Task CreateEquipoAsync(Equipo equipo);
        Task UpdateEquipoAsync(Equipo equipo);
        Task DeleteEquipoAsync(int id);
        Task<IEnumerable<Equipo>> GetEquiposByClienteIdAsync(int clienteId);
        Task<IEnumerable<Equipo>> GetEquiposByOrdenIdAsync(int ordenId);

        Task<IEnumerable<Equipo>> GetEquiposByTecnicoIdAsync(int tecnicoId);
    }
}
