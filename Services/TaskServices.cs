using TMS.Data.Context;
using TMS.Data;
using Microsoft.EntityFrameworkCore;

namespace TMS.Services
{
    public class TaskDataServices
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public TaskDataServices(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<TaskData>> GetAllTaskDatas()
        {
            return await _applicationDbContext.TaskDatas.ToListAsync();
        }
        public async Task<bool> AddNewTaskData(TaskData TaskData)
        {
            await _applicationDbContext.TaskDatas.AddAsync(TaskData);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }
        public async Task<TaskData> GetTaskDataById(int id)
        {
            TaskData TaskData = await _applicationDbContext.TaskDatas.FirstOrDefaultAsync(x => x.Id == id);
            return TaskData;
        }
        public async Task<bool> UpdateTaskDataDetail(TaskData TaskData)
        {
            _applicationDbContext.TaskDatas.Update(TaskData);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteTaskDataDetail(TaskData TaskData)
        {
            _applicationDbContext.TaskDatas.Remove(TaskData);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }
    }
}
