using AutoMapper;
using GPS.DTO;
using GPS.DTO.GridData;
using GPS.Properties;
using GPS.Services.PaiementService;
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
    public partial class PaymentForm : Form
    {
        private readonly IMapper _mapper;
        private readonly IPaiementRepository _paiementRepository;
        public PaymentForm(IMapper mapper, IPaiementRepository paiementRepository)
        {
            InitializeComponent();
            _mapper = mapper;
            _paiementRepository = paiementRepository;
            InitializeGrid();
        }

        private void InitializeGrid()
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
            PaymentsGrid.DataSource = dataList;
            PaymentsGrid.Columns[0].Visible = false;
            PaymentsGrid.Columns[5].Visible = false;
            PaymentsGrid.Columns[10].Visible = false;
            PaymentsGrid.Columns[2].HeaderText = "Nom";
            PaymentsGrid.Columns[3].HeaderText = "Téléphone";
            PaymentsGrid.Columns[4].HeaderText = "Ville";
            PaymentsGrid.Columns[6].HeaderText = "Nom traceur";
            PaymentsGrid.Columns[7].HeaderText = "Date renouvellement";
            PaymentsGrid.Columns[9].HeaderText = "Date paiement";
            PaymentsGrid.Columns[11].HeaderText = "Payé";
            PaymentsGrid.Columns[11].ReadOnly = true;
            
            foreach (DataGridViewColumn col in PaymentsGrid.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
               
                col.HeaderCell.Style.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            LoadColumns();
           
        }

        private void LoadColumns()
        {
            DataGridViewImageColumn deleteBtn = new DataGridViewImageColumn();
            Image image = Resources.trash;
            deleteBtn.Image = image;
            PaymentsGrid.Columns.Add(deleteBtn);
            deleteBtn.HeaderText = "";
            deleteBtn.Name = "Delete";
            deleteBtn.ImageLayout = DataGridViewImageCellLayout.Normal;
            deleteBtn.Width = 40;

            DataGridViewImageColumn editBtn = new DataGridViewImageColumn();
            Image editImage = Resources.edit;
            editBtn.Image = editImage;
            PaymentsGrid.Columns.Add(editBtn);
            editBtn.HeaderText = "";
            editBtn.Name = "Update";
            editBtn.ImageLayout = DataGridViewImageCellLayout.Normal;
            editBtn.Width = 40;
        }

        private void PaymentsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (PaymentsGrid.Columns[e.ColumnIndex].Name == "Delete")
            {
                var PaiementId = PaymentsGrid.Rows[e.RowIndex].Cells["PaiementId"].FormattedValue.ToString();
                if (MessageBox.Show("Supprimer ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int x = int.Parse(PaiementId);
                    _paiementRepository.Delete(x);
                }
            }
        }


    }
}
