using FelixManagementApp.Data;
using FelixManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelixManagementApp.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FelixElectronicsContext _context;
        private IRepository<Cliente> _clienteRepository;
        private ITecnicoRepository _tecnicoRepository;
        private IRepository<Orden> _ordenRepository;
        private IRepository<Equipo> _equipoRepository;

        public UnitOfWork(FelixElectronicsContext context)
        {
            _context = context;
            this._tecnicoRepository = new TecnicoRepository(_context);

        }

        public ITecnicoRepository TecnicoRepository
        {
            get
            {
                return _tecnicoRepository;
            }
        }
        public IRepository<Cliente> ClienteRepository
        {
            get
            {
                return _clienteRepository ??= new Repository<Cliente>(_context);
            }
        }

        public IRepository<Orden> OrdenRepository
        {
            get
            {
                return _ordenRepository ??= new Repository<Orden>(_context);
            }
        }

        public IRepository<Equipo> EquipoRepository
        {
            get
            {
                return _equipoRepository ??= new Repository<Equipo>(_context);
            }
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
