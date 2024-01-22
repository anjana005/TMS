using Microsoft.EntityFrameworkCore;
using TMS.Data;
using TMS.Data.Context;

namespace TMS.Services
{
    public class UserService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public UserService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<User>> GetAllUsers() {
            return await _applicationDbContext.Users.ToListAsync();
        }
        public async Task<bool> AddNewUser(User user)
        {
            await _applicationDbContext.Users.AddAsync(user);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }
        public async Task<User> GetUserById(int id)
        {
            User user = await _applicationDbContext.Users.FirstOrDefaultAsync(x => x.Id == id);
            return user;
        }
        public async Task<bool> UpdateUserDetail(User user)
        {
            _applicationDbContext.Users.Update(user);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteUserDetail(User user)
        {
            _applicationDbContext.Users.Remove(user);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }
    }
}
