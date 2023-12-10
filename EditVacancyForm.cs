using AZS_BD.Utils;
using AZS_BD;
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
    public partial class EditVacancyForm : Form
{
    private bool _editMode = false;
    private int _titId = 0;
    public EditVacancyForm()
    {
        InitializeComponent();
    }

    public EditVacancyForm(bool editMode = false, int titId = 0)
    {
        _editMode = editMode;
        _titId = titId;
        InitializeComponent();
    }

        private void EditVacancyForm_Load(object sender, EventArgs e)
        {
            if (_editMode)
            {
                var fieldsValues = DBHelper.SelectValuesFromTable(Constants.TableNames.TitlesTableName, _titId);
                titlestextBox.Text = fieldsValues[1];

            }
        }

        private void button1_Click(object sender, EventArgs e)
    {
        if (_editMode)
        {
            var fields = new Dictionary<string, TableField>();
            fields.Add(Constants.FieldsName.TitlesTable.Titles, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = titlestextBox.Text
            });
            DBHelper.UpdateEntry(Constants.TableNames.TitlesTableName, _titId, fields);
            DialogResult = DialogResult.OK;
        }
        else
        {
            var fields = new Dictionary<string, TableField>();
            fields.Add(Constants.FieldsName.TitlesTable.Titles, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = titlestextBox.Text
            });
            DBHelper.InsertEntry(Constants.TableNames.TitlesTableName, fields);
            DialogResult = DialogResult.OK;
        }
    }

    }
}
