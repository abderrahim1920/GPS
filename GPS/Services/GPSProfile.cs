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
                .ForMember(c => c.ClientId, opt => opt.MapFrom(c => c.Trace.Client.ClientId))
                .ForMember(c => c.Login, opt => opt.MapFrom(c => c.Trace.Client.Login))
                .ForMember(c => c.Name, opt => opt.MapFrom(c => c.Trace.Client.Name))
                .ForMember(c => c.PhoneNumber, opt => opt.MapFrom(c => c.Trace.Client.PhoneNumber))
                .ForMember(c => c.City, opt => opt.MapFrom(c => c.Trace.Client.City))

                .ForMember(c => c.TraceId, opt => opt.MapFrom(c => c.Trace.TraceId))
               .ForMember(c => c.TraceName, opt => opt.MapFrom(c => c.Trace.Name))
               .ForMember(c => c.RenewDate, opt => opt.MapFrom(c => c.Trace.RenewDate))
               .ForMember(c => c.IMEI, opt => opt.MapFrom(c => c.Trace.IMEI))

                .ReverseMap()
                .ForPath(c => c.Trace.Client.ClientId, opt => opt.Ignore())
                .ForPath(c => c.Trace.Client.Login, opt => opt.Ignore())
                 .ForPath(c => c.Trace.Client.Name, opt => opt.Ignore())
             .ForPath(c => c.Trace.Client.PhoneNumber, opt => opt.Ignore())
             .ForPath(c => c.Trace.Client.City, opt => opt.Ignore())

             .ForPath(c => c.Trace.TraceId, opt => opt.Ignore())
             .ForPath(c => c.Trace.Name, opt => opt.Ignore())
             .ForPath(c => c.Trace.RenewDate, opt => opt.Ignore())
             .ForPath(c => c.Trace.IMEI, opt => opt.Ignore());



            CreateMap<TraceDTO, ClientGridDTO>()
                .ForMember(c => c.ClientId, opt => opt.MapFrom(c => c.Client.ClientId))
                .ForMember(c => c.Login, opt => opt.MapFrom(c => c.Client.Login))
                .ForMember(c => c.Name, opt => opt.MapFrom(c => c.Client.Name))
                .ForMember(c => c.PhoneNumber, opt => opt.MapFrom(c => c.Client.PhoneNumber))
                .ForMember(c => c.City, opt => opt.MapFrom(c => c.Client.City))

                 .ForMember(c => c.TraceId, opt => opt.MapFrom(c => c.TraceId))
               .ForMember(c => c.TraceName, opt => opt.MapFrom(c => c.Name))
               .ForMember(c => c.RenewDate, opt => opt.MapFrom(c => c.RenewDate))
               .ForMember(c => c.IMEI, opt => opt.MapFrom(c => c.IMEI))

                .ReverseMap()
                 .ForPath(c => c.Client.ClientId, opt => opt.Ignore())
                .ForPath(c => c.Client.Login, opt => opt.Ignore())
                 .ForPath(c => c.Client.Name, opt => opt.Ignore())
             .ForPath(c => c.Client.PhoneNumber, opt => opt.Ignore())
             .ForPath(c => c.Client.City, opt => opt.Ignore())

              .ForPath(c => c.TraceId, opt => opt.Ignore())
             .ForPath(c => c.Name, opt => opt.Ignore())
             .ForPath(c => c.RenewDate, opt => opt.Ignore())
             .ForPath(c => c.IMEI, opt => opt.Ignore());


        }
    }
}
