using webapi.Models;

namespace webapi.Services
{
    public interface ITaskServices
    {
        public List<TaskModel> GetAll();

        public void CreatTask(TaskModel newTask);

        public void EditTask(TaskModel task);

        public TaskModel GetById(int Id);

        public TaskModel DeleteTask(TaskModel task);
    }
}