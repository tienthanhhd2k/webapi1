using System.Threading.Tasks;
using webapi.Models;

namespace webapi.Services
{
    public class TaskServices : ITaskServices
    {   
        public static List<TaskModel> taskModels = new List<TaskModel>()
        {
            new TaskModel 
            {
                Id = 1,
                Title = "Task1",
                IsCompleted = false,
            },
            new TaskModel 
            {
                Id = 2,
                Title = "Task2",
                IsCompleted = true,
            },
            new TaskModel 
            {
                Id = 3,
                Title = "Task3",
                IsCompleted = false,
            }
        };

        public void CreatTask(TaskModel newTask)
        {
           taskModels.Add(newTask);
        }

        public TaskModel DeleteTask(TaskModel task)
        {
            var taskDelete = taskModels.Where(x => x.Id == task.Id).FirstOrDefault();
            taskModels.Remove(taskDelete);
            return taskDelete;
        }

        public void EditTask(TaskModel task)
        {
            var taskEdit = taskModels.Where(x => x.Id == task.Id).FirstOrDefault();
            taskEdit.Title = task.Title;
            taskEdit.IsCompleted = task.IsCompleted;
        }

        public List<TaskModel> GetAll()
        {
            return taskModels;
        }

        public TaskModel GetById(int Id)
        {
           var task = taskModels.Where(x => x.Id == Id).FirstOrDefault();
           return task;
        }
    }
}