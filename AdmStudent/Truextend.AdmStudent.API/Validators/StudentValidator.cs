//-----------------------------------------------------------------------
// <copyright file="StudentValidator.cs" company="Truextend">
//     Copyright (c) Truextend. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Truextend.AdmStudent.API.Validators
{
    using FluentValidation;
    using Truextend.AdmStudent.Domain;
    using Truextend.AdmStudent.Commons.Extensions;

    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(request => request.Name).NotNull().NotEmpty().WithMessage("You must specify a student name.");
            RuleFor(request => request.Type).Must(x => x.IsDefinedInEnum(typeof(Domain.Enums.TypeStudent))).WithMessage("You must specify a valid student type.");
            RuleFor(request => request.Gender).Must(x => x.IsDefinedInEnum(typeof(Domain.Enums.Gender))).WithMessage("You must specify a valid gender.");
            RuleFor(request => request.LastUpdate).NotNull().NotEmpty().WithMessage("You must specify a date.");
        }
    }
}
