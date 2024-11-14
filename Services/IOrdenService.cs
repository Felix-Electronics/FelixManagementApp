﻿using FelixManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelixManagementApp.Services
{
    public interface IOrdenService
    {
        Task CrearOrdenConEquiposAsync(int clienteId, List<Equipo> equipos);
    }
}
