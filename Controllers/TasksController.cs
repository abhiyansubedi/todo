
using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc;
using todo.Models;
using todo.Services.TasksService;
 
namespace todo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class TasksController :ControllerBase
    {
        //injecting a TasksService

        private readonly ITasksService _tasksService;
        public TasksController(ITasksService tasksService)
        {
            _tasksService =  tasksService;
        }
        
          
        

        //Reading all the tasks
        [HttpGet]
        public async Task<ActionResult<List<Tasks>>>GetAllTasks()
        {
             return await _tasksService.GetAllTasks();

        }


        //Reading a single task
        [HttpGet("{Id}")]
        public async Task<ActionResult<Tasks>>GetSingleTask(int Id)
        {
            var result = await _tasksService.GetSingleTask(Id);
            if (result is null)
             return NotFound("Tasks not found");

            return Ok(result);

        }

        //Creating a task 
       [HttpPost]
       public async Task<ActionResult<List<Tasks>>> AddTask(Tasks t)
       {
        
        var result = await _tasksService.AddTask(t);
        return Ok(result);
        }
       
    

   
        

        //Updating a task
         [HttpPut("{Id}")]
        public async Task<ActionResult<List<Tasks>>>Updatetask(int Id, Tasks request)
        {
            var result = await _tasksService.UpdateTask(Id,request);
            if (result is null)
             return NotFound("Tasks not found");

            return Ok(result);

        }

        //Deleting a task 
         [HttpDelete("{Id}")]
        public async Task<ActionResult<List<Tasks>>> DeleteTask(int Id)
        {
            var result = await _tasksService.DeleteTask(Id);
            if(result is null)
            {
                return NotFound("Task not found");
            }
            
            return Ok(result);

        }






    }

    
}

