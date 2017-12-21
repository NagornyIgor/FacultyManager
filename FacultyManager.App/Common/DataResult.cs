using System;
using System.Collections.Generic;
using System.Text;

namespace FacultyManager.Common
{
    public class DataResult<T> : Result
    {
        //"new" is used because the base class logic is not needed and it needs to be hidden.

        public T Data { get; protected set; }

        public new static DataResult<T> Success()
        {
            var result = new DataResult<T> { Succeeded = true };

            return result;
        }

        public static DataResult<T> Success(T data)
        {
            var result = new DataResult<T>
            {
                Succeeded = true,
                Data = data
            };

            return result;
        }

        public new static DataResult<T> Failed(params Error[] errors)
        {
            var result = new DataResult<T> { Succeeded = false };

            if (errors != null)
            {
                result.errorsList.AddRange(errors);
            }

            return result;
        }

        public static DataResult<T> Failed(T data, params Error[] errors)
        {
            var result = new DataResult<T>
            {
                Succeeded = false,
                Data = data
            };

            if (errors != null)
            {
                result.errorsList.AddRange(errors);
            }

            return result;
        }
    }
}
    