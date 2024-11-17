using FelixManagementApp.Data;
using FelixManagementApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelixManagementApp.Repositories
{
    public class TecnicoRepository : Repository<Tecnico>, ITecnicoRepository
    {
        public TecnicoRepository(FelixElectronicsContext context) : base(context)
        {
        }

        public async Task<Tecnico> IniciarSesionAsync(string correo, string contrasenia)
        {
            return await _dbSet.FirstOrDefaultAsync(t => t.correo == correo && t.contrasenia == contrasenia);
        }

        public async Task<Tecnico> GetTecnicoByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<Tecnico>> GetAllTecnicosAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task CrearTecnicoAsync(Tecnico tecnico)
        {
            await _dbSet.AddAsync(tecnico);
        }

        public async Task UpdateTecnicoAsync(Tecnico tecnico)
        {
            _context.Entry(tecnico).State = EntityState.Modified;
            return;
        }

        public async Task DeleteTecnicoAsync(int id)
        {
            var tecnico = await GetTecnicoByIdAsync(id);
            if (tecnico != null)
                _dbSet.Remove(tecnico);
        }

        public async Task<IEnumerable<Tecnico>> GetTecnicosByNombreAsync(string nombre)
        {
            return await _dbSet.Where(t => t.nombre.Contains(nombre)).ToListAsync();
        }
    }
}
