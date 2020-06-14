//-----------------------------------------------------------------------
// <copyright file="StringValidator.cs" company="Truextend">
//     Copyright (c) Truextend. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Truextend.AdmStudent.API.Validators
{
    using Nancy.Validation;
    using System;
    using System.Collections.Generic;

    public class StringValidator
    {
        public static ModelValidationResult ValidateString(string parameterName, string value)
        {
            var IsValid = !String.IsNullOrEmpty(value) && value.Length > 2 && value != "\"\"";
            if (!IsValid)
            {
                return new ModelValidationResult(new List<ModelValidationError>() { new ModelValidationError(parameterName, "You must specify a valid string") });
            }
            return new ModelValidationResult();
        }

        public static ModelValidationResult ValidateGuid(string parameterName, string value)
        {
            Guid guidResult;
            bool isValid = Guid.TryParse(value, out guidResult);
            if (!isValid)
            {
                return new ModelValidationResult(new List<ModelValidationError>() { new ModelValidationError(parameterName, "You must specify a valid Guid") });
            }
            return new ModelValidationResult();
        }
    }
}
