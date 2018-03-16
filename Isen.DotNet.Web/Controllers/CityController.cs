using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Isen.DotNet.Web.Models;
using Isen.DotNet.Library.Repositories.Interfaces;
using Isen.DotNet.Library.Repositories.InMemory;
using Isen.DotNet.Library.Models.Implementation;
using Microsoft.Extensions.Logging;

namespace Isen.DotNet.Web.Controllers
{
    public class CityController : Controller
    {
        private ICityRepository _repository;
        private readonly ILogger<CityController> _logger;

        public CityController(ILogger<CityController> logger, ICityRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var model = _repository.GetAll();
            return View(model);
        }

        public IActionResult Detail(int? id)
        {
            // Pas d'id > form vide (création)
            if (id == null) return View();
            // Récupérer la ville et la passer à la vues
            var model = _repository.Single(id.Value);
            return View(model);
        }

        [HttpPost]
        public IActionResult Detail(City model)
        {
            _logger.LogWarning($"POST : {model}");
            _repository.Update(model);
            return RedirectToAction("Index");
        }
    }
}
