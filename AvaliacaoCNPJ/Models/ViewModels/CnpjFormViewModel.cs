using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliacaoCNPJ.Models.ViewModels
{
    public class CnpjFormViewModel
    {
        public ApiObjeto Empresa { get; set; }
        public ICollection<Atividade_principal> Atividade_principal { get; set; }
        public ICollection<Atividades_secundarias> Atividade_secundaria { get; set; }
        public ICollection<Qsa> Socio_adm { get; set; }
    }
}
