using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace wf_ValidationResult
{
    public class Imprimir : ValidationRule
    {
        public string TipoPapel { get; set; }
        public byte[] Documento { get; set; }
        public string Assinatura { get; set; }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (value == null)
            {
                return new ValidationResult(false, "O valor não pode ser nulo");
            }
            else if (!(value is Imprimir))
            {
                return new ValidationResult(false, "O valor não é do tipo imprimir");
            }
            else if (((Imprimir)value).Documento == null)
            {
                return new ValidationResult(false, "Nenhum documento atribuido na impressão");
            }
            else if (string.IsNullOrEmpty(((Imprimir)value).TipoPapel))
            {
                return new ValidationResult(false, "Não foi definido o tipo de papel na impressão");
            }

            return ValidationResult.ValidResult;
        }
    }
}
