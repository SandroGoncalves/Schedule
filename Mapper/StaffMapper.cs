using AutoMapper;
using Gendar.Entity;
using Gendar.ValueObj;

namespace Gendar.Mapper
{
    public class StaffMapper : Profile
    {
        public StaffMapper()
        {
            CreateMap<Staff, StaffVO>()
                .ReverseMap();
        }
    }
}
