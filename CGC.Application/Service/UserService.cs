using CGC.Application.IService;
using CGC.Domain.Entity.Common;
using CGC.Infrastructure.IRepository;
using MongoDB.Driver;

namespace CGC.Application.Service
{
    public class UserService:IUserService
    {
        private readonly IRepository<User> _repository;
        public UserService(IRepository<User> userRepository)
        {
            _repository = userRepository;
        }
        public async Task<User> AddUser(User user)
        {
            try
            {
                await _repository.InsertAsync(user);
                return user;
            }catch (Exception ex)
            {
                _repository.WriteError(ex.Message);
                throw;
            }
           
        }

        public async Task UpdateUser(string id, User user)
        {
            try
            {
                await _repository.UpdateAsync(id, user);
            }
            catch (Exception ex)
            {
                _repository.WriteError(ex.Message);
                throw;
            }
           
        }
        public async Task DeleteUser(User user)
        {
            try
            {
                await _repository.DeleteAsync(user);
            }
            catch (Exception ex)
            {
                _repository.WriteError(ex.Message);
                throw;
            }
           
        }
        public async Task<IEnumerable<User>> GetUserList()
        {
            try
            {
                var users = await _repository.GetAllAsync();
                return users;
            }
            catch (Exception ex)
            {
                _repository.WriteError(ex.Message);
                throw;
            }
            
        }
        public  User GetUserById(string id)
        {
            try
            {
                var user =  _repository.GetById(id);
                return user;

            } catch (Exception ex)
            {
                _repository.WriteError(ex.Message);
                throw;
            }
            
        }
        

         
    }   
}
