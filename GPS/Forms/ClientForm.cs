using AutoMapper;
using GPS.DTO;
using GPS.DTO.GridData;
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
    public partial class ClientForm : Form
    {
        private readonly IMapper _mapper;
        private readonly ITraceRepository _traceRepository;
        public ClientForm(IMapper mapper, ITraceRepository traceRepository)
        {
            InitializeComponent();
            _mapper = mapper;
            _traceRepository = traceRepository;
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            var traces = _traceRepository.GetTraces(true).Result;
            var mapped = _mapper.Map<TraceDTO[]>(traces);
            List<ClientGridDTO> dataList = new List<ClientGridDTO>();

            for (int i = 0; i < mapped.Length; i++)
            {
                var data = _mapper.Map<ClientGridDTO>(mapped[i]);
                dataList.Add(data);
            }
            clientGrid.DataSource = dataList;
            foreach (DataGridViewColumn col in clientGrid.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                col.HeaderCell.Style.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }
    }
}
