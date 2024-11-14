using FelixManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelixManagementApp.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Cliente> ClienteRepository { get; }
        IRepository<Tecnico> TecnicoRepository { get; }
        IRepository<Orden> OrdenRepository { get; }
        IRepository<Equipo> EquipoRepository { get; }
        Task<int> SaveChangesAsync();
    }
}
