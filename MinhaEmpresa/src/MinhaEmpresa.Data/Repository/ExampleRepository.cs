using System;
using System.Collections.Generic;
using System.Text;
using MinhaEmpresa.Business.Interfaces;
using MinhaEmpresa.Business.Models;
using MinhaEmpresa.Data.Context;

namespace MinhaEmpresa.Data.Repository
{
    public class ExampleRepository : Repository<Example>, IExampleRepository
    {
        public ExampleRepository(AppDbContext myDbContext) : base(myDbContext)
        {

        }
    }
}
