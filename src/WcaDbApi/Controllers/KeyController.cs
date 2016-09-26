using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WcaDbApi.Models;
using WcaDbApi.Repositories.Interfaces;
using WcaDbApi.ViewModels;

namespace WcaDbApi.Controllers
{
    public class KeyController : Controller
    {
        private readonly IKeyRepository _context;
        public KeyController(IKeyRepository context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(new KeyVM());
        }

        [HttpPost]
        public IActionResult Index(KeyVM keyVM)
        {
            if(ModelState.IsValid)
            {
                var apikey = new Key();
                apikey.BannedEmail = false;
                apikey.BannedKey = false;
                apikey.Email = keyVM.Email;
                apikey.ApiKey = Guid.NewGuid();
                _context.CreateKey(apikey);
                keyVM.ApiKey = apikey.ApiKey;
                return View("Created", keyVM);
            }
            return View(keyVM);
            
        }
    }
}
