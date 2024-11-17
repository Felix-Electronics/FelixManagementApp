using FelixManagementApp.Models;
using FelixManagementApp.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelixManagementApp.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ClienteService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Cliente> GetClienteByIdAsync(int id)
        {
            return await _unitOfWork.ClienteRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Cliente>> GetAllClientesAsync()
        {
            return await _unitOfWork.ClienteRepository.GetAllAsync();
        }

        public async Task CreateClienteAsync(Cliente cliente)
        {
            try
            {
                await _unitOfWork.ClienteRepository.AddAsync(cliente);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task UpdateClienteAsync(Cliente cliente)
        {
            try
            {
                var existingCliente = await _unitOfWork.ClienteRepository.GetByIdAsync(cliente.id_cliente);
                if (existingCliente != null)
                {
                    existingCliente.nombre = cliente.nombre;
                    existingCliente.apellido_paterno = cliente.apellido_paterno;
                    existingCliente.apellido_materno = cliente.apellido_materno;
                    existingCliente.correo = cliente.correo;
                    existingCliente.telefono = cliente.telefono;

                    await _unitOfWork.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el cliente", ex);
            }
        }

        public async Task DeleteClienteAsync(int id)
        {
            try
            {
                await _unitOfWork.ClienteRepository.DeleteAsync(id);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el cliente", ex);
            }
        }

    }
}
