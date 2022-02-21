using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using webapi.Services;
using webapi.Models;
using System.Net;

namespace webapi.Controllers
{

    [ApiController]
    [Route("[controller]")]


    public class TaskController : ControllerBase
    {
        private readonly ITaskServices _taskServices;

        public TaskController(ITaskServices taskServices)
        {
            _taskServices = taskServices;
        }
        [HttpGet]
        public IEnumerable<TaskModel> GetAll()
        {
            return _taskServices.GetAll();  
        }
        [HttpPost]
        public HttpStatusCode CreatTask(TaskModel newTask)
        {
            _taskServices.CreatTask(newTask);
            return HttpStatusCode.OK;
            
        }
        [HttpPut]
        public HttpStatusCode EditTask(TaskModel newTask)
        {
            _taskServices.EditTask(newTask);
            return HttpStatusCode.OK;
        }

        [HttpGet("Id")]
        public TaskModel GetById(int Id)
        {
            return _taskServices.GetById(Id);
        }

        [HttpDelete]
        public TaskModel DeleteTask(TaskModel newtask)
        {
            return _taskServices.DeleteTask(newtask);
        }


    }
}
