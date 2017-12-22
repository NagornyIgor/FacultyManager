using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace FacultyManager.Applicatiion.Common
{
    public static class UrlPropertyConverter
    {
        public static Dictionary<string, string> MappingToDictionary<T>(T model, BindingFlags bindingAttr = BindingFlags.Public | BindingFlags.Instance)
        {
            return model.GetType().GetProperties(bindingAttr).ToDictionary(
                propInfo => propInfo.Name,
                propValue => propValue.GetValue(model).ToString()
                );
        }
    }
}
