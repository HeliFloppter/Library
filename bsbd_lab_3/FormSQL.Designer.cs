namespace bsbd_lab_3
{
    partial class FormSQL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePrimer = new System.Windows.Forms.TabPage();
            this.dataGridViewSelect = new System.Windows.Forms.DataGridView();
            this.groupBoxSelect = new System.Windows.Forms.GroupBox();
            this.radioButtonBooks = new System.Windows.Forms.RadioButton();
            this.radioButtonReaders = new System.Windows.Forms.RadioButton();
            this.radioButtonWorkers = new System.Windows.Forms.RadioButton();
            this.tabPageSelect = new System.Windows.Forms.TabPage();
            this.dataGridViewFSelect = new System.Windows.Forms.DataGridView();
            this.checkBoxOrder = new System.Windows.Forms.CheckBox();
            this.radioButtonDet_NO = new System.Windows.Forms.RadioButton();
            this.groupBoxFSelect = new System.Windows.Forms.GroupBox();
            this.textBoxMore = new System.Windows.Forms.TextBox();
            this.buttonF_select = new System.Windows.Forms.Button();
            this.checkBoxMore = new System.Windows.Forms.CheckBox();
            this.groupBoxDet = new System.Windows.Forms.GroupBox();
            this.radioButtonDet_Sex = new System.Windows.Forms.RadioButton();
            this.radioButtonDet_Dol = new System.Windows.Forms.RadioButton();
            this.textBoxWorker = new System.Windows.Forms.TextBox();
            this.labelWorker = new System.Windows.Forms.Label();
            this.tabPageSubquery = new System.Windows.Forms.TabPage();
            this.dataGridViewSubquery = new System.Windows.Forms.DataGridView();
            this.groupBoxSubquery = new System.Windows.Forms.GroupBox();
            this.buttonSubquery = new System.Windows.Forms.Button();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.radioButtonNoCorrelated = new System.Windows.Forms.RadioButton();
            this.radioButtonCorrelated = new System.Windows.Forms.RadioButton();
            this.tabPageDML = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelDish = new System.Windows.Forms.Panel();
            this.buttonSelectDishes = new System.Windows.Forms.Button();
            this.textBoxNumPass = new System.Windows.Forms.TextBox();
            this.textBoxSerPass = new System.Windows.Forms.TextBox();
            this.textBoxFather = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.groupBoxDML = new System.Windows.Forms.GroupBox();
            this.buttonExecuteDML = new System.Windows.Forms.Button();
            this.radioButtonDelete = new System.Windows.Forms.RadioButton();
            this.radioButtonUpdate = new System.Windows.Forms.RadioButton();
            this.radioButtonInsert_Wokers = new System.Windows.Forms.RadioButton();
            this.Label_Reader_ID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPagePrimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).BeginInit();
            this.groupBoxSelect.SuspendLayout();
            this.tabPageSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFSelect)).BeginInit();
            this.groupBoxFSelect.SuspendLayout();
            this.groupBoxDet.SuspendLayout();
            this.tabPageSubquery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubquery)).BeginInit();
            this.groupBoxSubquery.SuspendLayout();
            this.tabPageDML.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelDish.SuspendLayout();
            this.groupBoxDML.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePrimer);
            this.tabControl1.Controls.Add(this.tabPageSelect);
            this.tabControl1.Controls.Add(this.tabPageSubquery);
            this.tabControl1.Controls.Add(this.tabPageDML);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 648);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPagePrimer
            // 
            this.tabPagePrimer.Controls.Add(this.dataGridViewSelect);
            this.tabPagePrimer.Controls.Add(this.groupBoxSelect);
            this.tabPagePrimer.Location = new System.Drawing.Point(4, 25);
            this.tabPagePrimer.Name = "tabPagePrimer";
            this.tabPagePrimer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrimer.Size = new System.Drawing.Size(792, 619);
            this.tabPagePrimer.TabIndex = 0;
            this.tabPagePrimer.Text = "Примеры запросов";
            this.tabPagePrimer.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSelect
            // 
            this.dataGridViewSelect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSelect.Location = new System.Drawing.Point(3, 103);
            this.dataGridViewSelect.Name = "dataGridViewSelect";
            this.dataGridViewSelect.RowHeadersWidth = 51;
            this.dataGridViewSelect.RowTemplate.Height = 24;
            this.dataGridViewSelect.Size = new System.Drawing.Size(786, 513);
            this.dataGridViewSelect.TabIndex = 1;
            // 
            // groupBoxSelect
            // 
            this.groupBoxSelect.Controls.Add(this.radioButtonBooks);
            this.groupBoxSelect.Controls.Add(this.radioButtonReaders);
            this.groupBoxSelect.Controls.Add(this.radioButtonWorkers);
            this.groupBoxSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSelect.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSelect.Name = "groupBoxSelect";
            this.groupBoxSelect.Size = new System.Drawing.Size(786, 100);
            this.groupBoxSelect.TabIndex = 0;
            this.groupBoxSelect.TabStop = false;
            this.groupBoxSelect.Text = "Запросы по данным";
            // 
            // radioButtonBooks
            // 
            this.radioButtonBooks.AutoSize = true;
            this.radioButtonBooks.Location = new System.Drawing.Point(26, 74);
            this.radioButtonBooks.Name = "radioButtonBooks";
            this.radioButtonBooks.Size = new System.Drawing.Size(66, 20);
            this.radioButtonBooks.TabIndex = 2;
            this.radioButtonBooks.TabStop = true;
            this.radioButtonBooks.Text = "Книги";
            this.radioButtonBooks.UseVisualStyleBackColor = true;
            this.radioButtonBooks.CheckedChanged += new System.EventHandler(this.radioButtonBooks_CheckedChanged);
            // 
            // radioButtonReaders
            // 
            this.radioButtonReaders.AutoSize = true;
            this.radioButtonReaders.Location = new System.Drawing.Point(26, 48);
            this.radioButtonReaders.Name = "radioButtonReaders";
            this.radioButtonReaders.Size = new System.Drawing.Size(91, 20);
            this.radioButtonReaders.TabIndex = 1;
            this.radioButtonReaders.TabStop = true;
            this.radioButtonReaders.Text = "Читатели";
            this.radioButtonReaders.UseVisualStyleBackColor = true;
            this.radioButtonReaders.CheckedChanged += new System.EventHandler(this.radioButtonReaders_CheckedChanged);
            // 
            // radioButtonWorkers
            // 
            this.radioButtonWorkers.AutoSize = true;
            this.radioButtonWorkers.Location = new System.Drawing.Point(26, 21);
            this.radioButtonWorkers.Name = "radioButtonWorkers";
            this.radioButtonWorkers.Size = new System.Drawing.Size(107, 20);
            this.radioButtonWorkers.TabIndex = 0;
            this.radioButtonWorkers.TabStop = true;
            this.radioButtonWorkers.Text = "Сотрудники";
            this.radioButtonWorkers.UseVisualStyleBackColor = true;
            this.radioButtonWorkers.CheckedChanged += new System.EventHandler(this.radioButtonWorkers_CheckedChanged);
            // 
            // tabPageSelect
            // 
            this.tabPageSelect.Controls.Add(this.dataGridViewFSelect);
            this.tabPageSelect.Controls.Add(this.checkBoxOrder);
            this.tabPageSelect.Controls.Add(this.radioButtonDet_NO);
            this.tabPageSelect.Controls.Add(this.groupBoxFSelect);
            this.tabPageSelect.Location = new System.Drawing.Point(4, 25);
            this.tabPageSelect.Name = "tabPageSelect";
            this.tabPageSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSelect.Size = new System.Drawing.Size(792, 619);
            this.tabPageSelect.TabIndex = 1;
            this.tabPageSelect.Text = "Полная запись SELECT";
            this.tabPageSelect.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFSelect
            // 
            this.dataGridViewFSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFSelect.Location = new System.Drawing.Point(3, 189);
            this.dataGridViewFSelect.Name = "dataGridViewFSelect";
            this.dataGridViewFSelect.RowHeadersWidth = 51;
            this.dataGridViewFSelect.RowTemplate.Height = 24;
            this.dataGridViewFSelect.Size = new System.Drawing.Size(786, 427);
            this.dataGridViewFSelect.TabIndex = 7;
            // 
            // checkBoxOrder
            // 
            this.checkBoxOrder.AutoSize = true;
            this.checkBoxOrder.Location = new System.Drawing.Point(13, 124);
            this.checkBoxOrder.Name = "checkBoxOrder";
            this.checkBoxOrder.Size = new System.Drawing.Size(262, 20);
            this.checkBoxOrder.TabIndex = 5;
            this.checkBoxOrder.Text = "Включить сортировку по убыванию";
            this.checkBoxOrder.UseVisualStyleBackColor = true;
            // 
            // radioButtonDet_NO
            // 
            this.radioButtonDet_NO.AutoSize = true;
            this.radioButtonDet_NO.Location = new System.Drawing.Point(495, 104);
            this.radioButtonDet_NO.Name = "radioButtonDet_NO";
            this.radioButtonDet_NO.Size = new System.Drawing.Size(156, 20);
            this.radioButtonDet_NO.TabIndex = 2;
            this.radioButtonDet_NO.TabStop = true;
            this.radioButtonDet_NO.Text = "нет детателизации";
            this.radioButtonDet_NO.UseVisualStyleBackColor = true;
            // 
            // groupBoxFSelect
            // 
            this.groupBoxFSelect.Controls.Add(this.textBoxMore);
            this.groupBoxFSelect.Controls.Add(this.buttonF_select);
            this.groupBoxFSelect.Controls.Add(this.checkBoxMore);
            this.groupBoxFSelect.Controls.Add(this.groupBoxDet);
            this.groupBoxFSelect.Controls.Add(this.textBoxWorker);
            this.groupBoxFSelect.Controls.Add(this.labelWorker);
            this.groupBoxFSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxFSelect.Location = new System.Drawing.Point(3, 3);
            this.groupBoxFSelect.Name = "groupBoxFSelect";
            this.groupBoxFSelect.Size = new System.Drawing.Size(786, 186);
            this.groupBoxFSelect.TabIndex = 0;
            this.groupBoxFSelect.TabStop = false;
            this.groupBoxFSelect.Text = "Стаж сотрудника";
            // 
            // textBoxMore
            // 
            this.textBoxMore.Location = new System.Drawing.Point(178, 74);
            this.textBoxMore.Name = "textBoxMore";
            this.textBoxMore.Size = new System.Drawing.Size(100, 22);
            this.textBoxMore.TabIndex = 4;
            // 
            // buttonF_select
            // 
            this.buttonF_select.Location = new System.Drawing.Point(295, 153);
            this.buttonF_select.Name = "buttonF_select";
            this.buttonF_select.Size = new System.Drawing.Size(160, 23);
            this.buttonF_select.TabIndex = 6;
            this.buttonF_select.Text = "Стаж сотрудников";
            this.buttonF_select.UseVisualStyleBackColor = true;
            this.buttonF_select.Click += new System.EventHandler(this.buttonF_select_Click);
            // 
            // checkBoxMore
            // 
            this.checkBoxMore.AutoSize = true;
            this.checkBoxMore.Location = new System.Drawing.Point(10, 73);
            this.checkBoxMore.Name = "checkBoxMore";
            this.checkBoxMore.Size = new System.Drawing.Size(162, 20);
            this.checkBoxMore.TabIndex = 3;
            this.checkBoxMore.Text = "Выбрать стаж более";
            this.checkBoxMore.UseVisualStyleBackColor = true;
            // 
            // groupBoxDet
            // 
            this.groupBoxDet.Controls.Add(this.radioButtonDet_Sex);
            this.groupBoxDet.Controls.Add(this.radioButtonDet_Dol);
            this.groupBoxDet.Location = new System.Drawing.Point(485, 21);
            this.groupBoxDet.Name = "groupBoxDet";
            this.groupBoxDet.Size = new System.Drawing.Size(238, 106);
            this.groupBoxDet.TabIndex = 2;
            this.groupBoxDet.TabStop = false;
            this.groupBoxDet.Text = "Детализация стажа";
            // 
            // radioButtonDet_Sex
            // 
            this.radioButtonDet_Sex.AutoSize = true;
            this.radioButtonDet_Sex.Location = new System.Drawing.Point(7, 53);
            this.radioButtonDet_Sex.Name = "radioButtonDet_Sex";
            this.radioButtonDet_Sex.Size = new System.Drawing.Size(184, 20);
            this.radioButtonDet_Sex.TabIndex = 1;
            this.radioButtonDet_Sex.TabStop = true;
            this.radioButtonDet_Sex.Text = "Детателизация по полу";
            this.radioButtonDet_Sex.UseVisualStyleBackColor = true;
            // 
            // radioButtonDet_Dol
            // 
            this.radioButtonDet_Dol.AutoSize = true;
            this.radioButtonDet_Dol.Location = new System.Drawing.Point(7, 22);
            this.radioButtonDet_Dol.Name = "radioButtonDet_Dol";
            this.radioButtonDet_Dol.Size = new System.Drawing.Size(223, 20);
            this.radioButtonDet_Dol.TabIndex = 0;
            this.radioButtonDet_Dol.TabStop = true;
            this.radioButtonDet_Dol.Text = "Детателизация по должности";
            this.radioButtonDet_Dol.UseVisualStyleBackColor = true;
            // 
            // textBoxWorker
            // 
            this.textBoxWorker.Location = new System.Drawing.Point(178, 31);
            this.textBoxWorker.Name = "textBoxWorker";
            this.textBoxWorker.Size = new System.Drawing.Size(100, 22);
            this.textBoxWorker.TabIndex = 1;
            // 
            // labelWorker
            // 
            this.labelWorker.AutoSize = true;
            this.labelWorker.Location = new System.Drawing.Point(7, 31);
            this.labelWorker.Name = "labelWorker";
            this.labelWorker.Size = new System.Drawing.Size(146, 16);
            this.labelWorker.TabIndex = 0;
            this.labelWorker.Text = "Фамилия сотрудника";
            // 
            // tabPageSubquery
            // 
            this.tabPageSubquery.Controls.Add(this.dataGridViewSubquery);
            this.tabPageSubquery.Controls.Add(this.groupBoxSubquery);
            this.tabPageSubquery.Location = new System.Drawing.Point(4, 25);
            this.tabPageSubquery.Name = "tabPageSubquery";
            this.tabPageSubquery.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSubquery.Size = new System.Drawing.Size(792, 619);
            this.tabPageSubquery.TabIndex = 2;
            this.tabPageSubquery.Text = "Примеры подзапросов";
            this.tabPageSubquery.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSubquery
            // 
            this.dataGridViewSubquery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSubquery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubquery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSubquery.Location = new System.Drawing.Point(3, 173);
            this.dataGridViewSubquery.Name = "dataGridViewSubquery";
            this.dataGridViewSubquery.RowHeadersWidth = 51;
            this.dataGridViewSubquery.RowTemplate.Height = 24;
            this.dataGridViewSubquery.Size = new System.Drawing.Size(786, 443);
            this.dataGridViewSubquery.TabIndex = 1;
            // 
            // groupBoxSubquery
            // 
            this.groupBoxSubquery.Controls.Add(this.buttonSubquery);
            this.groupBoxSubquery.Controls.Add(this.textBoxNumber);
            this.groupBoxSubquery.Controls.Add(this.labelNumber);
            this.groupBoxSubquery.Controls.Add(this.radioButtonNoCorrelated);
            this.groupBoxSubquery.Controls.Add(this.radioButtonCorrelated);
            this.groupBoxSubquery.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSubquery.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSubquery.Name = "groupBoxSubquery";
            this.groupBoxSubquery.Size = new System.Drawing.Size(786, 170);
            this.groupBoxSubquery.TabIndex = 0;
            this.groupBoxSubquery.TabStop = false;
            this.groupBoxSubquery.Text = "Подзапросы по данным";
            // 
            // buttonSubquery
            // 
            this.buttonSubquery.Location = new System.Drawing.Point(295, 124);
            this.buttonSubquery.Name = "buttonSubquery";
            this.buttonSubquery.Size = new System.Drawing.Size(167, 23);
            this.buttonSubquery.TabIndex = 4;
            this.buttonSubquery.Text = "Выполнить подзапрос";
            this.buttonSubquery.UseVisualStyleBackColor = true;
            this.buttonSubquery.Click += new System.EventHandler(this.buttonSubquery_Click);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(142, 90);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(100, 22);
            this.textBoxNumber.TabIndex = 3;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(50, 93);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(61, 16);
            this.labelNumber.TabIndex = 2;
            this.labelNumber.Text = "ID Книги";
            // 
            // radioButtonNoCorrelated
            // 
            this.radioButtonNoCorrelated.AutoSize = true;
            this.radioButtonNoCorrelated.Location = new System.Drawing.Point(398, 33);
            this.radioButtonNoCorrelated.Name = "radioButtonNoCorrelated";
            this.radioButtonNoCorrelated.Size = new System.Drawing.Size(240, 20);
            this.radioButtonNoCorrelated.TabIndex = 1;
            this.radioButtonNoCorrelated.TabStop = true;
            this.radioButtonNoCorrelated.Text = "Некоррелированный подзапрос";
            this.radioButtonNoCorrelated.UseVisualStyleBackColor = true;
            // 
            // radioButtonCorrelated
            // 
            this.radioButtonCorrelated.AutoSize = true;
            this.radioButtonCorrelated.Location = new System.Drawing.Point(109, 33);
            this.radioButtonCorrelated.Name = "radioButtonCorrelated";
            this.radioButtonCorrelated.Size = new System.Drawing.Size(223, 20);
            this.radioButtonCorrelated.TabIndex = 0;
            this.radioButtonCorrelated.TabStop = true;
            this.radioButtonCorrelated.Text = "Коррелированный подзапрос";
            this.radioButtonCorrelated.UseVisualStyleBackColor = true;
            // 
            // tabPageDML
            // 
            this.tabPageDML.Controls.Add(this.dataGridView1);
            this.tabPageDML.Controls.Add(this.panelDish);
            this.tabPageDML.Controls.Add(this.groupBoxDML);
            this.tabPageDML.Location = new System.Drawing.Point(4, 25);
            this.tabPageDML.Name = "tabPageDML";
            this.tabPageDML.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDML.Size = new System.Drawing.Size(792, 619);
            this.tabPageDML.TabIndex = 3;
            this.tabPageDML.Text = "Запросы изменения данных";
            this.tabPageDML.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 359);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(786, 257);
            this.dataGridView1.TabIndex = 2;
            // 
            // panelDish
            // 
            this.panelDish.Controls.Add(this.buttonSelectDishes);
            this.panelDish.Controls.Add(this.textBoxNumPass);
            this.panelDish.Controls.Add(this.textBoxSerPass);
            this.panelDish.Controls.Add(this.textBoxFather);
            this.panelDish.Controls.Add(this.textBoxName);
            this.panelDish.Controls.Add(this.textBoxSurname);
            this.panelDish.Controls.Add(this.textBoxPhone);
            this.panelDish.Controls.Add(this.label7);
            this.panelDish.Controls.Add(this.label6);
            this.panelDish.Controls.Add(this.labelName);
            this.panelDish.Controls.Add(this.label4);
            this.panelDish.Controls.Add(this.labelSurname);
            this.panelDish.Controls.Add(this.labelPhone);
            this.panelDish.Location = new System.Drawing.Point(3, 103);
            this.panelDish.Name = "panelDish";
            this.panelDish.Size = new System.Drawing.Size(786, 250);
            this.panelDish.TabIndex = 1;
            // 
            // buttonSelectDishes
            // 
            this.buttonSelectDishes.Location = new System.Drawing.Point(411, 192);
            this.buttonSelectDishes.Name = "buttonSelectDishes";
            this.buttonSelectDishes.Size = new System.Drawing.Size(216, 23);
            this.buttonSelectDishes.TabIndex = 15;
            this.buttonSelectDishes.Text = "Показать читателей";
            this.buttonSelectDishes.UseVisualStyleBackColor = true;
            this.buttonSelectDishes.Click += new System.EventHandler(this.buttonSelectDishes_Click);
            // 
            // textBoxNumPass
            // 
            this.textBoxNumPass.Location = new System.Drawing.Point(148, 149);
            this.textBoxNumPass.Name = "textBoxNumPass";
            this.textBoxNumPass.Size = new System.Drawing.Size(100, 22);
            this.textBoxNumPass.TabIndex = 13;
            // 
            // textBoxSerPass
            // 
            this.textBoxSerPass.Location = new System.Drawing.Point(148, 121);
            this.textBoxSerPass.Name = "textBoxSerPass";
            this.textBoxSerPass.Size = new System.Drawing.Size(100, 22);
            this.textBoxSerPass.TabIndex = 12;
            // 
            // textBoxFather
            // 
            this.textBoxFather.Location = new System.Drawing.Point(148, 93);
            this.textBoxFather.Name = "textBoxFather";
            this.textBoxFather.Size = new System.Drawing.Size(100, 22);
            this.textBoxFather.TabIndex = 11;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(148, 65);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 10;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(148, 37);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 22);
            this.textBoxSurname.TabIndex = 9;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(148, 9);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(100, 22);
            this.textBoxPhone.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Отчество";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Серия паспорта";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(16, 71);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(33, 16);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Номер паспорта";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(16, 43);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(66, 16);
            this.labelSurname.TabIndex = 2;
            this.labelSurname.Text = "Фамилия";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(16, 15);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(119, 16);
            this.labelPhone.TabIndex = 1;
            this.labelPhone.Text = "Номер телефона";
            // 
            // groupBoxDML
            // 
            this.groupBoxDML.Controls.Add(this.buttonExecuteDML);
            this.groupBoxDML.Controls.Add(this.radioButtonDelete);
            this.groupBoxDML.Controls.Add(this.radioButtonUpdate);
            this.groupBoxDML.Controls.Add(this.radioButtonInsert_Wokers);
            this.groupBoxDML.Controls.Add(this.Label_Reader_ID);
            this.groupBoxDML.Controls.Add(this.textBoxID);
            this.groupBoxDML.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxDML.Location = new System.Drawing.Point(3, 3);
            this.groupBoxDML.Name = "groupBoxDML";
            this.groupBoxDML.Size = new System.Drawing.Size(786, 100);
            this.groupBoxDML.TabIndex = 0;
            this.groupBoxDML.TabStop = false;
            this.groupBoxDML.Text = "Сотруники";
            // 
            // buttonExecuteDML
            // 
            this.buttonExecuteDML.Location = new System.Drawing.Point(496, 55);
            this.buttonExecuteDML.Name = "buttonExecuteDML";
            this.buttonExecuteDML.Size = new System.Drawing.Size(165, 23);
            this.buttonExecuteDML.TabIndex = 5;
            this.buttonExecuteDML.Text = "Выполнить запрос";
            this.buttonExecuteDML.UseVisualStyleBackColor = true;
            this.buttonExecuteDML.Click += new System.EventHandler(this.buttonExecuteDML_Click);
            // 
            // radioButtonDelete
            // 
            this.radioButtonDelete.AutoSize = true;
            this.radioButtonDelete.Location = new System.Drawing.Point(71, 51);
            this.radioButtonDelete.Name = "radioButtonDelete";
            this.radioButtonDelete.Size = new System.Drawing.Size(135, 20);
            this.radioButtonDelete.TabIndex = 2;
            this.radioButtonDelete.TabStop = true;
            this.radioButtonDelete.Text = "Удалить данные";
            this.radioButtonDelete.UseVisualStyleBackColor = true;
            // 
            // radioButtonUpdate
            // 
            this.radioButtonUpdate.AutoSize = true;
            this.radioButtonUpdate.Location = new System.Drawing.Point(71, 77);
            this.radioButtonUpdate.Name = "radioButtonUpdate";
            this.radioButtonUpdate.Size = new System.Drawing.Size(145, 20);
            this.radioButtonUpdate.TabIndex = 1;
            this.radioButtonUpdate.TabStop = true;
            this.radioButtonUpdate.Text = "Изменить данные";
            this.radioButtonUpdate.UseVisualStyleBackColor = true;
            // 
            // radioButtonInsert_Wokers
            // 
            this.radioButtonInsert_Wokers.AutoSize = true;
            this.radioButtonInsert_Wokers.Location = new System.Drawing.Point(71, 25);
            this.radioButtonInsert_Wokers.Name = "radioButtonInsert_Wokers";
            this.radioButtonInsert_Wokers.Size = new System.Drawing.Size(143, 20);
            this.radioButtonInsert_Wokers.TabIndex = 0;
            this.radioButtonInsert_Wokers.TabStop = true;
            this.radioButtonInsert_Wokers.Text = "Добавить данные";
            this.radioButtonInsert_Wokers.UseVisualStyleBackColor = true;
            this.radioButtonInsert_Wokers.CheckedChanged += new System.EventHandler(this.radioButtonInsert_Wokers_CheckedChanged);
            // 
            // Label_Reader_ID
            // 
            this.Label_Reader_ID.AutoSize = true;
            this.Label_Reader_ID.Location = new System.Drawing.Point(369, 21);
            this.Label_Reader_ID.Name = "Label_Reader_ID";
            this.Label_Reader_ID.Size = new System.Drawing.Size(85, 16);
            this.Label_Reader_ID.TabIndex = 0;
            this.Label_Reader_ID.Text = "ID Читателя";
            this.Label_Reader_ID.Click += new System.EventHandler(this.Label_Reader_ID_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(496, 21);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 22);
            this.textBoxID.TabIndex = 5;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // FormSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 648);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormSQL";
            this.Text = "Запросы";
            this.Load += new System.EventHandler(this.FormSQL_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPagePrimer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).EndInit();
            this.groupBoxSelect.ResumeLayout(false);
            this.groupBoxSelect.PerformLayout();
            this.tabPageSelect.ResumeLayout(false);
            this.tabPageSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFSelect)).EndInit();
            this.groupBoxFSelect.ResumeLayout(false);
            this.groupBoxFSelect.PerformLayout();
            this.groupBoxDet.ResumeLayout(false);
            this.groupBoxDet.PerformLayout();
            this.tabPageSubquery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubquery)).EndInit();
            this.groupBoxSubquery.ResumeLayout(false);
            this.groupBoxSubquery.PerformLayout();
            this.tabPageDML.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelDish.ResumeLayout(false);
            this.panelDish.PerformLayout();
            this.groupBoxDML.ResumeLayout(false);
            this.groupBoxDML.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePrimer;
        private System.Windows.Forms.DataGridView dataGridViewSelect;
        private System.Windows.Forms.GroupBox groupBoxSelect;
        private System.Windows.Forms.RadioButton radioButtonBooks;
        private System.Windows.Forms.RadioButton radioButtonReaders;
        private System.Windows.Forms.RadioButton radioButtonWorkers;
        private System.Windows.Forms.TabPage tabPageSelect;
        private System.Windows.Forms.GroupBox groupBoxFSelect;
        private System.Windows.Forms.GroupBox groupBoxDet;
        private System.Windows.Forms.RadioButton radioButtonDet_Sex;
        private System.Windows.Forms.RadioButton radioButtonDet_Dol;
        private System.Windows.Forms.TextBox textBoxWorker;
        private System.Windows.Forms.Label labelWorker;
        private System.Windows.Forms.DataGridView dataGridViewFSelect;
        private System.Windows.Forms.CheckBox checkBoxOrder;
        private System.Windows.Forms.RadioButton radioButtonDet_NO;
        private System.Windows.Forms.TextBox textBoxMore;
        private System.Windows.Forms.Button buttonF_select;
        private System.Windows.Forms.CheckBox checkBoxMore;
        private System.Windows.Forms.TabPage tabPageSubquery;
        private System.Windows.Forms.DataGridView dataGridViewSubquery;
        private System.Windows.Forms.GroupBox groupBoxSubquery;
        private System.Windows.Forms.Button buttonSubquery;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.RadioButton radioButtonNoCorrelated;
        private System.Windows.Forms.RadioButton radioButtonCorrelated;
        private System.Windows.Forms.TabPage tabPageDML;
        private System.Windows.Forms.Panel panelDish;
        private System.Windows.Forms.TextBox textBoxNumPass;
        private System.Windows.Forms.TextBox textBoxSerPass;
        private System.Windows.Forms.TextBox textBoxFather;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label Label_Reader_ID;
        private System.Windows.Forms.GroupBox groupBoxDML;
        private System.Windows.Forms.RadioButton radioButtonDelete;
        private System.Windows.Forms.RadioButton radioButtonUpdate;
        private System.Windows.Forms.RadioButton radioButtonInsert_Wokers;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSelectDishes;
        private System.Windows.Forms.Button buttonExecuteDML;
    }
}