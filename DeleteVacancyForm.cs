using AZS_BD.Utils;
using System;
using System.Windows.Forms;



namespace AZS_BD
{
    public partial class DeleteVacancyForm : Form
    {
        public DeleteVacancyForm()
        {
            InitializeComponent();
        }

        private void Cancellbutton2_Click(object sender, EventArgs e)
        {

        }

        private void RefreshData() 
        {
            this.titlesTableAdapter.Fill(this.workers_AZS_BDDataSet.Titles);
        }



        private void DeleteVacancyForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workers_AZS_BDDataSet.Titles". При необходимости она может быть перемещена или удалена.
            this.titlesTableAdapter.Fill(this.workers_AZS_BDDataSet.Titles);
            RefreshData();

        }

  

        private void detelebutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Вы действительно хотите удалить выбранную запись?", "Удалить запись ",
                 MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var id = 0;
                int.TryParse(vacancyCB.SelectedValue.ToString(), out id);
                DBHelper.DeleteEntry(Constants.TableNames.TitlesTableName, id);
                RefreshData();
            }
        }
    }
}
