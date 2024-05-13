﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicam.Paradigmi.Models.Context;
using Unicam.Paradigmi.Models.Entities;

namespace Unicam.Paradigmi.Models.Repositories
{
    public class UtenteRepository : GenericRepository<Utente>
    {
        public UtenteRepository(MyDbContext context) : base(context)
        {
            
        }
        public Utente GetByEmail(string email)
        {
            return _ctx.Set<Utente>().Where(x => x.email.Equals(email)).FirstOrDefault();
        }
        public bool checkMailPassword(string email, string password)
        {
            return _ctx.Set<Utente>().Where(x => x.email.Equals(email) && x.password.Equals(password)).Any();
        }
    }
}
