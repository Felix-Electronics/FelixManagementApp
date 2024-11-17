using FelixManagementApp.Models;
using FelixManagementApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelixManagementApp.Services
{
    public class EquipoService : IEquipoService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EquipoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CreateEquipoAsync(Equipo equipo)
        {
            try
            {
                await _unitOfWork.EquipoRepository.AddAsync(equipo);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear el equipo", ex);
            }
        }

        public async Task DeleteEquipoAsync(int id)
        {
            try
            {
                var equipo = await _unitOfWork.EquipoRepository.GetByIdAsync(id);
                await _unitOfWork.EquipoRepository.DeleteAsync(equipo.id_equipo);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el equipo", ex);
            }
        }

        public async Task<IEnumerable<Equipo>> GetAllEquiposAsync()
        {
            try
            {
                return await _unitOfWork.EquipoRepository.GetAllAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los equipos", ex);
            }
        }

        public async Task<Equipo> GetEquipoByIdAsync(int id)
        {
            try
            {
                return await _unitOfWork.EquipoRepository.GetByIdAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el equipo", ex);
            }
        }

        public async Task UpdateEquipoAsync(Equipo equipo)
        {
            try
            {
                await _unitOfWork.EquipoRepository.UpdateAsync(equipo);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el equipo", ex);
            }
        }

        public async Task<IEnumerable<Equipo>> GetEquiposByClienteIdAsync(int clienteId)
        {
            try
            {
                var equipos = await _unitOfWork.EquipoRepository.GetAllAsync();
                return equipos.Where(e => e.id_cliente == clienteId);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los equipos", ex);
            }
        }

        public async Task<IEnumerable<Equipo>> GetEquiposByOrdenIdAsync(int ordenId)
        {
            try
            {
                //await
                var equipos = await _unitOfWork.EquipoRepository.GetAllAsync();
                return equipos.Where(e => e.id_orden == ordenId);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los equipos", ex);
            }
        }

        public async Task<IEnumerable<Equipo>> GetEquiposByTecnicoIdAsync(int tecnicoId)
        {
            try
            {
                var equipos = await _unitOfWork.EquipoRepository.GetAllAsync();
                return equipos.Where(e => e.id_tecnico == tecnicoId);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los equipos", ex);
            }
        }
    }
}
