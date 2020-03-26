using AvaliacaoCNPJ.Data;
using AvaliacaoCNPJ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliacaoCNPJ.Services
{
    public class CnpjService
    {
        private readonly CnpjWebMvcContext _context;

        public CnpjService(CnpjWebMvcContext context)
        {
            _context = context;
        }

        public List<ApiObjeto> FindAll()
        {
            return _context.ApiObjeto.ToList();
        }
        public void Insert(ApiObjeto obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
