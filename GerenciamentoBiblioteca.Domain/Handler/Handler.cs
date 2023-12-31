﻿using FluentValidation.Results;

namespace LibraryManagement.Domain.Handler
{
    public static class Handler
    {
        public static void Handle(ValidationResult validationResult)
        {
            if (!validationResult.IsValid)
                throw new Exception(validationResult.ToString());
        }
    }
}
