using FluentValidation;
using RentARG.Domain.Commands.Commands;
using RentARG.Resources.Labels;
using System;

namespace RentARG.Domain.Validations
{
    public abstract class ProductoValidation<T> : AbstractValidator<T> where T : ProductoCommand
    {
        protected void ValidarNombre()
        {
            RuleFor(c => c.Nombre)
                .NotEmpty().WithMessage("Por favor asegurese de tener el nombre ingresado")
                .Length(1, 150).WithMessage(MessageValidation.CampoNombreEntre1y150Caracteres);
        }

        protected void ValidarDescripcion()
        {
            RuleFor(c => c.Descripcion)
                .NotEmpty().WithMessage("Por favor asegurese de tener una descripción ingresada")
                .Length(1, 2000).WithMessage(MessageValidation.CampoDescripcionEntre1y2000Caracteres);
        }

        protected void ValidateId()
        {
            RuleFor(c => c.Id)
                .NotEqual(Guid.Empty);
        }
    }
}
