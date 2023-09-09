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
    public partial class FormWorkers : Form
    {
        public FormWorkers()
        {
            InitializeComponent();
        }

        private void сотрудник_библиотекиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудник_библиотекиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.библиотекаDataSet);

        }

        private void FormWorkers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Сотрудник_библиотеки". При необходимости она может быть перемещена или удалена.
            this.сотрудник_библиотекиTableAdapter.Fill(this.библиотекаDataSet.Сотрудник_библиотеки);

        }
        private void FormBooks_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Книги". При необходимости она может быть перемещена или удалена.
            this.сотрудник_библиотекиTableAdapter.Fill(this.библиотекаDataSet.Сотрудник_библиотеки);

        }
        private static FormWorkers f;
        public static FormWorkers fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormWorkers();
                return f;
            }
        }
        int idCurrent = -1;
        public int ShowSelectForm(int id)
        {
            toolStripButtonOK.Visible = true;
            idCurrent = id;
            if (ShowDialog() == DialogResult.OK)
                return
               (int)((DataRowView)сотрудник_библиотекиBindingSource.Current)["ID Сотрудника"];
            else
                return -1;
        }


        public void ShowForm()
        {
            toolStripButtonOK.Visible = false;
            сотрудник_библиотекиBindingSource.Position = 0;
            Show();
            Activate();
        }
        private void FormWorkesList_Shown(object sender, EventArgs e)
        {
            сотрудник_библиотекиBindingSource.Position =
           сотрудник_библиотекиBindingSource.Find("ID Сотрудника", idCurrent);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

        }

        string GetSelectedFieldName()
        {
            return
           сотрудник_библиотекиDataGridView.Columns[сотрудник_библиотекиDataGridView.CurrentCell.ColumnIndex
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
                сотрудник_библиотекиBindingSource.Find(GetSelectedFieldName(),
                toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                сотрудник_библиотекиBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Таких сотрудников нет", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                сотрудник_библиотекиBindingSource.Position = 0;
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
                        сотрудник_библиотекиBindingSource.Filter =
                       GetSelectedFieldName() + "='" + toolStripTextBoxFind.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" +
                       err.Message);
                    }
            }
            else
                сотрудник_библиотекиBindingSource.Filter = "";
            if (сотрудник_библиотекиBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                сотрудник_библиотекиBindingSource.Filter = "";
                checkBoxFind.Checked = false;
            }

        }
    }
}
