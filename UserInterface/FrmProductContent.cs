using DataAccess.Services;
using DTOs.ProductEvaluation;
using System;
using System.Linq;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class FrmProductContent : Form
    {
        public FrmProductContent()
        {
            InitializeComponent();
        }
        ProductEvaluationService productEvaluationService = new ProductEvaluationService();
        private void FrmProductContent_Load(object sender, EventArgs e)
        {
            GetProductEvaluationsToGrid();
            ColumnVisibleProcess();
        }
        void ColumnVisibleProcess()
        {
            dataGridViewProductEvaluations.Columns[0].Visible = false;
            dataGridViewProductEvaluations.Columns[1].Visible = false;
            dataGridViewProductEvaluations.Columns[2].Visible = false;
            dataGridViewProductEvaluations.Columns[3].Visible = false;
            dataGridViewProductEvaluations.Columns[4].Visible = false;
        }
        void GetProductEvaluationsToGrid()
        {
            dataGridViewProductEvaluations.DataSource = productEvaluationService.GetProductEvaluationList(UserContext.Id);
        }

        private void removedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedRow = (int)dataGridViewProductEvaluations.SelectedRows[0].Cells["ID"].Value;
            productEvaluationService.DeleteEvaluation(selectedRow);
            MessageBox.Show("Deleted");
            dataGridViewProductEvaluations.DataSource = productEvaluationService.GetActiveEvaluation(UserContext.Id);
        }
    }
}

