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
    public partial class FormReadersCard : Form
    {
        public FormReadersCard()
        {
            InitializeComponent();
        }

        private void FormReadersCard_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Сотрудник_библиотеки". При необходимости она может быть перемещена или удалена.
            this.сотрудник_библиотекиTableAdapter.Fill(this.библиотекаDataSet.Сотрудник_библиотеки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Сотрудник_библиотеки". При необходимости она может быть перемещена или удалена.

            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Читатель". При необходимости она может быть перемещена или удалена.
            this.читательTableAdapter.Fill(this.библиотекаDataSet.Читатель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Читательский_билет". При необходимости она может быть перемещена или удалена.
            this.читательский_билетTableAdapter.Fill(this.библиотекаDataSet.Читательский_билет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Читатель". При необходимости она может быть перемещена или удалена.
            this.читательTableAdapter.Fill(this.библиотекаDataSet.Читатель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Читательский_билет". При необходимости она может быть перемещена или удалена.
            this.читательский_билетTableAdapter.Fill(this.библиотекаDataSet.Читательский_билет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Читатель". При необходимости она может быть перемещена или удалена.
            this.читательTableAdapter.Fill(this.библиотекаDataSet.Читатель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Читательский_билет". При необходимости она может быть перемещена или удалена.
            this.читательский_билетTableAdapter.Fill(this.библиотекаDataSet.Читательский_билет);

        }

        private static FormReadersCard f;
        public static FormReadersCard fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormReadersCard();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void читательский_билетBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.читательский_билетBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.библиотекаDataSet);

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.читательBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.библиотекаDataSet);
        }

        private void читательский_билетBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.читательский_билетBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.библиотекаDataSet);

        }

        private void читательский_билетBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.читательский_билетBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.библиотекаDataSet);

        }

        private void buttonWorker_Click(object sender, EventArgs e)
        {
            {
                int id = -1;
                if
               (((DataRowView)сотрудник_библиотекиBindingSource.Current)["ID Сотрудника"].ToString() !=
               "")
                {
                    id =
                   (int)(((DataRowView)сотрудник_библиотекиBindingSource.Current)["ID Сотрудника"]);
                }
                id = FormWorkers.fw.ShowSelectForm(id);
                if (id >= 0)
                {
                    MessageBox.Show(id.ToString());
                    ((DataRowView)сотрудник_библиотекиBindingSource.Current)["ID Сотрудника"]
                   = id;
                    сотрудник_библиотекиBindingSource.EndEdit();
                }

            }
        }

        private void iD_СотрудникаTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}