
namespace todo.Services.TasksService
{
    public class TasksService : ITasksService
    {
         

        private readonly DataContext _context;
        public TasksService(DataContext context)
        {
            _context=context;
        }

 
        public async Task<List<Tasks>> AddTask(Tasks t)
        {
        _context.Tasks.Add(t);
        await _context.SaveChangesAsync();
        return await _context.Tasks.ToListAsync();
        }
    
  


        public async Task<List<Tasks>?> DeleteTask(int Id)
        {
             var ta = await _context.Tasks.FindAsync(Id);
            if(ta is null)
              return null;

            _context.Tasks.Remove(ta);
            await _context.SaveChangesAsync(); 
            
             return await _context.Tasks.ToListAsync();
        }

        public async Task<List<Tasks>> GetAllTasks()
        {
            var ta=await _context.Tasks.ToListAsync();
            return ta;
        }

        public async Task<Tasks?> GetSingleTask(int Id)
        {
             var ta = await _context.Tasks.FindAsync(Id);
            if(ta is null)
              return null;
            
            return ta;
        }

        
        public async Task<List<Tasks>?> UpdateTask(int Id, Tasks request)
        {
             var ta = await _context.Tasks.FindAsync(Id);
            if(ta is null)
              return null;

            ta.Name=request.Name;
            ta.Done=request.Done;

            await _context.SaveChangesAsync();
              
            
            return await _context.Tasks.ToListAsync();
        }
    }
}