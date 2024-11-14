using FelixManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelixManagementApp.Services
{
    public interface ITecnicoService
    {
        Task<Tecnico> GetTecnicoByIdAsync(int id);
        Task<IEnumerable<Tecnico>> GetAllTecnicosAsync();
    }
}
