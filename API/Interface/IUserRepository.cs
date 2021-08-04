using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;
using API.Helpers;

namespace API.Interface
{
    public interface IUserRepository
    {
        void Update(appuser user);

        Task<bool> SaveAllAsync();
        Task<IEnumerable<appuser>> GetUserAsync();
        Task<appuser> GetUserByIdAsync(int id);
        Task<appuser> GetUserByUsernameAsync(string username);
        Task<PagedList<MemberDto>> GetMembersAsync(UserParams userParams);

        Task<MemberDto> GetMemberAsync(string username);

    }
}