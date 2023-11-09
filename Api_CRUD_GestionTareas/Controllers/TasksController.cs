using Api_CRUD_GestionTareas.Data;
using Api_CRUD_GestionTareas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_CRUD_GestionTareas.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        
        [HttpGet("Tareas")]
        public async Task<ActionResult> GetTaskList()
        {
            return Ok(await Task.Run(()=> new TasksData().TasksList()));
        }

        [HttpGet("TareasPorCategoria")]
        public async Task<ActionResult> GetTaskListCategory(string category)
        {
            return Ok(await Task.Run(() => new TasksData().TasksListCategory(category)));
        }


        [HttpPut("Editar")]
        public async Task<ActionResult> EditTasks (TasksModel task)
        {
            return Ok(await Task.Run(() => new TasksData().UpdateTask(task)));
        }
        [HttpPost("crear")]
        public async Task<ActionResult> CreateTasks(TasksModel task)
        {
            return Ok(await Task.Run(() => new TasksData().CreateNewTask(task)));
        }

        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Delete(string code)
        {
            return Ok(await Task.Run(() => new TasksData().DeleteTask(code)));
        }
    }
}
