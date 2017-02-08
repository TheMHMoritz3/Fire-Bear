using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WindowsClient.Manager.Validationrules
{
    class NotEmptyValidation : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            //ValidationResult result = string.IsNullOrWhiteSpace((value ?? "").ToString()) ? new ValidationResult(false, "Dieses Feld wird benötigt.") : ValidationResult.ValidResult;
            //Console.WriteLine(value.GetType());
            //return result;
            return ValidationResult.ValidResult;
        }
    }
}
