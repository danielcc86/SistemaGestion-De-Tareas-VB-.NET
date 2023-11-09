namespace Api_CRUD_GestionTareas.Models
{
    public class TasksModel
    {
        public int taskId { get; set; }
        public string? taskCode { get; set; }
        public string? taskTitulo { get; set; }
        public string? taskDescription { get; set; }
        public string? StatusName { get; set; }
        public DateTime? EndDate { get; set; }
        public string? taskCategory { get; set; }
    }
}
