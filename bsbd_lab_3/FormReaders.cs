using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bsbd_lab_3
{
    public partial class FormReaders : Form
    {
        public FormReaders()
        {
            InitializeComponent();
        }

        private void FormReaders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Читатель". При необходимости она может быть перемещена или удалена.
            this.читательTableAdapter.Fill(this.библиотекаDataSet.Читатель);

        }

        private static FormReaders f;
        public static FormReaders fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormReaders();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void читательBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.читательBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.библиотекаDataSet);

        }

        string GetSelectedFieldName()
        {
            return
           читательDataGridView.Columns[читательDataGridView.CurrentCell.ColumnIndex
           ].DataPropertyName;

        }

        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            if (toolStripTextBoxFind.Text == "")
            {
                MessageBox.Show("Вы ничего не задали", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int indexPos;
            try
            {
                indexPos =
               читательBindingSource.Find(GetSelectedFieldName(),
               toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                читательBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Таких сотрудников нет", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                читательBindingSource.Position = 0;
            }
        }

        private void checkBoxFind_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFind.Checked)
            {
                if (toolStripTextBoxFind.Text == "")
                    MessageBox.Show("Вы ничего не задали", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    try
                    {
                        читательBindingSource.Filter =
                       GetSelectedFieldName() + "='" + toolStripTextBoxFind.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" +
                       err.Message);
                    }
            }
            else
                читательBindingSource.Filter = "";
            if (читательBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                читательBindingSource.Filter = "";
                checkBoxFind.Checked = false;
            }
        }
    }
}
