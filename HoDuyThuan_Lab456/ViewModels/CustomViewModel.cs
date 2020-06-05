using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace HoDuyThuan_Lab456.ViewModels
{
    public class ValidTime : ValidationAttribute
    {
        DateTime dateTime;
        var isValid = DateTime.TryParseExact(Convert.ToString(value),
            "HH:mm",
            CultureInfo.CurrentCulture,
            DateTimeStyles.None,
            out dateTime);
        return private static object value;

        isValid;
    }
}