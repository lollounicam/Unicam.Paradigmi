using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicam.Paradigmi.Application.Models.Requests;

namespace Unicam.Paradigmi.Application.Validators
{
    public class DeleteLibroRequestValidator : AbstractValidator<DeleteLibroRequest>
    {
        public DeleteLibroRequestValidator()
        {
            RuleFor(x => x.id)
                .NotEmpty()
                .WithMessage("Il campo id è obbligatorio")
                .GreaterThan(0);
        }
    }
}
