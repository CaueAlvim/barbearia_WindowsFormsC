using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace projeto_barbearia.Models.Utils.ExtensionsMethods
{
    public static partial class ExtensionMethods
    {


        /// <summary>
        /// Obtem apenas os numeros de uma string 
        /// </summary>
        /// <param name="Valor"></param>
        /// <returns>apenas numeros</returns>
        public static string MTD_ApenasNumeros(this string Valor)
        {
            return new string(Valor.Where(letra => char.IsNumber(letra)).ToArray());
        }

        public static string MTD_FormatarTelefone(this string value)
        {
            //TODO: ExtensionsMethods >> Implementar formatação do telefone
            return value;
        }
    }
}
