using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicam.Paradigmi.Application.Models.Requests
{
    public class DeleteCategoriaRequest
    {
        public string nome { get; set; }
        public DeleteCategoriaRequest(string nome)
        {
            this.nome = nome;
        }
    }
}
