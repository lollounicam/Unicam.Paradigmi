using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicam.Paradigmi.Application.Abstractions;
using Unicam.Paradigmi.Models.Entities;
using Unicam.Paradigmi.Models.Repositories;

namespace Unicam.Paradigmi.Application.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly CategoriaRepository _categoriaRepository;
        public CategoriaService(CategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }
        public bool AddCategoria(string nome)
        {
            Categoria categoria = new Categoria();
            categoria.nome = nome;
            if (_categoriaRepository.GetByNome(nome) != null)
            {
                return false;
            }
            _categoriaRepository.Add(categoria);
            _categoriaRepository.Save();
            return true;
        }

        public bool RemoveCategoria(string nome)
        {
            Categoria categoria = _categoriaRepository.GetByNome(nome);
            if (categoria != null && !categoria.libri.Any())
            {
                _categoriaRepository.Delete(categoria);
                _categoriaRepository.Save();
                return true;
            }
            return false;
        }
    }
}
