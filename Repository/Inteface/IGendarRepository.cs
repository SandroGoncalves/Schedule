using Gendar.Entity;
using Gendar.ValueObj;

namespace Gendar.Repository.Inteface
{
    public interface IGendarRepository
    {
        public Task<List<StaffVO>> GetAllAsync();
        public Task<StaffVO> GetByIdAsync(Guid id);
        public Task<StaffVO> AddStaffAsync(StaffVO staff);
        public Task<StaffVO> UpdateStaffAsync(StaffVO staff);
        public Task<bool> DeleteStaffAsync(Guid staffId);
    }
}
