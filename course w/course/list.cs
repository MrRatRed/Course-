using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace course
{
    /// <summary>
    /// Форма для отображения списка людей и их атрибутов.
    /// </summary>
    public partial class list : Form
    {
        /// <summary>
        /// Событие, срабатывающее при добавлении данных.
        /// </summary>
        public event EventHandler<DataTable> DataAdded;

        /// <summary>
        /// Событие, срабатывающее при передаче данных.
        /// </summary>
        public event Action<DataTable> DataTransfer;

        private const int MaxRecordsDepatraments = 25;
        private const int MaxRecordsFamily = 50;
        private const int MaxRecordsMale = 50;
        private int firstDepartmentCounter = 0;
        private int secondDepartmentCounter = 0;
        private int thirdDepartmentCounter = 0;
        private int fourthDepartmentCounter = 0;
        private int maleCounter = 0;
        private int femaleCounter = 0;

        DataTable table = new DataTable();
        //private void list_Load(object sender, EventArgs e)
        //{
        //    //  Добавление колонок в таблицу при загрузке формы.
        //    table.Columns.Add("ПІБ", typeof(string));
        //    table.Columns.Add("Номер телефону", typeof(string));
        //    table.Columns.Add("Вік", typeof(string));
        //    table.Columns.Add("Стать", typeof(string));
        //    table.Columns.Add("Віділ", typeof(string));

        //    //  Установка источника данных для dataGridView1.
        //    dataGridView1.DataSource = table;
        //}

        /// <summary>
        /// Конструктор формы list.
        /// </summary>
        public list()
        {
            InitializeComponent();

            
            // Заполнение таблицы данными из списка людей при загрузке формы.
            foreach (var sel in Program.Humans)
            {
                dataGridView1.Rows.Add(sel.FullName, sel.Telephone, sel.Age, sel.Gender, sel.Money);
                //MessageBox.Show(sel.FullName + sel.Telephone + sel.Age + sel.Gender + sel.Money);


                if (sel.Gender == "Чоловік")
                {
                    maleCounter++;
                }
                else if (sel.Gender == "Жінка")
                {
                    femaleCounter++;
                }
            }
        }

        /// <summary>
        /// Обработчик события загрузки формы.
        /// </summary>

        /// <summary>
        /// Обработчик нажатия кнопки "Додати".
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            // Проверка заполненности полей ввода.
            if (string.IsNullOrWhiteSpace(NameBox.Text) ||
                string.IsNullOrWhiteSpace(TelephoneBox.Text) ||
                string.IsNullOrWhiteSpace(AgeBox.Text) ||
                string.IsNullOrEmpty(comboBox1.Text) ||
                string.IsNullOrEmpty(ResultBox.Text))
            {
                MessageBox.Show("Увага! Всі поля мають бути заповнені!");
            }
            else
            {
                // Добавление новой записи в зависимости от выбранных параметров.
                if (comboBox1.Text == "Чоловік")
                {
                    if (maleCounter < MaxRecordsMale)
                    {
                        Program.Humans.Add(new Humans(NameBox.Text, TelephoneBox.Text, AgeBox.Text, comboBox1.Text, ResultBox.Text));
                        dataGridView1.Rows.Add(NameBox.Text, TelephoneBox.Text, AgeBox.Text, comboBox1.Text, ResultBox.Text);
                        maleCounter++;
                    }
                    else
                    {
                        MessageBox.Show("Всі місця для чоловіків зайняті. Нові записи не додаються.");
                    }
                }
                else if (comboBox1.Text == "Жінка")
                {
                    if (femaleCounter < MaxRecordsFamily)
                    {
                        Program.Humans.Add(new Humans(NameBox.Text, TelephoneBox.Text, AgeBox.Text, comboBox1.Text, ResultBox.Text));
                        dataGridView1.Rows.Add(NameBox.Text, TelephoneBox.Text, AgeBox.Text, comboBox1.Text, ResultBox.Text);
                        femaleCounter++;
                    }
                    else
                    {
                        MessageBox.Show("Всі місця для жінок зайняті. Нові записи не додаються.");
                    }
                }
                else if (ResultBox.Text == "Хірургія")
                {
                    if (firstDepartmentCounter < MaxRecordsDepatraments)
                    {
                        Program.Humans.Add(new Humans(NameBox.Text, TelephoneBox.Text, AgeBox.Text, comboBox1.Text, ResultBox.Text));
                        table.Rows.Add(NameBox.Text, TelephoneBox.Text, AgeBox.Text, comboBox1.Text, ResultBox.Text);
                        firstDepartmentCounter++;
                    }
                    else
                    {
                        MessageBox.Show("Всі місця у відділенні хірургія зайняті");
                    }
                }
                else if (ResultBox.Text == "Пульманологія")
                {
                    if (secondDepartmentCounter < MaxRecordsDepatraments)
                    {
                        Program.Humans.Add(new Humans(NameBox.Text, TelephoneBox.Text, AgeBox.Text, comboBox1.Text, ResultBox.Text));
                        table.Rows.Add(NameBox.Text, TelephoneBox.Text, AgeBox.Text, comboBox1.Text, ResultBox.Text);
                        secondDepartmentCounter++;
                    }
                    else
                    {
                        MessageBox.Show("Всі місця у відділенні пульматології зайняті");
                    }
                }
                else if (ResultBox.Text == "Ревматологія")
                {
                    if (thirdDepartmentCounter < MaxRecordsDepatraments)
                    {
                        Program.Humans.Add(new Humans(NameBox.Text, TelephoneBox.Text, AgeBox.Text, comboBox1.Text, ResultBox.Text));
                        table.Rows.Add(NameBox.Text, TelephoneBox.Text, AgeBox.Text, comboBox1.Text, ResultBox.Text);
                        thirdDepartmentCounter++;
                    }
                    else
                    {
                        MessageBox.Show("Всі місця у відділенні реваматології зайняті");
                    }
                }
                else if (ResultBox.Text == "Гастроентерологія")
                {
                    if (fourthDepartmentCounter < MaxRecordsDepatraments)
                    {
                        Program.Humans.Add(new Humans(NameBox.Text, TelephoneBox.Text, AgeBox.Text, comboBox1.Text, ResultBox.Text));
                        table.Rows.Add(NameBox.Text, TelephoneBox.Text, AgeBox.Text, comboBox1.Text, ResultBox.Text);
                        fourthDepartmentCounter++;
                    }
                    else
                    {
                        MessageBox.Show("Всі місця у відділенні гастроентерології зайняті");
                    }
                }

                // Очистка полей ввода после добавления записи.
                NameBox.Text = string.Empty;
                TelephoneBox.Text = string.Empty;
                AgeBox.Text = string.Empty;
                comboBox1.Text = string.Empty;
                ResultBox.Text = string.Empty;
            }

            // Вызов события DataAdded.
            DataAdded?.Invoke(this, table);
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Архів".
        /// </summary>
        private void ArchiveButton_Click(object sender, EventArgs e)
        {
            // Проверка выбора записи для перемещения в архив.
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Archive archiveForm = new Archive();
                //DataTable data = ((DataTable)dataGridView1.DataSource).Copy();
                //archiveForm.SetData(data);
                archiveForm.Show();

                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                dataGridView1.Rows.RemoveAt(selectedIndex);
            }
            else
            {
                MessageBox.Show("Виберіть запис для переміщення в архів.");
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Зберегти".
        /// </summary>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Вызов метода сохранения данных в кастомном формате.
            CustomDataSaver.SaveToCustomFormat(dataGridView1, "custom_data_file.txt");
        }

        treatment treatment;

        /// <summary>
        /// Обработчик нажатия кнопки "Вибрати".
        /// </summary>
        private void Select_Click(object sender, EventArgs e)
        {
            treatment = new treatment();
            treatment.Show();
        }

        /// <summary>
        /// Метод для установки текста в поле ResultBox.
        /// </summary>
        public void SetText(string text)
        {
            ResultBox.Text = text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    /// <summary>
    /// Статический класс для сохранения данных в кастомном формате.
    /// </summary>

    public static class CustomDataSaver
    {
        /// <summary>
        /// Метод для сохранения данных из DataGridView в кастомном формате.
        /// </summary>
        public static void SaveToCustomFormat(DataGridView dataGridView, string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Сохранение данных в файл.
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        List<string> rowData = new List<string>();
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            rowData.Add(cell.Value.ToString());
                        }
                        writer.WriteLine(string.Join(",", rowData));
                    }
                }
                MessageBox.Show("Данные успешно сохранены в кастомном формате.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}");
            }
        }
    }
}