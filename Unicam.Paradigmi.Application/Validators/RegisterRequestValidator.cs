﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicam.Paradigmi.Application.Models.Requests;

namespace Unicam.Paradigmi.Application.Validators
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("Il campo email è obbligatorio")
                .NotNull()
                .WithMessage("Il campo email non può essere nullo");
            RuleFor(x => x.Password)
                .NotNull() 
                .WithMessage("Il campo password non può essere nullo")
                .MinimumLength(3)
                .WithMessage("Il campo password deve essere almeno lungo 3 caratteri");
            RuleFor(x => x.Nome)
                .NotEmpty()
                .WithMessage("Il campo nome è obbligatorio");
            RuleFor(x => x.Cognome)
                .NotEmpty()
                .WithMessage("Il campo cognome è obbligatorio");
        }
    }
}