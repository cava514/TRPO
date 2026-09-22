namespace LabWork2._5
{
    public class Tasks
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Priority Priority { get; set; }
        public bool Status { get; set; } 
    }

    public enum Priority
    {
        Low,
        Medium,
        High
    }
}
