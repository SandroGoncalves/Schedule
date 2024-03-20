using AutoMapper;
using Gendar.Entity;
using Gendar.ValueObj;

namespace Gendar.Mapper
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<StaffVO, Staff>();
                config.CreateMap<Staff, StaffVO>();
            });

            return mappingConfig;
        }
    }
}