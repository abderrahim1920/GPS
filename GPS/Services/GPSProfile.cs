using AutoMapper;
using GPS.DTO;
using GPS.DTO.GridData;
using GPS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPS.Services
{
    public class GPSProfile : Profile
    {
        public GPSProfile()
        {

            CreateMap<Client, ClientDTO>().ReverseMap();
            CreateMap<Payment, PaymentDTO>().ReverseMap();
            CreateMap<Trace, TraceDTO>().ReverseMap();
            CreateMap<PaymentDTO, DataDTO>()
                .ForMember(c => c.Login, opt => opt.MapFrom(c => c.Trace.Client.Login))
                .ForMember(c => c.Name, opt => opt.MapFrom(c => c.Trace.Client.Name))
                .ForMember(c => c.PhoneNumber, opt => opt.MapFrom(c => c.Trace.Client.PhoneNumber))
                .ForMember(c => c.City, opt => opt.MapFrom(c => c.Trace.Client.City))

                .ForMember(c => c.TraceId, opt => opt.MapFrom(c => c.Trace.TraceId))
               .ForMember(c => c.TraceName, opt => opt.MapFrom(c => c.Trace.Name))
               .ForMember(c => c.RenewDate, opt => opt.MapFrom(c => c.Trace.RenewDate))
               .ForMember(c => c.IMEI, opt => opt.MapFrom(c => c.Trace.IMEI))

                .ReverseMap()
                .ForPath(c => c.Trace.Client.Login, opt => opt.Ignore())
                 .ForPath(c => c.Trace.Client.Name, opt => opt.Ignore())
             .ForPath(c => c.Trace.Client.PhoneNumber, opt => opt.Ignore())
             .ForPath(c => c.Trace.Client.City, opt => opt.Ignore())

             .ForPath(c => c.Trace.TraceId, opt => opt.Ignore())
             .ForPath(c => c.Trace.Name, opt => opt.Ignore())
             .ForPath(c => c.Trace.RenewDate, opt => opt.Ignore())
             .ForPath(c => c.Trace.IMEI, opt => opt.Ignore());


        }
    }
}
