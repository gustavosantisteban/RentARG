using RentARG.Aplicacion.ViewModels;
using System;
using System.Collections.Generic;

namespace RentARG.Aplicacion.Services
{
    public interface IApiService : IDisposable
    {
        IEnumerable<ViewModel> GetAll();
        ViewModel GetById(Guid id);
    }
}
