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
            return await _unitOfWork.TecnicoRepository.GetByIdAsync(id);
        }
        public async Task<IEnumerable<Tecnico>> GetAllTecnicosAsync()
        {
            return await _unitOfWork.TecnicoRepository.GetAllAsync();
        }
    }
}
