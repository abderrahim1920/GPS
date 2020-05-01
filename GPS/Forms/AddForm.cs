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
        private readonly Services.TraceServices.ITraceRepository _tracerepository;

        public AddForm(IMapper mapper, IClientRepository clientRepository, Services.TraceServices.ITraceRepository tracerepository)
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

        private void creationDateTime_ValueChanged(object sender, EventArgs e)
        {
            renewDateTime.Value = creationDateTime.Value.AddDays(365);
        }

        #region validation
        private void loginTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(loginTextBox.Text))
            {
                e.Cancel = true;
                errorProviderLogin.SetError(loginTextBox, "Champ obligatoire");
            }
            else
            {
                e.Cancel = false;
                errorProviderLogin.SetError(loginTextBox, null);
            }
        }

        private void NameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(NameTextBox.Text))
            {
                e.Cancel = true;
                errorProviderName.SetError(NameTextBox, "Champ obligatoire");
            }
            else
            {
                e.Cancel = false;
                errorProviderName.SetError(NameTextBox, null);
            }
        }

        private void phoneNumberTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(phoneNumberTextBox.Text))
            {
                e.Cancel = true;
                errorProviderPhoneNumber.SetError(phoneNumberTextBox, "Champ obligatoire");
            }
            else
            {
                e.Cancel = false;
                errorProviderPhoneNumber.SetError(phoneNumberTextBox, null);
            }
        }

        private void cityTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cityTextBox.Text))
            {
                e.Cancel = true;
                errorProviderCity.SetError(cityTextBox, "Champ obligatoire");
            }
            else
            {
                e.Cancel = false;
                errorProviderCity.SetError(cityTextBox, null);
            }
        }

        private void traceNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(traceNameTextBox.Text))
            {
                e.Cancel = true;
                errorProviderTraceName.SetError(traceNameTextBox, "Champ obligatoire");
            }
            else
            {
                e.Cancel = false;
                errorProviderTraceName.SetError(traceNameTextBox, null);
            }
        }

        private void iMEITextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(iMEITextBox.Text))
            {
                e.Cancel = true;
                errorProviderIMEI.SetError(iMEITextBox, "Champ obligatoire");
            }
            else if (loginTextBox.Text.Length != 15)
            {
                e.Cancel = true;
                errorProviderIMEI.SetError(iMEITextBox, "15 caractères");
            }
            else
            {
                e.Cancel = false;
                errorProviderIMEI.SetError(iMEITextBox, null);
            }
        }

        private void traceNumberTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(traceNumberTextBox.Text))
            {
                e.Cancel = true;
                errorProviderTraceNumber.SetError(traceNumberTextBox, "Champ obligatoire");
            }
            else
            {
                e.Cancel = false;
                errorProviderTraceNumber.SetError(traceNumberTextBox, null);
            }
        }

        private void creationDateTime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(creationDateTime.Text))
            {
                e.Cancel = true;
                errorProviderCreationDate.SetError(creationDateTime, "Champ obligatoire");
            }
            else
            {
                e.Cancel = false;
                errorProviderCreationDate.SetError(creationDateTime, null);
            }
        }

        #endregion

    }
}
