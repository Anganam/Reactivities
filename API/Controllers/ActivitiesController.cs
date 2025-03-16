<<<<<<< HEAD
using System;
=======
>>>>>>> 6ce334a6797b4f2ef72097465f399b338f7f0e59
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

<<<<<<< HEAD
namespace API.Controllers;

public class ActivitiesController(AppDbContext context) : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<List<Activity>>> GetActivities()
    {
        return await context.Activities.ToListAsync();
    }

    [HttpGet("{id}")]

    public async Task<ActionResult<Activity>> GetActivityDetail(string id)
    {
        var activity = await context.Activities.FindAsync(id);

        if (activity == null) return NotFound();

        return activity;
    }



}
=======
namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        private readonly DataContext _context;

        public ActivitiesController(DataContext context)
        {
            _context = context;

        }

        [HttpGet] //api/activities
        public async Task<ActionResult<List<Activity>>> GetActivity(){
            return await _context.Activities.ToListAsync();
        }

        [HttpGet("{id}")] //api/activities/dfghjklsdfsdf-from-Guid
        public async Task<ActionResult<Activity>> GetActivity(Guid id){
            return await _context.Activities.FindAsync(id);
        }
    }
}
>>>>>>> 6ce334a6797b4f2ef72097465f399b338f7f0e59
