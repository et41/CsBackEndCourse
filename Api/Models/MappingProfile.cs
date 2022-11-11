using AutoMapper;

namespace Api.Models
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BankAccount, BankAcountDto>();
            CreateMap<BankAcountDto, BankAccount>();
            
        }
    }
}
