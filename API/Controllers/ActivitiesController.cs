using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System.Diagnostics;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        private readonly DataContext _context;

        public ActivitiesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]  //api/activities
        public async Task<ActionResult<List<Domain.Activity>>> GetActivities()
        {
            return await _context.Activities.ToListAsync();
        }

        [HttpGet("{Id}")] //api/activities/fghfgh
        public async Task<ActionResult<Domain.Activity>> GetActivity(Guid Id)
        {
            return await _context.Activities.FindAsync(Id);
        }
            


    }
}
