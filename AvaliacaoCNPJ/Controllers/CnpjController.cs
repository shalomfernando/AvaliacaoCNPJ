using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using AvaliacaoCNPJ.Models;
using Microsoft.AspNetCore.Mvc;

namespace AvaliacaoCNPJ.Controllers
{
    public class CnpjController : Controller
    {
        static HttpClient client = new HttpClient();

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Cnpj()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Cnpj(CnpjTO cnpj)
        {
            string apiUrl = "https://www.receitaws.com.br/v1/cnpj/06323467000159";
            var ApiObjeto = new ApiObjeto();

            using(HttpClient client = new HttpClient())
            {
                var response = client.GetAsync(apiUrl).Result;
                var resposta = response.Content.ReadAsStringAsync().Result;
                ApiObjeto = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiObjeto>(resposta);
            }
          
            return View(ApiObjeto);
        }

    }
}