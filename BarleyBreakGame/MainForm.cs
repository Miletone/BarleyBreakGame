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
    public partial class MainForm : Form
    {
        Game game; //Создание экземпляра класса игры
        int movesCount = 0; //Счётчик количества выполненных ходов
        bool is16Notation = false; //Выбрана ли шестнадцатеричная система счисления
        List<Player> playerList = new List<Player>(); //Список игроков с их данными

        public MainForm()
        {
            InitializeComponent(); //Инициализация интерфейса программы
            game = new Game(4); //Создание экземпляра класса игры для поля размером 4x4
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            StartGame(); //При закрузке главного окна игры - начать игру
        }

        private void button0_Click(object sender, EventArgs e)
        {
            int position = Convert.ToInt16(((Button)sender).Tag); //Определить на какое поле кликнул пользователь 
            game.Shift(position); //Сдвинуть поле, на которое кликнул пользователь
            RefreshMainForm(); //Обновить игровое поле
            movesCount++; //Подсчёт количества выполненных ходов

            if (game.CheckNumbers()) //Если пользователь выиграл
            {
                FinishForm finishForm = new FinishForm(movesCount); //Создать окно для ввода имени
                finishForm.ShowDialog(this); //Показать окно для ввода имени
                string name = finishForm.GetName(); //Получить имя

                if (name.Length != 0) //Если имя не пустое
                {
                    playerList.Add(new Player(name, movesCount, DateTime.Now.ToString("dd MMMM yyyy | HH:mm:ss"))); //Добавить новый результат в список рекордов
                    playerList.Sort((x, y) => x.movesCount.CompareTo(y.movesCount)); //Сортировать результаты по количеству ходов
                    WriteRecordsInFile();
                }
            }
        }

        private void StartGame()
        {
            game.Start(); //Запустить игру
            for (int i = 0; i < 100; i++)
            {
                game.ShiftRandom(); //Перемешать поля
            }
            movesCount = 0; //Сбросить счётчик выполненных ходов
            RefreshMainForm(); //Обновить игровое поле
        }

        private Button button(int position)
        {
            switch (position) //Получить кнопку в зависимости от её позиции
            {
                case 0: return button0; case 1: return button1; case 2: return button2;
                case 3: return button3; case 4: return button4; case 5: return button5;
                case 6: return button6; case 7: return button7; case 8: return button8;
                case 9: return button9; case 10: return button10; case 11: return button11;
                case 12: return button12; case 13: return button13; case 14: return button14;
                case 15: return button15; default: return null;
            }
        }

        private void startGameMenuItem_Click(object sender, EventArgs e)
        {
            StartGame(); //Начать новую игру
        }

        private void RefreshMainForm()
        {
            for (int position = 0; position < 16; position++)
            {
                int nr = game.GetNumber(position); //Определить позицию поля
                button(position).Text = nr.ToString(); //Поместить на кнопку её номер
                button(position).Visible = (nr > 0); //Сделать невидимым пустое поле
                if (is16Notation) //Если выбрана шестнадцатеричная система счисления
                {
                    if(nr == 10)
                    {
                        button(position).Text = "A"; //Поместить на кнопку номер "A"
                    }
                    else if(nr == 11)
                    {
                        button(position).Text = "B"; //Поместить на кнопку номер "B"
                    }
                    else if (nr == 12)
                    {
                        button(position).Text = "C"; //Поместить на кнопку номер "C"
                    }
                    else if (nr == 13)
                    {
                        button(position).Text = "D"; //Поместить на кнопку номер "D"
                    }
                    else if (nr == 14)
                    {
                        button(position).Text = "E"; //Поместить на кнопку номер "E"
                    }
                    else if (nr == 15)
                    {
                        button(position).Text = "F"; //Поместить на кнопку номер "F"
                    }
                }
            }
        }

        private void descriptionMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Игра 'Пятнашки' представляет собой набор из 16 одинаковых " +
                "квадратных полей, заключённых в квадратную форму. На 15 полей нанесены " +
                "числа, а одно остаётся пустым. Цель игры — перемещая поля по форме, добиться " +
                "упорядочивания их по номерам, желательно сделав как можно меньше перемещений.", "Справка"); //Открыть окно справки
        }

        private void notation10MenuItem_Click(object sender, EventArgs e)
        {
            Notation10ButtonClick(); //Включить десятичную систему счисления
            RefreshMainForm(); //Обновить игровое поле
        }

        private void notation16MenuItem_Click(object sender, EventArgs e)
        {
            Notation16ButtonClick(); //Включить шестнадцатеричную систему счисления
            RefreshMainForm(); //Обновить игровое поле
        }

        private void Notation10ButtonClick()
        {
            is16Notation = false; //Выбрана десятичная система счисления
            notation10MenuItem.Text = "10 ✔";
            notation16MenuItem.Text = "16";
        }

        private void Notation16ButtonClick()
        {
            is16Notation = true; //Выбрана шестнадцатеричная система счисления
            notation10MenuItem.Text = "10";
            notation16MenuItem.Text = "16 ✔";
        }

        private void WriteRecordsInFile()
        {
            try
            {
                //Открыть или создать (если он отсутствует) файл рекордов
                using (BinaryWriter writer = new BinaryWriter(File.Open("records.bin", FileMode.OpenOrCreate)))
                {
                    //Записать в файл данные рекордов
                    for (int i = 0; i < playerList.Count; i++)
                    {
                        writer.Write(playerList[i].name);
                        writer.Write(playerList[i].movesCount);
                        writer.Write(playerList[i].date);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось сохранить результат! Ошибка: " + ex.Message, "Ошибка"); //Вывести сообщение об ошибке, возникшей при сохранении результата
            }
        }

        private void ReadRecordsFromFile()
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
        }

        private void recordsMenuItem_Click(object sender, EventArgs e)
        {
            RecordsTableForm RecordsForm = new RecordsTableForm(); //Создать новое окно с таблицей рекордов
            RecordsForm.ShowDialog(this); //Открыть окно с таблицей рекордов
        }

        private void saveGameMenuItem_Click(object sender, EventArgs e)
        {
            int[,] map = game.GetMap(); //Получить карту текущего игрового поля
            int notation = is16Notation == true ? 16 : 10; //Получить значение используемой системы счисления

            try
            {
                //Открыть или создать (если он отсутствует) файл сохранения
                using (BinaryWriter writer = new BinaryWriter(File.Open("save.bin", FileMode.OpenOrCreate)))
                {
                    //Записать в файл карту текущего игрового поля
                    for (int i = 0; i < map.GetLength(0); i++)
                    {
                        for (int j = 0; j < map.GetLength(1); j++)
                        {
                            writer.Write(map[i,j]);
                        }
                    }
                    
                    writer.Write(movesCount); //Записать в файл количество выполненных ходов
                    writer.Write(notation); //Записать в файл используемую систему счисления
                }
                MessageBox.Show("Игра сохранена!", "Сохранение игры"); //Вывести сообщение об удачном сохранении игры
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось сохранить игру! Ошибка: " + ex.Message, "Ошибка"); //Вывести сообщение об ошибке, возникшей при сохранении игры
            }
        }

        private void loadGameMenuItem_Click(object sender, EventArgs e)
        {
            int[,] map = game.GetMap(); //Карта игрового поля
            int notation = 0; //Переменная дла хранения системы счисления, сохранённой в файле

            if (System.IO.File.Exists("save.bin")) //Если файл сохранения существует
            {
                try
                {
                    //Открыть файл сохранения
                    using (BinaryReader reader = new BinaryReader(File.Open("save.bin", FileMode.Open)))
                    {
                        //Считать из файла карту игрового поля
                        for (int i = 0; i < map.GetLength(0); i++)
                        {
                            for (int j = 0; j < map.GetLength(1); j++)
                            {
                                map[i, j] = reader.ReadInt32();
                            }
                        }

                        movesCount = reader.ReadInt32(); //Считать из файла количество ходов
                        notation = reader.ReadInt32(); //Считать из файла значение системы счисления

                        //Установить значение используемой системы счисления
                        if (notation == 10)
                        {
                            Notation10ButtonClick(); //Включить десятичную систему счисления
                        }
                        else
                        {
                            Notation16ButtonClick(); //Включить шестнадцатеричную систему счисления
                        }
                    }
                    MessageBox.Show("Сохранение игры загружено!", "Сохранение загружено"); //Вывести сообщение об удачной загрузке сохранения игры
                    game.SetMap(map); //Установить загруженную карту игрового поля
                    RefreshMainForm(); //Обновить игровое поле
                }
                catch (Exception)
                {
                    MessageBox.Show("Не удалось загрузить сохранение игры! Файл сохранения повреждён.", "Ошибка"); //Вывести сообщение об ошибке, возникшей при загрузке сохранения игры
                }
            }
            else
            {
                MessageBox.Show("Не удалось загрузить сохранение игры! Файл сохранения отсутствует.", "Ошибка"); //Вывести сообщение об ошибке, возникшей при загрузке сохранения игры
            }
        }
    }
}