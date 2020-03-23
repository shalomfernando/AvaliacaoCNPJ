using AvaliacaoCNPJ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliacaoCNPJ.Services
{
    public class CnpjService
    {
       
        public bool isCnpj(string cnpj)
        {
            if (cnpj.Length != 14)
                return false;
            return true;

        }

        public Empresa ConvertObjJson(string jsData)
        {
            Empresa empresa = new Empresa();
            // contrução do metodo
            return empresa;
        }
    }
}
