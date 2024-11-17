using FelixManagementApp.Models;
using FelixManagementApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelixManagementApp.Services
{
    public class TecnicoService : ITecnicoService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TecnicoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Tecnico> GetTecnicoByIdAsync(int id)
        {
            try
            {
                return await _unitOfWork.TecnicoRepository.GetByIdAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el técnico", ex);
            }
        }
        public async Task<IEnumerable<Tecnico>> GetAllTecnicosAsync()
        {
            try
            {
                return await _unitOfWork.TecnicoRepository.GetAllAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los técnicos", ex);
            }
        }

        public async Task CrearTecnicoAsync(Tecnico tecnico)
        {
            try
            {
                await _unitOfWork.TecnicoRepository.AddAsync(tecnico);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear el técnico", ex);
            }
        }

        public async Task<Tecnico> IniciarSesionAsync(string correo, string contrasenia)
        {
            try
            {
                return await _unitOfWork.TecnicoRepository.IniciarSesionAsync(correo, contrasenia);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al iniciar sesión", ex);
            }
        }

        public async Task UpdateTecnicoAsync(Tecnico tecnico)
        {
            try
            {
                var existingTecnico = await _unitOfWork.TecnicoRepository.GetByIdAsync(tecnico.id_tecnico);
                if (existingTecnico != null)
                {
                    existingTecnico.nombre = tecnico.nombre;
                    existingTecnico.apellido_paterno = tecnico.apellido_paterno;
                    existingTecnico.apellido_materno = tecnico.apellido_materno;
                    existingTecnico.correo = tecnico.correo;
                    existingTecnico.contrasenia = tecnico.contrasenia;
                    await _unitOfWork.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el técnico", ex);
            }
        }

        public async Task DeleteTecnicoAsync(int id)
        {
            try
            {
                await _unitOfWork.TecnicoRepository.DeleteAsync(id);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el técnico", ex);
            }
        }
    }
}
