using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using AvaliacaoCNPJ.Models;
using AvaliacaoCNPJ.Models.ViewModels;
using AvaliacaoCNPJ.Services;
using Microsoft.AspNetCore.Mvc;

namespace AvaliacaoCNPJ.Controllers
{
    public class CnpjController : Controller
    {
        static HttpClient client = new HttpClient();
        private ApiObjeto obSave;
        private readonly CnpjService _cnpjService;

        public CnpjController(CnpjService cnpjService)
        {
            _cnpjService = cnpjService;
        }

        public IActionResult Index()
        {
            var list = _cnpjService.FindAll();
            return View(list);
        }
        public IActionResult Cnpj()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Cnpj(string txtCep)
        {
            if (txtCep == null)
            {
                TempData["erro"] = "Digite um numero valido";
                return RedirectToAction(nameof(Index));
            }
            txtCep = txtCep.Replace(".", "").Replace("-", "").Replace("/", "").Replace(" ", "");
            string apiUrl = "https://www.receitaws.com.br/v1/cnpj/" + txtCep;
            var ApiObjeto = new ApiObjeto();


            using (HttpClient client = new HttpClient())
            {
                var response = client.GetAsync(apiUrl).Result;
                var resposta = response.Content.ReadAsStringAsync().Result;
                ApiObjeto = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiObjeto>(resposta);
            }


            if (ApiObjeto.Message != null)
            {
                TempData["erro"] = ApiObjeto.Message;
                return RedirectToAction(nameof(Index));
            }
            else
            {
                //ViewData.Add("ApiObjeto", ApiObjeto);
                ViewBag.ApiObjeto = ApiObjeto;
                var viewModel = new CnpjFormViewModel
                {
                    Empresa = ApiObjeto,
                    Atividade_principal = ApiObjeto.Atividade_principal,
                    Atividade_secundaria = ApiObjeto.atividades_secundarias,
                    Socio_adm = ApiObjeto.Qsa,
                };
                return View(viewModel);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(CnpjFormViewModel modelo)
        {

            ApiObjeto apiObjeto = modelo.Empresa;
            obSave = apiObjeto;
            _cnpjService.Insert(obSave);
            return RedirectToAction(nameof(Index));
        }

    }
}