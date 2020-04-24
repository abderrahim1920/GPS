using AutoMapper;
using GPS.DTO;
using GPS.DTO.GridData;
using GPS.Models;
using GPS.Services.ClientServices;
using GPS.Services.PaiementService;
using GPS.Services.TraceServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationContext = System.ComponentModel.DataAnnotations.ValidationContext;

namespace GPS
{
    public partial class Form1 : Form
    {
        private readonly IMapper _mapper;
        private readonly IClientRepository _clientRepository;
        private readonly ITracerepository _tracerepository;
        private readonly IPaiementRepository _paiementRepository;


        public Form1(IMapper mapper, IClientRepository clientRepository, ITracerepository tracerepository, IPaiementRepository paiementRepository)
        {
            InitializeComponent();
            _mapper = mapper;
            _clientRepository = clientRepository;
            _tracerepository = tracerepository;
            _paiementRepository = paiementRepository;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            ClientDTO client = new ClientDTO
            {
                City = "Sousse",
                Login = "Abde",
                Name = "Abde",
                PhoneNumber = "25098886",
            };
            try
            {
                //  var mappedEntity = _mapper.Map<Client>(client);
                //  _clientRepository.Add(mappedEntity);
                TraceDTO trace = new TraceDTO
                {
                    CreationDate = DateTime.Now,
                    IMEI = "12345678912345",
                    Name = "Polo",
                    Number = "25098886",
                    RenewDate = DateTime.Now.AddDays(365),
                    ClientId = 21
                };
                var x = trace;
                var context = new ValidationContext(trace, serviceProvider: null, items: null);
                var results = new List<ValidationResult>();
                Console.WriteLine(Validator.TryValidateObject(trace, context, results, true));
                if (Validator.TryValidateObject(trace, context, results, true))
                {
                    var traceMapped = _mapper.Map<Trace>(trace);
                    //_tracerepository.Add(traceMapped);
                }

                PaymentDTO payment = new PaymentDTO
                {
                    PaiementDate = DateTime.Now,
                    Payee = true,
                    TraceId = 8
                };
                var paymentMapped = _mapper.Map<Payment>(payment);
                _paiementRepository.Add(paymentMapped);


            }
            catch (Exception ex)
            {
                Console.WriteLine("error add to Database", ex.Message);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            var x = _paiementRepository.GetPayments(true, true).Result;

            var mapped = _mapper.Map<PaymentDTO[]>(x);

            var m = _mapper.Map<DataDTO>(mapped[0]);
            var length = mapped.Length;
            List<DataDTO> dataList = new List<DataDTO>();

            for (int i = 0; i < mapped.Length; i++)
            {
                var data = _mapper.Map<DataDTO>(mapped[i]);
                dataList.Add(data);
            }
            var j = dataList;
            dgv.DataSource = dataList;
            var y = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var client = _paiementRepository.GetPaymentById(1, true, true).Result;
            var mapped = _mapper.Map<PaymentDTO>(client);
            dgv.DataSource = mapped;
        }
    }
}
