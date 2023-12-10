using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AZS_BD
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void RefreshData()
        {
            
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workers_AZS_BDDataSet.InfoWorkers". При необходимости она может быть перемещена или удалена.
            this.infoWorkersTableAdapter.Fill(this.workers_AZS_BDDataSet.InfoWorkers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workers_AZS_BDDataSet.Workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.workers_AZS_BDDataSet.Workers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workers_AZS_BDDataSet.InfoWorkers". При необходимости она может быть перемещена или удалена.
            this.infoWorkersTableAdapter.Fill(this.workers_AZS_BDDataSet.InfoWorkers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workers_AZS_BDDataSet.Unit". При необходимости она может быть перемещена или удалена.
            this.unitTableAdapter.Fill(this.workers_AZS_BDDataSet.Unit);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workers_AZS_BDDataSet.Titles". При необходимости она может быть перемещена или удалена.
            this.titlesTableAdapter.Fill(this.workers_AZS_BDDataSet.Titles);
            RefreshData();

            education_richTextBox.ReadOnly = true;
            address_richTextBox.ReadOnly = true;
        }

        private void titles_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void delete_StripButton_Click(object sender, EventArgs e)
        {

        }

        private void addEmployeeMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addVacancyMenuItem_Click(object sender, EventArgs e)
        {
            if (new DeleteVacancyForm().ShowDialog() == DialogResult.OK)
            {
                this.titlesTableAdapter.Fill(this.workers_AZS_BDDataSet.Titles);
            }
        }

        private void AZSbindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void newVacancyMenuItem_Click(object sender, EventArgs e)
        {
            if (new EditVacancyForm().ShowDialog() == DialogResult.OK)
            {
                this.titlesTableAdapter.Fill(this.workers_AZS_BDDataSet.Titles);
            }
        }

        private void editVacancyMenuuItem_Click(object sender, EventArgs e)
        {
            if (titlesCB.Items.Count == 0)

            {
                MessageBox.Show("Отсутствует выбранный отдел");
                return;
            }
            var id = 0;

            if (int.TryParse(titlesCB.SelectedValue.ToString(), out id)
                && new EditVacancyForm(true, id).ShowDialog() == DialogResult.OK)
            {
                
              this.titlesTableAdapter.Fill(this.workers_AZS_BDDataSet.Titles);
                
            }
            
        }
    }
}
