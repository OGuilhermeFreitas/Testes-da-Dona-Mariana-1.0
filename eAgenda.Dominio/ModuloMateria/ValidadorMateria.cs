using FluentValidation;
using System;

namespace Testes_da_Mariana.Dominio.ModuloMateria
{
    public class ValidadorMateria : AbstractValidator<Materia>
    {
        public ValidadorMateria()
        {
            RuleFor(x => x.Nome)
                .NotNull().NotEmpty();

            RuleFor(x => x.Disciplina)
                .NotNull().NotEmpty();
        }
    }
}
