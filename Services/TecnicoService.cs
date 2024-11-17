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
    }
}
