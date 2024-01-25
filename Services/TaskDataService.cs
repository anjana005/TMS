using TMS.Data.Context;
using TMS.Data;
using Microsoft.EntityFrameworkCore;

namespace TMS.Service
{
    public class TaskDataService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public TaskDataService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<TaskData>> GetAllTaskDatas()
        {
            return await _applicationDbContext.TaskDatas.ToListAsync();
        }
        public async Task<bool> AddNewTaskData(TaskData taskData)
        {
            taskData.Status = taskData.Status!=null? taskData.Status : "New";
            taskData.DueDate = taskData.DueDate != DateTime.MinValue ? taskData.DueDate : DateTime.Now;
            taskData.CreatedBy = 1;
            taskData.CreatedOn = DateTime.Now;
            await _applicationDbContext.TaskDatas.AddAsync(taskData);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }
        public async Task<TaskData> GetTaskDataById(int? id)
        {
            TaskData TaskData = await _applicationDbContext.TaskDatas.FirstOrDefaultAsync(x => x.Id == id);
            return TaskData;
        }
        public async Task<bool> UpdateTaskDataDetail(TaskData taskData)
        {
            _applicationDbContext.TaskDatas.Update(taskData);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteTaskDataDetail(TaskData taskData)
        {
            _applicationDbContext.TaskDatas.Remove(taskData);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }
    }
}
