using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicam.Paradigmi.Application.Models.Requests;
using FluentValidation;

namespace Unicam.Paradigmi.Application.Validators
{
    public class AddCategoriaRequestValidator : AbstractValidator<AddCategoriaRequest>
    {
        public AddCategoriaRequestValidator()
        {
            RuleFor(x => x.nome)
                 .NotEmpty()
                 .WithMessage("Il campo nome è obbligatorio");
        }
    }
}
