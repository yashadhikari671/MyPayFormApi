using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyPayFormApi.Data;
using MyPayFormApi.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MyPayFormApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApplicantesController : Controller
    {
        private readonly AppDbcontext _context;

        


        public ApplicantesController(AppDbcontext context)
        {
            _context = context;
            
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<Form> applicants;

            applicants = _context.Applicants.ToList();


            return Ok(applicants);
        }
        [HttpGet("{OrderId}")]
        public async Task<ActionResult<Form>> GetById(string OrderId)
        {
            var people = await _context.Applicants.Where(n => n.OrderId == OrderId).SingleOrDefaultAsync();

            if (people == null)
            {
                return NotFound();
            }

            return people;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] FormDto formDto)
        {
            var unique = (DateTime.Now.Ticks).ToString();
            var data = new Form
            {
                OrderId = unique,
                FullName = formDto.FullName,
                Email = formDto.Email,
                Phone = formDto.Phone,
                Address = formDto.Address,
                City = formDto.City,
                Province = formDto.Province,
                Performance_Solo_Group = formDto.Performance_Solo_Group,
                GroupName = formDto.GroupName,
                Members = formDto.Members,
                AgeRange = formDto.AgeRange,
                GroupType = formDto.GroupType,
                ParticipantName = formDto.ParticipantName,
                Gender = formDto.Gender,
                Age = formDto.Age,
                PaymentStatus = "Pending"
            };

            await _context.Applicants.AddAsync(data);
            _context.SaveChanges();
            return Ok(unique);


        }
        [HttpPut("{OrderId}")]
        public async Task<IActionResult> Edit(string OrderId, string TransactionId , string PaymentStatus)
        {
            var people = await _context.Applicants.Where(n => n.OrderId == OrderId).SingleOrDefaultAsync();
            if(people != null)
            {
                people.TransactionId = TransactionId;
                people.PaymentStatus = PaymentStatus;
                _context.SaveChanges();
                return Ok("Updated");

            }

            return BadRequest("something went wrong");



        }
    }       
}
