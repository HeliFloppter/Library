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
    public partial class FormCard : Form
    {
        public FormCard()
        {
            InitializeComponent();
        }

        private void читательский_билетBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.читательский_билетBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.библиотекаDataSet);

        }

        private void FormCard_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Читательский_билет". При необходимости она может быть перемещена или удалена.
            this.читательский_билетTableAdapter.Fill(this.библиотекаDataSet.Читательский_билет);

        }

        private static FormCard f;
        public static FormCard fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormCard();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }
    }
}
