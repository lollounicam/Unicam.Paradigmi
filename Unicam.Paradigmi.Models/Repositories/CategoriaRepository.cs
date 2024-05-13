using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicam.Paradigmi.Models.Context;
using Unicam.Paradigmi.Models.Entities;

namespace Unicam.Paradigmi.Models.Repositories
{
    public class CategoriaRepository : GenericRepository<Categoria>
    {
        public CategoriaRepository(MyDbContext context) : base(context)
        {

        }

        public Categoria GetByNome(string nome)
        {
            return _ctx.Set<Categoria>().Include(c => c.libri)
                .Where(x => x.nome.Equals(nome)).FirstOrDefault();
        }
    }
}
