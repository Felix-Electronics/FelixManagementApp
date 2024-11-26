using FelixManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelixManagementApp.Services
{
    public interface IOrdenService
    {
        Task CrearOrdenConEquiposAsync(int clienteId, decimal total);

        //GetOrdenByIdAsync
        Task<Orden> GetOrdenByIdAsync(int id);

        //GetAllOrdenesAsync
        Task<IEnumerable<Orden>> GetAllOrdenesAsync();

        //UpdateOrdenAsync
        Task UpdateOrdenAsync(Orden orden);

        //DeleteOrdenAsync
        Task DeleteOrdenAsync(int id);

        //GetOrdenesByClienteIdAsync
        Task<IEnumerable<Orden>> GetOrdenesByClienteIdAsync(int clienteId);


    }
}
