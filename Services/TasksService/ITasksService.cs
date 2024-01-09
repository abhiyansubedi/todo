
namespace todo.Services.TasksService
{
    public interface ITasksService
    {   
        //Reading list of tasks
        Task<List<Tasks>>? GetAllTasks();

        //Reading single task
        Task<Tasks?> GetSingleTask(int Id);

        //Adding task
        Task<List<Tasks>> AddTask(Tasks t);

        //Updating a task
        Task<List<Tasks>?> UpdateTask(int Id, Tasks request);

        //Deleting a task
        Task<List<Tasks>?> DeleteTask(int Id);

    }
}