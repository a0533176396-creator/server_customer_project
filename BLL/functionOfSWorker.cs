using DAL;
using DAL.function;
using DAL.Models;
using DTO.mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class functionOfSWorker
    {
        //שליפה
        public static List<WorkerDTO> GetAllWorkers()
        {
            List<Worker> list= workersFunction.GetAllWorkers();
            List<WorkerDTO> dtoList = AutoMapClass.MapWorkerListToDTO(list);
            return dtoList;
        }
        //שליפה באמצעות מזהה
        public static WorkerDTO GetWorkerById(string tz)
        {
            Worker worker = workersFunction.GetWorkerById(tz);
            WorkerDTO workerDTO = AutoMapClass._Mapper.Map<Worker, WorkerDTO>(worker);
            return workerDTO;
        }
        //הוספה
        public static List<WorkerDTO> AddWorker(WorkerDTO workerDTO)
        {
            Worker worker = AutoMapClass._Mapper.Map<WorkerDTO, Worker>(workerDTO);
            List<Worker> list = workersFunction.AddWorker(worker);
            List<WorkerDTO> dtoList = AutoMapClass.MapWorkerListToDTO(list);
            return dtoList;
        }
        //עדכון
        public static List<WorkerDTO> UpdateWorker(WorkerDTO workerDTO)
        {
            Worker worker = AutoMapClass._Mapper.Map<WorkerDTO, Worker>(workerDTO);
            List<Worker> list = workersFunction.UpdateWorker(worker);
            List<WorkerDTO> dtoList = AutoMapClass.MapWorkerListToDTO(list);
            return dtoList;
        }
        //מחיקה
        public static List<WorkerDTO> DeleteWorker(string tz)
        {
            List<Worker> list = workersFunction.DeleteWorker(tz);
            List<WorkerDTO> dtoList = AutoMapClass.MapWorkerListToDTO(list);
            return dtoList;
        }
    }
}
