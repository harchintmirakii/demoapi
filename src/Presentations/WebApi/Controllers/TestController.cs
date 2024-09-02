using AutoMapper;
using Data.Mongo.Collections;
using Microsoft.AspNetCore.Mvc;
using Models.DTOs.Log;
using Models.ResponseModels;
using Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("get")]
        public string GetSampleString(string input)
        {
            string formattedText = $"You inputted {input}, and I think that's great";
            return formattedText;
        }
    }
}
