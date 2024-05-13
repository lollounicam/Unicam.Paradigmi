﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicam.Paradigmi.Models.Entities
{
    public class Utente
    {
        public int id { get; set; }
        public string nome { get; set; } = string.Empty;
        public string cognome { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;

        public Utente(string nome, string cognome, string email, string password)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.email = email;
            this.password = password;
        }
        public Utente()
        {
        }
    }
}
