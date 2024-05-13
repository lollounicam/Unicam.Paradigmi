using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicam.Paradigmi.Application.Models.Requests
{
    public class DeleteLibroRequest
    {
        public int id { get; set; }
        public DeleteLibroRequest(int id)
        {
            this.id = id;
        }
    }
}
