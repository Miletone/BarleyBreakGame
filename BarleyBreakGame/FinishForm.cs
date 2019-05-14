using System;
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
    public partial class FinishForm : Form
    {
        string name = ""; //Переменная для хранения имени

        public FinishForm(int moves)
        {
            InitializeComponent();
            label1.Text = "Вы победили! Количество ходов: " + moves.ToString(); //Показать поздравление и количество ходов
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text.Replace(" ", string.Empty); //Получить имя без пробелов

            //Если поле ввода имени не пустое
            if (name.Length != 0)
            {
                name = textBox1.Text; //Получить имя
                this.Close(); //Закрыть окно
            }
        }

        public string GetName()
        {
            return name; //Получить введённое имя
        }
    }
}
