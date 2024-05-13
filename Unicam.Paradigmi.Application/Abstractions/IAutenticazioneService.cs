using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicam.Paradigmi.Application.Abstractions
{
    public interface IAutenticazioneService
    {
        public bool Login(string mail, string password);
        public bool Register(string nome, string cognome, string password, string mail);
    }
}
