using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using AvaliacaoCNPJ.Models;
using AvaliacaoCNPJ.Services;
using Microsoft.AspNetCore.Mvc;

namespace AvaliacaoCNPJ.Controllers
{
    public class CnpjController : Controller
    {
        static HttpClient client = new HttpClient();

        CnpjService cnpjService;

        public IActionResult Index()
        {
            return View();
        }
        public Empresa GetCnpj(string cnpj)
        {
            return cnpjService.ConvertObjJson(cnpj) ;
        }

        public IActionResult Cnpj(Empresa em)
        {
            return View(em);
        }

    }
}