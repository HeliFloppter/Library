using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bsbd_lab_3
{
    public partial class FormSQL : Form
    {
        public FormSQL()
        {
            InitializeComponent();
        }

        private void FormSQL_Load(object sender, EventArgs e)
        {

        }

        DataTable FillDataGridView(string sqlSelect)
        {
            //Создаем объект connection класса SqlConnection для соединения с БД
            //CafeConnectionString – строка описания соединения с источником данных

             SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.БиблиотекаConnectionString);
            //Создаем объект command для SQL команды
            SqlCommand command = connection.CreateCommand();
            //Заносим текст SQL запроса через параметр sqlSelect
            command.CommandText = sqlSelect;
            //Создаем объект adapter класса SqlDataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter();
            //Задаем адаптеру нужную команду, в данном случае команду Select
            adapter.SelectCommand = command;
            //Создаем объект table для последующего отображения результата запроса
             DataTable table = new DataTable();
            //заполним набор данных результатом запроса
            adapter.Fill(table);
            return table;
        }
        private static FormSQL f;
        public static FormSQL fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormSQL();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void radioButtonWorkers_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT * FROM [Сотрудник библиотеки]"); 
        }

        private void radioButtonReaders_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT * FROM Читатель");
        }

        private void radioButtonBooks_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT * FROM Книги");
        }

        private void buttonF_select_Click(object sender, EventArgs e)
            
        {  
            if (String.IsNullOrEmpty(textBoxWorker.Text))
            {
                MessageBox.Show("Обязательно укажите фамилию необходимого сотрудника.\nДопустим ввод первых символов.", "Внимание", MessageBoxButtons.OK,
               MessageBoxIcon.Warning);
                return;
            }
            if (checkBoxMore.Checked && String.IsNullOrEmpty(textBoxMore.Text))
            {
                MessageBox.Show("Не указана прибыль в условии", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkBoxMore.Checked = false;
                return;
            }
            string sqlSelect = "";
            if (radioButtonDet_Dol.Checked && checkBoxMore.Checked == false)
                sqlSelect = @"SELECT [ID Сотрудника], Фимилия,
                Имя, Отчество, Должность, Стаж  FROM [Сотрудник библиотеки]";
            else
                if (radioButtonDet_Dol.Checked && checkBoxMore.Checked)
                sqlSelect = String.Format(@"SELECT [ID Сотрудника], Фимилия,
                Имя, Отчество, Должность, Стаж  FROM [Сотрудник библиотеки] WHERE Стаж >= {0} ", textBoxMore.Text);

            

    
            if (checkBoxOrder.Checked)
                sqlSelect += " ORDER BY [Сотрудник библиотеки].Стаж desc";        
            SqlConnection connection = new
           SqlConnection(Properties.Settings.Default.БиблиотекаConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewFSelect.DataSource = table;
            if (table.Rows.Count == 0) MessageBox.Show("Нет значений!",
           "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSubquery_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxNumber.Text))
            {
                MessageBox.Show("Обязательно укажите номер необходимой продажи",
               "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlSelect = "";

            if (radioButtonCorrelated.Checked)
                sqlSelect = @"SELECT  [ID Книги], Название, Автор, 
                (SELECT Фамилия+' '+Имя+' '+Отчество FROM [Читатель] WHERE [ID Читателя] = @number) AS [Читатели книги]  
                FROM Книги WHERE [ID Книги] = @number";


            else
            if (radioButtonNoCorrelated.Checked)
                sqlSelect = @"SELECT * FROM Книги
                             WHERE [ID книги] = @number";
            else
            {
                MessageBox.Show("Не выбрали вид подзапроса", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection connection = new
           SqlConnection(Properties.Settings.Default.БиблиотекаConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            try
            {
                command.Parameters.Add("@number", SqlDbType.Int).Value =
               int.Parse(textBoxNumber.Text);
            }
            catch
            {
                MessageBox.Show("Номер продажи в условии должен быть задан числом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
            }
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewSubquery.DataSource = table;
            if (table.Rows.Count == 0) MessageBox.Show("Нет значений!",
           "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        
    
    

        void InsertDish()
        {
            if (String.IsNullOrEmpty(textBoxID.Text) ||
           (String.IsNullOrEmpty(textBoxSurname.Text) ||
           (String.IsNullOrEmpty(textBoxName.Text))))
            {
                MessageBox.Show("Обязательно введите ID Читателя, Фамилию и Имя", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
            }
            int id;
            if (!int.TryParse(textBoxID.Text, out id))
            {
                MessageBox.Show("Некоректное значение кода блюда!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlInsert = @"INSERT INTO Читатель ([ID Читателя], [Номер телефона], Фамилия,
Имя, Отчество, [Серия паспорта], [Номер паспорта])
 VALUES (@id, @phone, @SurName, @Name, @FatherName, @SerPass, @NumPass)";
            SqlConnection connection = new
           SqlConnection(Properties.Settings.Default.БиблиотекаConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlInsert;
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@Name", textBoxName.Text);
            //или другим способом, если необходимо явное указание типа данных
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value =
           textBoxPhone.Text;
            command.Parameters.AddWithValue("Surname", textBoxSurname.Text);
            command.Parameters.AddWithValue("@FatherName", textBoxFather.Text);
            command.Parameters.AddWithValue("@SerPass", textBoxSerPass.Text);
            command.Parameters.AddWithValue("@NumPass", textBoxNumPass.Text);
            

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса.\n" + err.Message,
               "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            connection.Close();
            
        }

        void UpdateDish()
        {
            if (String.IsNullOrEmpty(textBoxID.Text))
            {
                MessageBox.Show("Обязательно укажите ID Читателя, для которого будете менять данные", "Внимание", MessageBoxButtons.OK,
               MessageBoxIcon.Warning);
                return;
            }
            int id;
            if (!int.TryParse(textBoxID.Text, out id))
            {
                MessageBox.Show("Некоректное значение кода блюда!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlUpdate = "UPDATE Читатель SET {0} WHERE [ID Читателя] = @id";

            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.БиблиотекаConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            string sqlValues = "";

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@Name", textBoxName.Text);

            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value =
           textBoxPhone.Text;
            command.Parameters.AddWithValue("@Surname", textBoxSurname.Text);
            command.Parameters.AddWithValue("@FatherName", textBoxFather.Text);
            command.Parameters.AddWithValue("@SerPass", textBoxSerPass.Text);
            command.Parameters.AddWithValue("@NumPass", textBoxNumPass.Text);

            if (!String.IsNullOrEmpty(textBoxPhone.Text))
                sqlValues += "[Номер телефона]=@phone,";
            if (!String.IsNullOrEmpty(textBoxSurname.Text))
                sqlValues += "Фамилия=@Surname,";
            if (!String.IsNullOrEmpty(textBoxName.Text))
                sqlValues += "Имя=@Name,";
            if (!String.IsNullOrEmpty(textBoxFather.Text))
                sqlValues += "Отчество=@FatherName,";
            if (!String.IsNullOrEmpty(textBoxSerPass.Text))
                sqlValues += "[Серия паспорта]=@SerPass,";
            if (!String.IsNullOrEmpty(textBoxNumPass.Text))
                sqlValues += "[Номер паспорта]=@NumPass";

            

            command.CommandText = String.Format(sqlUpdate, sqlValues);


            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса:\n" + err.Message,
               "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
            buttonSelectDishes_Click(this, EventArgs.Empty);

        }

        void DeleteDish()
        {
            if (String.IsNullOrEmpty(textBoxID.Text))
            {
                MessageBox.Show("Обязательно укажите код блюда данные которого необходимо удалить", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id;
            if (!int.TryParse(textBoxID.Text, out id))
            {
                MessageBox.Show("Некоректное значение кода блюда!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlDelete = @"DELETE FROM Читатель WHERE [ID Читателя]=@id";
            SqlConnection connection = new
           SqlConnection(Properties.Settings.Default.БиблиотекаConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlDelete;
            command.Parameters.AddWithValue("@id", id);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка удаления");
            }
        }
        private void radioButtonInsert_Wokers_CheckedChanged(object sender, EventArgs e)
            {

            }

        private void buttonExecuteDML_Click(object sender, EventArgs e)
        {
            if (radioButtonInsert_Wokers.Checked)
                    InsertDish();
            else
            if (radioButtonDelete.Checked)
                    DeleteDish();
            else
            if (radioButtonUpdate.Checked)
                    UpdateDish();
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label_Reader_ID_Click(object sender, EventArgs e)
        {

        }

        private void buttonSelectDishes_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = FillDataGridView("SELECT * FROM [Читатель]");
        }
    }
}
