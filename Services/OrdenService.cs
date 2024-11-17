using FelixManagementApp.Data;
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
        private readonly FelixElectronicsContext _context;

        public OrdenService(FelixElectronicsContext context)
        {
            _context = context;
        }
        public Task CrearOrdenConEquiposAsync(int clienteId, List<Equipo> equipos)
        {
            try
            {
                var orden = new Orden
                {
                    id_cliente = clienteId,
                    fecha_creacion = DateTime.Now,
                };
                _context.Ordenes.Add(orden);
                _context.SaveChanges();
                return Task.CompletedTask;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear la orden", ex);
            }
        }

        public Task DeleteOrdenAsync(int id)
        {
            try
            {
                var orden = _context.Ordenes.Find(id);
                _context.Ordenes.Remove(orden);
                _context.SaveChanges();
                return Task.CompletedTask;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la orden", ex);
            }
        }

        public Task<IEnumerable<Orden>> GetAllOrdenesAsync()
        {
            try
            {
                return Task.FromResult(_context.Ordenes.AsEnumerable());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las ordenes", ex);
            }
        }

        public async Task<Orden> GetOrdenByIdAsync(int id)
        {
            try
            {
                return await _context.Ordenes.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la orden", ex);
            }
        }

        public Task<IEnumerable<Orden>> GetOrdenesByClienteIdAsync(int clienteId)
        {
            try
            {
                return Task.FromResult(_context.Ordenes.Where(o => o.id_cliente == clienteId).AsEnumerable());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las ordenes", ex);
            }
        }

        public Task UpdateOrdenAsync(Orden orden)
        {
            try
            {
                _context.Ordenes.Update(orden);
                _context.SaveChanges();
                return Task.CompletedTask;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la orden", ex);
            }
        }
    }
}
