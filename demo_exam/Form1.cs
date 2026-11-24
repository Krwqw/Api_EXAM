using MySqlConnector;
using System.Data;

namespace demo_exam
{
    public partial class Form1 : Form
    {

        //Подключение к бд
        private readonly string _connString = "Server=192.168.1.200;Port=3306;Database=booking_4_1_grigoreva;Uid=stis3-05;Pwd=j9Ez!.3eU;";

        public Form1()
        {
            InitializeComponent();

            textsql.Text = "Введите свой sql запрос или выберите из предложенных вариантов";
        }

        //Кнопка выполнения + сообщение об ушибке или успехе
        private void buttonExecute_Click(object sender, EventArgs e)
        {
            string query = textsql.Text.Trim();


            try
            {
                dataGridView1.DataSource = null;

                using (MySqlConnection conn = new MySqlConnection(_connString))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dataGridView1.DataSource = dataTable;
                            dataGridView1.AutoResizeColumns();

                            MessageBox.Show($"Запрос выполнен успешно.\nСтрок получено: {dataTable.Rows.Count}",
                                            "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                dataGridView1.DataSource = null;
                MessageBox.Show($"Ошибка выполнения запроса:\n\n{ex.Message}",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Кнопка очистки написанного
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textsql.Clear();
            textsql.Focus();
            lblStatus.Text = "Готов к вводу запроса";
            lblStatus.ForeColor = Color.Black;
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            textsql.Text = @"SELECT 
                r.num_room AS 'Номер', 
                r.floor AS 'Этаж', 
                r.category AS 'Категория'
            FROM rooms r
            JOIN room_status rs ON r.num_room = rs.num_room
            WHERE rs.room_stat = 'Чистый'
            ORDER BY r.num_room;";
            buttonExecute_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textsql.Text = @"SELECT 
                r.num_room AS 'Номер', 
                r.floor AS 'Этаж', 
                r.category AS 'Категория'
            FROM rooms r
            JOIN room_status rs ON r.num_room = rs.num_room
            WHERE rs.room_stat = 'Чистый'
              AND r.category LIKE '%стандарт%'
            ORDER BY r.num_room;";
            buttonExecute_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textsql.Text = @"SELECT 
                COUNT(*) AS 'Всего номеров'
            FROM rooms;";
            buttonExecute_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textsql.Text = @"SELECT 
                COUNT(*) AS 'Свободных бизнес с 1 кроватью'
            FROM rooms r
            JOIN room_status rs ON r.num_room = rs.num_room
            WHERE rs.room_stat = 'Чистый'
              AND r.category LIKE '%Бизнес%'
              AND r.category LIKE '%1%';";
            buttonExecute_Click(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textsql.Text = @"SELECT 
                g.guest_name AS 'Гость',
                r.num_room AS 'Номер',
                r.category AS 'Категория',
                b.data_in AS 'Заезд',
                b.data_out AS 'Выезд'
            FROM bookings b
            JOIN guests g ON b.guest_id = g.guest_id
            JOIN rooms r ON b.room_id = r.num_room
            WHERE (b.data_in >= '2025-02-01' AND b.data_in <= '2025-02-28')
               OR (b.data_out >= '2025-02-01' AND b.data_out <= '2025-02-28')
               OR (b.data_in < '2025-02-01' AND b.data_out > '2025-02-28')
            ORDER BY b.data_in;";
            buttonExecute_Click(sender, e);
        }
    }
}