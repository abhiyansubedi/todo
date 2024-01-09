namespace todo.Models
{
    public class Tasks
    {
        public int Id{get; set;}

        public string Name{get; set;}= string.Empty;

        public bool Done {get; set;}= false;
    }
}