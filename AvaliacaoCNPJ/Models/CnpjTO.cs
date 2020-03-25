using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliacaoCNPJ.Models
{
    public class CnpjTO
    {
        public string Cnpj { get; set; }

        public CnpjTO(string cnpj)
        {
            Cnpj = cnpj;
        }

        public CnpjTO()
        {
        }
    }

}
