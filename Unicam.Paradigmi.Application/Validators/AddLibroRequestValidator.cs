using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicam.Paradigmi.Application.Models.Requests;

namespace Unicam.Paradigmi.Application.Validators
{
    public class AddLibroRequestValidator : AbstractValidator<AddLibroRequest>
    {
        public AddLibroRequestValidator()
        {
            RuleFor(x => x.editore)
                .NotEmpty()
                .WithMessage("Il campo editore è obbligatorio")
                .NotNull()
                .WithMessage("Il campo editore non può essere nullo");
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