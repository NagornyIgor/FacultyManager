using System;
using System.Collections.Generic;
using System.Text;

namespace FacultyManager.Applicatiion.Common
{
    public class Result
    {
        public bool Succeeded { get; protected set; }
        protected readonly List<Error> errorsList = new List<Error>();
        public IEnumerable<Error> Errors { get { return errorsList; } }

        public static Result Success()
        {
            var result = new Result
            {
                Succeeded = true
            };

            return result;
        }

        public static Result Failed(params Error[] errors)
        {
            var result = new Result
            {
                Succeeded = false
            };

            if (errors == null)
            {
                result.errorsList.AddRange(errors);
            }
            return result;
        }

        public override string ToString()
        {
            return Succeeded ? "Succeeded" : string.Join("; ", Errors);
        }
    }
}
