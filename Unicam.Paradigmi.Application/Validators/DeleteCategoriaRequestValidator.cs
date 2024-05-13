using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicam.Paradigmi.Application.Models.Requests;

namespace Unicam.Paradigmi.Application.Validators
{
    public class DeleteCategoriaRequestValidator : AbstractValidator<DeleteCategoriaRequest>
    {
        public DeleteCategoriaRequestValidator()
        {
            RuleFor(x => x.nome)
                .NotEmpty()
                .WithMessage("Il campo nome è obbligatorio")
                .NotNull()
                .WithMessage("Il campo nome non può essere nullo");
        }
    }
}
