using System;
using System.IO;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BarleyBreakGame
{
    public partial class RecordsTableForm : Form
    {
        List<Player> playerList = new List<Player>(); //Список игроков с их данными


        public RecordsTableForm()
        {
            InitializeComponent();
            FillTable();
        }

        public void FillTable()
        {
            if (System.IO.File.Exists("records.bin")) //Если файл рекордов существует
            {
                string n = ""; //Имя игрока
                int mc = 0; //Количество ходов
                string d = ""; //Дата
                playerList.Clear(); //Очистить список результатов

                try
                {
                    //Открыть файл рекордов
                    using (BinaryReader reader = new BinaryReader(File.Open("records.bin", FileMode.Open)))
                    {
                        //Читать из файла данные, пока не достигнут конец файла
                        while (reader.PeekChar() > -1)
                        {
                            n = reader.ReadString();
                            mc = reader.ReadInt32();
                            d = reader.ReadString();
                            playerList.Add(new Player(n, mc, d)); //Добавить результат в список рекордов
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Не удалось загрузить список рекордов! Файл рекордов повреждён.", "Ошибка"); //Вывести сообщение об ошибке, возникшей при загрузке рекордов игры
                }
            }

            //Заполнитьтаблицу данными из файла
            for (int i = 0; i < playerList.Count; i++)
            {
                if (i + 1 != playerList.Count) //Если необходима новая строка
                {
                    dataGridView1.Rows.Add(); //Добавить в таблицу новую строку
                }
                dataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString(); //Внести в таблицу номер
                dataGridView1.Rows[i].Cells[1].Value = playerList[i].name; //Внести в таблицу имя
                dataGridView1.Rows[i].Cells[2].Value = playerList[i].movesCount; //Внести в таблицу количество ходов
                dataGridView1.Rows[i].Cells[3].Value = playerList[i].date; //Внести в таблицу дату
            }
        }
    }
}
