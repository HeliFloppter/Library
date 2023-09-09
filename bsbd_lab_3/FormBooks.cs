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
    public partial class FormBooks : Form
    {
        public FormBooks()
        {
            InitializeComponent();
        }

        private void FormBooks_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Книги". При необходимости она может быть перемещена или удалена.
            this.книгиTableAdapter.Fill(this.библиотекаDataSet.Книги);

        }
        private static FormBooks f;
        public static FormBooks fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormBooks();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void книгиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.книгиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.библиотекаDataSet);

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        string GetSelectedFieldName()
        {
            return
           книгиDataGridView.Columns[книгиDataGridView.CurrentCell.ColumnIndex
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
               книгиBindingSource.Find(GetSelectedFieldName(),
               toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                книгиBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Таких сотрудников нет", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                книгиBindingSource.Position = 0;
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
                        книгиBindingSource.Filter =
                       GetSelectedFieldName() + "='" + toolStripTextBoxFind.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" +
                       err.Message);
                    }
            }
            else
                книгиBindingSource.Filter = "";
            if (книгиBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                книгиBindingSource.Filter = "";
                checkBoxFind.Checked = false;
            }
        }

        private void FormBooks_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Книги". При необходимости она может быть перемещена или удалена.
            this.книгиTableAdapter.Fill(this.библиотекаDataSet.Книги);

        }

        private void книгиBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.книгиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.библиотекаDataSet);

        }
    }
}
