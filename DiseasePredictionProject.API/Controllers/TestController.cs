using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DiseasePredictionProject.Core.Models;
using DiseasePredictionProject.Core.Response;
using DiseasePredictionProject.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DiseasePredictionProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ITestService _testService;
        private readonly IService<Question> _service;
        private readonly IMapper _mapper;

        public TestController(ITestService testService,IService<Question> service, IMapper mapper)
        {
            _testService = testService;
            _mapper = mapper;
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> FindDisease([FromForm]int[] userArray)
        {
            Response<Disease> disease = await _testService.GetByIdAsync(userArray);
            if (disease.Success)
            {
                return Ok(disease.Extra);
            }
            else
            {
                return BadRequest(disease);
            }
        }
        [HttpGet("{id}")]
     
        public async Task<IActionResult> Question(int id)
        {
            var question = await _service.GetByIdAsync(id);
            return Ok(question);
        }
    }
}