﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MinhaEmpresa.Business.Interfaces;
using MinhaEmpresa.Business.Models;
using MinhaEmpresa.Business.Models.Validations;

namespace MinhaEmpresa.Business.Servicecs
{
    public class ExampleService : BaseService, IExampleService
    {
        private readonly IExampleRepository _exempleRepository;
        private readonly IUser _user;
        public ExampleService(IExampleRepository exempleRepository, INotificator notificator, IUser user) : base(notificator)
        {
            _exempleRepository = exempleRepository;
            _user = user;
        }
        public async Task<bool> Adicionar(Example exemple)
        {
            if (!ExecutarValidacao(new ExampleValidation(), exemple)) return false;
            
            await _exempleRepository.Adicionar(exemple);
            return true;
        }

        public async Task<bool> Atualizar(Example exemple)
        {
            if (!ExecutarValidacao(new ExampleValidation(), exemple)) return false;

            await _exempleRepository.Atualizar(exemple);
            return true;
        }

        public async Task<bool> Remover(Guid id)
        {            
            await _exempleRepository.Remover(id);
            return true;
        }

        public void Dispose()
        {
            _exempleRepository?.Dispose();
        }

    }
}
