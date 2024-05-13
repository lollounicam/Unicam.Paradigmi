﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicam.Paradigmi.Application.Models.Requests;

namespace Unicam.Paradigmi.Application.Validators
{
    public class UpdateLibroRequestValidator : AbstractValidator<UpdateLibroRequest>
    {
        public UpdateLibroRequestValidator()
        {
            RuleFor(x => x.id)
                .NotEmpty()
                .WithMessage("Il campo id è obbligatorio")
                .GreaterThan(0)
                .WithMessage("Il campo id deve essere positivo");
            RuleFor(x => x.editore)
               .NotEmpty()
               .WithMessage("Il campo titolo è obbligatorio")
               .NotNull()
               .WithMessage("Il campo titolo non può essere nullo");
            RuleFor(x => x.nome)
               .NotEmpty()
               .WithMessage("Il campo nome è obbligatorio")
               .NotNull()
               .WithMessage("Il campo nome non può essere nullo");
            RuleFor(x => x.autore)
               .NotEmpty()
               .WithMessage("Il campo autore è obbligatorio")
               .NotNull()
               .WithMessage("Il campo autore non può essere nullo");
            RuleFor(x => x.dataPubblicazione)
               .NotEmpty()
               .WithMessage("Il campo data è obbligatorio")
               .NotNull()
               .WithMessage("Il campo data non può essere nullo");
        }
    }
}