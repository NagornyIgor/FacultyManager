using System;
using System.Collections.Generic;
using System.Text;

namespace FacultyManager.Applicatiion.Common
{
    class ErrorDescriber
    {
        public Error DefaultError()
        {
            return new Error
            {
                Code = nameof(DefaultError),
                Description = $"An unexpected error occurred."
            };
        }
        public Error RequestError(string code, string message)
        {
            return new Error
            {
                Code = nameof(RequestError),
                Description = $"{code}, {message}"
            };
        }
    }
}

