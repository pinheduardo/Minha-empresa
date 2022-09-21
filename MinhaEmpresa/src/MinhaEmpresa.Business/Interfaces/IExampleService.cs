using System;
using System.Threading.Tasks;
using MinhaEmpresa.Business.Models;

namespace MinhaEmpresa.Business.Interfaces
{
    public interface IExampleService : IDisposable
    {
        Task<bool> Adicionar(Example exemple);
        Task<bool> Atualizar(Example exemple);
        Task<bool> Remover(Guid id);
    }
}
