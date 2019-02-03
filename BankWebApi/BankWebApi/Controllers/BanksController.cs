using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankWebApi.Repositories.Interfaces;
using BankWebApi.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BanksController : ControllerBase
    {
        private readonly IBankRepository _bankRepository;
        private readonly IBankService _bankService;

        public BanksController(IBankRepository bankRepository, IBankService bankService)
        {
            _bankRepository = bankRepository;
            _bankService = bankService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return new JsonResult(_bankRepository.Read());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return new JsonResult(_bankService.Read(id));
        }
    }
}