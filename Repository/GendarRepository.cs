using AutoMapper;
using Gendar.Context;
using Gendar.Entity;
using Gendar.Repository.Inteface;
using Gendar.ValueObj;
using Microsoft.EntityFrameworkCore;

namespace Gendar.Repository
{
    public class GendarRepository : IGendarRepository
    {
        private readonly SqlServerContext _context;
        private IMapper _mapper;

        public GendarRepository(SqlServerContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<StaffVO>> GetAllAsync()
        {
            return _mapper.Map<List<StaffVO>>(await _context.Staff.ToListAsync());
        }

        public async Task<StaffVO> GetByIdAsync(Guid id)
        {
            return _mapper.Map<StaffVO>(await _context.Staff.Where(sff => sff.Id == id).FirstOrDefaultAsync());
        }

        public async Task<StaffVO> AddStaffAsync(StaffVO staff)
        {
            var staffObj = _mapper.Map<Staff>(staff);
            await _context.Staff.AddAsync(staffObj);
            await _context.SaveChangesAsync();

            return _mapper.Map<StaffVO>(staffObj);
        }

        public async Task<StaffVO> UpdateStaffAsync(StaffVO staff)
        {
            var staffObj = _mapper.Map<Staff>(staff);
            _context.Staff.Update(staffObj);
            await _context.SaveChangesAsync();

            return _mapper.Map<StaffVO>(staffObj);
        }

        public async Task<bool> DeleteStaffAsync(Guid id)
        {
            var staff = await _context.Staff.Where(sff => sff.Id == id).FirstOrDefaultAsync();
            if (staff.Id == Guid.Empty) return false;

            _context.Staff.Remove(staff);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
