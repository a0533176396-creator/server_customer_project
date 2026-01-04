using BLL;
using DAL;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkersController : ControllerBase
    {
        [HttpGet("GetAllWorkers")]
        public List<WorkerDTO> GetAllWorkers()
        {
            return functionOfSWorker.GetAllWorkers();
        }
        [HttpGet("GetWorkerById/{id}")]
        public WorkerDTO getWorkerById(string id)
        {
            return functionOfSWorker.GetWorkerById(id);
        }
        [HttpPost("AddWorker")]
        public List<WorkerDTO> AddWorker(WorkerDTO workerDTO)
        {
            return functionOfSWorker.AddWorker(workerDTO);
        }
        [HttpPut("UpdateWorker/{id}")]
        public List<WorkerDTO> updateWorker(WorkerDTO workerDTO)
        {
            return functionOfSWorker.UpdateWorker(workerDTO);
        }
        [HttpDelete("DeleteWorker/{id}")]
        public List<WorkerDTO> deleteWorker(string id)
        {
            return functionOfSWorker.DeleteWorker(id);
        }
    }
}
