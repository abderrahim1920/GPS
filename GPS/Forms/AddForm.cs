using AutoMapper;
using GPS.DTO;
using GPS.Models;
using GPS.Services.ClientServices;
using GPS.Services.TraceServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPS.Forms
{
    public partial class AddForm : Form
    {
        private readonly IMapper _mapper;
        private readonly IClientRepository _clientRepository;
        private readonly ITracerepository _tracerepository;

        public AddForm(IMapper mapper, IClientRepository clientRepository, ITracerepository tracerepository)
        {
            InitializeComponent();
            _mapper = mapper;
            _clientRepository = clientRepository;
            _tracerepository = tracerepository;
            this.Text = "Ajouter";
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                ClientDTO client = new ClientDTO
                {
                    City = cityTextBox.Text,
                    Login = loginTextBox.Text,
                    Name = NameTextBox.Text,
                    PhoneNumber = phoneNumberTextBox.Text,
                };
                var mappedEntity = _mapper.Map<Client>(client);
                _clientRepository.Add(mappedEntity);
                TraceDTO trace = new TraceDTO
                {
                    CreationDate = creationDateTime.Value,
                    IMEI = iMEITextBox.Text,
                    Name = traceNameTextBox.Text,
                    Number = phoneNumberTextBox.Text,
                    RenewDate = DateTime.Now.AddDays(365),
                    ClientId = mappedEntity.ClientId
                };
                var traceMapped = _mapper.Map<Trace>(trace);
                _tracerepository.Add(traceMapped);
            }
        }

        private void loginTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(loginTextBox.Text))
            {
                errorProvider.SetError(loginTextBox, "Champ obligatoire");
            }
            else if (loginTextBox.Text.Length != 15)
            {
                errorProvider.SetError(loginTextBox, "15 caractères");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(loginTextBox, null);
            }
        }
    }
}
