using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicam.Paradigmi.Application.Models.Requests
{
    public class AddCategoriaRequest
    {
        public string nome { get; set; }
        public AddCategoriaRequest(string nome)
        {
            this.nome = nome;
        }
    }
}
